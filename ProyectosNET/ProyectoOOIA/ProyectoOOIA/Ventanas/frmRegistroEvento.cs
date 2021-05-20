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
    public partial class frmRegistroEvento : Form
    {
        public frmRegistroEvento()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "") MessageBox.Show("Datos invalidos u horario \nocupado","Error message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else MessageBox.Show("El evento ha sido registrado\ncon exito");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmInformacionEvento().Show();
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            new frmPrincipalAlumno().Show();
            this.Close();
        }
    }
}
