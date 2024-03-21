using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEmpleado.MODELOS;


namespace SistemaEmpleado.DAL
{
    public class EmpleadoDal
    {
        public DataTable ListarEmpleadoDal()
        {
            string consulta = "select * from empleadoex";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarEmpleadoDal(Empleado empleado)
        {
            int counter = 5;
            string consulta = "insert into empleadoex values('" + counter +"','" + empleado.Puesto + "'," + "'" + empleado.Salario + "'," + "'" + empleado.FechaContratacion+ "')";
            conexion.Ejecutar(consulta);
            counter++;
        }
        public Empleado ObtenerEmpleadoId(int id)
        {
            string consulta = "select * from empleadoex where idempleado=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asas");
            Empleado e = new Empleado();
            if (tabla.Rows.Count > 0)
            {
                e.IdEmpleado = Convert.ToInt32(tabla.Rows[0]["idempleado"]);
                e.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                e.Puesto = tabla.Rows[0]["Puesto"].ToString();
                e.Salario = Convert.ToInt32(tabla.Rows[0]["Salario"]);
                e.FechaContratacion = Convert.ToDateTime(tabla.Rows[0]["Fechacontratacion"]);
               
            }
            return e;
        }
        public void EditarEmpleadoDal(Empleado e)
        {
            string consulta = "update empleadoex set puesto='" + e.Puesto + "'," + "salario='" + e.Salario + "'," + "fechacontratacion='" + e.FechaContratacion  +"'" + "where idempleado=" + e.IdEmpleado;
            conexion.Ejecutar(consulta);
        }
        public void EliminarEmpleadoDal(int id)
        {
            string consulta = "delete from empleadoex where idempleado=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
