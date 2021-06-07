using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA
{
    public partial class frmCargarDatos : Form
    {
        public frmCargarDatos()
        {
            InitializeComponent();
            data.AutoGenerateColumns = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (archivos.ShowDialog() == DialogResult.OK)
            {
                cmbAlumno.Text = archivos.FileName;
            }
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            if (archivos.ShowDialog() == DialogResult.OK)
            {
                cmbProfesor.Text = archivos.FileName;
            }
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            if (archivos.ShowDialog() == DialogResult.OK)
            {
                cmbCurso.Text = archivos.FileName;
            }
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            if (archivos.ShowDialog() == DialogResult.OK)
            {
                cmbNotas.Text = archivos.FileName;
            }
        }

        private void btnPsicologo_Click(object sender, EventArgs e)
        {
            if (archivos.ShowDialog() == DialogResult.OK)
            {
                cmbPsicologo.Text = archivos.FileName;
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            txtHeader.Text = "Cargar datos de Gestion Humana";
        }

        private void panelGestionHumana_Enter(object sender, EventArgs e)
        {
            txtHeader.Text = "Cargar datos de Gestion Humana"
        }
    }
}
