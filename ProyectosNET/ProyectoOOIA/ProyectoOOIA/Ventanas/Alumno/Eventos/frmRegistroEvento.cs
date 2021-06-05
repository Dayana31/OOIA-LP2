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


        private void button1_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            new frmPrincipalAsesor().Show();
            this.Close();
        }

        private void frmRegistroEvento_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarInscritos_Click(object sender, EventArgs e)
        {
            new frmBuscarEventoAlumno().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new frmPrincipal(TipoUsuario.Alumno).Show();
            this.Close();
        }

        private void btnDetInscritos_Click(object sender, EventArgs e)
        {
            new frmVistadeEvento().Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            new frmAgregarEventoAlumno().Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new frmCancelarEventoAlumno().Show();
        }

        private void btnDetHistorial_Click(object sender, EventArgs e)
        {
            new frmVistadeEvento().Show();
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            new frmPrincipal(TipoUsuario.Alumno).Show();
            this.Close();
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
