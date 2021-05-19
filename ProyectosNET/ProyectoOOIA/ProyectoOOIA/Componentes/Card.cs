using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoOOIA.Ventanas;

namespace ProyectoOOIA.Componentes
{
    public partial class Card : UserControl
    {
        
        public Card()
        {
            InitializeComponent();
        }
        public void insertarImagen(Bitmap archivo)
        {
            try {
                this.pictureBox1.Image = archivo;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }

        public void insertarEtiquetas(String apellido,String nombre,String especialidad)
        {
            this.label1.Text = apellido+",";
            this.label2.Text = nombre;
            this.label3.Text = especialidad;
        }

        private void Card_Load(object sender, EventArgs e)
        {

        }

        public void asignarClick(frmOpiniones op,frmListaTutores lt)
        {
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler((sender, args) =>
            {
                op.Show();
                lt.Close();
            });
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
