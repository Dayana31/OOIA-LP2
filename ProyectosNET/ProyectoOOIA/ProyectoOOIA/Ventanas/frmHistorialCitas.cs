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
    public partial class frmHistorialCitas : Form
    {
       
        public frmHistorialCitas()
        {
            InitializeComponent();
            //esto hace que no se genere mas columnas de las que yo he 
            //definido en la interfaz grafica
            dgvHistorialCitas.AutoGenerateColumns = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new frmPrincipalAlumno().Show();
            this.Close();
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
