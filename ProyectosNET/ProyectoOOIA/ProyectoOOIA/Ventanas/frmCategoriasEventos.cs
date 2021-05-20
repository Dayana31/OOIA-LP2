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
    public partial class CategoriasEventos : Form
    {
        public CategoriasEventos()
        {
            InitializeComponent();
        }

        private void CategoriasEventos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmListaDeEventos().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmListaDeEventos().Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmListaDeEventos().Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmListaDeEventos().Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new frmListaDeEventos().Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new frmPrincipalEventos().Show();
            this.Close();
        }
    }
}
