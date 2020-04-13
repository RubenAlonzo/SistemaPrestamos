using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class ConsultasClientes
    {
        ConexionDB conexion = new ConexionDB();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            comando.Parameters.Clear();

            return tabla;
        }
        public void Insertar(string nombre, string apellido, string cedula, string direccion, byte edad, string telefono)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@cedula", cedula);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@edad", edad);
            comando.Parameters.AddWithValue("@telefono", telefono);

            comando.ExecuteNonQuery();

            conexion.CerrarConexion();
            comando.Parameters.Clear();
        }
        public void Editar(string nombre, string apellido, string cedula, string direccion, byte edad, string telefono, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@cedula", cedula);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@edad", edad);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
            comando.Parameters.Clear();
        }
        public void Eliminar(int id)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
            comando.Parameters.Clear();

        }
        public DataTable Buscar(string nombre)
        {
            SqlDataReader leer2;
            DataTable tabla2 = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            leer2 = comando.ExecuteReader();
            tabla2.Load(leer2);

            conexion.CerrarConexion();
            comando.Parameters.Clear();
            return tabla2;

        }
    }
}
