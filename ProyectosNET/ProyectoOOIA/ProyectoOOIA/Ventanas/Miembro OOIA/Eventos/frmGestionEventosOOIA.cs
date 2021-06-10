﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoOOIA.GestionEventoWS;
using ProyectoOOIA.Ventanas.Miembro_OOIA.Eventos;


namespace ProyectoOOIA.Ventanas
{
    public partial class frmGestionEventosOOIA : Form
    {
        
        ErrorProvider error = new ErrorProvider();
        private GestionEventoWS.GesionEventoWSClient eventoDao;
        private GestionEventoWS.evento evento;
        private BindingList<GestionEventoWS.persona> lista = new BindingList<GestionEventoWS.persona>();
        private GestionEventoWS.persona persona = null;
        private int numeroElementos = 0;
        

        public frmGestionEventosOOIA(Estado estado)
        {
            InitializeComponent();
            componentes(estado);
            
            error.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            dgvPonentes.AutoGenerateColumns = false;
            dgvPonentes.RowCount = 0;
            
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
                    dtpFin.Enabled = true;
                    dtpInicio.Enabled = true;
                    txtNombre.Enabled = false;
                    txtNombrePonente.Enabled = false;
                    txtDescripcion.Enabled = false;
                    cboCategoria.Enabled = false;
                    dgvPonentes.Enabled = false;
                    npdCapacidad.Enabled = false;
                    txtLugar.Enabled = false;
                    dgvPonentes.RowCount = 1;
                    btnBuscarPonente.Enabled = false;
                    txtIdEvento.Enabled = false;
                    dtpFin.Enabled = false;
                    dtpInicio.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = true;
                    btnAgregarImagen.Enabled = true;
                    btnAgregarPonente.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnEliminarPonente.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    dtpFechaEvento.Enabled = true;
                    dtpFin.Enabled = true;
                    dtpInicio.Enabled = true;
                    txtNombre.Enabled = true;
                    txtNombrePonente.Enabled = false;
                    txtDescripcion.Enabled = true;
                    cboCategoria.Enabled = true;
                    dgvPonentes.Enabled = true;
                    npdCapacidad.Enabled = true;
                    txtLugar.Enabled = true;
                    btnBuscarPonente.Enabled = true;
                    txtIdEvento.Enabled = false;
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
                    dtpFin.Enabled = true;
                    dtpInicio.Enabled = true;
                    txtNombre.Enabled = false;
                    txtNombrePonente.Enabled = false;
                    txtDescripcion.Enabled = false;
                    cboCategoria.Enabled = false;
                    dgvPonentes.Enabled = false;
                    npdCapacidad.Enabled = false;
                    txtLugar.Enabled = false;
                    txtIdEvento.Enabled = false;
                    dtpFin.Enabled = false;
                    dtpInicio.Enabled = false;
                    break;
                
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarEventoAlumno aux=new frmBuscarEventoAlumno();
            aux.ShowDialog();
            componentes(Estado.Busqueda);
            evento = aux.Evento;
            txtNombre.Text = evento.nombre;
            txtDescripcion.Text = "Descripcion";
            txtLugar.Text = evento.lugar;
            txtIdEvento.Text = evento.id_evento.ToString();
            dtpFechaEvento.Value = evento.fecha;
            dtpInicio.Value = evento.horaInicio;
            dtpFin.Value = evento.horaFina;
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new frmPrincipal(TipoUsuario.OOIA).Show();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validacionDatos()==1)
            {
                evento = new GestionEventoWS.evento();
                eventoDao = new GestionEventoWS.GesionEventoWSClient();
                evento.nombre = txtNombre.Text;
                evento.fecha = dtpFechaEvento.Value;
                evento.fechaSpecified = true;
                evento.estado = true;
                evento.capacidad = Decimal.ToInt32(npdCapacidad.Value);
                evento.horaInicio = dtpInicio.Value;
                evento.horaInicioSpecified = true;
                evento.horaFina = dtpFin.Value;
                evento.horaFinaSpecified = true;
                evento.id_coordinador = 11;
                evento.lugar = txtLugar.Text;

                evento.ponentes = lista.ToArray();
                DialogResult dr =
                    MessageBox.Show("¿Desea registrar este evento?", "Guardar Evento",MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    if (eventoDao.insertarEvento(evento) == 1)
                    {
                        MessageBox.Show("Exito");
                    }
                    else MessageBox.Show("Fallo");
                }
            }





        }

        private int validacionDatos()
        {
            if (lista.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un ponente", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return 0;
            }

            return 1;
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
            componentes(Estado.Nuevo);
            
        }

        private void btnAgregarPonente_Click(object sender, EventArgs e)
        {
            if (persona != null)
            {
                dgvPonentes.Rows.Add();
                dgvPonentes.Rows[dgvPonentes.RowCount - 1].Cells[0].Value = persona.nombre;
                lista.Add(persona);
                persona = null;
            }
            else
                MessageBox.Show("no puede agregar a un ponente dos veces", "error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

        }

        private void btnBuscarPonente_Click(object sender, EventArgs e)
        {
            frmMostrarPonentes mostrar = new frmMostrarPonentes();
            mostrar.ShowDialog();
            int tipo = mostrar.TipoUsuario;
            persona = asignarPersona(mostrar.Persona, mostrar.TipoUsuario);
            txtNombrePonente.Text = persona.nombre;

        }

        private persona asignarPersona(GestionHumanaWS.persona mostrarPersona, int TipoUsuario)
        {
            GestionEventoWS.persona aux= new GestionEventoWS.miembroOOIA();
            aux.nombre = mostrarPersona.nombre;
            aux.correo = mostrarPersona.correo;
            aux.id_persona = mostrarPersona.id_persona;
            aux.direccion = mostrarPersona.direccion;
            aux.edad = mostrarPersona.edad;
            aux.dni = mostrarPersona.dni;
            return aux;

        }

        private void btnEliminarPonente_Click(object sender, EventArgs e)
        {
            if (dgvPonentes.CurrentRow.Index >= 0)
            {
                lista.RemoveAt(dgvPonentes.CurrentRow.Index);
                dgvPonentes.Rows.RemoveAt(dgvPonentes.CurrentRow.Index);
            }
        }
        
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            
            if (txtNombre.Text == "")
                error.SetError(txtNombre,"El campo es obligatorio");


        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            error.Clear();
        }

        private void txtHoraInicio_Enter(object sender, EventArgs e)
        {
           
            error.Clear();
        }

        private void txtHoraInicio_Leave(object sender, EventArgs e)
        {

            
           
        }
        private void txtHoraFin_Enter(object sender, EventArgs e)
        {
           
            error.Clear();
        }

        private void txtHoraFin_Leave(object sender, EventArgs e)
        {
            
            string patron = @"\s?\d?\d:\d\d";
            Regex regex = new Regex(patron);


        }

        private void txtLugar_Enter(object sender, EventArgs e)
        {
            error.Clear();
        }

        private void txtLugar_Leave(object sender, EventArgs e)
        {
            if(txtLugar.Text=="")
                error.SetError(txtLugar,"El campo es obligatorio");
        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
                error.SetError(txtDescripcion, "El campo es obligatorio");
        }

        private void txtHoraInicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarPonente_Click_1(object sender, EventArgs e)
        {

        }
    }
}
