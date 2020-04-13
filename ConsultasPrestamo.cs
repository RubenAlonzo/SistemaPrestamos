using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class ConsultasPrestamo
    {
        ConexionDB conexion = new ConexionDB();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        #region Metodos para el formulario de prestamos
        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarPrestamos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);

            comando.Connection = conexion.CerrarConexion();
            comando.Parameters.Clear();
            return tabla;
        }
        public DataTable Buscar(string nombre)
        {
            SqlDataReader leer2;
            DataTable tabla2 = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarPrestamo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            leer2 = comando.ExecuteReader();
            tabla2.Load(leer2);

            comando.Connection = conexion.CerrarConexion();
            comando.Parameters.Clear();
            return tabla2;
        }
        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarPrestamo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
            comando.Parameters.Clear();
        }


        //*********  Manejo de pagos  ************

        public void Pagar(int idPrestamo, double pago)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EntrarPago";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idPrestamo", idPrestamo);
            comando.Parameters.AddWithValue("@pago", pago);
            comando.ExecuteNonQuery();

            comando.Connection = conexion.CerrarConexion();
            comando.Parameters.Clear();
        }
        public void ActualizarPrestamos(int id, double monto, int cuota, string modalidad, int interes, DateTime fecha)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarPrestamo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idPrestamo", id);
            comando.Parameters.AddWithValue("@monto", monto);
            comando.Parameters.AddWithValue("@cuota", cuota);
            comando.Parameters.AddWithValue("@modalidad", modalidad);
            comando.Parameters.AddWithValue("@interes", interes);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.ExecuteNonQuery();

            comando.Connection = conexion.CerrarConexion();
            comando.Parameters.Clear();
        }
       
        //Selecciona en la base de datos los balances de: pago total, restante y saldado de un prestamo en especifico
        public DataTable Balances(int id)
        {
            DataTable tabla = new DataTable();
            SqlDataReader leer;
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BalancesPrestamos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idPrestamo", id);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Connection = conexion.CerrarConexion();

            comando.Connection = conexion.CerrarConexion();
            comando.Parameters.Clear();
            return tabla;
        }
        #endregion

        #region Metodos usados en el formulario de Nuevo prestamo 
        public DataTable MostrarClientes()
        {
            SqlDataReader leer3;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostarNombres";
            comando.CommandType = CommandType.StoredProcedure;
            leer3 = comando.ExecuteReader();
            tabla.Load(leer3);

            comando.Connection = conexion.CerrarConexion();
            comando.Parameters.Clear();
            return tabla;
        }
        
        //Obtiene el Id del cliente al que le crearan el prestamo
        public string GetID(string nombre)
        {
            string id;

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "GetID";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nom", nombre);
            comando.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
            comando.ExecuteNonQuery();

            id = Convert.ToString(comando.Parameters["@id"].Value);

            comando.Connection = conexion.CerrarConexion();
            comando.Parameters.Clear();
            return id;
        }
        public void Insertar(byte id, double monto, byte cuota, byte interes, string modalidad, string fehca)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarNuevoPrestamo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCliente", id);
            comando.Parameters.AddWithValue("@monto", monto);
            comando.Parameters.AddWithValue("@cuota", cuota);
            comando.Parameters.AddWithValue("@interes", interes);
            comando.Parameters.AddWithValue("@modalidad", modalidad);
            comando.Parameters.AddWithValue("@fecha", fehca);

            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
            comando.Parameters.Clear();
        }
        #endregion
    }
}
