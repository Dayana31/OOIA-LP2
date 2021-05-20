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
    public partial class frmAccesoEvento : Form
    {
        public frmAccesoEvento()
        {
            InitializeComponent();
        }

        private void btnUnirse_Click(object sender, EventArgs e)
        {
            //hora inicio > hora actual
            if (txtDuracion.Text == "" && txtHoraIni.Text == "" && txtInscritos.Text == "" && txtFecha.Text == "")
                btnUnirse.Text = "No puedes unirte en este momento";
        }
    }
}
