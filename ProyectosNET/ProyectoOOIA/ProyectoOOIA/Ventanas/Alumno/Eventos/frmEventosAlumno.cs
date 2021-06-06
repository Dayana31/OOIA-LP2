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

        private void frmRegistroEvento_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarInscritos_Click(object sender, EventArgs e)
        {
            new frmBuscarEventoAlumno().Show();
        }

        private void btnDetInscritos_Click(object sender, EventArgs e)
        {
            new frmVistadeEvento().Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //new frmAgregarEventoAlumno().Show();
            DialogResult dr =
               MessageBox.Show("¿Desea inscribirse a este evento?", "Inscripción a Evento",
               MessageBoxButtons.YesNo, MessageBoxIcon.None);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //new frmCancelarEventoAlumno().Show();
            DialogResult dr =
               MessageBox.Show("¿Desea cancelar su inscripción a este evento?", "Cancelar Evento",
               MessageBoxButtons.YesNo, MessageBoxIcon.None);
        }

        private void btnDetHistorial_Click(object sender, EventArgs e)
        {
            new frmVistadeEvento().Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new frmPrincipal(TipoUsuario.Alumno).Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new frmInicioSesion().Show();
            this.Close();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            new frmAccesoEvento().ShowDialog();
        }
    }
}
