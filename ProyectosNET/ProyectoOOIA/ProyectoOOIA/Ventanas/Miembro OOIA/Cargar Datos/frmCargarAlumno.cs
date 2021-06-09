using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{
    public partial class frmCargarAlumno : Form
    {
        private EspecialidadWS.EspecialidadWSClient daoEspecialidad;
        private AlumnoWS.AlumnoWSClient daoAlumno;
        private AlumnoWS.alumno alumno;
        private Estado estado;

        public frmCargarAlumno()
        {
            InitializeComponent();
            estado = Estado.Inicial;
            cambiarEstado();
            daoEspecialidad = new EspecialidadWS.EspecialidadWSClient();
            daoAlumno = new AlumnoWS.AlumnoWSClient();
            cbEspecialidad.DataSource = new BindingList<EspecialidadWS.especialidad>
                (daoEspecialidad.listarEsppecialidad().ToList());
            cbEspecialidad.DisplayMember = "nombre_especialidad";
            cbEspecialidad.ValueMember = "id_especialidad";
        }

        public void clearall()
        {
            /*Persona*/
            txtIdPersona.Text = "";
            txtDni.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            /*Miembro PUCP*/
            txtIdMiembroPucp.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
            pbPerfil.Image = null;
            /*Alumno*/
            txtIdPersona.Text = "";
            txtCodigo.Text = "";
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
                    txtIdPersona.Enabled = false;
                    txtDni.Enabled = false;
                    txtNombre.Enabled = false;
                    txtEdad.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtCorreo.Enabled = false;
                    /*Miembro PUCP*/
                    txtIdMiembroPucp.Enabled = false;
                    txtUsuario.Enabled = false;
                    txtPassword.Enabled = false;
                    /*Alumno*/
                    txtIdAlumno.Enabled = false;
                    txtCodigo.Enabled = false;
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
                    txtIdPersona.Enabled = false;
                    txtDni.Enabled = true;
                    txtNombre.Enabled = true;
                    txtEdad.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtCorreo.Enabled = true;
                    /*Miembro PUCP*/
                    txtIdMiembroPucp.Enabled = false;
                    txtUsuario.Enabled = true;
                    txtPassword.Enabled = true;
                    /*Alumno*/
                    txtIdAlumno.Enabled = false;
                    txtCodigo.Enabled = true;
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
                    txtIdPersona.Enabled = false;
                    txtDni.Enabled = false;
                    txtNombre.Enabled = false;
                    txtEdad.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtCorreo.Enabled = false;
                    /*Miembro PUCP*/
                    txtIdMiembroPucp.Enabled = false;
                    txtUsuario.Enabled = false;
                    txtPassword.Enabled = false;
                    /*Alumno*/
                    txtIdAlumno.Enabled = false;
                    txtCodigo.Enabled = false;
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

        public void fillText(AlumnoWS.alumno alu)
        {
            //Persona
            txtDni.Text = alu.dni;
            txtNombre.Text = alu.nombre;
            txtEdad.Text = alu.edad.ToString();
            txtDireccion.Text = alu.direccion;
            txtCorreo.Text = alu.correo;
            //Miembro PUCP
            txtUsuario.Text = alu.usuario_pucp;
            txtPassword.Text = alu.contraseña;
            //Alumno
            txtCodigo.Text = alumno.codigo_pucp;
            cbEspecialidad.SelectedValue = alu.especialidad.id_especialidad;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            this.alumno = new AlumnoWS.alumno();
            estado = Estado.Nuevo;
            cambiarEstado();
            clearall();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            //Validación Persona
            if(txtDni.Text == "")
            {
                MessageBox.Show("No ha ingresado el DNI", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtNombre.Text == "")
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
            if(txtUsuario.Text == "")
            {
                MessageBox.Show("No ha ingresado el usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtPassword.Text == "")
            {
                MessageBox.Show("No ha ingresado la contraseña", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Validación Alumno
            if(txtCodigo.Text == "")
            {
                MessageBox.Show("No ha ingresado el código", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cbEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show("No ha seleccionado la especialidad", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Persona
            alumno.dni = txtDni.Text;
            alumno.nombre = txtNombre.Text;
            alumno.edad = Int32.Parse(txtEdad.Text);
            alumno.direccion = txtDireccion.Text;
            alumno.correo = txtCorreo.Text;
            //Miembro PUCP
            alumno.usuario_pucp = txtUsuario.Text;
            alumno.contraseña = txtPassword.Text;
            alumno.fecha_inclusion = DateTime.Today;
            //Alumno
            alumno.codigo_pucp = txtCodigo.Text;
            EspecialidadWS.especialidad esp_selected = (EspecialidadWS.especialidad)cbEspecialidad.SelectedItem;
            alumno.especialidad = new AlumnoWS.especialidad();
            alumno.especialidad.id_especialidad = esp_selected.id_especialidad;
            alumno.especialidad.nombre_especialidad = esp_selected.nombre_especialidad;

            if (estado.Equals(Estado.Nuevo))
            {
                int resultado = daoAlumno.insertarAlumno(alumno);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha registrado con exito", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdAlumno.Text = resultado.ToString();
                    this.estado = Estado.Inicial;
                    cambiarEstado();
                }
                else MessageBox.Show("Ha ocurrido un error en la inserción", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (estado == Estado.Modificar)
            {
                int resultado = daoAlumno.modificarAlumno(alumno);
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
            frmBuscarAlumno frmBuscar = new frmBuscarAlumno();
            if(frmBuscar.ShowDialog() == DialogResult.OK)
            {
                this.alumno = frmBuscar.Alumno;
                fillText(this.alumno);
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
                this.alumno.imagenDePerfil = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
                displayImage(this.alumno.imagenDePerfil);
            }

        }
    }
}
