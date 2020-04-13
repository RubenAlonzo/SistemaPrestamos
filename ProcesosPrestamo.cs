using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;


namespace CapaNegocios
{
    public class ProcesosPrestamo
    {
        ConsultasPrestamo objConsulta = new ConsultasPrestamo();

        #region Metodos para el formulario de prestamos
        public DataTable MostrarPrestamos()
        {
            DataTable tabla = new DataTable();
            tabla = objConsulta.Mostrar();

            return tabla;
        }
        public DataTable BuscarPrestamo(string nombre)
        {
            DataTable tabla2 = new DataTable();
            tabla2 = objConsulta.Buscar(nombre);

            return tabla2;
        }
        public void EliminarPrestamo(string num)
        {
            objConsulta.Eliminar(Convert.ToInt32(num));
        }

        // ****** Manejo de pagos *******

        public void Pagar(string idPrestamo, double pago)
        {
            objConsulta.Pagar(Convert.ToInt32(idPrestamo), pago);
        }
        public DataTable BalancesData(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objConsulta.Balances(Convert.ToInt32(id));

            return tabla;
        }
        public void ActualizarPrestamos(string id, string monto, string cuota, string modalidad, string interes, string fecha)
        {
            //Elimina el signo de porcentaje del interes
            string[] numInteres = interes.Split('%');
            objConsulta.ActualizarPrestamos(Convert.ToInt32(id), Convert.ToDouble(monto), Convert.ToInt32(cuota), modalidad, Convert.ToInt32(numInteres[0]), Convert.ToDateTime(fecha));
        }
        #endregion

        #region Metodos usados en el formulario de Nuevo prestamo

        public DataTable MostrarClientes()
        {
            DataTable clientes = objConsulta.MostrarClientes();
            return clientes;
        }
        public string GetID(string nombre)
        {
            string ID = objConsulta.GetID(nombre);
            return ID;
        }
        public void InsertarNuevoPrestamo(string id, string monto, string cuota, string interes, string modalidad, string fecha)
        {
            //Elimina en signo de % en el ComboBox de interes
            string[] InteresValor = interes.Split('%');
            objConsulta.Insertar(Convert.ToByte(id), Convert.ToDouble(monto), Convert.ToByte(cuota), Convert.ToByte(InteresValor[0]), modalidad, fecha);
        }
        #endregion

    }
}
