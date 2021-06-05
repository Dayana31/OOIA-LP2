using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmGestionEventosOOIA : Form
    {
        public frmGestionEventosOOIA()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmBuscarEventoAlumno().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new frmPrincipal(TipoUsuario.OOIA).Show();
            this.Close();
        }
    }
}
