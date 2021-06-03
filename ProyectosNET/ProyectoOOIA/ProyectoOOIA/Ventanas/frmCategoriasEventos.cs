using System;
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

        private void button6_Click(object sender, EventArgs e)
        {
            new frmPrincipalEventos().Show();
            this.Close();
        }
    }
}
