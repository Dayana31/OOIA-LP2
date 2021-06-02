using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmDetCita_EventAlumnos : Form
    {
        public frmDetCita_EventAlumnos()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHistoriaAcademica historiaAcademica = new frmHistoriaAcademica();
            historiaAcademica.ShowDialog();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new frmHorario().Show();
            this.Close();
        }
    }
}
