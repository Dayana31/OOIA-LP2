using ProyectoOOIA.Componentes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmListaTutores : Form
    {
        public frmListaTutores()
        {
            InitializeComponent();
            tabTutor.AutoScroll = false;
            tabTutor.HorizontalScroll.Enabled = false;
            tabTutor.HorizontalScroll.Visible = false;
            tabTutor.HorizontalScroll.Maximum = 0;
            tabTutor.AutoScroll = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            TabPage tp = tabControl1.TabPages[e.Index];

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;

            // Este sera el rectangulo que se dibujara sobre el titutlo del tab 
            RectangleF headerRect = new RectangleF(e.Bounds.X, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height - 2);

            // Este sera el color por defecto del tab no seleccionado 
            SolidBrush sb = new SolidBrush(Color.AntiqueWhite);

            // color del tab que se selecciona
            if (tabControl1.SelectedIndex == e.Index)
                sb.Color = Color.Red;

            // aplica el color sobre el tabpage actual 
            g.FillRectangle(sb, e.Bounds);

            //escribe el texto que tenia el tab 
            g.DrawString(tp.Text, tabControl1.Font, new SolidBrush(Color.Black), headerRect, sf);
        }

        private void card2_Load(object sender, EventArgs e)
        {
            Card carta = (Card)sender;
            carta.insertarImagen(ProyectoOOIA.Properties.Resources.profesor);
            carta.insertarEtiquetas("Gonzales Prada", "Guillermo", "Ingeniero Informatico");
            carta.asignarClick(new frmOpiniones(), this);


        }

        private void card3_Load(object sender, EventArgs e)
        {
            Card carta = (Card)sender;
            carta.insertarImagen(ProyectoOOIA.Properties.Resources.profesor);
            carta.insertarEtiquetas("Gonzales Prada", "Guillermo", "Ingeniero Informatico");
            carta.asignarClick(new frmOpiniones(), this);
        }

        private void card4_Load(object sender, EventArgs e)
        {
            Card carta = (Card)sender;
            carta.insertarImagen(ProyectoOOIA.Properties.Resources.profesor);
            carta.insertarEtiquetas("Gonzales Prada", "Guillermo", "Ingeniero Informatico");
            carta.asignarClick(new frmOpiniones(), this);
        }

        private void card5_Load(object sender, EventArgs e)
        {
            Card carta = (Card)sender;
            carta.insertarImagen(ProyectoOOIA.Properties.Resources.profesor);
            carta.insertarEtiquetas("Gonzales Prada", "Guillermo", "Ingeniero Informatico");
            carta.asignarClick(new frmOpiniones(), this);
        }

        private void card6_Load(object sender, EventArgs e)
        {
            Card carta = (Card)sender;
            carta.insertarImagen(ProyectoOOIA.Properties.Resources.profesor);
            carta.insertarEtiquetas("Gonzales Prada", "Guillermo", "Ingeniero Informatico");
            carta.asignarClick(new frmOpiniones(), this);
        }
        private void card7_Load(object sender, EventArgs e)
        {
            Card carta = (Card)sender;
            carta.insertarImagen(ProyectoOOIA.Properties.Resources.profesor);
            carta.insertarEtiquetas("Gonzales Prada", "Guillermo", "Ingeniero Informatico");
            carta.asignarClick(new frmOpiniones(), this);
        }

        private void tabTutor_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void card1_Load(object sender, EventArgs e)
        {
            Card carta = (Card)sender;
            carta.insertarImagen(ProyectoOOIA.Properties.Resources.psicologo);
            carta.insertarEtiquetas("Perez Quispe", "Ana", "Ingeniera Electrica");
            carta.asignarClick(new frmOpiniones(), this);
        }

        private void card8_Load(object sender, EventArgs e)
        {
            Card carta = (Card)sender;
            carta.insertarImagen(ProyectoOOIA.Properties.Resources.psicologo);
            carta.insertarEtiquetas("Perez Quispe", "Ana", "Ingeniera Electrica");
            carta.asignarClick(new frmOpiniones(), this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmPrincipalAlumno().Show();
            this.Close();
        }

        private void card2_Click(object sender, EventArgs e)
        {
            //new frmHorarioCita().ShowDialog();
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //new frmCitaRegistro().Show();
            this.Close();
        }
    }
}
