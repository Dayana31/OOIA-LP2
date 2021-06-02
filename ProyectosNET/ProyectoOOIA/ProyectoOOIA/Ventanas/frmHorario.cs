using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmHorario : Form
    {
        public frmHorario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmHorario_Load(object sender, EventArgs e)
        {

        }

        private void dgvHorarioProf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            new frmDetCita_EventAlumnos().Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new frmPrincipalProfesor().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmCancelarCita().ShowDialog();
        }
    }
}
