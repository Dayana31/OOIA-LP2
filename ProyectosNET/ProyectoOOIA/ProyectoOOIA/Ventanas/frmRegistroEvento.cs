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
            if (txtNombre.Text == "") MessageBox.Show("Datos invalidos u horario \nocupado", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else MessageBox.Show("El evento ha sido registrado\ncon exito");


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
    }
}
