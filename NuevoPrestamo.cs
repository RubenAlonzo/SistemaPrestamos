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


namespace SistemaPrestamos
{
    public partial class NuevoPrestamo : Form
    {
        public NuevoPrestamo()
        {
            InitializeComponent();
        }

        private void NuevoPrestamo_Load(object sender, EventArgs e)
        {
            cbClientesData();
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            try
            {
                if (objPrestamos.GetID(cbCliente.Text) != "")
                {
                    ActivacionDatos(true);
                }
                else
                {
                    MessageBox.Show("Seleccione un cliente existente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error en la busqueda. " + ex.Message);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objPrestamos.InsertarNuevoPrestamo(objPrestamos.GetID(cbCliente.Text), txtMonto.Text, txtCuotas.Text, cbInteres.Text, cbModalidad.Text, dtpFechaInicio.Value.ToString("yyyy-MM-dd"));
                MessageBox.Show("Prestamo creado exitosamente");
                ActivacionDatos(false);

                txtMonto.Clear();
                cbModalidad.SelectedIndex = -1;
                dtpFechaInicio.ResetText();
                txtCuotas.Clear();
                cbInteres.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo crear el prestamo" + ex.Message);
            }
        }

        //Para poder habilitar abrir el formulario de NuevoPrestamo y mantener una sola instancia
        private void NuevoPrestamo_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainClass.formPrestamos.btnCrearPrestamo.Enabled = true;
        }

        #region Funciones para la UI NuevoPrestamo

        ProcesosPrestamo objPrestamos = new ProcesosPrestamo();

        //Envia el nombre de los clientes al ComboBox de seleccion
        private void cbClientesData()
        {
            try
            {
                cbCliente.DataSource = objPrestamos.MostrarClientes();
                cbCliente.DisplayMember = "NOMBRE";
                cbCliente.ValueMember = "ID_CLIENTE";
                cbCliente.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error en la busqueda. " + ex.Message);
            }
        }
        //Bloquea o desbloquea la seleccion e insercion de datos a la base de datos
        private void ActivacionDatos(bool val)
        {
            if (val == true)
            {
                lbPrincipal.Enabled = true;
                txtMonto.Enabled = true;
                cbModalidad.Enabled = true;
                dtpFechaInicio.Enabled = true;
                btnGuardar.Enabled = true;
                txtCuotas.Enabled = true;
                cbInteres.Enabled = true;
            }
            else
            {
                lbPrincipal.Enabled = false;
                txtMonto.Enabled = false;
                cbModalidad.Enabled = false;
                dtpFechaInicio.Enabled = false;
                btnGuardar.Enabled = false;
                txtCuotas.Enabled = false;
                cbInteres.Enabled = false;
            }
        }
        #endregion
    }
}