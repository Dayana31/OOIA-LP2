﻿using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{

    public partial class frmInicioSesion : Form
    {

        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/");
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkContraseña_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmReestablecerContraseña().ShowDialog();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (txtContraseña.Text == "") lblIncorrecto.Visible = true;
            else
            {
                if (toggle1.Checked == false)
                    new frmPrincipalAlumno().Show();
                else
                    new frmPrincipalProfesor().Show();

                this.Close();

            }



        }

        private void frmInicioSesion_Load_1(object sender, EventArgs e)
        {

        }

        private void frmInicioSesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = '\n';
            if (e.KeyChar == c)
                btnIngresar_Click(null, null);
        }

        private void panel2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            char c = '\n';
            if (e.KeyCode == Keys.Enter)
                btnIngresar_Click(null, null);
        }
    }
}
