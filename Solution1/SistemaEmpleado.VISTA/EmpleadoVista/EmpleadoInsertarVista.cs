using SistemaEmpleado.BSS;
using SistemaEmpleado.MODELOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaEmpleado.VISTA.EmpleadoVista
{
    public partial class EmpleadoInsertarVista : Form
    {
        public EmpleadoInsertarVista()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
        EmpleadoBss bss = new EmpleadoBss();

        private void button1_Click(object sender, EventArgs e)
        {
            bool EsValido;
            bool validarNumeroAntesDeOperacion(string numero)
            {
                //bool EsValido;
                try
                {
                    double Numero = Convert.ToDouble(numero);
                    EsValido = true;
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.ToString());
                    EsValido = false;
                }

                return EsValido;
            }
            do
            {
                validarNumeroAntesDeOperacion(textBox2.Text);
                if (EsValido == true)
                {
                    break;
                }
                else
                {
                    MessageBox.Show("Ingrese Un numero en sueldo por favor");
                }
            } while (true);
            if (textBox1.Text == null || textBox2.Text == null || dateTimePicker1.Value == null)
            {
                MessageBox.Show("Por favor ingrese valores correctos en cada casilla");

            }
            else
            {
                Empleado em = new Empleado();
                em.Puesto = textBox1.Text;
                em.Salario = Convert.ToInt32(textBox2.Text);
                em.FechaContratacion = dateTimePicker1.Value;

                bss.InsertarEmpleadoBss(em);
                MessageBox.Show("Se guardo correctamente el empleado");
            }
        }

        private void EmpleadoInsertarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
