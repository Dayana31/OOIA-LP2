
namespace ProyectoOOIA.Ventanas
{
    partial class frmCancelarCita
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
            this.lblCancelarCitaTiulo = new System.Windows.Forms.Label();
            this.lblCancelarCitaDescripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCancelarCita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCancelarCitaTiulo
            // 
            this.lblCancelarCitaTiulo.AutoSize = true;
            this.lblCancelarCitaTiulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelarCitaTiulo.Location = new System.Drawing.Point(176, 9);
            this.lblCancelarCitaTiulo.Name = "lblCancelarCitaTiulo";
            this.lblCancelarCitaTiulo.Size = new System.Drawing.Size(216, 29);
            this.lblCancelarCitaTiulo.TabIndex = 0;
            this.lblCancelarCitaTiulo.Text = "Horario Reservado";
            this.lblCancelarCitaTiulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCancelarCitaTiulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCancelarCitaDescripcion
            // 
            this.lblCancelarCitaDescripcion.AutoSize = true;
            this.lblCancelarCitaDescripcion.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCancelarCitaDescripcion.Location = new System.Drawing.Point(12, 59);
            this.lblCancelarCitaDescripcion.MaximumSize = new System.Drawing.Size(570, 0);
            this.lblCancelarCitaDescripcion.Name = "lblCancelarCitaDescripcion";
            this.lblCancelarCitaDescripcion.Size = new System.Drawing.Size(559, 26);
            this.lblCancelarCitaDescripcion.TabIndex = 1;
            this.lblCancelarCitaDescripcion.Text = "Tiene una cita reservada con un alumno en el hoaraio reservado. Si desea cancelar" +
    " la cita, se le notificará al alumno por correo y se le dará la oportunidad de r" +
    "eprogramar la cita en otro horario. ";
            this.lblCancelarCitaDescripcion.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.MaximumSize = new System.Drawing.Size(570, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escriba su justificación para la cancelación de la cita.";
            this.label1.UseMnemonic = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 116);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(556, 222);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(15, 370);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(116, 23);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCancelarCita
            // 
            this.btnCancelarCita.Location = new System.Drawing.Point(455, 370);
            this.btnCancelarCita.Name = "btnCancelarCita";
            this.btnCancelarCita.Size = new System.Drawing.Size(116, 23);
            this.btnCancelarCita.TabIndex = 5;
            this.btnCancelarCita.Text = "Cancelar Cita";
            this.btnCancelarCita.UseVisualStyleBackColor = true;
            this.btnCancelarCita.Click += new System.EventHandler(this.btnCancelarCita_Click);
            // 
            // frmCancelarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.btnCancelarCita);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCancelarCitaDescripcion);
            this.Controls.Add(this.lblCancelarCitaTiulo);
            this.Name = "frmCancelarCita";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCancelarCitaTiulo;
        private System.Windows.Forms.Label lblCancelarCitaDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCancelarCita;
    }
}