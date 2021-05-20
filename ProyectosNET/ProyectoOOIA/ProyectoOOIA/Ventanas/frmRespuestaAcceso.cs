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
    public partial class frmRespuestaAcceso : Form
    {
        private Boolean estado;
        public frmRespuestaAcceso()
        {
            InitializeComponent();
        }
        public frmRespuestaAcceso(Boolean estado)
        {
            InitializeComponent();
            this.estado=estado;
        }
    }
}
