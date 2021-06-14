﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{
    public partial class frmCargarAlumno : Form
    {
        private EspecialidadWS.EspecialidadWSClient daoEspecialidad;
        private AlumnoWS.AlumnoWSClient daoAlumno;
       private AlumnoWS.alumno alumno;
        private byte[] imagen_perfil;
        private Estado estado;

        public frmCargarAlumno()
        {
            InitializeComponent();
            estado = Estado.Inicial;
            clearall();
            cambiarEstado();
            daoEspecialidad = new EspecialidadWS.EspecialidadWSClient();
            daoAlumno = new AlumnoWS.AlumnoWSClient();
            cbEspecialidad.DataSource = new BindingList<EspecialidadWS.especialidad>
                (daoEspecialidad.listarEspecialidad().ToList());
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
            /*Alumno*/
            txtIdAlumno.Text = "";
            txtCodigo.Text = "";
            cbEspecialidad.SelectedIndex = -1;
            /*Imagen*/
            Image img = Properties.Resources.placeholder_profile;
            imagen_perfil = ImageToByte2(img);
            displayImage(imagen_perfil);
        }

        public static byte[] ImageToByte2(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
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
                    btnImagen1.Enabled = false;
                    btnImagen2.Enabled = false;
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
                    btnImagen1.Enabled = true;
                    btnImagen2.Enabled = true;
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
                    btnImagen1.Enabled = false;
                    btnImagen2.Enabled = false;
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
            pbPerfil1.Image = Image.FromStream(ms);
            pbPerfil2.Image = Image.FromStream(ms);
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
            //txtEdad.Text = alu.edad.ToString();
            txtDireccion.Text = alu.direccion;
            txtCorreo.Text = alu.correo;
            //Miembro PUCP
            txtUsuario.Text = alu.usuario;
            txtPassword.Text = alu.password;
            imagen_perfil = alu.imagenDePerfil;
            if(imagen_perfil != null)displayImage(imagen_perfil);
            //Alumno
            txtIdAlumno.Text = alu.id_alumno.ToString();
            txtCodigo.Text = alumno.codigo;
            EspecialidadWS.especialidad esp_selected = new EspecialidadWS.especialidad();
            esp_selected.id_especialidad = alu.especialidad.id_especialidad;
            esp_selected.nombre = alu.especialidad.nombre;
            cbEspecialidad.SelectedValue = esp_selected.id_especialidad;
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
            //Validación Alumno
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("No ha ingresado el código", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show("No ha seleccionado la especialidad", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Persona
            alumno.dni = txtDni.Text;
            alumno.nombre = txtNombre.Text;
            //alumno.edad = Int32.Parse(txtEdad.Text);
            alumno.direccion = txtDireccion.Text;
            alumno.correo = txtCorreo.Text;
            //Miembro PUCP
            alumno.usuario = txtUsuario.Text;
            alumno.password = txtPassword.Text;
            alumno.imagenDePerfil = imagen_perfil;
            alumno.fecha_inclusion = DateTime.Today.Date;
            alumno.fecha_inclusionSpecified = true;
            //Alumno
            alumno.codigo = txtCodigo.Text;
            EspecialidadWS.especialidad esp_selected = (EspecialidadWS.especialidad)cbEspecialidad.SelectedItem;
            alumno.especialidad = new AlumnoWS.especialidad();
            alumno.especialidad.id_especialidad = esp_selected.id_especialidad;
            alumno.craest = 0;
            alumno.creditos_aprobados = 0;

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
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar este empleado?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int resultado = daoAlumno.eliminarAlumno(alumno.id_alumno);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.estado = Estado.Inicial;
                    cambiarEstado();
                }
                else MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarAlumno frmBuscar = new frmBuscarAlumno();
            if (frmBuscar.ShowDialog() == DialogResult.OK)
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
                imagen_perfil = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
                displayImage(imagen_perfil);
            }

        }
    }
}
