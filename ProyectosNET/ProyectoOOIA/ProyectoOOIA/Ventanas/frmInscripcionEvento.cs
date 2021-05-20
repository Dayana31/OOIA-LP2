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
    public partial class frmInscripcionEvento : Form
    {
        public frmInscripcionEvento()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmInscripcionEvento_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su registro ha sido exitoso", "Cerrar");

        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su registro ha sido exitoso", "Cerrar");
        }
    }
}
