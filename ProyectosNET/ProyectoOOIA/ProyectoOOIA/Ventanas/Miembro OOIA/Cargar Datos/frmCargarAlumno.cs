using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{
    public partial class frmCargarAlumno : Form
    {

        private Estado estado;

        public frmCargarAlumno()
        {
            InitializeComponent();
            estado = Estado.Nuevo;
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
                    txtIdPersona.Enabled = false;
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
                    //Texto
                    /*Persona*/
                    txtIdPersona.Enabled = false;
                    txtDni.Enabled = true;
                    txtNombre.Enabled = true;
                    txtEdad.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtCorreo.Enabled = true;
                    /*Miembro PUCP*/
                    txtIdMiembroPucp.Enabled = true;
                    txtUsuario.Enabled = true;
                    txtPassword.Enabled = true;
                    /*Alumno*/
                    txtIdPersona.Enabled = true;
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
                    txtIdPersona.Enabled = false;
                    txtCodigo.Enabled = false;
                    cbEspecialidad.Enabled = false;
                    break;
            }
        }

        /*Botones de Header*/

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new frmInicioSesion().Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Botones de Toolstrip*/
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            //this.alumno = new Alumno();
            estado = Estado.Nuevo;
            cambiarEstado();
            clearall();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {

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

        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            this.estado = Estado.Inicial;
            clearall();
            cambiarEstado();
        }
    }
}
