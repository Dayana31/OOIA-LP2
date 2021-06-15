using ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos;
using System;
using System.IO;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA
{
    public partial class frmCargarDatos : Form
    {
        public frmCargarDatos()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*TAB Gestion Humana*/
        //Alumno
        private void btnAlumno_Click(object sender, EventArgs e)
        {
            new frmCargarAlumno().ShowDialog();
        }

        private void btnAlumnoFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ruta = openFileDialog.FileName;
                txtAlumno.Text = ruta;
            }
        }

        private void btnAlumnoCSV_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(txtAlumno.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            /*CargarCSValumnos.AlumnosCSVcargaWSClient cargaCSVAlumnos =
                new CargarCSValumnos.AlumnosCSVcargaWS1Client();*/
            int resultado = 1;
            //resultado = cargaCSVAlumnos.CargarCSValumnos(br.ReadBytes((int)fs.Length));
            br.Close();
            fs.Close();
            if(resultado == 0)
                MessageBox.Show("Se han cargado los datos correctamente", "Confirmacion",
                    MessageBoxButtons.OK);
            else
                MessageBox.Show("Ha ocurrido un error en la carga de los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Asesor
        private void btnAsesor_Click(object sender, EventArgs e)
        {
            if (rbProfesor.Checked) new frmCargarProfesor().ShowDialog();
            if (rbPsicologo.Checked) new frmCargarPsicologo().ShowDialog();
        }

        private void btnAsesorFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ruta = openFileDialog.FileName;

                txtAsesor.Text = ruta;
            }
        }

        private void btnAsesorCSV_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(txtAsesor.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            
            int resultado = 1;
            if (rbProfesor.Checked)
            {
                /*CargarCSVprofesores.ProfesoresCSVcargaWSClient cargaCSVprofesores =
                    new CargarCSVprofesores.ProfesoresCSVcargaWSClient();*/
                //resultado = cargaCSVprofesores.CargarCSVprofesores(br.ReadBytes((int)fs.Length));
            }
            if (rbPsicologo.Checked)
            {
                /*CargarCSVpsicologos.PsicologosCSVcargaWSClient cargaCSVpsicologos =
                new CargarCSVpsicologos.PsicologosCSVcargaWSClient();*/
                //int resultado = cargaCSVpsicologos.CargarCSVpsicologos(txtRutaArchivo.Text);
            }
            br.Close();
            fs.Close();
            if (resultado == 0)
                MessageBox.Show("Se han cargado los datos correctamente", "Confirmacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else 
                MessageBox.Show("Ha ocurrido un error en la carga de los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /*TAB Gestion Atencion*/
                private void btnCodigoAtencion_Click(object sender, EventArgs e)
        {
            new frmCodigosAtencion().ShowDialog();
        }

        
    }
}
