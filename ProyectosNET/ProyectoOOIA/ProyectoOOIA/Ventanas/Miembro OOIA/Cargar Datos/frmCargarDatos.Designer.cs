
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHeader = new System.Windows.Forms.Label();
            this.panelGestionHumana = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCargaCSVPsicologos = new System.Windows.Forms.Button();
            this.btnCargaCSVProfesores = new System.Windows.Forms.Button();
            this.btnCargaCSVAlumnos = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.cmbEspecialidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPsicologo = new System.Windows.Forms.TextBox();
            this.btnPsicologo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProfesor = new System.Windows.Forms.TextBox();
            this.cmbAlumno = new System.Windows.Forms.TextBox();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.btnAlumno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnHistorialCursos = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMenos2 = new System.Windows.Forms.Button();
            this.btnMax2 = new System.Windows.Forms.Button();
            this.boxCategoria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbNotas = new System.Windows.Forms.TextBox();
            this.btnNotas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.TextBox();
            this.btnCursos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.boxAtencion = new System.Windows.Forms.TextBox();
            this.btnCodigoAtencion = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelGestionHumana.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // archivos
            // 
            this.archivos.Filter = "Archivos CSV (*.csv)|*.csv|Archivo de texto (*.txt)|*.txt";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.txtHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 123);
            this.panel1.TabIndex = 0;
            // 
            // txtHeader
            // 
            this.txtHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.txtHeader.Location = new System.Drawing.Point(16, 47);
            this.txtHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(475, 28);
            this.txtHeader.TabIndex = 1;
            this.txtHeader.Text = "Cargar Datos de ";
            // 
            // panelGestionHumana
            // 
            this.panelGestionHumana.Controls.Add(this.tabPage1);
            this.panelGestionHumana.Controls.Add(this.tabPage2);
            this.panelGestionHumana.Controls.Add(this.tabPage3);
            this.panelGestionHumana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGestionHumana.Location = new System.Drawing.Point(0, 123);
            this.panelGestionHumana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelGestionHumana.Name = "panelGestionHumana";
            this.panelGestionHumana.SelectedIndex = 0;
            this.panelGestionHumana.Size = new System.Drawing.Size(1263, 606);
            this.panelGestionHumana.TabIndex = 1;
            this.panelGestionHumana.Enter += new System.EventHandler(this.panelGestionHumana_Enter);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCargaCSVPsicologos);
            this.tabPage1.Controls.Add(this.btnCargaCSVProfesores);
            this.tabPage1.Controls.Add(this.btnCargaCSVAlumnos);
            this.tabPage1.Controls.Add(this.btnMenos);
            this.tabPage1.Controls.Add(this.btnMas);
            this.tabPage1.Controls.Add(this.cmbEspecialidad);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.data);
            this.tabPage1.Controls.Add(this.cmbPsicologo);
            this.tabPage1.Controls.Add(this.btnPsicologo);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cmbProfesor);
            this.tabPage1.Controls.Add(this.cmbAlumno);
            this.tabPage1.Controls.Add(this.btnProfesores);
            this.tabPage1.Controls.Add(this.btnAlumno);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1255, 577);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestion Humana";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // btnCargaCSVPsicologos
            // 
            this.btnCargaCSVPsicologos.Location = new System.Drawing.Point(1059, 209);
            this.btnCargaCSVPsicologos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargaCSVPsicologos.Name = "btnCargaCSVPsicologos";
            this.btnCargaCSVPsicologos.Size = new System.Drawing.Size(160, 34);
            this.btnCargaCSVPsicologos.TabIndex = 34;
            this.btnCargaCSVPsicologos.Text = "Cargar desde csv";
            this.btnCargaCSVPsicologos.UseVisualStyleBackColor = true;
            this.btnCargaCSVPsicologos.Click += new System.EventHandler(this.btnCargaCSVPsicologos_Click);
            // 
            // btnCargaCSVProfesores
            // 
            this.btnCargaCSVProfesores.Location = new System.Drawing.Point(1059, 149);
            this.btnCargaCSVProfesores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargaCSVProfesores.Name = "btnCargaCSVProfesores";
            this.btnCargaCSVProfesores.Size = new System.Drawing.Size(160, 34);
            this.btnCargaCSVProfesores.TabIndex = 33;
            this.btnCargaCSVProfesores.Text = "Cargar desde csv";
            this.btnCargaCSVProfesores.UseVisualStyleBackColor = true;
            this.btnCargaCSVProfesores.Click += new System.EventHandler(this.btnCargaCSVProfesores_Click);
            // 
            // btnCargaCSVAlumnos
            // 
            this.btnCargaCSVAlumnos.Location = new System.Drawing.Point(1059, 92);
            this.btnCargaCSVAlumnos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargaCSVAlumnos.Name = "btnCargaCSVAlumnos";
            this.btnCargaCSVAlumnos.Size = new System.Drawing.Size(160, 34);
            this.btnCargaCSVAlumnos.TabIndex = 32;
            this.btnCargaCSVAlumnos.Text = "Cargar desde csv";
            this.btnCargaCSVAlumnos.UseVisualStyleBackColor = true;
            this.btnCargaCSVAlumnos.Click += new System.EventHandler(this.btnCargaCSVAlumnos_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.BackgroundImage = global::ProyectoOOIA.Properties.Resources.menos;
            this.btnMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenos.Location = new System.Drawing.Point(999, 261);
            this.btnMenos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(40, 37);
            this.btnMenos.TabIndex = 31;
            this.btnMenos.UseVisualStyleBackColor = true;
            // 
            // btnMas
            // 
            this.btnMas.BackgroundImage = global::ProyectoOOIA.Properties.Resources.mas;
            this.btnMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMas.Location = new System.Drawing.Point(935, 261);
            this.btnMas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(40, 37);
            this.btnMas.TabIndex = 30;
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.Enabled = false;
            this.cmbEspecialidad.Location = new System.Drawing.Point(369, 261);
            this.cmbEspecialidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(523, 22);
            this.cmbEspecialidad.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 265);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Especialidades:";
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.data.Location = new System.Drawing.Point(205, 342);
            this.data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 51;
            this.data.Size = new System.Drawing.Size(845, 222);
            this.data.TabIndex = 27;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // cmbPsicologo
            // 
            this.cmbPsicologo.Enabled = false;
            this.cmbPsicologo.Location = new System.Drawing.Point(369, 215);
            this.cmbPsicologo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPsicologo.Name = "cmbPsicologo";
            this.cmbPsicologo.Size = new System.Drawing.Size(523, 22);
            this.cmbPsicologo.TabIndex = 26;
            // 
            // btnPsicologo
            // 
            this.btnPsicologo.Location = new System.Drawing.Point(935, 209);
            this.btnPsicologo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPsicologo.Name = "btnPsicologo";
            this.btnPsicologo.Size = new System.Drawing.Size(116, 36);
            this.btnPsicologo.TabIndex = 25;
            this.btnPsicologo.Text = "Cargar Datos";
            this.btnPsicologo.UseVisualStyleBackColor = true;
            this.btnPsicologo.Click += new System.EventHandler(this.btnPsicologo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Psicologos:";
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.Enabled = false;
            this.cmbProfesor.Location = new System.Drawing.Point(369, 154);
            this.cmbProfesor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(523, 22);
            this.cmbProfesor.TabIndex = 19;
            // 
            // cmbAlumno
            // 
            this.cmbAlumno.Enabled = false;
            this.cmbAlumno.Location = new System.Drawing.Point(369, 92);
            this.cmbAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAlumno.Name = "cmbAlumno";
            this.cmbAlumno.Size = new System.Drawing.Size(523, 22);
            this.cmbAlumno.TabIndex = 18;
            // 
            // btnProfesores
            // 
            this.btnProfesores.Location = new System.Drawing.Point(935, 148);
            this.btnProfesores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(116, 36);
            this.btnProfesores.TabIndex = 16;
            this.btnProfesores.Text = "Cargar Datos";
            this.btnProfesores.UseVisualStyleBackColor = true;
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click_1);
            // 
            // btnAlumno
            // 
            this.btnAlumno.Location = new System.Drawing.Point(935, 92);
            this.btnAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(116, 36);
            this.btnAlumno.TabIndex = 15;
            this.btnAlumno.Text = "Cargar Datos";
            this.btnAlumno.UseVisualStyleBackColor = true;
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Profesores:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Alumnos:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.btnHistorialCursos);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnMenos2);
            this.tabPage2.Controls.Add(this.btnMax2);
            this.tabPage2.Controls.Add(this.boxCategoria);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.cmbNotas);
            this.tabPage2.Controls.Add(this.btnNotas);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cmbCurso);
            this.tabPage2.Controls.Add(this.btnCursos);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1255, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gestion Academica";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(331, 172);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(523, 22);
            this.textBox1.TabIndex = 39;
            // 
            // btnHistorialCursos
            // 
            this.btnHistorialCursos.Location = new System.Drawing.Point(896, 166);
            this.btnHistorialCursos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHistorialCursos.Name = "btnHistorialCursos";
            this.btnHistorialCursos.Size = new System.Drawing.Size(116, 36);
            this.btnHistorialCursos.TabIndex = 38;
            this.btnHistorialCursos.Text = "Cargar Datos";
            this.btnHistorialCursos.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(163, 176);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Historial de cursos:";
            // 
            // btnMenos2
            // 
            this.btnMenos2.BackgroundImage = global::ProyectoOOIA.Properties.Resources.menos;
            this.btnMenos2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenos2.Location = new System.Drawing.Point(960, 261);
            this.btnMenos2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenos2.Name = "btnMenos2";
            this.btnMenos2.Size = new System.Drawing.Size(40, 37);
            this.btnMenos2.TabIndex = 36;
            this.btnMenos2.UseVisualStyleBackColor = true;
            // 
            // btnMax2
            // 
            this.btnMax2.BackgroundImage = global::ProyectoOOIA.Properties.Resources.mas;
            this.btnMax2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMax2.Location = new System.Drawing.Point(896, 261);
            this.btnMax2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMax2.Name = "btnMax2";
            this.btnMax2.Size = new System.Drawing.Size(40, 37);
            this.btnMax2.TabIndex = 35;
            this.btnMax2.UseVisualStyleBackColor = true;
            // 
            // boxCategoria
            // 
            this.boxCategoria.Enabled = false;
            this.boxCategoria.Location = new System.Drawing.Point(331, 261);
            this.boxCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxCategoria.Name = "boxCategoria";
            this.boxCategoria.Size = new System.Drawing.Size(523, 22);
            this.boxCategoria.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 265);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Categoria:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(167, 342);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(845, 222);
            this.dataGridView1.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // cmbNotas
            // 
            this.cmbNotas.Enabled = false;
            this.cmbNotas.Location = new System.Drawing.Point(331, 110);
            this.cmbNotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNotas.Name = "cmbNotas";
            this.cmbNotas.Size = new System.Drawing.Size(523, 22);
            this.cmbNotas.TabIndex = 29;
            // 
            // btnNotas
            // 
            this.btnNotas.Location = new System.Drawing.Point(896, 103);
            this.btnNotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(116, 36);
            this.btnNotas.TabIndex = 28;
            this.btnNotas.Text = "Cargar Datos";
            this.btnNotas.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Notas";
            // 
            // cmbCurso
            // 
            this.cmbCurso.Enabled = false;
            this.cmbCurso.Location = new System.Drawing.Point(331, 52);
            this.cmbCurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(523, 22);
            this.cmbCurso.TabIndex = 26;
            // 
            // btnCursos
            // 
            this.btnCursos.Location = new System.Drawing.Point(896, 46);
            this.btnCursos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(116, 36);
            this.btnCursos.TabIndex = 25;
            this.btnCursos.Text = "Cargar Datos";
            this.btnCursos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cursos";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.boxAtencion);
            this.tabPage3.Controls.Add(this.btnCodigoAtencion);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1255, 577);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gestion Atencion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // boxAtencion
            // 
            this.boxAtencion.Enabled = false;
            this.boxAtencion.Location = new System.Drawing.Point(356, 85);
            this.boxAtencion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxAtencion.Name = "boxAtencion";
            this.boxAtencion.Size = new System.Drawing.Size(523, 22);
            this.boxAtencion.TabIndex = 29;
            // 
            // btnCodigoAtencion
            // 
            this.btnCodigoAtencion.Location = new System.Drawing.Point(921, 79);
            this.btnCodigoAtencion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCodigoAtencion.Name = "btnCodigoAtencion";
            this.btnCodigoAtencion.Size = new System.Drawing.Size(116, 36);
            this.btnCodigoAtencion.TabIndex = 28;
            this.btnCodigoAtencion.Text = "Cargar Datos";
            this.btnCodigoAtencion.UseVisualStyleBackColor = true;
            this.btnCodigoAtencion.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 89);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Codigo de Atención:";
            // 
            // frmCargarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1263, 729);
            this.Controls.Add(this.panelGestionHumana);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "frmCargarDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCargarDatos";
            this.panel1.ResumeLayout(false);
            this.panelGestionHumana.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog archivos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl panelGestionHumana;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox cmbProfesor;
        private System.Windows.Forms.TextBox cmbAlumno;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.Button btnAlumno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label txtHeader;
        private System.Windows.Forms.TextBox cmbPsicologo;
        private System.Windows.Forms.Button btnPsicologo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.TextBox cmbNotas;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cmbCurso;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.TextBox cmbEspecialidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button btnMenos2;
        private System.Windows.Forms.Button btnMax2;
        private System.Windows.Forms.TextBox boxCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnHistorialCursos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox boxAtencion;
        private System.Windows.Forms.Button btnCodigoAtencion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCargaCSVPsicologos;
        private System.Windows.Forms.Button btnCargaCSVProfesores;
        private System.Windows.Forms.Button btnCargaCSVAlumnos;
    }
}