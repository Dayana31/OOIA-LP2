using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmListaCitasAlumno : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,
            int wMsg, int wParam, int lParam);

        public frmListaCitasAlumno()
        {
            InitializeComponent();
            //esto hace que no se genere mas columnas de las que yo he 
            //definido en la interfaz grafica
            dgvCitasProgramadas.AutoGenerateColumns = false;
            dgvHistorialCitas.AutoGenerateColumns = false;
            tabCitasProgramadas.AutoScroll = false;
            tabCitasProgramadas.HorizontalScroll.Enabled = false;
            tabCitasProgramadas.HorizontalScroll.Visible = false;
            tabCitasProgramadas.HorizontalScroll.Maximum = 0;
            tabCitasProgramadas.AutoScroll = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new frmPrincipal(TipoUsuario.Alumno).Show();
            this.Close();
        }

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {
            //new frmCancelarCitaAlumno().ShowDialog();
            DialogResult dr =
               MessageBox.Show("¿Esta seguro que desea cancelar esta cita?", "Cancelación de cita", 
               MessageBoxButtons.YesNo, MessageBoxIcon.None);

        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            //tenemos que almacenar los datos en la pantalla
            new frmDetalleCita().ShowDialog();
            //this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }


        private void btnRegistrarCita_Click(object sender, EventArgs e)
        {
            //new frmCitaRegistroAlumno().ShowDialog();
            //new frmConfirmarCitaAlumno().ShowDialog();
            DialogResult dr = 
                MessageBox.Show("¿Esta seguro que desea programar la cita?", "Registro de cita", 
                MessageBoxButtons.YesNo, MessageBoxIcon.None);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

            new frmInicioSesion().Show();
            this.Close();
        }

        private void btnAgregarOpinion_Click(object sender, EventArgs e)
        {
            new frmAgregarOpinion().ShowDialog();

        }

        private void btnBuscarAsesor_Click(object sender, EventArgs e)
        {
            new frmListaTutores().Show();
        }

        private void btnBuscarHorario_Click(object sender, EventArgs e)
        {
            new frmHorarioCita().Show();
        }

        private void btnDetInscritas_Click(object sender, EventArgs e)
        {
            new frmDetalleCita().ShowDialog();
            this.DialogResult = DialogResult.OK;
        }
    }
}
