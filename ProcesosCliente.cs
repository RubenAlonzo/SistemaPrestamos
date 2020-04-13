using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;


namespace CapaNegocios
{
    //Procesos intermedio entre los formularios y la base de datos
    public class ProcesosCliente
    {
        ConsultasClientes objConsulta = new ConsultasClientes();

        public DataTable MostrarClientes()
        {
            DataTable tabla = new DataTable();
            tabla = objConsulta.Mostrar();

            return tabla;
        }
        public void InsertarCliente(string nombre, string apellido, string cedula, string direccion, string edad, string telefono)
        {
            objConsulta.Insertar(nombre, apellido, cedula, direccion, Convert.ToByte(edad), telefono);
        }
        public void EditarCliente(string nombre, string apellido, string cedula, string direccion, string edad, string telefono, string id)
        {
            objConsulta.Editar(nombre, apellido, cedula, direccion, Convert.ToByte(edad), telefono, Convert.ToInt32(id));
        }
        public void EliminarCliente(string id)
        {
            objConsulta.Eliminar(Convert.ToInt32(id));
        }
        public DataTable BuscarCliente(string nombre)
        {
            DataTable tabla2 = new DataTable();
            tabla2 = objConsulta.Buscar(nombre);

            return tabla2;
        }
    }
}
