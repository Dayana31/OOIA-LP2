using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmHorarioAsesor : Form
    {

        //private Horario _horarioSeleccionado;

        public frmHorarioAsesor()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new frmPrincipalAsesor().Show();
            this.Close();
        }

        private void btnMostrarDetalles_Click(object sender, EventArgs e)
        {
            /*_horarioSeleccionado = (Horario)dvgHorarioProf.CurrentRow.DataBoundItem;*/
            new frmDetCita_EventAlumnos().Show();
            this.Close();
        }

        private void btnModificarHorario_Click(object sender, EventArgs e)
        {
            /*_horarioSeleccionado = (Horario)dvgHorarioProf.CurrentRow.DataBoundItem;
            if(_horarioSeleccionado.Estado == Libre || _horarioSeleccionado == Ocupado)
                new frmModificatCita().ShowDialog();
            else if(_horarioSeleccionado.Estado == Reservado)*/
            new frmCancelarCitaAsesor().ShowDialog();
        }

        private void btnBuscarHorario_Click(object sender, EventArgs e)
        {
            /*dgvHorarioProf.DataSource =
                daoHorario.listarHorario(tbNombre.Text);*/
        }
    }
}
