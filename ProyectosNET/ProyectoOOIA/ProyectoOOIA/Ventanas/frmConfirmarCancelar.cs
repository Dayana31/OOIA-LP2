using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmConfirmarCancelar : Form
    {
        public frmConfirmarCancelar()
        {
            InitializeComponent();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            frmHorarioCambiado horarioCambiado = new frmHorarioCambiado();
            horarioCambiado.ShowDialog();
            this.Close();
        }
    }
}
