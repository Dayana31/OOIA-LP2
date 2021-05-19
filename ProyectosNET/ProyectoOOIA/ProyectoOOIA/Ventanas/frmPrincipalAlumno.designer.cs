
namespace ProyectoOOIA.Ventanas
{
    partial class frmPrincipalAlumno
{
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
            this.txtUsername = new System.Windows.Forms.Label();
            this.txtEventos = new System.Windows.Forms.Label();
            this.txtCitas = new System.Windows.Forms.Label();
            this.txtTramites = new System.Windows.Forms.Label();
            this.txtHorarios = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.ovalPictureBox1 = new OvalPictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(125, 39);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(337, 37);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Solorzano Tapia, José";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // txtEventos
            // 
            this.txtEventos.AutoSize = true;
            this.txtEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventos.Location = new System.Drawing.Point(219, 314);
            this.txtEventos.Name = "txtEventos";
            this.txtEventos.Size = new System.Drawing.Size(78, 24);
            this.txtEventos.TabIndex = 8;
            this.txtEventos.Text = "Eventos";
            this.txtEventos.Click += new System.EventHandler(this.txtEventos_Click);
            // 
            // txtCitas
            // 
            this.txtCitas.AutoSize = true;
            this.txtCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCitas.Location = new System.Drawing.Point(229, 103);
            this.txtCitas.Name = "txtCitas";
            this.txtCitas.Size = new System.Drawing.Size(50, 24);
            this.txtCitas.TabIndex = 6;
            this.txtCitas.Text = "Citas";
            this.txtCitas.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTramites
            // 
            this.txtTramites.AutoSize = true;
            this.txtTramites.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTramites.Location = new System.Drawing.Point(613, 314);
            this.txtTramites.Name = "txtTramites";
            this.txtTramites.Size = new System.Drawing.Size(82, 24);
            this.txtTramites.TabIndex = 9;
            this.txtTramites.Text = "Trámites";
            this.txtTramites.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtTramites.Click += new System.EventHandler(this.txtTramites_Click);
            // 
            // txtHorarios
            // 
            this.txtHorarios.AutoSize = true;
            this.txtHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorarios.Location = new System.Drawing.Point(613, 103);
            this.txtHorarios.Name = "txtHorarios";
            this.txtHorarios.Size = new System.Drawing.Size(81, 24);
            this.txtHorarios.TabIndex = 7;
            this.txtHorarios.Text = "Horarios";
            this.txtHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtHorarios.Click += new System.EventHandler(this.txtHorarios_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Image = global::ProyectoOOIA.Properties.Resources.log_out__2_;
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(889, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(35, 34);
            this.btnAtras.TabIndex = 12;
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.button1_Click);
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox1.Image = global::ProyectoOOIA.Properties.Resources.Estudiante1;
            this.ovalPictureBox1.Location = new System.Drawing.Point(40, 29);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(64, 71);
            this.ovalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovalPictureBox1.TabIndex = 11;
            this.ovalPictureBox1.TabStop = false;
            this.ovalPictureBox1.Click += new System.EventHandler(this.ovalPictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ProyectoOOIA.Properties.Resources.B2B_Appointment_Setting_Services;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(181, 143);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(162, 145);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::ProyectoOOIA.Properties.Resources.Icono_Agenda_tu_Cita;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(577, 143);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(162, 145);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::ProyectoOOIA.Properties.Resources.pexels_pixabay_261621;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(577, 341);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(162, 145);
            this.button3.TabIndex = 15;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::ProyectoOOIA.Properties.Resources.foto_29;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(181, 341);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(162, 145);
            this.button4.TabIndex = 16;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmPrincipalAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(936, 523);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.ovalPictureBox1);
            this.Controls.Add(this.txtTramites);
            this.Controls.Add(this.txtEventos);
            this.Controls.Add(this.txtHorarios);
            this.Controls.Add(this.txtCitas);
            this.Controls.Add(this.txtUsername);
            this.MaximizeBox = false;
            this.Name = "frmPrincipalAlumno";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label txtUsername;
    private System.Windows.Forms.Label txtEventos;
    private System.Windows.Forms.Label txtCitas;
    private System.Windows.Forms.Label txtTramites;
    private System.Windows.Forms.Label txtHorarios;
        private OvalPictureBox ovalPictureBox1;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

