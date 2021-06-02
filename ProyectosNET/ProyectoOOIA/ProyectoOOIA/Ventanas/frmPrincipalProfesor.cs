using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmPrincipalProfesor : Form
    {
        public frmPrincipalProfesor()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            new frmInicioSesion().Show();
            this.Close();
        }

        private void txtHorarios_Click(object sender, EventArgs e)
        {

        }

        private void txtEventos_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmHorario().Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmRegistroEvento().Show();
            this.Close();
        }
    }
}
