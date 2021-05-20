using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmVistadeEvento : Form
    {
        private int flag;
        frmPrincipalEventos principalEventos = null;
        frmListaDeEventos listaEventos = null;
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

        public frmVistadeEvento(frmListaDeEventos p)
        {
            listaEventos = p;
            InitializeComponent();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            new frmInscripcionEvento(this.flag).Show();
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
            new frmPrincipalEventos().Show();
            this.Close();
        }
    }
}
