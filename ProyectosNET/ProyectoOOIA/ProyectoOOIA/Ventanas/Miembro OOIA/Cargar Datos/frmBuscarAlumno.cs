using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{

    public partial class frmBuscarAlumno : Form
    {
        private AlumnoWS.AlumnoWSClient daoAlumno;
        private AlumnoWS.alumno _alumno;

        public AlumnoWS.alumno Alumno { get => _alumno; set => _alumno = value; }

        public frmBuscarAlumno()
        {
            InitializeComponent();
            dgvAlumnos.AutoGenerateColumns = false;
            daoAlumno = new AlumnoWS.AlumnoWSClient();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BindingList<AlumnoWS.alumno>
                alumnos = new BindingList<AlumnoWS.alumno>
                (daoAlumno.listarAlumno().ToList());
            dgvAlumnos.DataSource = alumnos;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow != null)
            {
                _alumno =
              (AlumnoWS.alumno)dgvAlumnos.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
