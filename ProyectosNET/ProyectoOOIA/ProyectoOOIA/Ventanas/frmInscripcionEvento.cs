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
    public partial class frmInscripcionEvento : Form
    {
        private int flag;
        frmPrincipalEventos principalEventos = null;
        frmListaDeEventos listaEventos = null;
        public frmInscripcionEvento()
        {
            InitializeComponent();
        }

        public frmInscripcionEvento(frmPrincipalEventos p)
        {
            principalEventos = p;
            InitializeComponent();
        }

        public frmInscripcionEvento(frmListaDeEventos p)
        {
            listaEventos = p;
            InitializeComponent();
        }

        public frmInscripcionEvento(int flag)
        {
            this.flag = flag;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmInscripcionEvento_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su registro ha sido exitoso", "Cerrar");

        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Su registro ha sido exitoso", "Cerrar");
            if (flag == 2)
            {
                new frmPrincipalEventos().Show();

            }
         

            this.Close();

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cancelo la inscripcion", "Cerrar");
            if (flag == 2)
            {
                new frmPrincipalEventos().Show();

            }

            this.Close();
        }
    }
}
