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


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHistoriaAcademica historiaAcademica = new frmHistoriaAcademica();
            historiaAcademica.ShowDialog();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new frmHorarioAsesor().Show();
            this.Close();
        }
    }
}
