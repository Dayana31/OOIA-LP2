using ProyectoOOIA.Componentes;
using ProyectoOOIA.Ventanas.Alumno.Citas;
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
         
            tabTutor.HorizontalScroll.Enabled = false;
            tabTutor.HorizontalScroll.Visible = false;
            tabTutor.HorizontalScroll.Maximum = 0;
            tabTutor.AutoScroll = true;

            

            for (int i = 0; i < 3; i++)
            {
                UserControl uc = new ucAsesor();
                pnlTutorLeft.Controls.Add(uc);
                uc.Dock = DockStyle.Top;
                Panel pnl = new Panel();
                pnlTutorLeft.Controls.Add(pnl);
                pnl.Dock = DockStyle.Top;
                pnl.Height = 30;
            }
            for (int i = 0; i < 3; i++)
            {
                UserControl uc = new ucAsesor();
                pnlTutorRight.Controls.Add(uc);
                uc.Dock = DockStyle.Top;
                Panel pnl = new Panel();
                pnlTutorRight.Controls.Add(pnl);
                pnl.Dock = DockStyle.Top;
                pnl.Height = 30;
            }
            for (int i = 0; i < 3; i++)
            {
                UserControl uc = new ucAsesor();
                pnlPsicLeft.Controls.Add(uc);
                uc.Dock = DockStyle.Top;
                Panel pnl = new Panel();
                pnlPsicLeft.Controls.Add(pnl);
                pnl.Dock = DockStyle.Top;
                pnl.Height = 30;
            }
            for (int i = 0; i < 3; i++)
            {
                UserControl uc = new ucAsesor();
                pnlPsicRight.Controls.Add(uc);
                uc.Dock = DockStyle.Top;
                Panel pnl = new Panel();
                pnlPsicRight.Controls.Add(pnl);
                pnl.Dock = DockStyle.Top;
                pnl.Height = 30;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
