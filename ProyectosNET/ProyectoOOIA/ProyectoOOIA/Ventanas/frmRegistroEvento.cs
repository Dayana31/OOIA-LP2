using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmRegistroEvento : Form
    {
        public frmRegistroEvento()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            new frmPrincipalProfesor().Show();
            this.Close();
        }

        private void frmRegistroEvento_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new frmBuscarEventoAlumno().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new frmNuevoPrincipal().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmVistadeEvento().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmAgregarEventoAlumno().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmEliminarEventoAlum().Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            new frmVistadeEvento().Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            new frmNuevoPrincipal().Show();
            this.Close();
        }
    }
}
