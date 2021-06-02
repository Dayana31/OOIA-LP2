﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmHorarioCita : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,
            int wMsg, int wParam, int lParam);
        public frmHorarioCita()
        {
            InitializeComponent();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }


        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
