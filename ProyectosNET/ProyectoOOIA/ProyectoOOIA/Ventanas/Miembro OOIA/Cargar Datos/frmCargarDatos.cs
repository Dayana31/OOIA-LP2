﻿using ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos;
using System;
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
            /*if (archivos.ShowDialog() == DialogResult.OK)
            {
                cmbPsicologo.Text = archivos.FileName;
            }*/
            new frmCargarPsicologo().ShowDialog();

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
            txtHeader.Text = "Cargar datos de Gestion Humana";
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            new frmCargarAlumno().ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new frmCodigosAtencion().ShowDialog();
        }

        private void btnCargaCSVAlumnos_Click(object sender, EventArgs e)
        {
            new frmCargarCSVAlumnos().ShowDialog();
        }

        private void btnCargaCSVProfesores_Click(object sender, EventArgs e)
        {
            new frmCargarCSVProfesores().ShowDialog();
        }

        private void btnCargaCSVPsicologos_Click(object sender, EventArgs e)
        {
            new frmCargarCSVPsicologos().ShowDialog();
        }

        private void btnProfesores_Click_1(object sender, EventArgs e)
        {
            new frmCargarProfesor().ShowDialog();
        }
    }
}
