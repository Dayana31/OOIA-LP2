
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 100);
            this.panel1.TabIndex = 0;
            // 
            // txtHeader
            // 
            this.txtHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.txtHeader.Location = new System.Drawing.Point(12, 38);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(356, 23);
            this.txtHeader.TabIndex = 1;
            this.txtHeader.Text = "Cargar Datos de ";
            // 
            // panelGestionHumana
            // 
            this.panelGestionHumana.Controls.Add(this.tabPage1);
            this.panelGestionHumana.Controls.Add(this.tabPage2);
            this.panelGestionHumana.Controls.Add(this.tabPage3);
            this.panelGestionHumana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGestionHumana.Location = new System.Drawing.Point(0, 100);
            this.panelGestionHumana.Name = "panelGestionHumana";
            this.panelGestionHumana.SelectedIndex = 0;
            this.panelGestionHumana.Size = new System.Drawing.Size(947, 492);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(939, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestion Humana";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // btnCargaCSVPsicologos
            // 
            this.btnCargaCSVPsicologos.Location = new System.Drawing.Point(794, 170);
            this.btnCargaCSVPsicologos.Name = "btnCargaCSVPsicologos";
            this.btnCargaCSVPsicologos.Size = new System.Drawing.Size(120, 28);
            this.btnCargaCSVPsicologos.TabIndex = 34;
            this.btnCargaCSVPsicologos.Text = "Cargar desde csv";
            this.btnCargaCSVPsicologos.UseVisualStyleBackColor = true;
            this.btnCargaCSVPsicologos.Click += new System.EventHandler(this.btnCargaCSVPsicologos_Click);
            // 
            // btnCargaCSVProfesores
            // 
            this.btnCargaCSVProfesores.Location = new System.Drawing.Point(794, 121);
            this.btnCargaCSVProfesores.Name = "btnCargaCSVProfesores";
            this.btnCargaCSVProfesores.Size = new System.Drawing.Size(120, 28);
            this.btnCargaCSVProfesores.TabIndex = 33;
            this.btnCargaCSVProfesores.Text = "Cargar desde csv";
            this.btnCargaCSVProfesores.UseVisualStyleBackColor = true;
            this.btnCargaCSVProfesores.Click += new System.EventHandler(this.btnCargaCSVProfesores_Click);
            // 
            // btnCargaCSVAlumnos
            // 
            this.btnCargaCSVAlumnos.Location = new System.Drawing.Point(794, 75);
            this.btnCargaCSVAlumnos.Name = "btnCargaCSVAlumnos";
            this.btnCargaCSVAlumnos.Size = new System.Drawing.Size(120, 28);
            this.btnCargaCSVAlumnos.TabIndex = 32;
            this.btnCargaCSVAlumnos.Text = "Cargar desde csv";
            this.btnCargaCSVAlumnos.UseVisualStyleBackColor = true;
            this.btnCargaCSVAlumnos.Click += new System.EventHandler(this.btnCargaCSVAlumnos_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.BackgroundImage = global::ProyectoOOIA.Properties.Resources.menos;
            this.btnMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenos.Location = new System.Drawing.Point(749, 212);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(30, 30);
            this.btnMenos.TabIndex = 31;
            this.btnMenos.UseVisualStyleBackColor = true;
            // 
            // btnMas
            // 
            this.btnMas.BackgroundImage = global::ProyectoOOIA.Properties.Resources.mas;
            this.btnMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMas.Location = new System.Drawing.Point(701, 212);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(30, 30);
            this.btnMas.TabIndex = 30;
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.Enabled = false;
            this.cmbEspecialidad.Location = new System.Drawing.Point(277, 212);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(393, 20);
            this.cmbEspecialidad.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Especialidades:";
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.data.Location = new System.Drawing.Point(154, 278);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 51;
            this.data.Size = new System.Drawing.Size(634, 180);
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
            this.cmbPsicologo.Location = new System.Drawing.Point(277, 175);
            this.cmbPsicologo.Name = "cmbPsicologo";
            this.cmbPsicologo.Size = new System.Drawing.Size(393, 20);
            this.cmbPsicologo.TabIndex = 26;
            // 
            // btnPsicologo
            // 
            this.btnPsicologo.Location = new System.Drawing.Point(701, 170);
            this.btnPsicologo.Name = "btnPsicologo";
            this.btnPsicologo.Size = new System.Drawing.Size(87, 29);
            this.btnPsicologo.TabIndex = 25;
            this.btnPsicologo.Text = "Cargar Datos";
            this.btnPsicologo.UseVisualStyleBackColor = true;
            this.btnPsicologo.Click += new System.EventHandler(this.btnPsicologo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Psicologos:";
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.Enabled = false;
            this.cmbProfesor.Location = new System.Drawing.Point(277, 125);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(393, 20);
            this.cmbProfesor.TabIndex = 19;
            // 
            // cmbAlumno
            // 
            this.cmbAlumno.Enabled = false;
            this.cmbAlumno.Location = new System.Drawing.Point(277, 75);
            this.cmbAlumno.Name = "cmbAlumno";
            this.cmbAlumno.Size = new System.Drawing.Size(393, 20);
            this.cmbAlumno.TabIndex = 18;
            // 
            // btnProfesores
            // 
            this.btnProfesores.Location = new System.Drawing.Point(701, 120);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(87, 29);
            this.btnProfesores.TabIndex = 16;
            this.btnProfesores.Text = "Cargar Datos";
            this.btnProfesores.UseVisualStyleBackColor = true;
            // 
            // btnAlumno
            // 
            this.btnAlumno.Location = new System.Drawing.Point(701, 75);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(87, 29);
            this.btnAlumno.TabIndex = 15;
            this.btnAlumno.Text = "Cargar Datos";
            this.btnAlumno.UseVisualStyleBackColor = true;
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Profesores:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(939, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gestion Academica";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(248, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(393, 20);
            this.textBox1.TabIndex = 39;
            // 
            // btnHistorialCursos
            // 
            this.btnHistorialCursos.Location = new System.Drawing.Point(672, 135);
            this.btnHistorialCursos.Name = "btnHistorialCursos";
            this.btnHistorialCursos.Size = new System.Drawing.Size(87, 29);
            this.btnHistorialCursos.TabIndex = 38;
            this.btnHistorialCursos.Text = "Cargar Datos";
            this.btnHistorialCursos.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Historial de cursos:";
            // 
            // btnMenos2
            // 
            this.btnMenos2.BackgroundImage = global::ProyectoOOIA.Properties.Resources.menos;
            this.btnMenos2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenos2.Location = new System.Drawing.Point(720, 212);
            this.btnMenos2.Name = "btnMenos2";
            this.btnMenos2.Size = new System.Drawing.Size(30, 30);
            this.btnMenos2.TabIndex = 36;
            this.btnMenos2.UseVisualStyleBackColor = true;
            // 
            // btnMax2
            // 
            this.btnMax2.BackgroundImage = global::ProyectoOOIA.Properties.Resources.mas;
            this.btnMax2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMax2.Location = new System.Drawing.Point(672, 212);
            this.btnMax2.Name = "btnMax2";
            this.btnMax2.Size = new System.Drawing.Size(30, 30);
            this.btnMax2.TabIndex = 35;
            this.btnMax2.UseVisualStyleBackColor = true;
            // 
            // boxCategoria
            // 
            this.boxCategoria.Enabled = false;
            this.boxCategoria.Location = new System.Drawing.Point(248, 212);
            this.boxCategoria.Name = "boxCategoria";
            this.boxCategoria.Size = new System.Drawing.Size(393, 20);
            this.boxCategoria.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Categoria:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(125, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(634, 180);
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
            this.cmbNotas.Location = new System.Drawing.Point(248, 89);
            this.cmbNotas.Name = "cmbNotas";
            this.cmbNotas.Size = new System.Drawing.Size(393, 20);
            this.cmbNotas.TabIndex = 29;
            // 
            // btnNotas
            // 
            this.btnNotas.Location = new System.Drawing.Point(672, 84);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(87, 29);
            this.btnNotas.TabIndex = 28;
            this.btnNotas.Text = "Cargar Datos";
            this.btnNotas.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Notas";
            // 
            // cmbCurso
            // 
            this.cmbCurso.Enabled = false;
            this.cmbCurso.Location = new System.Drawing.Point(248, 42);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(393, 20);
            this.cmbCurso.TabIndex = 26;
            // 
            // btnCursos
            // 
            this.btnCursos.Location = new System.Drawing.Point(672, 37);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(87, 29);
            this.btnCursos.TabIndex = 25;
            this.btnCursos.Text = "Cargar Datos";
            this.btnCursos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cursos";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.boxAtencion);
            this.tabPage3.Controls.Add(this.btnCodigoAtencion);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(939, 466);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gestion Atencion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // boxAtencion
            // 
            this.boxAtencion.Enabled = false;
            this.boxAtencion.Location = new System.Drawing.Point(267, 69);
            this.boxAtencion.Name = "boxAtencion";
            this.boxAtencion.Size = new System.Drawing.Size(393, 20);
            this.boxAtencion.TabIndex = 29;
            // 
            // btnCodigoAtencion
            // 
            this.btnCodigoAtencion.Location = new System.Drawing.Point(691, 64);
            this.btnCodigoAtencion.Name = "btnCodigoAtencion";
            this.btnCodigoAtencion.Size = new System.Drawing.Size(87, 29);
            this.btnCodigoAtencion.TabIndex = 28;
            this.btnCodigoAtencion.Text = "Cargar Datos";
            this.btnCodigoAtencion.UseVisualStyleBackColor = true;
            this.btnCodigoAtencion.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Codigo de Atención:";
            // 
            // frmCargarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(947, 592);
            this.Controls.Add(this.panelGestionHumana);
            this.Controls.Add(this.panel1);
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