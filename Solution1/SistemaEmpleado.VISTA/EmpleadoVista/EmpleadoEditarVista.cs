using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using SistemaEmpleado.MODELOS;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEmpleado.BSS;

namespace SistemaEmpleado.VISTA.EmpleadoVista
{
    public partial class EmpleadoEditarVista : Form
    {
        int idx = 0;
        Empleado em = new Empleado();
        EmpleadoBss bss= new EmpleadoBss();
        public EmpleadoEditarVista(int id)
        {
            idx = id;   
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            em.Puesto = textBox1.Text;
            em.Salario = Convert.ToInt32(textBox2.Text);
            em.FechaContratacion = dateTimePicker1.Value;
        }

        private void EmpleadoEditarVista_Load(object sender, EventArgs e)
        {
            em = bss.ObtenerIdBss(idx);
            textBox1.Text = em.Puesto;
            textBox2.Text = Convert.ToString(em.Salario);
            dateTimePicker1.Value = em.FechaContratacion;
            bss.EditarEmpleadoBss(em);
            MessageBox.Show("Datos Actualizados");

        }
    }
}
