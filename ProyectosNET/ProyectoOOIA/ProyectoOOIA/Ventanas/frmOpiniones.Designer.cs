
namespace ProyectoOOIA.Ventanas
{   /// <summary>
/// Pantalla de opiniones 
/// </summary>
/// //raaaaa
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOpiniones = new System.Windows.Forms.Label();
            this.lblBuscarOpinion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscarOpinion = new System.Windows.Forms.Button();
            this.dgvOpiniones = new System.Windows.Forms.DataGridView();
            this.ImagenTutorPsicologo = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opinion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpiniones)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoOOIA.Properties.Resources.log_out__2_;
            this.pictureBox1.Location = new System.Drawing.Point(766, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 23);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblOpiniones
            // 
            this.lblOpiniones.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblOpiniones.Location = new System.Drawing.Point(0, 9);
            this.lblOpiniones.Name = "lblOpiniones";
            this.lblOpiniones.Size = new System.Drawing.Size(115, 46);
            this.lblOpiniones.TabIndex = 2;
            this.lblOpiniones.Text = "Opiniones";
            this.lblOpiniones.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBuscarOpinion
            // 
            this.lblBuscarOpinion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblBuscarOpinion.Location = new System.Drawing.Point(276, 29);
            this.lblBuscarOpinion.Name = "lblBuscarOpinion";
            this.lblBuscarOpinion.Size = new System.Drawing.Size(153, 23);
            this.lblBuscarOpinion.TabIndex = 3;
            this.lblBuscarOpinion.Text = "Ingrese nombre";
            this.lblBuscarOpinion.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(421, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBuscarOpinion
            // 
            this.btnBuscarOpinion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnBuscarOpinion.Location = new System.Drawing.Point(672, 28);
            this.btnBuscarOpinion.Name = "btnBuscarOpinion";
            this.btnBuscarOpinion.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarOpinion.TabIndex = 5;
            this.btnBuscarOpinion.Text = "Buscar";
            this.btnBuscarOpinion.UseVisualStyleBackColor = true;
            // 
            // dgvOpiniones
            // 
            this.dgvOpiniones.AllowUserToAddRows = false;
            this.dgvOpiniones.AllowUserToDeleteRows = false;
            this.dgvOpiniones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpiniones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImagenTutorPsicologo,
            this.Nombre,
            this.Opinion});
            this.dgvOpiniones.Location = new System.Drawing.Point(12, 67);
            this.dgvOpiniones.Name = "dgvOpiniones";
            this.dgvOpiniones.ReadOnly = true;
            this.dgvOpiniones.Size = new System.Drawing.Size(776, 362);
            this.dgvOpiniones.TabIndex = 6;
            this.dgvOpiniones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOpiniones_CellContentClick);
            // 
            // ImagenTutorPsicologo
            // 
            this.ImagenTutorPsicologo.HeaderText = "Foto de perfil";
            this.ImagenTutorPsicologo.Name = "ImagenTutorPsicologo";
            this.ImagenTutorPsicologo.ReadOnly = true;
            this.ImagenTutorPsicologo.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Opinion
            // 
            this.Opinion.HeaderText = "Opinion";
            this.Opinion.Name = "Opinion";
            this.Opinion.ReadOnly = true;
            this.Opinion.Width = 380;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvOpiniones);
            this.Controls.Add(this.btnBuscarOpinion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBuscarOpinion);
            this.Controls.Add(this.lblOpiniones);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Opiniones tutores y psicologos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpiniones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblOpiniones;
        private System.Windows.Forms.Label lblBuscarOpinion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscarOpinion;
        private System.Windows.Forms.DataGridView dgvOpiniones;
        private System.Windows.Forms.DataGridViewImageColumn ImagenTutorPsicologo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opinion;
    }
}