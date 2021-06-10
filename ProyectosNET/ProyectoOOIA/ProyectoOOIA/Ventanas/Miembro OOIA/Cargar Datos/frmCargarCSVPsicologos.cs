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
    public partial class frmCargarCSVPsicologos : Form
    {
        public frmCargarCSVPsicologos()
        {
            InitializeComponent();
        }

        private void btnSeleccionArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ruta = openFileDialog1.FileName;

                txtRutaArchivo.Text = ruta;
            }
        }

        private void btnCargaDatosCSVAlumnos_Click(object sender, EventArgs e)
        {

        }
    }
}
