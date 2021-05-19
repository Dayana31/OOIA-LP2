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
    public partial class frmCancelarCita : Form
    {
        public frmCancelarCita()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bthRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarCita_Click(object sender, EventArgs e)
        {
            frmConfirmarCancelar confirmarCancelar = new frmConfirmarCancelar();
            confirmarCancelar.ShowDialog();
            this.Close();
        }
    }
}
