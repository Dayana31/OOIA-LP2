﻿
namespace ProyectoOOIA.Ventanas
{
    partial class frmEliminarEventoAlum
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
            this.btnNo = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnSi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(54, 121);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(98, 23);
            this.btnNo.TabIndex = 9;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(61, 40);
            this.lblMensaje.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(263, 50);
            this.lblMensaje.TabIndex = 8;
            this.lblMensaje.Text = "¿Desea eliminar su inscripcion a este evento?";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSi
            // 
            this.btnSi.Location = new System.Drawing.Point(226, 121);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(98, 23);
            this.btnSi.TabIndex = 7;
            this.btnSi.Text = "Si";
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // frmEliminarEventoAlum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 204);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnSi);
            this.Name = "frmEliminarEventoAlum";
            this.Text = "frmEliminarEventoAlum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnSi;
    }
}