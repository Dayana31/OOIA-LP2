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
    public partial class frmAgregarOpinion : Form
    {
        public frmAgregarOpinion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //new frmConfirmarOpinion().ShowDialog();
            DialogResult dr =
               MessageBox.Show("¿Esta seguro que desea agregar su opinión?", "Agregar opinión de Asesor",
               MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if(dr == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
