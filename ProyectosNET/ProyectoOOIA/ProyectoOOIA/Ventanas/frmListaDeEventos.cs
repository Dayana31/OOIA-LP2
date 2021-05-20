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
    public partial class frmListaDeEventos : Form
    {
        public frmListaDeEventos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmVistadeEvento(2).Show();
            this.Close();
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            new CategoriasEventos().Show();
            this.Close();
        }
    }
}
