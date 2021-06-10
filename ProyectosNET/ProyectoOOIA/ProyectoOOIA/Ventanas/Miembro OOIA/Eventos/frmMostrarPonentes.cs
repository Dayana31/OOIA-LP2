using ProyectoOOIA.AlumnoWS;
using ProyectoOOIA.InvitadoWS;
using ProyectoOOIA.ProfesorWS;
using System;
using System.Windows.Forms;
using persona = ProyectoOOIA.GestionHumanaWS.persona;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Eventos
{
    public partial class frmMostrarPonentes : Form
    {

        private int tipoUsuario = -1;
        private GestionHumanaWS.persona persona=null;
        public frmMostrarPonentes()
        {
            InitializeComponent();
            dgvPonentes.AutoGenerateColumns = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tipoUsuario = cmbHorario.SelectedIndex;
            

            if (tipoUsuario == 0)
            {
                persona = new GestionHumanaWS.invitado();
                dgvPonentes.DataSource = new GestionHumanaWS.GestionHumanaWSClient().listarInvitado();



            }
            else if (tipoUsuario == 1)
            {
                persona = new GestionHumanaWS.profesor();
                dgvPonentes.DataSource = new GestionHumanaWS.GestionHumanaWSClient().listarProfesores();

            }
            else
            {
                persona = new GestionHumanaWS.alumno();
                dgvPonentes.DataSource = new GestionHumanaWS.GestionHumanaWSClient().listarAlumno();
            }

        }

        public int TipoUsuario
        {
            get => tipoUsuario;
            set => tipoUsuario = value;
        }

       

        public persona Persona
        {
            get => persona;
            set => persona = value;
        }

        private void dgvPonentes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tipoUsuario == 0)
            {
                persona = dgvPonentes.Rows[e.RowIndex].DataBoundItem as GestionHumanaWS.invitado;
            }
            else if (tipoUsuario == 1)
            {
                persona = dgvPonentes.Rows[e.RowIndex].DataBoundItem as GestionHumanaWS.profesor;

            }
            else
            {
                persona = dgvPonentes.Rows[e.RowIndex].DataBoundItem as GestionHumanaWS.alumno;
            }
            dgvPonentes.Rows[e.RowIndex].Cells[0].Value = persona.nombre;
            dgvPonentes.Rows[e.RowIndex].Cells[1].Value = persona.correo;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            persona = dgvPonentes.CurrentRow.DataBoundItem as GestionHumanaWS.persona;


            this.Dispose();
        }
    }
}
