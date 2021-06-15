using ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos;
using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA
{
    public partial class frmCargarDatos : Form
    {
        public frmCargarDatos()
        {
            InitializeComponent();
        }

        /*TAB Gestion Humana*/

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            new frmCargarAlumno().ShowDialog();
        }


        /*TAB Gestion Atencion*/
        private void btnCodigoAtencion_Click(object sender, EventArgs e)
        {
            new frmCodigosAtencion().ShowDialog();
        }

        private void btnAsesor_Click(object sender, EventArgs e)
        {
            if (rbProfesor.Checked) new frmCargarProfesor().ShowDialog();
            if (rbPsicologo.Checked) new frmCargarPsicologo().ShowDialog();
        }
    }
}
