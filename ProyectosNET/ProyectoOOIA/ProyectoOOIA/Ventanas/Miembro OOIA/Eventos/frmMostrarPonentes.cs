using ProyectoOOIA.AlumnoWS;
using ProyectoOOIA.PonenteWS;
using ProyectoOOIA.ProfesorWS;
using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Eventos
{
    public partial class frmMostrarPonentes : Form
    {

        private int tipoUsuario = -1;
        private PonenteWS.ponente ponente=null;
        public frmMostrarPonentes()
        {
            InitializeComponent();
            dgvPonentes.AutoGenerateColumns = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tipoUsuario = cmbHorario.SelectedIndex;
            

            ponente = new PonenteWS.ponente();
            dgvPonentes.DataSource = new PonenteWS.PonenteWSClient().listarPonente();

        }

        public int TipoUsuario
        {
            get => tipoUsuario;
            set => tipoUsuario = value;
        }

       

        public ponente Ponente
        {
            get => ponente;
            set => ponente = value;
        }

        private void dgvPonentes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            ponente = dgvPonentes.Rows[e.RowIndex].DataBoundItem as PonenteWS.ponente;
            dgvPonentes.Rows[e.RowIndex].Cells[0].Value = ponente.nombre;
            dgvPonentes.Rows[e.RowIndex].Cells[1].Value = ponente.correo;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (ponente == null) return;
            ponente = dgvPonentes.CurrentRow.DataBoundItem as PonenteWS.ponente;


            this.Dispose();
        }
    }
}
