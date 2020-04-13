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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarClientes(txtNombre.Text);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Establece el formato inicial en todo el formulario

            MostrarClientes();
            LimpiarTexto();
            idCliente = null;
            editar = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (editar == false)
            {
                //Verfificacion si los campos no contienen datos vacios: ""
                if (CamposVacios() == false)
                {
                    try
                    {
                        //Inserta los datos en los campos de cliente a la base de Datos (Guarda la informacion)

                        objClientes.InsertarCliente(txtNombre.Text, txtApellido.Text, txtCedula.Text, txtDireccion.Text, txtEdad.Text, txtTelefono.Text);
                        MessageBox.Show("Se insertaron los datos correctamente");
                        LimpiarTexto();
                        MostrarClientes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo insertar los datos. " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Complete los campos vacios");
                }
            }
            else
            {
                if (CamposVacios() == false)
                {
                    //Realiza una actualizacion de los datos especificados
                    try
                    {
                        objClientes.EditarCliente(txtNombre.Text, txtApellido.Text, txtCedula.Text, txtDireccion.Text, txtEdad.Text, txtTelefono.Text, idCliente);
                        MessageBox.Show("Se editaron los datos correctamente");
                        MostrarClientes();
                        LimpiarTexto();
                        editar = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo editar los datos. " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Complete los campos vacios");
                }
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dgv1.SelectedRows.Count > 0)
            {
                editar = true;
                RellenarTextBox();
            }
            else
            {
                MessageBox.Show("Seleccione la fila a editar");
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                if (dgv1.Rows[0].Cells[0].Value != null)
                {
                    try
                    {
                        //Proceso de eliminar cliente

                        idCliente = dgv1.CurrentRow.Cells["ID_CLIENTE"].Value.ToString();
                        objClientes.EliminarCliente(idCliente);
                        MessageBox.Show("Cliente eliminado correctamente");
                        LimpiarTexto();
                        MostrarClientes();
                    }
                    catch (SqlException ex)
                    {
                        //Numero de error en SQL para cuando un cliente contiene datos en la tabla prestamos: 547
                        if (ex.Number == 547)
                        {
                            MessageBox.Show("No puede eliminar este cliente ya que tiene un prestamo");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el cliente. " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay seleccionado un cliente para eliminar");
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila a eliminar");
            }
        }


        //Metodos para manipular cambios de formularios
        private void Clientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainClass.formPrestamos.Show();
        }
        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region Funciones para la UI de Clientes

        //Objeto para manipular los datos de la tabla clientes
        ProcesosCliente objClientes = new ProcesosCliente();

        string idCliente = null;
        bool editar = false;

        //Metodo para Vincular los datos de clientes al Grid View
        public void MostrarClientes(string nombreBusqueda = null)
        {
            //El parametro opcional que acepta permite saber si se realiza una busqueda o no
            try
            {
                ProcesosCliente objeto = new ProcesosCliente();
                if (nombreBusqueda == null || nombreBusqueda == "")
                {
                    //Para presentar todos los datos
                    dgv1.DataSource = objeto.MostrarClientes();
                }
                else
                {
                    //Para buscar clientes
                    dgv1.DataSource = objeto.BuscarCliente(nombreBusqueda);
                    if (dgv1.Rows[0].Cells["NOMBRE"].Value == null)
                    {
                        MessageBox.Show("No se encontro el cliente");
                        dgv1.DataSource = objeto.MostrarClientes();
                        LimpiarTexto();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro el cliente");
            }
        }
        //Rellena los TextBoxs con el contenido del registro seleccionado
        public void RellenarTextBox()
        {
            txtNombre.Text = dgv1.CurrentRow.Cells["NOMBRE"].Value.ToString();
            txtApellido.Text = dgv1.CurrentRow.Cells["APELLIDO"].Value.ToString();
            txtCedula.Text = dgv1.CurrentRow.Cells["CEDULA"].Value.ToString();
            txtDireccion.Text = dgv1.CurrentRow.Cells["DIRECCION"].Value.ToString();
            txtEdad.Text = dgv1.CurrentRow.Cells["EDAD"].Value.ToString();
            txtTelefono.Text = dgv1.CurrentRow.Cells["TELEFONO"].Value.ToString();
            idCliente = dgv1.CurrentRow.Cells["ID_CLIENTE"].Value.ToString();


        }
        //Elimina el contenido de los TextBoxs mencionados
        public void LimpiarTexto()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtDireccion.Clear();
            txtEdad.Clear();
            txtTelefono.Clear();
        }
        //Valida si hay campos vacios
        public bool CamposVacios()
        {
            bool vacios = false;

            if (txtNombre.Text.Length < 1 || txtApellido.Text.Length < 1 || txtCedula.Text.Length < 1 || txtDireccion.Text.Length < 1 || txtEdad.Text.Length < 1 || txtTelefono.Text.Length < 1)
            {
                vacios = true;
            }

            return vacios;
        }

        #endregion

    }
}
