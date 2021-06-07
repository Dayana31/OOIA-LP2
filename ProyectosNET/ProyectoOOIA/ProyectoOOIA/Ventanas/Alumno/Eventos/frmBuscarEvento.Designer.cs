
namespace ProyectoOOIA.Ventanas
{
    partial class frmBuscarEventoAlumno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNombreEvento = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblBuscarEventos = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToDeleteRows = false;
            this.dgvEventos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.fecha,
            this.horaInicio,
            this.horaFin,
            this.categoria});
            this.dgvEventos.EnableHeadersVisualStyles = false;
            this.dgvEventos.Location = new System.Drawing.Point(20, 108);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.RowHeadersWidth = 51;
            this.dgvEventos.Size = new System.Drawing.Size(812, 316);
            this.dgvEventos.TabIndex = 36;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(736, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 26);
            this.button2.TabIndex = 35;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(533, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 26);
            this.button1.TabIndex = 34;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(267, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 23);
            this.textBox1.TabIndex = 33;
            // 
            // lblNombreEvento
            // 
            this.lblNombreEvento.AutoSize = true;
            this.lblNombreEvento.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEvento.Location = new System.Drawing.Point(16, 76);
            this.lblNombreEvento.Name = "lblNombreEvento";
            this.lblNombreEvento.Size = new System.Drawing.Size(236, 21);
            this.lblNombreEvento.TabIndex = 32;
            this.lblNombreEvento.Text = "Ingrese categoria o nombre de evento:";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 250;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 125;
            // 
            // horaInicio
            // 
            this.horaInicio.HeaderText = "Hora Inicio";
            this.horaInicio.MinimumWidth = 6;
            this.horaInicio.Name = "horaInicio";
            this.horaInicio.ReadOnly = true;
            this.horaInicio.Width = 120;
            // 
            // horaFin
            // 
            this.horaFin.HeaderText = "Hora Fin";
            this.horaFin.MinimumWidth = 6;
            this.horaFin.Name = "horaFin";
            this.horaFin.ReadOnly = true;
            this.horaFin.Width = 120;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.MinimumWidth = 6;
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 150;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.lblBuscarEventos);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(844, 71);
            this.pnlHeader.TabIndex = 38;
            // 
            // lblBuscarEventos
            // 
            this.lblBuscarEventos.AutoSize = true;
            this.lblBuscarEventos.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarEventos.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBuscarEventos.Location = new System.Drawing.Point(50, 24);
            this.lblBuscarEventos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarEventos.Name = "lblBuscarEventos";
            this.lblBuscarEventos.Size = new System.Drawing.Size(194, 30);
            this.lblBuscarEventos.TabIndex = 38;
            this.lblBuscarEventos.Text = "Buscador de Eventos";
            // 
            // btnBack
            // 
            this.btnBack.Image = global::ProyectoOOIA.Properties.Resources.arrowWhite;
            this.btnBack.Location = new System.Drawing.Point(21, 24);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 25);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 39;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmBuscarEventoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNombreEvento);
            this.Name = "frmBuscarEventoAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar evento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBuscarEventos;
        private System.Windows.Forms.PictureBox btnBack;
    }
}