using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoOOIA.AlumnoWS;
using ProyectoOOIA.InvitadoWS;
using ProyectoOOIA.ProfesorWS;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Eventos
{
    public partial class frmMostrarPonentes : Form
    {

        private int tipoUsuario = -1;
        private ProfesorWS.profesor profesor = null;
        private AlumnoWS.alumno alumno = null;
        private InvitadoWS.invitado invitado = null;
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
                invitado = new invitado();
                dgvPonentes.DataSource = new InvitadoWS.InvitadoWSClient().listarInvitado();
            }
            else if (tipoUsuario == 1)
            {
                profesor = new profesor();
                dgvPonentes.DataSource = new ProfesorWS.ProfesorWSClient().listarProfesores();

            }
            else
            {
                alumno = new alumno();
                dgvPonentes.DataSource = new AlumnoWS.AlumnoWSClient().listarAlumno();
            }
            
        }

        public int TipoUsuario
        {
            get => tipoUsuario;
            set => tipoUsuario = value;
        }

        public profesor Profesor
        {
            get => profesor;
            set => profesor = value;
        }

        public alumno Alumno
        {
            get => alumno;
            set => alumno = value;
        }

        public invitado Invitado
        {
            get => invitado;
            set => invitado = value;
        }

        private void dgvPonentes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tipoUsuario == 0)
            {
                invitado = dgvPonentes.Rows[e.RowIndex].DataBoundItem as InvitadoWS.invitado;
                dgvPonentes.Rows[e.RowIndex].Cells[0].Value = invitado.nombre;
                dgvPonentes.Rows[e.RowIndex].Cells[0].Value = "Invitado";

            }
            else if (tipoUsuario == 1)
            {
                profesor=dgvPonentes.Rows[e.RowIndex].DataBoundItem as profesor;
                dgvPonentes.Rows[e.RowIndex].Cells[0].Value = profesor.nombre;
                dgvPonentes.Rows[e.RowIndex].Cells[0].Value = profesor.especialidad.nombre_especialidad;

            }
            else
            {
                alumno= dgvPonentes.Rows[e.RowIndex].DataBoundItem as alumno;
                dgvPonentes.Rows[e.RowIndex].Cells[0].Value = alumno.nombre;
                dgvPonentes.Rows[e.RowIndex].Cells[0].Value = alumno.especialidad.nombre_especialidad;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (tipoUsuario == 0) invitado = dgvPonentes.CurrentRow.DataBoundItem as InvitadoWS.invitado;
            else if(tipoUsuario==1)profesor=dgvPonentes.CurrentRow.DataBoundItem as ProfesorWS.profesor;
            else alumno=dgvPonentes.CurrentRow.DataBoundItem as AlumnoWS.alumno;
            
            this.Dispose();
        }
    }
}
