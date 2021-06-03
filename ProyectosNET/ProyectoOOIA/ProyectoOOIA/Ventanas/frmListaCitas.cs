using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmListaCitas : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,
            int wMsg, int wParam, int lParam);

        public frmListaCitas()
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
            new frmNuevoPrincipal().Show();
            this.Close();
        }

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {
            new frmCancelarCitaAlumno().ShowDialog();

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

        private void dgvCitasProgramadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnRegistrarCita_Click(object sender, EventArgs e)
        {
            new frmCitaRegistro().ShowDialog();
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
    }
}
