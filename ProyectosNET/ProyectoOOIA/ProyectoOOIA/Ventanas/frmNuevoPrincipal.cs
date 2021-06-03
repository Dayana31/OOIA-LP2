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
    public partial class frmNuevoPrincipal : Form
    {
        private BindingList<Bitmap> listaImagenes=new BindingList<Bitmap>();
        private int indice = 0;
        public frmNuevoPrincipal()
        {
            InitializeComponent();
            
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.profesor);
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.EEGGCC);
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.Estudiante1);
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.pexels_pixabay_261621);
            imagenes.Image = listaImagenes[0];
            ToolTip ttEjemplo = new ToolTip();

            ttEjemplo.SetToolTip(botonCitas, "Programar citas");

        }

        private void cardEvento1_Load(object sender, EventArgs e)
        {
            tarjetaEvento.iniciarComponentes("El primer evento","Este evento es el primero de la OOIA",new DateTime(
                2021,7,15));
        }

        private void tarjetaEvento2_Load(object sender, EventArgs e)
        {
            tarjetaEvento2.iniciarComponentes("El segundo evento", "Este evento es el segundo de la OOIA", new DateTime(
                2021, 8, 30));
        }
        private void tarjetaEvento3_Load(object sender, EventArgs e)
        {
            tarjetaEvento3.iniciarComponentes("El Tercer evento", "Este evento es el Tercer de la OOIA", new DateTime(
                2021, 9, 5));
        }

        private void imagenes_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            indice++;
            if (indice >= listaImagenes.Count)
                indice = 0;
            imagenes.Image = listaImagenes[indice];
        }

        private void botonCitas_Click(object sender, EventArgs e)
        {
            new frmListaCitas().Show();
            this.Close();
        }

        private void botonEventos_Click(object sender, EventArgs e)
        {
            new frmRegistroEvento().Show();
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            new frmInicioSesion().Show();
            this.Close();
        }
    }
    }

