using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmPrincipalEventos : Form
    {

        public frmPrincipalEventos()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipalEventos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // new CategoriasEventos().Show();
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prueba", "cerrar");

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            new frmVistadeEvento(1).Show();
            //this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            new frmPrincipalAlumno().Show();
            this.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            new frmPrincipalAlumno().Show();
            this.Close();
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // frmPrincipalEventos
        //    // 
        //    this.ClientSize = new System.Drawing.Size(446, 404);
        //    this.Name = "frmPrincipalEventos";
        //    this.ResumeLayout(false);

        //}
    }
}
