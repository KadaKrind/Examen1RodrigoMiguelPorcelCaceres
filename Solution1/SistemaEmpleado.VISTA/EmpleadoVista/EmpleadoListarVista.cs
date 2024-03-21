using System;
using SistemaEmpleado.BSS;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmpleado.VISTA.EmpleadoVista
{
    public partial class EmpleadoListarVista : Form
    {
        public EmpleadoListarVista()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        EmpleadoBss bss = new EmpleadoBss();
        private void EmpleadoListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarEmpleadoBss();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpleadoInsertarVista fr = new EmpleadoInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarEmpleadoBss();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idEmpleadoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EmpleadoEditarVista fr = new EmpleadoEditarVista(idEmpleadoSeleccionado);
                if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarEmpleadoBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar este empleado", "Eliminado", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarEmpleadoBss(idPersonaSeleccionada);
                dataGridView1.DataSource = bss.ListarEmpleadoBss();
            }
        }
    }
}
