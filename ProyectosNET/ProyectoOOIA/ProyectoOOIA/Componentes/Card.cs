using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
