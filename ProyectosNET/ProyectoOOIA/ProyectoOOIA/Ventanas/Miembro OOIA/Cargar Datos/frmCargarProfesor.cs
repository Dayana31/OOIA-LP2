using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{
    public partial class frmCargarProfesor: Form
    {
        private EspecialidadWS.EspecialidadWSClient daoEspecialidad;
        private ProfesorWS.ProfesorWSClient daoProfesor;
        private ProfesorWS.profesor profesor;
        private Estado estado;

        public frmCargarProfesor()
        {
            InitializeComponent();
            estado = Estado.Inicial;
            cambiarEstado();
            daoEspecialidad = new EspecialidadWS.EspecialidadWSClient();
            daoProfesor = new ProfesorWS.ProfesorWSClient();
            cbEspecialidad.DataSource = new BindingList<EspecialidadWS.especialidad>
                (daoEspecialidad.listarEsppecialidad().ToList());
            cbEspecialidad.DisplayMember = "nombre_especialidad";
            cbEspecialidad.ValueMember = "id_especialidad";
        }

        public void clearall()
        {
            /*Persona*/

            txtDni.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            /*Miembro PUCP*/

            txtUsuario.Text = "";
            txtPassword.Text = "";
            pbPerfil.Image = null;
            /*Profesor*/
            txtIdProfesor.Text = "";
            txtFacultad.Text = "";
            txtCategoria.Text = "";
            cbEspecialidad.SelectedIndex = -1;
        }

        public void cambiarEstado()
        {
            switch (estado)
            {
                case Estado.Inicial:
                    //Botones
                    tsbNuevo.Enabled = true;
                    tsbGuardar.Enabled = false;
                    tsbModificar.Enabled = false;
                    tsbBuscar.Enabled = true;
                    tsbEliminar.Enabled = false;
                    tsbCancelar.Enabled = true;
                    btnImagen.Enabled = false;
                    //Texto
                    /*Persona*/
                    txtDni.Enabled = false;
                    txtNombre.Enabled = false;
                    txtEdad.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtCorreo.Enabled = false;
                    /*Miembro PUCP*/
                    txtUsuario.Enabled = false;
                    txtPassword.Enabled = false;
                    /*Profesor*/
                    txtIdProfesor.Enabled = false;
                    txtFacultad.Enabled = false;
                    txtCategoria.Enabled = false;
                    cbEspecialidad.Enabled = false;
                    break;
                case Estado.Nuevo:
                case Estado.Modificar:
                    //Botones
                    tsbNuevo.Enabled = false;
                    tsbGuardar.Enabled = true;
                    tsbModificar.Enabled = false;
                    tsbBuscar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    tsbCancelar.Enabled = true;
                    btnImagen.Enabled = true;
                    //Texto
                    /*Persona*/
                    txtDni.Enabled = true;
                    txtNombre.Enabled = true;
                    txtEdad.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtCorreo.Enabled = true;
                    /*Miembro PUCP*/
                    txtUsuario.Enabled = true;
                    txtPassword.Enabled = true;
                    /*Profesor*/
                    txtIdProfesor.Enabled = false;
                    txtFacultad.Enabled = true;
                    txtCategoria.Enabled = true;
                    cbEspecialidad.Enabled = true;
                    break;
                case Estado.Busqueda:
                    //Botones
                    tsbNuevo.Enabled = false;
                    tsbGuardar.Enabled = false;
                    tsbModificar.Enabled = true;
                    tsbBuscar.Enabled = false;
                    tsbEliminar.Enabled = true;
                    tsbCancelar.Enabled = true;
                    btnImagen.Enabled = false;
                    //Texto
                    /*Persona*/
                    txtDni.Enabled = false;
                    txtNombre.Enabled = false;
                    txtEdad.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtCorreo.Enabled = false;
                    /*Miembro PUCP*/
                    txtUsuario.Enabled = false;
                    txtPassword.Enabled = false;
                    /*Profesor*/
                    txtIdProfesor.Enabled = false;
                    txtFacultad.Enabled = false;
                    txtCategoria.Enabled = false;
                    cbEspecialidad.Enabled = false;
                    break;
            }
        }

        public void displayImage(byte[] image)
        {
            MemoryStream ms = new MemoryStream(image);
            pbPerfil.Image = Image.FromStream(ms);
        }

        /*Botones de Header*/

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new frmInicioSesion().Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Botones de Toolstrip*/

        public void fillText(ProfesorWS.profesor profe)
        {
            //Persona
            txtDni.Text = profe.dni;
            txtNombre.Text = profe.nombre;
            txtEdad.Text = profe.edad.ToString();
            txtDireccion.Text = profe.direccion;
            txtCorreo.Text = profe.correo;
            //Miembro PUCP
            txtUsuario.Text = profe.usuario_pucp;
            txtPassword.Text = profe.contraseña;
            //Alumno
            txtIdProfesor.Text = profe.id_profesor.ToString();
            txtFacultad.Text = profe.facultad;
            txtCategoria.Text = profe.categoria;
            cbEspecialidad.SelectedValue = profe.especialidad.id_especialidad;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            this.profesor = new ProfesorWS.profesor();
            estado = Estado.Nuevo;
            cambiarEstado();
            clearall();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            //Validación Persona
            if (txtDni.Text == "")
            {
                MessageBox.Show("No ha ingresado el DNI", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("No ha ingresado el nombre", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Int32.Parse(txtEdad.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No ha ingresado correctamente la edad", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show("No ha ingresado la dirección", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCorreo.Text == "")
            {
                MessageBox.Show("No ha ingresado el correo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Validación Miembro PUCP
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("No ha ingresado el usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("No ha ingresado la contraseña", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Validación Profesor
            if (txtFacultad.Text == "")
            {
                MessageBox.Show("No ha ingresado la facultad", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCategoria.Text == "")
            {
                MessageBox.Show("No ha ingresado la categoría", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show("No ha seleccionado la especialidad", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Persona
            profesor.dni = txtDni.Text;
            profesor.nombre = txtNombre.Text;
            profesor.edad = Int32.Parse(txtEdad.Text);
            profesor.direccion = txtDireccion.Text;
            profesor.correo = txtCorreo.Text;
            //Miembro PUCP
            profesor.usuario_pucp = txtUsuario.Text;
            profesor.contraseña = txtPassword.Text;
            profesor.fecha_inclusion = DateTime.Today;
            //Alumno
            profesor.facultad = txtFacultad.Text;
            profesor.categoria = txtCategoria.Text;
            EspecialidadWS.especialidad esp_selected = (EspecialidadWS.especialidad)cbEspecialidad.SelectedItem;
            profesor.especialidad = new ProfesorWS.especialidad();
            profesor.especialidad.id_especialidad = esp_selected.id_especialidad;
            profesor.especialidad.nombre_especialidad = esp_selected.nombre_especialidad;
            if (estado.Equals(Estado.Nuevo))
            {
                int resultado = daoProfesor.insertarProfesores(profesor);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha registrado con exito", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdProfesor.Text = resultado.ToString();
                    this.estado = Estado.Inicial;
                    cambiarEstado();
                }
                else MessageBox.Show("Ha ocurrido un error en la inserción", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (estado == Estado.Modificar)
            {
                int resultado = daoProfesor.modificarProfesores(profesor);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha actualizado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.estado = Estado.Inicial;
                    cambiarEstado();
                }
                else
                    MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            this.estado = Estado.Modificar;
            cambiarEstado();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {

        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarProfesor frmBuscar = new frmBuscarProfesor();
            if (frmBuscar.ShowDialog() == DialogResult.OK)
            {
                this.profesor = frmBuscar.Profesor;
                fillText(this.profesor);
                estado = Estado.Busqueda;
                cambiarEstado();
            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            this.estado = Estado.Inicial;
            clearall();
            cambiarEstado();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            if (ofd_Imagen.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd_Imagen.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                //Asignamos el archivo al objeto
                this.profesor.imagenDePerfil = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
                displayImage(this.profesor.imagenDePerfil);
            }

        }
    }
}
