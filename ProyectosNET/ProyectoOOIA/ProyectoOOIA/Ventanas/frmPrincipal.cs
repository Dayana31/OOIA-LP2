using ProyectoOOIA.Ventanas.Miembro_OOIA;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmPrincipal : Form
    {
        private BindingList<Bitmap> listaImagenes = new BindingList<Bitmap>();
        private int indice = 0;
        private TipoUsuario tipo;
        public frmPrincipal(TipoUsuario tipoUsuario)
        {
            InitializeComponent();
            btnCargaDatos.Visible = false;
            tipo = tipoUsuario;
            if (tipo == TipoUsuario.Asesor)
            {
                btnEventos.Enabled = false;
                //btnEventos.Visible = false;
                txtEventos.Enabled = false;
            }
            if (tipo == TipoUsuario.OOIA)
            {
                btnCargaDatos.Visible = true;
                btnCitas.Enabled = false;
                //btnCitas.Visible = false;
                txtCitas.Enabled = false;
            }
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.profesor);
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.EEGGCC);
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.Estudiante1);
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.pexels_pixabay_261621);
            imagenes.Image = listaImagenes[0];
            ToolTip ttEjemplo = new ToolTip();

            ttEjemplo.SetToolTip(btnCitas, "Programar citas");

        }


        private void imagenes_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            indice++;
            if (indice >= listaImagenes.Count)
                indice = 0;
            imagenes.Image = listaImagenes[indice];
        }

        private void botonCitas_Click(object sender, EventArgs e)
        {
            if (tipo == TipoUsuario.Alumno) new frmCitasAlumno().Show();
            if (tipo == TipoUsuario.Asesor) new frmHorarioAsesor().Show();
            this.Close();
        }

        private void botonEventos_Click(object sender, EventArgs e)
        {
            if (tipo == TipoUsuario.Alumno) new frmRegistroEvento().Show();
            if (tipo == TipoUsuario.OOIA) new frmGestionEventosOOIA(Estado.Inicial).Show();
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            new frmInicioSesion().Show();
            this.Close();
        }

        private void btnCargaDatos_Click(object sender, EventArgs e)
        {
            new frmCargarDatos().ShowDialog();

        }
    }
}

