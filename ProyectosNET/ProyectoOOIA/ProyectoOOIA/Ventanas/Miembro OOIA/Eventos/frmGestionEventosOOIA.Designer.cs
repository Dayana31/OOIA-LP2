﻿
namespace ProyectoOOIA.Ventanas
{
    partial class frmGestionEventosOOIA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionEventosOOIA));
            this.btnBack = new System.Windows.Forms.Button();
            this.agregarImagen = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.txtNombrePonente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregarPonente = new System.Windows.Forms.Button();
            this.btnEliminarPonente = new System.Windows.Forms.Button();
            this.btnBuscarPonente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NombreCompletoPonente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPonentes = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdEvento = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.npdCapacidad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpFechaEvento = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtHoraFin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::ProyectoOOIA.Properties.Resources.arrow;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(757, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(22, 25);
            this.btnBack.TabIndex = 42;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // agregarImagen
            // 
            this.agregarImagen.FileName = "openFileDialog1";
            this.agregarImagen.Filter = "Imagen jpg|*.jpg|Imagen pgn|*.png";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnBuscar,
            this.btnModificar,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(797, 25);
            this.toolStrip1.TabIndex = 43;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(46, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.ToolTipText = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(53, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(46, 22);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(62, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNombrePonente
            // 
            this.txtNombrePonente.Location = new System.Drawing.Point(132, 19);
            this.txtNombrePonente.Name = "txtNombrePonente";
            this.txtNombrePonente.Size = new System.Drawing.Size(566, 20);
            this.txtNombrePonente.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nombre del ponente:";
            // 
            // btnAgregarPonente
            // 
            this.btnAgregarPonente.Location = new System.Drawing.Point(445, 44);
            this.btnAgregarPonente.Name = "btnAgregarPonente";
            this.btnAgregarPonente.Size = new System.Drawing.Size(145, 23);
            this.btnAgregarPonente.TabIndex = 19;
            this.btnAgregarPonente.Text = "Agregar Ponente";
            this.btnAgregarPonente.UseVisualStyleBackColor = true;
            this.btnAgregarPonente.Click += new System.EventHandler(this.btnAgregarPonente_Click);
            // 
            // btnEliminarPonente
            // 
            this.btnEliminarPonente.Location = new System.Drawing.Point(596, 44);
            this.btnEliminarPonente.Name = "btnEliminarPonente";
            this.btnEliminarPonente.Size = new System.Drawing.Size(145, 23);
            this.btnEliminarPonente.TabIndex = 20;
            this.btnEliminarPonente.Text = "Eliminar Ponente";
            this.btnEliminarPonente.UseVisualStyleBackColor = true;
            this.btnEliminarPonente.Click += new System.EventHandler(this.btnEliminarPonente_Click);
            // 
            // btnBuscarPonente
            // 
            this.btnBuscarPonente.Location = new System.Drawing.Point(704, 19);
            this.btnBuscarPonente.Name = "btnBuscarPonente";
            this.btnBuscarPonente.Size = new System.Drawing.Size(38, 20);
            this.btnBuscarPonente.TabIndex = 48;
            this.btnBuscarPonente.Text = "...";
            this.btnBuscarPonente.UseVisualStyleBackColor = true;
            this.btnBuscarPonente.Click += new System.EventHandler(this.btnBuscarPonente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPonentes);
            this.groupBox1.Controls.Add(this.btnBuscarPonente);
            this.groupBox1.Controls.Add(this.btnEliminarPonente);
            this.groupBox1.Controls.Add(this.btnAgregarPonente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNombrePonente);
            this.groupBox1.Location = new System.Drawing.Point(12, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 202);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ponentes";
            // 
            // NombreCompletoPonente
            // 
            this.NombreCompletoPonente.HeaderText = "Nombre completo del ponente";
            this.NombreCompletoPonente.MinimumWidth = 6;
            this.NombreCompletoPonente.Name = "NombreCompletoPonente";
            this.NombreCompletoPonente.ReadOnly = true;
            this.NombreCompletoPonente.Width = 700;
            // 
            // dgvPonentes
            // 
            this.dgvPonentes.AllowUserToAddRows = false;
            this.dgvPonentes.AllowUserToDeleteRows = false;
            this.dgvPonentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCompletoPonente});
            this.dgvPonentes.Location = new System.Drawing.Point(9, 63);
            this.dgvPonentes.Name = "dgvPonentes";
            this.dgvPonentes.ReadOnly = true;
            this.dgvPonentes.RowHeadersWidth = 51;
            this.dgvPonentes.Size = new System.Drawing.Size(758, 133);
            this.dgvPonentes.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "id Evento:";
            // 
            // txtIdEvento
            // 
            this.txtIdEvento.Location = new System.Drawing.Point(144, 88);
            this.txtIdEvento.Name = "txtIdEvento";
            this.txtIdEvento.Size = new System.Drawing.Size(366, 20);
            this.txtIdEvento.TabIndex = 69;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(527, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(144, 200);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(138, 20);
            this.txtLugar.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nombre del evento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "Lugar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Fecha:";
            // 
            // npdCapacidad
            // 
            this.npdCapacidad.Location = new System.Drawing.Point(368, 233);
            this.npdCapacidad.Name = "npdCapacidad";
            this.npdCapacidad.Size = new System.Drawing.Size(142, 20);
            this.npdCapacidad.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Hora inicio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Capacidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Hora fin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Descripcion del evento:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(144, 118);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(366, 20);
            this.txtNombre.TabIndex = 55;
            // 
            // dtpFechaEvento
            // 
            this.dtpFechaEvento.Location = new System.Drawing.Point(144, 147);
            this.dtpFechaEvento.Name = "dtpFechaEvento";
            this.dtpFechaEvento.Size = new System.Drawing.Size(366, 20);
            this.dtpFechaEvento.TabIndex = 56;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(565, 88);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(162, 23);
            this.btnAgregarImagen.TabIndex = 62;
            this.btnAgregarImagen.Text = "Agregar imagen";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtHoraInicio.Location = new System.Drawing.Point(144, 174);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(138, 20);
            this.txtHoraInicio.TabIndex = 57;
            this.txtHoraInicio.Text = "Ejempo 15:30";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(144, 226);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(138, 21);
            this.cboCategoria.TabIndex = 61;
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtHoraFin.Location = new System.Drawing.Point(368, 170);
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.Size = new System.Drawing.Size(143, 20);
            this.txtHoraFin.TabIndex = 58;
            this.txtHoraFin.Text = "Ejempo 15:30";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Categoria:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(144, 262);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(367, 62);
            this.txtDescripcion.TabIndex = 59;
            this.txtDescripcion.Text = "";
            // 
            // frmGestionEventosOOIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 570);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtIdEvento);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoraFin);
            this.Controls.Add(this.npdCapacidad);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechaEvento);
            this.Controls.Add(this.label5);
            this.Name = "frmGestionEventosOOIA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar eventos";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCapacidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.OpenFileDialog agregarImagen;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.TextBox txtNombrePonente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregarPonente;
        private System.Windows.Forms.Button btnEliminarPonente;
        private System.Windows.Forms.Button btnBuscarPonente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPonentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompletoPonente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdEvento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown npdCapacidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaEvento;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txtHoraFin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtDescripcion;
    }
}