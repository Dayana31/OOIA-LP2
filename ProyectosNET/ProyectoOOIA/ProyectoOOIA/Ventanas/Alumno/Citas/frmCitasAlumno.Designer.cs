
namespace ProyectoOOIA.Ventanas
{
    partial class frmListaCitasAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaCitasAlumno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.lblCitasHeader = new System.Windows.Forms.Label();
            this.dgvCitasProgramadas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orientador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarCita = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabHistorial = new System.Windows.Forms.TabControl();
            this.tabCitasProgramadas = new System.Windows.Forms.TabPage();
            this.pnlRegistrarCita = new System.Windows.Forms.Panel();
            this.lblRegistrar = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblAsesor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtAsesor = new System.Windows.Forms.TextBox();
            this.btnBuscarAsesor = new System.Windows.Forms.Button();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.btnBuscarHorario = new System.Windows.Forms.Button();
            this.txtHoraFin = new System.Windows.Forms.TextBox();
            this.lblListaCitasInscritas = new System.Windows.Forms.Label();
            this.btnDetInscritas = new System.Windows.Forms.Button();
            this.btnRegistrarCita = new System.Windows.Forms.Button();
            this.tabHistorialCitas = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaHistorial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMotivoHistorial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAsesorHistorial = new System.Windows.Forms.TextBox();
            this.txtHoraInicioHistorial = new System.Windows.Forms.TextBox();
            this.txtHoraFinHistorial = new System.Windows.Forms.TextBox();
            this.lblListaCitasPasadas = new System.Windows.Forms.Label();
            this.btnAgregarOpinion = new System.Windows.Forms.Button();
            this.btnDetHistorial = new System.Windows.Forms.Button();
            this.dgvHistorialCitas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasProgramadas)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabHistorial.SuspendLayout();
            this.tabCitasProgramadas.SuspendLayout();
            this.pnlRegistrarCita.SuspendLayout();
            this.tabHistorialCitas.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCitas)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.lblCitasHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 71);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImage = global::ProyectoOOIA.Properties.Resources.log_out__1_;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(967, 28);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(35, 34);
            this.btnAtras.TabIndex = 13;
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(11, 32);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(25, 25);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 1;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblCitasHeader
            // 
            this.lblCitasHeader.AutoSize = true;
            this.lblCitasHeader.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitasHeader.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCitasHeader.Location = new System.Drawing.Point(49, 32);
            this.lblCitasHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCitasHeader.Name = "lblCitasHeader";
            this.lblCitasHeader.Size = new System.Drawing.Size(160, 30);
            this.lblCitasHeader.TabIndex = 0;
            this.lblCitasHeader.Text = "Citas y Asesorías";
            // 
            // dgvCitasProgramadas
            // 
            this.dgvCitasProgramadas.AllowUserToDeleteRows = false;
            this.dgvCitasProgramadas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCitasProgramadas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitasProgramadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCitasProgramadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitasProgramadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Orientador,
            this.Fecha,
            this.HoraInicio,
            this.HoraFin,
            this.Asistencia});
            this.dgvCitasProgramadas.EnableHeadersVisualStyles = false;
            this.dgvCitasProgramadas.Location = new System.Drawing.Point(26, 279);
            this.dgvCitasProgramadas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCitasProgramadas.Name = "dgvCitasProgramadas";
            this.dgvCitasProgramadas.ReadOnly = true;
            this.dgvCitasProgramadas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCitasProgramadas.RowHeadersWidth = 51;
            this.dgvCitasProgramadas.RowTemplate.Height = 24;
            this.dgvCitasProgramadas.Size = new System.Drawing.Size(972, 223);
            this.dgvCitasProgramadas.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 130;
            // 
            // Orientador
            // 
            this.Orientador.HeaderText = "Orientador";
            this.Orientador.MinimumWidth = 6;
            this.Orientador.Name = "Orientador";
            this.Orientador.ReadOnly = true;
            this.Orientador.Width = 285;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 125;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.MinimumWidth = 6;
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            this.HoraInicio.Width = 125;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Hora Fin";
            this.HoraFin.MinimumWidth = 6;
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.ReadOnly = true;
            this.HoraFin.Width = 125;
            // 
            // Asistencia
            // 
            this.Asistencia.HeaderText = "Asistencia";
            this.Asistencia.MinimumWidth = 6;
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.ReadOnly = true;
            this.Asistencia.Width = 125;
            // 
            // btnEliminarCita
            // 
            this.btnEliminarCita.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEliminarCita.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnEliminarCita.Location = new System.Drawing.Point(801, 250);
            this.btnEliminarCita.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCita.Name = "btnEliminarCita";
            this.btnEliminarCita.Size = new System.Drawing.Size(92, 25);
            this.btnEliminarCita.TabIndex = 2;
            this.btnEliminarCita.Text = "Eliminar";
            this.btnEliminarCita.UseVisualStyleBackColor = false;
            this.btnEliminarCita.Click += new System.EventHandler(this.btnEliminarCita_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.tabHistorial);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 540);
            this.panel2.TabIndex = 3;
            // 
            // tabHistorial
            // 
            this.tabHistorial.Controls.Add(this.tabCitasProgramadas);
            this.tabHistorial.Controls.Add(this.tabHistorialCitas);
            this.tabHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHistorial.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHistorial.Location = new System.Drawing.Point(0, 0);
            this.tabHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.SelectedIndex = 0;
            this.tabHistorial.Size = new System.Drawing.Size(1014, 540);
            this.tabHistorial.TabIndex = 3;
            // 
            // tabCitasProgramadas
            // 
            this.tabCitasProgramadas.BackColor = System.Drawing.SystemColors.Control;
            this.tabCitasProgramadas.Controls.Add(this.pnlRegistrarCita);
            this.tabCitasProgramadas.Controls.Add(this.lblListaCitasInscritas);
            this.tabCitasProgramadas.Controls.Add(this.btnDetInscritas);
            this.tabCitasProgramadas.Controls.Add(this.btnRegistrarCita);
            this.tabCitasProgramadas.Controls.Add(this.btnEliminarCita);
            this.tabCitasProgramadas.Controls.Add(this.dgvCitasProgramadas);
            this.tabCitasProgramadas.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCitasProgramadas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabCitasProgramadas.Location = new System.Drawing.Point(4, 27);
            this.tabCitasProgramadas.Margin = new System.Windows.Forms.Padding(2);
            this.tabCitasProgramadas.Name = "tabCitasProgramadas";
            this.tabCitasProgramadas.Padding = new System.Windows.Forms.Padding(2);
            this.tabCitasProgramadas.Size = new System.Drawing.Size(1006, 509);
            this.tabCitasProgramadas.TabIndex = 0;
            this.tabCitasProgramadas.Text = "Citas programadas";
            // 
            // pnlRegistrarCita
            // 
            this.pnlRegistrarCita.Controls.Add(this.lblRegistrar);
            this.pnlRegistrarCita.Controls.Add(this.dtpFecha);
            this.pnlRegistrarCita.Controls.Add(this.lblAsesor);
            this.pnlRegistrarCita.Controls.Add(this.lblFecha);
            this.pnlRegistrarCita.Controls.Add(this.lblHoraInicio);
            this.pnlRegistrarCita.Controls.Add(this.txtMotivo);
            this.pnlRegistrarCita.Controls.Add(this.lblHoraFin);
            this.pnlRegistrarCita.Controls.Add(this.lblMotivo);
            this.pnlRegistrarCita.Controls.Add(this.txtAsesor);
            this.pnlRegistrarCita.Controls.Add(this.btnBuscarAsesor);
            this.pnlRegistrarCita.Controls.Add(this.txtHoraInicio);
            this.pnlRegistrarCita.Controls.Add(this.btnBuscarHorario);
            this.pnlRegistrarCita.Controls.Add(this.txtHoraFin);
            this.pnlRegistrarCita.Location = new System.Drawing.Point(8, 5);
            this.pnlRegistrarCita.Name = "pnlRegistrarCita";
            this.pnlRegistrarCita.Size = new System.Drawing.Size(580, 246);
            this.pnlRegistrarCita.TabIndex = 53;
            // 
            // lblRegistrar
            // 
            this.lblRegistrar.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrar.Location = new System.Drawing.Point(14, 19);
            this.lblRegistrar.Name = "lblRegistrar";
            this.lblRegistrar.Size = new System.Drawing.Size(207, 23);
            this.lblRegistrar.TabIndex = 50;
            this.lblRegistrar.Text = "Registrar una nueva cita";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(100, 70);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 21);
            this.dtpFecha.TabIndex = 52;
            // 
            // lblAsesor
            // 
            this.lblAsesor.AutoSize = true;
            this.lblAsesor.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsesor.Location = new System.Drawing.Point(14, 45);
            this.lblAsesor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsesor.Name = "lblAsesor";
            this.lblAsesor.Size = new System.Drawing.Size(60, 21);
            this.lblAsesor.TabIndex = 25;
            this.lblAsesor.Text = "Asesor: ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(14, 70);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(52, 21);
            this.lblFecha.TabIndex = 26;
            this.lblFecha.Text = "Fecha: ";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(14, 97);
            this.lblHoraInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(84, 21);
            this.lblHoraInicio.TabIndex = 27;
            this.lblHoraInicio.Text = "Hora inicio: ";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(18, 144);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(2);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(486, 77);
            this.txtMotivo.TabIndex = 36;
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFin.Location = new System.Drawing.Point(219, 97);
            this.lblHoraFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(67, 21);
            this.lblHoraFin.TabIndex = 28;
            this.lblHoraFin.Text = "Hora fin: ";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(14, 121);
            this.lblMotivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(177, 21);
            this.lblMotivo.TabIndex = 35;
            this.lblMotivo.Text = "Ingrese motivo de consulta:";
            // 
            // txtAsesor
            // 
            this.txtAsesor.Enabled = false;
            this.txtAsesor.Location = new System.Drawing.Point(100, 44);
            this.txtAsesor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAsesor.Name = "txtAsesor";
            this.txtAsesor.ReadOnly = true;
            this.txtAsesor.Size = new System.Drawing.Size(246, 21);
            this.txtAsesor.TabIndex = 29;
            // 
            // btnBuscarAsesor
            // 
            this.btnBuscarAsesor.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAsesor.Location = new System.Drawing.Point(350, 43);
            this.btnBuscarAsesor.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarAsesor.Name = "btnBuscarAsesor";
            this.btnBuscarAsesor.Size = new System.Drawing.Size(33, 22);
            this.btnBuscarAsesor.TabIndex = 34;
            this.btnBuscarAsesor.Text = "...";
            this.btnBuscarAsesor.UseVisualStyleBackColor = true;
            this.btnBuscarAsesor.Click += new System.EventHandler(this.btnBuscarAsesor_Click);
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Enabled = false;
            this.txtHoraInicio.Location = new System.Drawing.Point(100, 97);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.ReadOnly = true;
            this.txtHoraInicio.Size = new System.Drawing.Size(87, 21);
            this.txtHoraInicio.TabIndex = 31;
            // 
            // btnBuscarHorario
            // 
            this.btnBuscarHorario.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHorario.Location = new System.Drawing.Point(305, 69);
            this.btnBuscarHorario.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarHorario.Name = "btnBuscarHorario";
            this.btnBuscarHorario.Size = new System.Drawing.Size(33, 22);
            this.btnBuscarHorario.TabIndex = 33;
            this.btnBuscarHorario.Text = "...";
            this.btnBuscarHorario.UseVisualStyleBackColor = true;
            this.btnBuscarHorario.Click += new System.EventHandler(this.btnBuscarHorario_Click);
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.Enabled = false;
            this.txtHoraFin.Location = new System.Drawing.Point(290, 97);
            this.txtHoraFin.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.ReadOnly = true;
            this.txtHoraFin.Size = new System.Drawing.Size(87, 21);
            this.txtHoraFin.TabIndex = 32;
            // 
            // lblListaCitasInscritas
            // 
            this.lblListaCitasInscritas.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCitasInscritas.Location = new System.Drawing.Point(22, 254);
            this.lblListaCitasInscritas.Name = "lblListaCitasInscritas";
            this.lblListaCitasInscritas.Size = new System.Drawing.Size(207, 23);
            this.lblListaCitasInscritas.TabIndex = 51;
            this.lblListaCitasInscritas.Text = "Lista de Citas Inscritas";
            // 
            // btnDetInscritas
            // 
            this.btnDetInscritas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDetInscritas.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnDetInscritas.Location = new System.Drawing.Point(897, 251);
            this.btnDetInscritas.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetInscritas.Name = "btnDetInscritas";
            this.btnDetInscritas.Size = new System.Drawing.Size(101, 24);
            this.btnDetInscritas.TabIndex = 7;
            this.btnDetInscritas.Text = "Ver detalle";
            this.btnDetInscritas.UseVisualStyleBackColor = false;
            this.btnDetInscritas.Click += new System.EventHandler(this.btnDetInscritas_Click);
            // 
            // btnRegistrarCita
            // 
            this.btnRegistrarCita.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRegistrarCita.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnRegistrarCita.Location = new System.Drawing.Point(705, 250);
            this.btnRegistrarCita.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarCita.Name = "btnRegistrarCita";
            this.btnRegistrarCita.Size = new System.Drawing.Size(92, 25);
            this.btnRegistrarCita.TabIndex = 3;
            this.btnRegistrarCita.Text = "Registrar cita";
            this.btnRegistrarCita.UseVisualStyleBackColor = false;
            this.btnRegistrarCita.Click += new System.EventHandler(this.btnRegistrarCita_Click);
            // 
            // tabHistorialCitas
            // 
            this.tabHistorialCitas.BackColor = System.Drawing.SystemColors.Control;
            this.tabHistorialCitas.Controls.Add(this.panel4);
            this.tabHistorialCitas.Controls.Add(this.lblListaCitasPasadas);
            this.tabHistorialCitas.Controls.Add(this.btnAgregarOpinion);
            this.tabHistorialCitas.Controls.Add(this.btnDetHistorial);
            this.tabHistorialCitas.Controls.Add(this.dgvHistorialCitas);
            this.tabHistorialCitas.Location = new System.Drawing.Point(4, 27);
            this.tabHistorialCitas.Margin = new System.Windows.Forms.Padding(2);
            this.tabHistorialCitas.Name = "tabHistorialCitas";
            this.tabHistorialCitas.Padding = new System.Windows.Forms.Padding(2);
            this.tabHistorialCitas.Size = new System.Drawing.Size(1006, 509);
            this.tabHistorialCitas.TabIndex = 1;
            this.tabHistorialCitas.Text = "Historial de citas";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dtpFechaHistorial);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtMotivoHistorial);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtAsesorHistorial);
            this.panel4.Controls.Add(this.txtHoraInicioHistorial);
            this.panel4.Controls.Add(this.txtHoraFinHistorial);
            this.panel4.Location = new System.Drawing.Point(8, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(580, 246);
            this.panel4.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "Buscar una Cita Pasada";
            // 
            // dtpFechaHistorial
            // 
            this.dtpFechaHistorial.Enabled = false;
            this.dtpFechaHistorial.Location = new System.Drawing.Point(100, 70);
            this.dtpFechaHistorial.Name = "dtpFechaHistorial";
            this.dtpFechaHistorial.Size = new System.Drawing.Size(200, 21);
            this.dtpFechaHistorial.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Asesor: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "Fecha: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(14, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Hora inicio: ";
            // 
            // txtMotivoHistorial
            // 
            this.txtMotivoHistorial.Enabled = false;
            this.txtMotivoHistorial.Location = new System.Drawing.Point(18, 144);
            this.txtMotivoHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.txtMotivoHistorial.Multiline = true;
            this.txtMotivoHistorial.Name = "txtMotivoHistorial";
            this.txtMotivoHistorial.Size = new System.Drawing.Size(486, 77);
            this.txtMotivoHistorial.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(219, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Hora fin: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(14, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "Motivo de consulta:";
            // 
            // txtAsesorHistorial
            // 
            this.txtAsesorHistorial.Location = new System.Drawing.Point(100, 44);
            this.txtAsesorHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.txtAsesorHistorial.Name = "txtAsesorHistorial";
            this.txtAsesorHistorial.ReadOnly = true;
            this.txtAsesorHistorial.Size = new System.Drawing.Size(246, 21);
            this.txtAsesorHistorial.TabIndex = 29;
            // 
            // txtHoraInicioHistorial
            // 
            this.txtHoraInicioHistorial.Enabled = false;
            this.txtHoraInicioHistorial.Location = new System.Drawing.Point(100, 97);
            this.txtHoraInicioHistorial.Name = "txtHoraInicioHistorial";
            this.txtHoraInicioHistorial.ReadOnly = true;
            this.txtHoraInicioHistorial.Size = new System.Drawing.Size(87, 21);
            this.txtHoraInicioHistorial.TabIndex = 31;
            // 
            // txtHoraFinHistorial
            // 
            this.txtHoraFinHistorial.Enabled = false;
            this.txtHoraFinHistorial.Location = new System.Drawing.Point(290, 97);
            this.txtHoraFinHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoraFinHistorial.Name = "txtHoraFinHistorial";
            this.txtHoraFinHistorial.ReadOnly = true;
            this.txtHoraFinHistorial.Size = new System.Drawing.Size(87, 21);
            this.txtHoraFinHistorial.TabIndex = 32;
            // 
            // lblListaCitasPasadas
            // 
            this.lblListaCitasPasadas.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCitasPasadas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblListaCitasPasadas.Location = new System.Drawing.Point(22, 254);
            this.lblListaCitasPasadas.Name = "lblListaCitasPasadas";
            this.lblListaCitasPasadas.Size = new System.Drawing.Size(207, 23);
            this.lblListaCitasPasadas.TabIndex = 52;
            this.lblListaCitasPasadas.Text = "Lista de Citas Pasadas";
            // 
            // btnAgregarOpinion
            // 
            this.btnAgregarOpinion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAgregarOpinion.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnAgregarOpinion.Location = new System.Drawing.Point(791, 251);
            this.btnAgregarOpinion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarOpinion.Name = "btnAgregarOpinion";
            this.btnAgregarOpinion.Size = new System.Drawing.Size(103, 24);
            this.btnAgregarOpinion.TabIndex = 7;
            this.btnAgregarOpinion.Text = "Agregar opinión";
            this.btnAgregarOpinion.UseVisualStyleBackColor = false;
            this.btnAgregarOpinion.Click += new System.EventHandler(this.btnAgregarOpinion_Click);
            // 
            // btnDetHistorial
            // 
            this.btnDetHistorial.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDetHistorial.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnDetHistorial.Location = new System.Drawing.Point(898, 251);
            this.btnDetHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetHistorial.Name = "btnDetHistorial";
            this.btnDetHistorial.Size = new System.Drawing.Size(101, 24);
            this.btnDetHistorial.TabIndex = 6;
            this.btnDetHistorial.Text = "Ver detalle";
            this.btnDetHistorial.UseVisualStyleBackColor = false;
            this.btnDetHistorial.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // dgvHistorialCitas
            // 
            this.dgvHistorialCitas.AllowUserToDeleteRows = false;
            this.dgvHistorialCitas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHistorialCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvHistorialCitas.EnableHeadersVisualStyles = false;
            this.dgvHistorialCitas.Location = new System.Drawing.Point(26, 279);
            this.dgvHistorialCitas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHistorialCitas.Name = "dgvHistorialCitas";
            this.dgvHistorialCitas.ReadOnly = true;
            this.dgvHistorialCitas.RowHeadersWidth = 51;
            this.dgvHistorialCitas.RowTemplate.Height = 24;
            this.dgvHistorialCitas.Size = new System.Drawing.Size(972, 223);
            this.dgvHistorialCitas.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Orientador";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 285;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Hora Inicio";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Hora Fin";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Asistencia";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 71);
            this.panel3.TabIndex = 4;
            // 
            // frmListaCitasAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmListaCitasAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de citas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasProgramadas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabHistorial.ResumeLayout(false);
            this.tabCitasProgramadas.ResumeLayout(false);
            this.pnlRegistrarCita.ResumeLayout(false);
            this.pnlRegistrarCita.PerformLayout();
            this.tabHistorialCitas.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCitas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label lblCitasHeader;
        private System.Windows.Forms.DataGridView dgvCitasProgramadas;
        private System.Windows.Forms.Button btnEliminarCita;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabHistorial;
        private System.Windows.Forms.TabPage tabCitasProgramadas;
        private System.Windows.Forms.TabPage tabHistorialCitas;
        private System.Windows.Forms.Button btnDetHistorial;
        private System.Windows.Forms.DataGridView dgvHistorialCitas;
        private System.Windows.Forms.Button btnRegistrarCita;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAgregarOpinion;
        private System.Windows.Forms.Button btnDetInscritas;
        private System.Windows.Forms.Button btnBuscarAsesor;
        private System.Windows.Forms.Button btnBuscarHorario;
        private System.Windows.Forms.TextBox txtHoraFin;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.TextBox txtAsesor;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblAsesor;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblListaCitasInscritas;
        private System.Windows.Forms.Label lblRegistrar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblListaCitasPasadas;
        private System.Windows.Forms.Panel pnlRegistrarCita;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaHistorial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMotivoHistorial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAsesorHistorial;
        private System.Windows.Forms.TextBox txtHoraInicioHistorial;
        private System.Windows.Forms.TextBox txtHoraFinHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orientador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}