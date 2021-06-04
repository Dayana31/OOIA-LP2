
namespace ProyectoOOIA.Ventanas
{
    partial class frmDetalleCita
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrientador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.txtHoraFin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoAtencion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMotivoConsulta = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 90);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle de la cita";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnRegresar.Location = new System.Drawing.Point(723, 336);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(126, 27);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Orientador";
            // 
            // txtOrientador
            // 
            this.txtOrientador.Enabled = false;
            this.txtOrientador.Location = new System.Drawing.Point(29, 48);
            this.txtOrientador.Name = "txtOrientador";
            this.txtOrientador.ReadOnly = true;
            this.txtOrientador.Size = new System.Drawing.Size(326, 22);
            this.txtOrientador.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(29, 139);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(326, 22);
            this.txtFecha.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hora inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hora fin";
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Enabled = false;
            this.txtHoraInicio.Location = new System.Drawing.Point(29, 238);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.ReadOnly = true;
            this.txtHoraInicio.Size = new System.Drawing.Size(132, 22);
            this.txtHoraInicio.TabIndex = 12;
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.Enabled = false;
            this.txtHoraFin.Location = new System.Drawing.Point(218, 238);
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.ReadOnly = true;
            this.txtHoraFin.Size = new System.Drawing.Size(137, 22);
            this.txtHoraFin.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "Código de atención";
            // 
            // txtCodigoAtencion
            // 
            this.txtCodigoAtencion.Enabled = false;
            this.txtCodigoAtencion.Location = new System.Drawing.Point(429, 238);
            this.txtCodigoAtencion.Name = "txtCodigoAtencion";
            this.txtCodigoAtencion.ReadOnly = true;
            this.txtCodigoAtencion.Size = new System.Drawing.Size(420, 22);
            this.txtCodigoAtencion.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(426, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 27);
            this.label7.TabIndex = 16;
            this.label7.Text = "Motivo de consulta";
            // 
            // txtMotivoConsulta
            // 
            this.txtMotivoConsulta.Enabled = false;
            this.txtMotivoConsulta.Location = new System.Drawing.Point(429, 48);
            this.txtMotivoConsulta.Multiline = true;
            this.txtMotivoConsulta.Name = "txtMotivoConsulta";
            this.txtMotivoConsulta.ReadOnly = true;
            this.txtMotivoConsulta.Size = new System.Drawing.Size(420, 113);
            this.txtMotivoConsulta.TabIndex = 17;
            this.txtMotivoConsulta.Text = "\r\n\r\n\r\n\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtMotivoConsulta);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtCodigoAtencion);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtHoraFin);
            this.panel2.Controls.Add(this.txtHoraInicio);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtFecha);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtOrientador);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnRegresar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 400);
            this.panel2.TabIndex = 3;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(226, 294);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 31);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(135, 296);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 31);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sí";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 27);
            this.label8.TabIndex = 18;
            this.label8.Text = "Asistencia";
            // 
            // frmDetalleCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 490);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetalleCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetalleCita";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrientador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.TextBox txtHoraFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoAtencion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMotivoConsulta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label8;
    }
}