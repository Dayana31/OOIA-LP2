using System;
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
        
        ErrorProvider errorNombre = new ErrorProvider();
        ErrorProvider errorFecha = new ErrorProvider();
        ErrorProvider errorFin = new ErrorProvider();
        ErrorProvider errorInicio = new ErrorProvider();
        ErrorProvider errorDescripcion = new ErrorProvider();
        ErrorProvider errorLugar = new ErrorProvider();
        private GestionEventoWS.GesionEventoWSClient eventoDao;
        private GestionEventoWS.evento evento;
        private BindingList<GestionEventoWS.persona> lista = new BindingList<GestionEventoWS.persona>();
        private GestionEventoWS.persona persona = null;
        private int numeroElementos = 0;
        

        public frmGestionEventosOOIA(Estado estado)
        {
            InitializeComponent();
            componentes(estado);

            errorNombre.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            dgvPonentes.AutoGenerateColumns = false;
            dgvPonentes.RowCount = 0;
            errorFin.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorInicio.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorFecha.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorNombre.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorLugar.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorDescripcion.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            evento = new GestionEventoWS.evento();
            eventoDao = new GestionEventoWS.GesionEventoWSClient();
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
                    
                    dtpFin.Enabled = false;
                    dtpInicio.Enabled = false;
                    btnEliminar.Enabled = false;
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
                    
                    btnEliminar.Enabled = false;

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
                    
                    dtpFin.Enabled = false;
                    dtpInicio.Enabled = false;
                    btnEliminar.Enabled = true;
                    break;
                case Estado.Modificar:
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
                    
                    btnEliminar.Enabled = true;
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
            if (validacionDatos() == 1)
            {
                evento.nombre = txtNombre.Text;
                evento.fecha = dtpFechaEvento.Value;
                evento.fechaSpecified = true;
                evento.estado = true;
                evento.capacidad = Decimal.ToInt32(npdCapacidad.Value);
                evento.horaInicio = dtpInicio.Value;
                evento.horaInicioSpecified = true;
                evento.horaFina = dtpFin.Value;
                evento.horaFinaSpecified = true;
                evento.lugar = txtLugar.Text;

                evento.ponentes = lista.ToArray();
                DialogResult dr =
                    MessageBox.Show("¿Desea modificar este evento?", "Modificar Evento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    if (eventoDao.modificarEvento(evento) == 1)
                    {
                        MessageBox.Show("Se ha registrado el evento","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Ha fallado el registro del evento","Fallo",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                }
            } 
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
                errorNombre.SetError(txtNombre,"El campo es obligatorio");


        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            errorNombre.Clear();
        }

        private void txtHoraInicio_Enter(object sender, EventArgs e)
        {
           
            errorInicio.Clear();
        }

        private void txtHora_Leave(object sender, EventArgs e)
        {
            if(dtpFin.Value<dtpInicio.Value)
                errorFin.SetError(dtpFin,"La hora final debe ser mayor que la inicial");
            
           
        }
        private void txtHoraFin_Enter(object sender, EventArgs e)
        {
           
            errorFin.Clear();
            
        }

        private void txtHoraFin_Leave(object sender, EventArgs e)
        {
            
           if(dtpFin.Value<dtpInicio.Value)
               errorFin.SetError(dtpFin,"La hora final debe ser mayor que la inicial");
           else errorInicio.Clear();


        }

        private void txtLugar_Enter(object sender, EventArgs e)
        {
            errorLugar.Clear();
        }

        private void txtLugar_Leave(object sender, EventArgs e)
        {
            if(txtLugar.Text=="")
                errorLugar.SetError(txtLugar,"El campo es obligatorio");
        }

     

      
        

      

        private void dtpInicio_Enter(object sender, EventArgs e)
        {
            errorInicio.Clear();
            
        }

        private void dtpInicio_Leave(object sender, EventArgs e)
        {
            if(dtpInicio.Value>dtpFin.Value)
                errorInicio.SetError(dtpInicio,"La hora inicial debe ser menor que la inicial");
           else errorFin.Clear();

        }

        private void dtpFecha_Enter(object sender, EventArgs e)
        {
            errorFecha.Clear();
        }

        private void dtpFecha_Leave(object sender, EventArgs e)
        {
            if(dtpFechaEvento.Value< DateTime.Today)
                errorFecha.SetError(dtpFechaEvento,"No puede seleccionr un dia pasado");
        }

        private void txtDescripcion_Enter_1(object sender, EventArgs e)
        {
            errorDescripcion.Clear();
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if(txtDescripcion.Text=="")
                errorDescripcion.SetError(txtDescripcion,"Debe llenar este campo");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            eventoDao.eliminarEvento(evento);
        }
    }
    
}
