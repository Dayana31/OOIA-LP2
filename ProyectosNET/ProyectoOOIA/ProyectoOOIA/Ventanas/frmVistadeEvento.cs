using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmVistadeEvento : Form
    {
        private int flag;
        frmPrincipalEventos principalEventos = null;

        public frmVistadeEvento()
        {
            InitializeComponent();
        }

        public frmVistadeEvento(frmPrincipalEventos p)
        {
            principalEventos = p;
            InitializeComponent();
        }

        public frmVistadeEvento(int flag)
        {
            this.flag = flag;
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
            //if (principalEventos != null)
            //{
            //    new frmInscripcionEvento(principalEventos).Show();
            //}
            // else
            // {
            //    new frmInscripcionEvento(listaEventos).Show();
            //}
            this.Close();
        }

        private void atras_Click(object sender, EventArgs e)
        {
            if (flag != 1)
                new frmPrincipalEventos().Show();
            this.Close();
        }
    }
}
