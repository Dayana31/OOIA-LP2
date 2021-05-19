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
    public partial class frmListaCitas : Form
    {
        public frmListaCitas()
        {
            InitializeComponent();
            //esto hace que no se genere mas columnas de las que yo he 
            //definido en la interfaz grafica
            dgvCitasProgramadas.AutoGenerateColumns = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new frmPrincipalAlumno().Show();
            this.Close();
        }

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su cita ha sido cancelada con exito", "Mensaje de confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
