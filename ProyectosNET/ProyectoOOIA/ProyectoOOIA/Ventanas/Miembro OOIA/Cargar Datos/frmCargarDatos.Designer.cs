
namespace ProyectoOOIA.Ventanas.Miembro_OOIA
{
    partial class frmCargarDatos
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
            this.archivos = new System.Windows.Forms.OpenFileDialog();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.txtHeader = new System.Windows.Forms.Label();
            this.panelGestionHumana = new System.Windows.Forms.TabControl();
            this.tabGestionHumana = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEspecialidad = new System.Windows.Forms.Button();
            this.lblEspecialidadForm = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCoordinador = new System.Windows.Forms.Panel();
            this.btnCoordinador = new System.Windows.Forms.Button();
            this.lblCoordinadorForm = new System.Windows.Forms.Label();
            this.lblCoordinador = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlEspecialidad = new System.Windows.Forms.Panel();
            this.btnPonente = new System.Windows.Forms.Button();
            this.lblPonenteForm = new System.Windows.Forms.Label();
            this.lblPonente = new System.Windows.Forms.Label();
            this.pnlAsesor = new System.Windows.Forms.Panel();
            this.btnAsesorFile = new System.Windows.Forms.Button();
            this.rbPsicologo = new System.Windows.Forms.RadioButton();
            this.rbProfesor = new System.Windows.Forms.RadioButton();
            this.lblTipoAsesor = new System.Windows.Forms.Label();
            this.lblAsesor = new System.Windows.Forms.Label();
            this.btnAsesorCSV = new System.Windows.Forms.Button();
            this.lblAsesorCSV = new System.Windows.Forms.Label();
            this.lblAsesorForm = new System.Windows.Forms.Label();
            this.txtAsesor = new System.Windows.Forms.TextBox();
            this.btnAsesor = new System.Windows.Forms.Button();
            this.pnlAlumno = new System.Windows.Forms.Panel();
            this.btnAlumnoFile = new System.Windows.Forms.Button();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.btnAlumnoCSV = new System.Windows.Forms.Button();
            this.lblAlumnoCSV = new System.Windows.Forms.Label();
            this.lblAlumnoForm = new System.Windows.Forms.Label();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.btnAlumno = new System.Windows.Forms.Button();
            this.tabGestionAcademica = new System.Windows.Forms.TabPage();
            this.tabGestionAtencion = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCodigoAtencion = new System.Windows.Forms.Button();
            this.lblCodigoAtencionForm = new System.Windows.Forms.Label();
            this.lblCodigoAtencion = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.panelGestionHumana.SuspendLayout();
            this.tabGestionHumana.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCoordinador.SuspendLayout();
            this.pnlEspecialidad.SuspendLayout();
            this.pnlAsesor.SuspendLayout();
            this.pnlAlumno.SuspendLayout();
            this.tabGestionAtencion.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // archivos
            // 
            this.archivos.Filter = "Archivos CSV (*.csv)|*.csv|Archivo de texto (*.txt)|*.txt";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.txtHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(684, 71);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::ProyectoOOIA.Properties.Resources.arrowWhite;
            this.btnBack.Location = new System.Drawing.Point(11, 34);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 25);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 4;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtHeader
            // 
            this.txtHeader.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.txtHeader.Location = new System.Drawing.Point(41, 34);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(356, 37);
            this.txtHeader.TabIndex = 1;
            this.txtHeader.Text = "Carga de Datos";
            // 
            // panelGestionHumana
            // 
            this.panelGestionHumana.Controls.Add(this.tabGestionHumana);
            this.panelGestionHumana.Controls.Add(this.tabGestionAcademica);
            this.panelGestionHumana.Controls.Add(this.tabGestionAtencion);
            this.panelGestionHumana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGestionHumana.Location = new System.Drawing.Point(0, 71);
            this.panelGestionHumana.Name = "panelGestionHumana";
            this.panelGestionHumana.SelectedIndex = 0;
            this.panelGestionHumana.Size = new System.Drawing.Size(684, 390);
            this.panelGestionHumana.TabIndex = 1;
            // 
            // tabGestionHumana
            // 
            this.tabGestionHumana.AutoScroll = true;
            this.tabGestionHumana.Controls.Add(this.panel3);
            this.tabGestionHumana.Controls.Add(this.panel1);
            this.tabGestionHumana.Controls.Add(this.pnlEspecialidad);
            this.tabGestionHumana.Controls.Add(this.pnlAsesor);
            this.tabGestionHumana.Controls.Add(this.pnlAlumno);
            this.tabGestionHumana.Location = new System.Drawing.Point(4, 22);
            this.tabGestionHumana.Name = "tabGestionHumana";
            this.tabGestionHumana.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestionHumana.Size = new System.Drawing.Size(676, 364);
            this.tabGestionHumana.TabIndex = 0;
            this.tabGestionHumana.Text = "Gestion Humana";
            this.tabGestionHumana.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnEspecialidad);
            this.panel3.Controls.Add(this.lblEspecialidadForm);
            this.panel3.Controls.Add(this.lblEspecialidad);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 401);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(653, 78);
            this.panel3.TabIndex = 41;
            // 
            // btnEspecialidad
            // 
            this.btnEspecialidad.Location = new System.Drawing.Point(404, 31);
            this.btnEspecialidad.Name = "btnEspecialidad";
            this.btnEspecialidad.Size = new System.Drawing.Size(138, 29);
            this.btnEspecialidad.TabIndex = 37;
            this.btnEspecialidad.Text = "Gestionar Especialidades";
            this.btnEspecialidad.UseVisualStyleBackColor = true;
            this.btnEspecialidad.Click += new System.EventHandler(this.btnEspecialidad_Click);
            // 
            // lblEspecialidadForm
            // 
            this.lblEspecialidadForm.AutoSize = true;
            this.lblEspecialidadForm.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidadForm.Location = new System.Drawing.Point(6, 34);
            this.lblEspecialidadForm.Name = "lblEspecialidadForm";
            this.lblEspecialidadForm.Size = new System.Drawing.Size(252, 21);
            this.lblEspecialidadForm.TabIndex = 36;
            this.lblEspecialidadForm.Text = "Gestionar especialidades por formulario";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(5, 3);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(135, 30);
            this.lblEspecialidad.TabIndex = 12;
            this.lblEspecialidad.Text = "Especialidades";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlCoordinador);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 78);
            this.panel1.TabIndex = 40;
            // 
            // pnlCoordinador
            // 
            this.pnlCoordinador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCoordinador.Controls.Add(this.btnCoordinador);
            this.pnlCoordinador.Controls.Add(this.lblCoordinadorForm);
            this.pnlCoordinador.Controls.Add(this.lblCoordinador);
            this.pnlCoordinador.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCoordinador.Location = new System.Drawing.Point(0, 0);
            this.pnlCoordinador.Name = "pnlCoordinador";
            this.pnlCoordinador.Size = new System.Drawing.Size(653, 78);
            this.pnlCoordinador.TabIndex = 41;
            // 
            // btnCoordinador
            // 
            this.btnCoordinador.Location = new System.Drawing.Point(404, 31);
            this.btnCoordinador.Name = "btnCoordinador";
            this.btnCoordinador.Size = new System.Drawing.Size(138, 29);
            this.btnCoordinador.TabIndex = 37;
            this.btnCoordinador.Text = "Gestionar Coordinadores";
            this.btnCoordinador.UseVisualStyleBackColor = true;
            // 
            // lblCoordinadorForm
            // 
            this.lblCoordinadorForm.AutoSize = true;
            this.lblCoordinadorForm.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordinadorForm.Location = new System.Drawing.Point(6, 34);
            this.lblCoordinadorForm.Name = "lblCoordinadorForm";
            this.lblCoordinadorForm.Size = new System.Drawing.Size(256, 21);
            this.lblCoordinadorForm.TabIndex = 36;
            this.lblCoordinadorForm.Text = "Gestionar coordinadores por formulario";
            // 
            // lblCoordinador
            // 
            this.lblCoordinador.AutoSize = true;
            this.lblCoordinador.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordinador.Location = new System.Drawing.Point(5, 3);
            this.lblCoordinador.Name = "lblCoordinador";
            this.lblCoordinador.Size = new System.Drawing.Size(145, 30);
            this.lblCoordinador.TabIndex = 12;
            this.lblCoordinador.Text = "Coordinadores";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 29);
            this.button1.TabIndex = 37;
            this.button1.Text = "Gestionar Especialidades";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "Gestionar especialidades por formulario";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 30);
            this.label13.TabIndex = 12;
            this.label13.Text = "Especialidades";
            // 
            // pnlEspecialidad
            // 
            this.pnlEspecialidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEspecialidad.Controls.Add(this.btnPonente);
            this.pnlEspecialidad.Controls.Add(this.lblPonenteForm);
            this.pnlEspecialidad.Controls.Add(this.lblPonente);
            this.pnlEspecialidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEspecialidad.Location = new System.Drawing.Point(3, 245);
            this.pnlEspecialidad.Name = "pnlEspecialidad";
            this.pnlEspecialidad.Size = new System.Drawing.Size(653, 78);
            this.pnlEspecialidad.TabIndex = 39;
            // 
            // btnPonente
            // 
            this.btnPonente.Location = new System.Drawing.Point(404, 31);
            this.btnPonente.Name = "btnPonente";
            this.btnPonente.Size = new System.Drawing.Size(138, 29);
            this.btnPonente.TabIndex = 37;
            this.btnPonente.Text = "Gestionar Ponentes";
            this.btnPonente.UseVisualStyleBackColor = true;
            // 
            // lblPonenteForm
            // 
            this.lblPonenteForm.AutoSize = true;
            this.lblPonenteForm.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPonenteForm.Location = new System.Drawing.Point(6, 34);
            this.lblPonenteForm.Name = "lblPonenteForm";
            this.lblPonenteForm.Size = new System.Drawing.Size(224, 21);
            this.lblPonenteForm.TabIndex = 36;
            this.lblPonenteForm.Text = "Gestionar ponentes por formulario";
            // 
            // lblPonente
            // 
            this.lblPonente.AutoSize = true;
            this.lblPonente.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPonente.Location = new System.Drawing.Point(5, 3);
            this.lblPonente.Name = "lblPonente";
            this.lblPonente.Size = new System.Drawing.Size(93, 30);
            this.lblPonente.TabIndex = 12;
            this.lblPonente.Text = "Ponentes";
            // 
            // pnlAsesor
            // 
            this.pnlAsesor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAsesor.Controls.Add(this.btnAsesorFile);
            this.pnlAsesor.Controls.Add(this.rbPsicologo);
            this.pnlAsesor.Controls.Add(this.rbProfesor);
            this.pnlAsesor.Controls.Add(this.lblTipoAsesor);
            this.pnlAsesor.Controls.Add(this.lblAsesor);
            this.pnlAsesor.Controls.Add(this.btnAsesorCSV);
            this.pnlAsesor.Controls.Add(this.lblAsesorCSV);
            this.pnlAsesor.Controls.Add(this.lblAsesorForm);
            this.pnlAsesor.Controls.Add(this.txtAsesor);
            this.pnlAsesor.Controls.Add(this.btnAsesor);
            this.pnlAsesor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAsesor.Location = new System.Drawing.Point(3, 113);
            this.pnlAsesor.Name = "pnlAsesor";
            this.pnlAsesor.Size = new System.Drawing.Size(653, 132);
            this.pnlAsesor.TabIndex = 38;
            // 
            // btnAsesorFile
            // 
            this.btnAsesorFile.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsesorFile.Location = new System.Drawing.Point(366, 94);
            this.btnAsesorFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsesorFile.Name = "btnAsesorFile";
            this.btnAsesorFile.Size = new System.Drawing.Size(33, 22);
            this.btnAsesorFile.TabIndex = 40;
            this.btnAsesorFile.Text = "...";
            this.btnAsesorFile.UseVisualStyleBackColor = true;
            this.btnAsesorFile.Click += new System.EventHandler(this.btnAsesorFile_Click);
            // 
            // rbPsicologo
            // 
            this.rbPsicologo.AutoSize = true;
            this.rbPsicologo.Location = new System.Drawing.Point(489, 25);
            this.rbPsicologo.Name = "rbPsicologo";
            this.rbPsicologo.Size = new System.Drawing.Size(71, 17);
            this.rbPsicologo.TabIndex = 39;
            this.rbPsicologo.TabStop = true;
            this.rbPsicologo.Text = "Psicologo";
            this.rbPsicologo.UseVisualStyleBackColor = true;
            // 
            // rbProfesor
            // 
            this.rbProfesor.AutoSize = true;
            this.rbProfesor.Checked = true;
            this.rbProfesor.Location = new System.Drawing.Point(398, 25);
            this.rbProfesor.Name = "rbProfesor";
            this.rbProfesor.Size = new System.Drawing.Size(64, 17);
            this.rbProfesor.TabIndex = 38;
            this.rbProfesor.TabStop = true;
            this.rbProfesor.Text = "Profesor";
            this.rbProfesor.UseVisualStyleBackColor = true;
            // 
            // lblTipoAsesor
            // 
            this.lblTipoAsesor.AutoSize = true;
            this.lblTipoAsesor.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAsesor.Location = new System.Drawing.Point(6, 30);
            this.lblTipoAsesor.Name = "lblTipoAsesor";
            this.lblTipoAsesor.Size = new System.Drawing.Size(100, 21);
            this.lblTipoAsesor.TabIndex = 37;
            this.lblTipoAsesor.Text = "Tipo de asesor";
            // 
            // lblAsesor
            // 
            this.lblAsesor.AutoSize = true;
            this.lblAsesor.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsesor.Location = new System.Drawing.Point(5, 0);
            this.lblAsesor.Name = "lblAsesor";
            this.lblAsesor.Size = new System.Drawing.Size(91, 30);
            this.lblAsesor.TabIndex = 12;
            this.lblAsesor.Text = "Asesores";
            // 
            // btnAsesorCSV
            // 
            this.btnAsesorCSV.Location = new System.Drawing.Point(404, 91);
            this.btnAsesorCSV.Name = "btnAsesorCSV";
            this.btnAsesorCSV.Size = new System.Drawing.Size(138, 28);
            this.btnAsesorCSV.TabIndex = 34;
            this.btnAsesorCSV.Text = "Cargar desde csv";
            this.btnAsesorCSV.UseVisualStyleBackColor = true;
            this.btnAsesorCSV.Click += new System.EventHandler(this.btnAsesorCSV_Click);
            // 
            // lblAsesorCSV
            // 
            this.lblAsesorCSV.AutoSize = true;
            this.lblAsesorCSV.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsesorCSV.Location = new System.Drawing.Point(6, 72);
            this.lblAsesorCSV.Name = "lblAsesorCSV";
            this.lblAsesorCSV.Size = new System.Drawing.Size(231, 21);
            this.lblAsesorCSV.TabIndex = 36;
            this.lblAsesorCSV.Text = "Cargar Asesores desde archivo CSV";
            // 
            // lblAsesorForm
            // 
            this.lblAsesorForm.AutoSize = true;
            this.lblAsesorForm.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsesorForm.Location = new System.Drawing.Point(6, 51);
            this.lblAsesorForm.Name = "lblAsesorForm";
            this.lblAsesorForm.Size = new System.Drawing.Size(219, 21);
            this.lblAsesorForm.TabIndex = 35;
            this.lblAsesorForm.Text = "Gestionar asesores por formulario";
            // 
            // txtAsesor
            // 
            this.txtAsesor.Enabled = false;
            this.txtAsesor.Location = new System.Drawing.Point(10, 96);
            this.txtAsesor.Name = "txtAsesor";
            this.txtAsesor.Size = new System.Drawing.Size(351, 20);
            this.txtAsesor.TabIndex = 18;
            // 
            // btnAsesor
            // 
            this.btnAsesor.Location = new System.Drawing.Point(404, 48);
            this.btnAsesor.Name = "btnAsesor";
            this.btnAsesor.Size = new System.Drawing.Size(138, 29);
            this.btnAsesor.TabIndex = 15;
            this.btnAsesor.Text = "Gestionar Asesores";
            this.btnAsesor.UseVisualStyleBackColor = true;
            this.btnAsesor.Click += new System.EventHandler(this.btnAsesor_Click);
            // 
            // pnlAlumno
            // 
            this.pnlAlumno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAlumno.Controls.Add(this.btnAlumnoFile);
            this.pnlAlumno.Controls.Add(this.lblAlumno);
            this.pnlAlumno.Controls.Add(this.btnAlumnoCSV);
            this.pnlAlumno.Controls.Add(this.lblAlumnoCSV);
            this.pnlAlumno.Controls.Add(this.lblAlumnoForm);
            this.pnlAlumno.Controls.Add(this.txtAlumno);
            this.pnlAlumno.Controls.Add(this.btnAlumno);
            this.pnlAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAlumno.Location = new System.Drawing.Point(3, 3);
            this.pnlAlumno.Name = "pnlAlumno";
            this.pnlAlumno.Size = new System.Drawing.Size(653, 110);
            this.pnlAlumno.TabIndex = 37;
            // 
            // btnAlumnoFile
            // 
            this.btnAlumnoFile.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnoFile.Location = new System.Drawing.Point(366, 73);
            this.btnAlumnoFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlumnoFile.Name = "btnAlumnoFile";
            this.btnAlumnoFile.Size = new System.Drawing.Size(33, 22);
            this.btnAlumnoFile.TabIndex = 37;
            this.btnAlumnoFile.Text = "...";
            this.btnAlumnoFile.UseVisualStyleBackColor = true;
            this.btnAlumnoFile.Click += new System.EventHandler(this.btnAlumnoFile_Click);
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.Location = new System.Drawing.Point(5, 0);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(90, 30);
            this.lblAlumno.TabIndex = 12;
            this.lblAlumno.Text = "Alumnos";
            // 
            // btnAlumnoCSV
            // 
            this.btnAlumnoCSV.Location = new System.Drawing.Point(404, 70);
            this.btnAlumnoCSV.Name = "btnAlumnoCSV";
            this.btnAlumnoCSV.Size = new System.Drawing.Size(138, 28);
            this.btnAlumnoCSV.TabIndex = 34;
            this.btnAlumnoCSV.Text = "Cargar desde csv";
            this.btnAlumnoCSV.UseVisualStyleBackColor = true;
            this.btnAlumnoCSV.Click += new System.EventHandler(this.btnAlumnoCSV_Click);
            // 
            // lblAlumnoCSV
            // 
            this.lblAlumnoCSV.AutoSize = true;
            this.lblAlumnoCSV.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnoCSV.Location = new System.Drawing.Point(6, 51);
            this.lblAlumnoCSV.Name = "lblAlumnoCSV";
            this.lblAlumnoCSV.Size = new System.Drawing.Size(229, 21);
            this.lblAlumnoCSV.TabIndex = 36;
            this.lblAlumnoCSV.Text = "Cargar Alumnos desde archivo CSV";
            // 
            // lblAlumnoForm
            // 
            this.lblAlumnoForm.AutoSize = true;
            this.lblAlumnoForm.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnoForm.Location = new System.Drawing.Point(6, 30);
            this.lblAlumnoForm.Name = "lblAlumnoForm";
            this.lblAlumnoForm.Size = new System.Drawing.Size(217, 21);
            this.lblAlumnoForm.TabIndex = 35;
            this.lblAlumnoForm.Text = "Gestionar alumnos por formulario";
            // 
            // txtAlumno
            // 
            this.txtAlumno.Enabled = false;
            this.txtAlumno.Location = new System.Drawing.Point(10, 75);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(351, 20);
            this.txtAlumno.TabIndex = 18;
            // 
            // btnAlumno
            // 
            this.btnAlumno.Location = new System.Drawing.Point(404, 27);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(138, 29);
            this.btnAlumno.TabIndex = 15;
            this.btnAlumno.Text = "Gestionar Alumnos";
            this.btnAlumno.UseVisualStyleBackColor = true;
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // tabGestionAcademica
            // 
            this.tabGestionAcademica.AutoScroll = true;
            this.tabGestionAcademica.Location = new System.Drawing.Point(4, 22);
            this.tabGestionAcademica.Name = "tabGestionAcademica";
            this.tabGestionAcademica.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestionAcademica.Size = new System.Drawing.Size(676, 364);
            this.tabGestionAcademica.TabIndex = 1;
            this.tabGestionAcademica.Text = "Gestion Academica";
            this.tabGestionAcademica.UseVisualStyleBackColor = true;
            // 
            // tabGestionAtencion
            // 
            this.tabGestionAtencion.AutoScroll = true;
            this.tabGestionAtencion.Controls.Add(this.panel2);
            this.tabGestionAtencion.Location = new System.Drawing.Point(4, 22);
            this.tabGestionAtencion.Name = "tabGestionAtencion";
            this.tabGestionAtencion.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestionAtencion.Size = new System.Drawing.Size(676, 364);
            this.tabGestionAtencion.TabIndex = 2;
            this.tabGestionAtencion.Text = "Gestion Atencion";
            this.tabGestionAtencion.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCodigoAtencion);
            this.panel2.Controls.Add(this.lblCodigoAtencionForm);
            this.panel2.Controls.Add(this.lblCodigoAtencion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 78);
            this.panel2.TabIndex = 40;
            // 
            // btnCodigoAtencion
            // 
            this.btnCodigoAtencion.Location = new System.Drawing.Point(404, 31);
            this.btnCodigoAtencion.Name = "btnCodigoAtencion";
            this.btnCodigoAtencion.Size = new System.Drawing.Size(138, 29);
            this.btnCodigoAtencion.TabIndex = 37;
            this.btnCodigoAtencion.Text = "Gestionar Códigos";
            this.btnCodigoAtencion.UseVisualStyleBackColor = true;
            this.btnCodigoAtencion.Click += new System.EventHandler(this.btnCodigoAtencion_Click);
            // 
            // lblCodigoAtencionForm
            // 
            this.lblCodigoAtencionForm.AutoSize = true;
            this.lblCodigoAtencionForm.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAtencionForm.Location = new System.Drawing.Point(6, 34);
            this.lblCodigoAtencionForm.Name = "lblCodigoAtencionForm";
            this.lblCodigoAtencionForm.Size = new System.Drawing.Size(288, 21);
            this.lblCodigoAtencionForm.TabIndex = 36;
            this.lblCodigoAtencionForm.Text = "Gestionar códigos de atención por formulario";
            // 
            // lblCodigoAtencion
            // 
            this.lblCodigoAtencion.AutoSize = true;
            this.lblCodigoAtencion.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAtencion.Location = new System.Drawing.Point(5, 3);
            this.lblCodigoAtencion.Name = "lblCodigoAtencion";
            this.lblCodigoAtencion.Size = new System.Drawing.Size(197, 30);
            this.lblCodigoAtencion.TabIndex = 12;
            this.lblCodigoAtencion.Text = "Códigos de Atención";
            // 
            // frmCargarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.panelGestionHumana);
            this.Controls.Add(this.pnlHeader);
            this.MinimizeBox = false;
            this.Name = "frmCargarDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCargarDatos";
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.panelGestionHumana.ResumeLayout(false);
            this.tabGestionHumana.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCoordinador.ResumeLayout(false);
            this.pnlCoordinador.PerformLayout();
            this.pnlEspecialidad.ResumeLayout(false);
            this.pnlEspecialidad.PerformLayout();
            this.pnlAsesor.ResumeLayout(false);
            this.pnlAsesor.PerformLayout();
            this.pnlAlumno.ResumeLayout(false);
            this.pnlAlumno.PerformLayout();
            this.tabGestionAtencion.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog archivos;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TabControl panelGestionHumana;
        private System.Windows.Forms.TabPage tabGestionHumana;
        private System.Windows.Forms.Button btnAlumno;
        private System.Windows.Forms.TabPage tabGestionAcademica;
        private System.Windows.Forms.Label txtHeader;
        private System.Windows.Forms.TabPage tabGestionAtencion;
        private System.Windows.Forms.Button btnAlumnoCSV;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Panel pnlAlumno;
        private System.Windows.Forms.Label lblAlumnoCSV;
        private System.Windows.Forms.Label lblAlumnoForm;
        private System.Windows.Forms.Panel pnlAsesor;
        private System.Windows.Forms.Label lblAsesor;
        private System.Windows.Forms.Button btnAsesorCSV;
        private System.Windows.Forms.Label lblAsesorCSV;
        private System.Windows.Forms.Label lblAsesorForm;
        private System.Windows.Forms.TextBox txtAsesor;
        private System.Windows.Forms.Button btnAsesor;
        private System.Windows.Forms.Label lblTipoAsesor;
        private System.Windows.Forms.Panel pnlEspecialidad;
        private System.Windows.Forms.Label lblPonente;
        private System.Windows.Forms.Button btnPonente;
        private System.Windows.Forms.Label lblPonenteForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEspecialidad;
        private System.Windows.Forms.Label lblEspecialidadForm;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCoordinador;
        private System.Windows.Forms.Button btnCoordinador;
        private System.Windows.Forms.Label lblCoordinadorForm;
        private System.Windows.Forms.Label lblCoordinador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rbPsicologo;
        private System.Windows.Forms.RadioButton rbProfesor;
        private System.Windows.Forms.Button btnAsesorFile;
        private System.Windows.Forms.Button btnAlumnoFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCodigoAtencion;
        private System.Windows.Forms.Label lblCodigoAtencionForm;
        private System.Windows.Forms.Label lblCodigoAtencion;
        private System.Windows.Forms.PictureBox btnBack;
    }
}