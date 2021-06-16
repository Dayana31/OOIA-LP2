using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{

    public partial class frmInicioSesion : Form
    {

        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }


        private void linkContraseña_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmReestablecerContraseña().ShowDialog();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (rbtAlumno.Checked == false && rbtTutor.Checked == false && rbtMiembroOOIA.Checked == false)
            {
                lblPassIncorrecto.Visible = false;
                lblTipoIncorrecto.Visible = true;
            }
            else if (txtContraseña.Text == "")
            {
                lblTipoIncorrecto.Visible = false;
                lblPassIncorrecto.Visible = true;
            }
            else
            {
           
                if (rbtAlumno.Checked == true)
                {
                    new frmPrincipal(TipoUsuario.Alumno).Show();
                }
                else if (rbtTutor.Checked == true)
                {
                    new frmPrincipal(TipoUsuario.Asesor).Show();
                }
                else
                {
                    new frmPrincipal(TipoUsuario.OOIA).Show();
                }
                this.Close();
            }
        }

        private void frmInicioSesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = '\n';
            if (e.KeyChar == c)
                btnIngresar_Click(null, null);
        }

        private void pnlRight_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                btnIngresar_Click(null, null);
        }

    }
}
