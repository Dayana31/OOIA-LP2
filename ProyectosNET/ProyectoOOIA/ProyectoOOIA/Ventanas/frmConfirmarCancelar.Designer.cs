
namespace ProyectoOOIA.Ventanas
{
    partial class frmConfirmarCancelar
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
            this.btnSi = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSi
            // 
            this.btnSi.Location = new System.Drawing.Point(325, 169);
            this.btnSi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(131, 28);
            this.btnSi.TabIndex = 0;
            this.btnSi.Text = "Si";
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(91, 57);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(307, 62);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.Text = "¿Está seguro que desea cancelar la cita?";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(55, 169);
            this.btnNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(131, 28);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // frmConfirmarCancelar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(512, 233);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnSi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConfirmarCancelar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnNo;
    }
}