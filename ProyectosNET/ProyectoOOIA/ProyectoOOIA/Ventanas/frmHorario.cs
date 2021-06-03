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

        private void frmHorario_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new frmPrincipalProfesor().Show();
            this.Close();
        }

        private void btnMostrarDetalles_Click(object sender, EventArgs e)
        {
            new frmDetCita_EventAlumnos().Show();
            this.Close();
        }

        private void btnModificarHorario_Click(object sender, EventArgs e)
        {
            new frmCancelarCita().ShowDialog();
        }

        private void btnBuscarHorario_Click(object sender, EventArgs e)
        {

        }
    }
}
