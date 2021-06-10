using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Alumno.Citas
{
    public partial class ucAsesor : UserControl
    {
        private ProfesorWS.profesor tutor;
        private PsicologoWS.psicologo psicologo;


        public ucAsesor(ProfesorWS.profesor t)
        {
            InitializeComponent();
            tutor = t;

            lblNombre.Text = tutor.nombre;
            lblEspecialidad.Text = tutor.especialidad.nombre_especialidad;

        }

        public ucAsesor(PsicologoWS.psicologo p)
        {
            InitializeComponent();
            psicologo = p;

            lblNombre.Text = tutor.nombre;
            lblEspecialidad.Visible = false;
        }

        private void btnOpinion_Click(object sender, EventArgs e)
        {
            new frmOpiniones().ShowDialog();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
