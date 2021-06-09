using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoOOIA.Ventanas.Miembro_OOIA.Eventos;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmGestionEventosOOIA : Form
    {

        private ProfesorWS.profesor profesor = null;
        private AlumnoWS.alumno alumno = null;
        private InvitadoWS.invitado invitado = null;

        public frmGestionEventosOOIA(Estado estado)
        {
            InitializeComponent();
            componentes(estado);
        }

        private void componentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = false;
                    btnAgregarImagen.Enabled = false;
                    btnAgregarPonente.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnEliminarPonente.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    dtpFechaEvento.Enabled = false;
                    txtHoraFin.Enabled= false;
                    txtHoraInicio.Enabled = false;
                    txtNombre.Enabled = false;
                    txtNombrePonente.Enabled = false;
                    txtDescripcion.Enabled = false;
                    cboCategoria.Enabled = false;
                    dgvPonentes.Enabled = false;
                    dgvPonentes.RowCount = 1;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = true;
                    btnAgregarImagen.Enabled = true;
                    btnAgregarPonente.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnEliminarPonente.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    dtpFechaEvento.Enabled = true;
                    txtHoraFin.Enabled = true;
                    txtHoraInicio.Enabled = true;
                    txtNombre.Enabled = true;
                    txtNombrePonente.Enabled = true;
                    txtDescripcion.Enabled = true;
                    cboCategoria.Enabled = true;
                    dgvPonentes.Enabled = true;
                    break;
                case Estado.Busqueda:
                    btnNuevo.Enabled = false;
                    btnAgregarImagen.Enabled = false;
                    btnAgregarPonente.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnEliminarPonente.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = true;
                    dtpFechaEvento.Enabled = false;
                    txtHoraFin.Enabled = false;
                    txtHoraInicio.Enabled = false;
                    txtNombre.Enabled = false;
                    txtNombrePonente.Enabled = false;
                    txtDescripcion.Enabled = false;
                    cboCategoria.Enabled = false;
                    dgvPonentes.Enabled = false;
                    break;
                
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            new frmBuscarEventoAlumno().Show();
            componentes(Estado.Busqueda);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new frmPrincipal(TipoUsuario.OOIA).Show();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dr =
               MessageBox.Show("¿Desea registrar este evento?", "Guardar Evento",
               MessageBoxButtons.YesNo, MessageBoxIcon.None);

            string patron = @"\s?\d?\d:\d\d";
            Regex regex = new Regex(patron);
            if (!regex.IsMatch(txtHoraInicio.Text))
            {
                MessageBox.Show("Formato de hora Inicio incorrecto","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if (!regex.IsMatch(txtHoraFin.Text))
            {
                MessageBox.Show("Formato de hora Fin incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            componentes(Estado.Nuevo);
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if (agregarImagen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(agregarImagen.InitialDirectory + agregarImagen.FileName);
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            componentes(Estado.Inicial);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea modificar este evento?", "Confirmacion", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Evento Actualizado", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                componentes(Estado.Nuevo);
            }
            
        }

        private void btnAgregarPonente_Click(object sender, EventArgs e)
        {

            dgvPonentes.Rows[dgvPonentes.Rows.Add()].Cells[0].Value = txtNombrePonente.Text;
        }

        private void btnBuscarPonente_Click(object sender, EventArgs e)
        {
            frmMostrarPonentes mostrar = new frmMostrarPonentes();
            mostrar.ShowDialog();
            int tipo = mostrar.TipoUsuario;
            if (tipo == 0) invitado = mostrar.Invitado;
            else if (tipo == 1) profesor = mostrar.Profesor;
            else alumno = mostrar.Alumno;
        }
    }
}
