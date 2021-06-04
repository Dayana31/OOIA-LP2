
namespace ProyectoOOIA.Ventanas
{
    partial class frmOpiniones
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
            this.lbOpiniones = new System.Windows.Forms.Label();
            this.dgvOpiniones = new System.Windows.Forms.DataGridView();
            this.FotoDePerfil = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opinion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpiniones)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOpiniones
            // 
            this.lbOpiniones.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOpiniones.Location = new System.Drawing.Point(13, 11);
            this.lbOpiniones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOpiniones.Name = "lbOpiniones";
            this.lbOpiniones.Size = new System.Drawing.Size(161, 58);
            this.lbOpiniones.TabIndex = 0;
            this.lbOpiniones.Text = "Opiniones";
            this.lbOpiniones.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvOpiniones
            // 
            this.dgvOpiniones.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOpiniones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOpiniones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpiniones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FotoDePerfil,
            this.Nombre,
            this.Opinion});
            this.dgvOpiniones.EnableHeadersVisualStyles = false;
            this.dgvOpiniones.Location = new System.Drawing.Point(16, 73);
            this.dgvOpiniones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOpiniones.Name = "dgvOpiniones";
            this.dgvOpiniones.RowHeadersWidth = 51;
            this.dgvOpiniones.Size = new System.Drawing.Size(1028, 448);
            this.dgvOpiniones.TabIndex = 4;
            // 
            // FotoDePerfil
            // 
            this.FotoDePerfil.HeaderText = "Foto de perfil";
            this.FotoDePerfil.MinimumWidth = 6;
            this.FotoDePerfil.Name = "FotoDePerfil";
            this.FotoDePerfil.Width = 130;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 230;
            // 
            // Opinion
            // 
            this.Opinion.HeaderText = "Opinion";
            this.Opinion.MinimumWidth = 6;
            this.Opinion.Name = "Opinion";
            this.Opinion.Width = 380;
            // 
            // frmOpiniones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvOpiniones);
            this.Controls.Add(this.lbOpiniones);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmOpiniones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opiniones de tutores y psicologos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpiniones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbOpiniones;
        private System.Windows.Forms.DataGridView dgvOpiniones;
        private System.Windows.Forms.DataGridViewImageColumn FotoDePerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opinion;
    }
}