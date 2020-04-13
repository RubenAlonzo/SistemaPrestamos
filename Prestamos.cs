using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using System.Data.SqlClient;
using System.Globalization;
namespace SistemaPrestamos
{
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            CargarPrestamos();
        }

        //Metodo para actualizar los valores de Balance cuando suceda el evento de cambio de Seleccion en el DGV
        private void dgv2_SelectionChanged(object sender, EventArgs e)
        {
            MontoDeLabel();
            LimpiarTextos();
            ActivacionModificar(false);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarPrestamos(txtNombre.Text);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv2.Rows[0].Cells[0].Value != null)
                {
                    string PrestamoNumber = null;
                    if (dgv2.SelectedRows.Count > 0)
                    {
                        try
                        {
                            PrestamoNumber = dgv2.CurrentRow.Cells["#PRESTAMO"].Value.ToString();
                            objPrestamos.EliminarPrestamo(PrestamoNumber);
                            MessageBox.Show("Prestamo eliminado correctamente");
                            //LimpiarTexto();
                            CargarPrestamos();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("No se pudo eliminar el cliente. " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione la fila a eliminar");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay un prestamo por eliminar");
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CargarPrestamos();
            ActivacionModificar(false);
            LimpiarTextos();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv2.Rows[0].Cells[0].Value != null)
                {
                    if (dgv2.SelectedRows.Count > 0)
                    {
                        try
                        {
                            ActivacionModificar(true);
                            RellenarModificar();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se puede modificar el registro. " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione la fila a modificar");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay un prestamo por editar");
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objPrestamos.ActualizarPrestamos(dgv2.CurrentRow.Cells["#PRESTAMO"].Value.ToString(), txtMonto.Text, txtCuotas.Text, cbModalidad.Text, cbInteres.Text, dtpFecha.Value.ToString());
                MessageBox.Show("Se modificaron correctamente los datos");
                LimpiarTextos();
                ActivacionModificar(false);
                CargarPrestamos();
            }
            catch (Exception)
            {
                MessageBox.Show("Revise que los campos tengan el formato correcto");
            }
        }
        private void btnPago_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv2.Rows[0].Cells[0].Value != null)
                {
                    double pago = 0;
                    double pagoaDeber = 0;
                    double devuelta;
                    byte idFila = 0;

                    try
                    {
                        pagoaDeber = Convert.ToDouble(objPrestamos.BalancesData(dgv2.CurrentRow.Cells["#PRESTAMO"].Value.ToString()).Rows[0]["MONTO_RESTANTE"].ToString());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error validando pago");
                    }
                    try
                    {
                        pago = Convert.ToInt32(txtPago.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Monto a pagar no valido");
                    }

                    if (pago == 0)
                    {

                        MessageBox.Show("Favor digite un monto valido");
                    }
                    else
                    {
                        if (pagoaDeber == 0)
                        {
                            MessageBox.Show("Este prestamo ya fue saldado. Puede eliminarlo");
                        }
                        else
                        {
                            if (pago < 0)
                            {
                                MessageBox.Show("El monto a pagar debe ser un valor positivo");
                                pago = 0;
                            }
                            else
                            {
                                // verifico si me estan pagando mas de lo que debe
                                try
                                {
                                    if (pago > pagoaDeber)
                                    {
                                        devuelta = pago - pagoaDeber;
                                        pago = pagoaDeber;

                                        objPrestamos.Pagar(dgv2.CurrentRow.Cells["#PRESTAMO"].Value.ToString(), pago);

                                        MessageBox.Show("Prestamo saldado. Devuelta de " + devuelta + " RD$");

                                    }
                                    else if (pago == pagoaDeber)
                                    {
                                        objPrestamos.Pagar(dgv2.CurrentRow.Cells["#PRESTAMO"].Value.ToString(), pago);

                                        MessageBox.Show("Prestamo saldado.");
                                    }
                                    else
                                    {
                                        objPrestamos.Pagar(dgv2.CurrentRow.Cells["#PRESTAMO"].Value.ToString(), pago);
                                        MessageBox.Show("Pago realizado.");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Ha ocurrido un error procesando el pago. " + ex.Message);
                                }
                                idFila = Convert.ToByte(dgv2.CurrentRow.Index);
                            }
                        }
                    }

                    //Limpiar datos y actualizar balances
                    CargarPrestamos();
                    dgv2.Rows[0].Selected = false;
                    dgv2.Rows[idFila].Selected = true;
                    dgv2.CurrentCell = dgv2.Rows[idFila].Cells[0];
                    MontoDeLabel();
                    ActivacionModificar(false);
                    LimpiarTextos();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("No hay un prestamo seleccionado");
            }
        }


        //Metodos para manipular cambios de formularios
        private void btnCrearPrestamo_Click(object sender, EventArgs e)
        {
            NuevoPrestamo objNuevo = new NuevoPrestamo();
            objNuevo.Show();
            btnCrearPrestamo.Enabled = false;
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes objformClientes = new Clientes();
            MainClass.formPrestamos.Hide();
            objformClientes.Show();
        }


        #region Funiones para la UI Prestamos
        ProcesosPrestamo objPrestamos = new ProcesosPrestamo();

        //Carga los datos de los prestamos en el DGV
        private void CargarPrestamos(string nombreBusqueda = null)
        {
            //Si se pasa el parametro del metodo, se realiza la busqueda de ese prestamo
            //De lo contrario simplemente carga la informacion de todos los prestamos

            ProcesosPrestamo objeto = new ProcesosPrestamo();
            if (nombreBusqueda == null || nombreBusqueda == "")
            {
                dgv2.DataSource = objeto.MostrarPrestamos();
            }
            else
            {
                try
                {
                    dgv2.DataSource = objeto.BuscarPrestamo(nombreBusqueda);
                    if (dgv2.Rows[0].Cells["NOMBRE"].Value == null)
                    {
                        MessageBox.Show("No hay prestamos registrados para esta persona");
                        dgv2.DataSource = objeto.MostrarPrestamos();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No hay prestamos registrados para esta persona");
                }
            }
        }
        //Limpia el contenido de los TextBoxes
        private void LimpiarTextos()
        {
            txtNombre.Clear();
            txtMonto.Clear();
            txtCuotas.Clear();
            txtPago.Clear();
            cbModalidad.SelectedIndex = -1;
            cbInteres.SelectedIndex = -1;
            dtpFecha.ResetText();
        }
        //Establece los balances de prestamo del usuario seleccionado
        private void MontoDeLabel()
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.CurrencyPositivePattern = 3;
            nfi.CurrencySymbol = "RD$";

            if (dgv2.SelectedRows.Count > 0)
            {
                try
                {
                    lbTotal.Text = string.Format(nfi, "{0:C}", objPrestamos.BalancesData(dgv2.CurrentRow.Cells["#PRESTAMO"].Value.ToString()).Rows[0]["PAGO_TOTAL"]);
                    lbSaldado.Text = string.Format(nfi, "{0:C}", objPrestamos.BalancesData(dgv2.CurrentRow.Cells["#PRESTAMO"].Value.ToString()).Rows[0]["MONTO_SALDADO"]);
                    lbRestante.Text = string.Format(nfi, "{0:C}", objPrestamos.BalancesData(dgv2.CurrentRow.Cells["#PRESTAMO"].Value.ToString()).Rows[0]["MONTO_RESTANTE"]);
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                lbTotal.Text = string.Format(nfi, "{0:C}", 0);
                lbSaldado.Text = string.Format(nfi, "{0:C}", 0);
                lbRestante.Text = string.Format(nfi, "{0:C}", 0);
            }

        }
        //Cambia el estado de activacion de las opciones de edicion
        private void ActivacionModificar(bool valor)
        {
            if (valor == true)
            {
                txtMonto.Enabled = true;
                txtCuotas.Enabled = true;
                cbModalidad.Enabled = true;
                cbInteres.Enabled = true;
                dtpFecha.Enabled = true;
                btnGuardar.Enabled = true;
                lbCuota.Enabled = true;
                lbFecha.Enabled = true;
                lbInteres.Enabled = true;
                lbModalidad.Enabled = true;
                lbMonto.Enabled = true;
            }
            else
            {
                txtMonto.Enabled = false;
                txtCuotas.Enabled = false;
                cbModalidad.Enabled = false;
                cbInteres.Enabled = false;
                dtpFecha.Enabled = false;
                btnGuardar.Enabled = false;
                lbCuota.Enabled = false;
                lbFecha.Enabled = false;
                lbInteres.Enabled = false;
                lbModalidad.Enabled = false;
                lbMonto.Enabled = false;
            }
        }
        //Carga los datos del usuario a modificar
        private void RellenarModificar()
        {

            txtMonto.Text = dgv2.CurrentRow.Cells["MONTO"].Value.ToString();
            txtCuotas.Text = dgv2.CurrentRow.Cells["CUOTAS"].Value.ToString();
            cbModalidad.Text = dgv2.CurrentRow.Cells["MODALIDAD"].Value.ToString();
            cbInteres.Text = dgv2.CurrentRow.Cells["INTERES"].Value.ToString() + "%";
            dtpFecha.Value = Convert.ToDateTime(dgv2.CurrentRow.Cells["FECHA"].Value);
        }
        #endregion

    }
}
