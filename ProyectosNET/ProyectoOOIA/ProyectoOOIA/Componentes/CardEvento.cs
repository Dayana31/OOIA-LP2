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
    public partial class CardEvento : UserControl
    {
        public CardEvento()
        {
            InitializeComponent();
        }

        public void iniciarComponentes(String nombre,String descripcion,DateTime fecha)
        {
            lblDescripcion.Text = descripcion;
            lblNombreEvento.Text = nombre;
            lblFecha.Text = fecha.ToString("D");
            lblDia.Text = fecha.Day.ToString();
        }
    }
}
