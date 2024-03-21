using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEmpleado.DAL;
using SistemaEmpleado.MODELOS;

namespace SistemaEmpleado.BSS
{
    public class EmpleadoBss
    {
        EmpleadoDal dal = new EmpleadoDal();
        public DataTable ListarEmpleadoBss()
        {
            return dal.ListarEmpleadoDal();
        }
        public void InsertarEmpleadoBss(Empleado empleado)
        {
            dal.InsertarEmpleadoDal(empleado);
        }
        public Empleado ObtenerIdBss(int id)
        {
            return dal.ObtenerEmpleadoId(id);
        }
        public void EditarEmpleadoBss(Empleado e)
        {
            dal.EditarEmpleadoDal(e);
        }
        public void EliminarEmpleadoBss(int id)
        {
            dal.EliminarEmpleadoDal(id);
        }

    }
}

