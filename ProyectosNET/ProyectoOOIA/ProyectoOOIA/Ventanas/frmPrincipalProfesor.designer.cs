﻿
namespace ProyectoOOIA.Ventanas
{
    partial class frmPrincipalProfesor
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.txtHorarios = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ovalPictureBox1 = new OvalPictureBox();
            this.panelEventos = new System.Windows.Forms.Panel();
            this.tarjetaEvento3 = new ProyectoOOIA.Componentes.CardEvento();
            this.tarjetaEvento2 = new ProyectoOOIA.Componentes.CardEvento();
            this.tarjetaEvento = new ProyectoOOIA.Componentes.CardEvento();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.imagenes = new System.Windows.Forms.PictureBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            this.panelEventos.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::ProyectoOOIA.Properties.Resources.Icono_Agenda_tu_Cita;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(285, 468);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(162, 145);
            this.button2.TabIndex = 25;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtHorarios
            // 
            this.txtHorarios.AutoSize = true;
            this.txtHorarios.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorarios.Location = new System.Drawing.Point(336, 438);
            this.txtHorarios.Name = "txtHorarios";
            this.txtHorarios.Size = new System.Drawing.Size(58, 27);
            this.txtHorarios.TabIndex = 19;
            this.txtHorarios.Text = "Citas";
            this.txtHorarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.txtHorarios.Click += new System.EventHandler(this.txtHorarios_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Transparent;
            this.txtUsername.Location = new System.Drawing.Point(115, 29);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(201, 27);
            this.txtUsername.TabIndex = 17;
            this.txtUsername.Text = "Solorzano Tapia, José";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.ovalPictureBox1);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 83);
            this.panel1.TabIndex = 28;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 83);
            this.splitter1.TabIndex = 24;
            this.splitter1.TabStop = false;
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox1.Image = global::ProyectoOOIA.Properties.Resources.Estudiante1;
            this.ovalPictureBox1.Location = new System.Drawing.Point(38, 10);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(71, 71);
            this.ovalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovalPictureBox1.TabIndex = 22;
            this.ovalPictureBox1.TabStop = false;
            // 
            // panelEventos
            // 
            this.panelEventos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEventos.Controls.Add(this.tarjetaEvento3);
            this.panelEventos.Controls.Add(this.tarjetaEvento2);
            this.panelEventos.Controls.Add(this.tarjetaEvento);
            this.panelEventos.Controls.Add(this.panel5);
            this.panelEventos.Location = new System.Drawing.Point(715, 121);
            this.panelEventos.Name = "panelEventos";
            this.panelEventos.Size = new System.Drawing.Size(286, 504);
            this.panelEventos.TabIndex = 29;
            // 
            // tarjetaEvento3
            // 
            this.tarjetaEvento3.Location = new System.Drawing.Point(5, 278);
            this.tarjetaEvento3.Name = "tarjetaEvento3";
            this.tarjetaEvento3.Size = new System.Drawing.Size(280, 129);
            this.tarjetaEvento3.TabIndex = 3;
            // 
            // tarjetaEvento2
            // 
            this.tarjetaEvento2.Location = new System.Drawing.Point(5, 177);
            this.tarjetaEvento2.Name = "tarjetaEvento2";
            this.tarjetaEvento2.Size = new System.Drawing.Size(280, 129);
            this.tarjetaEvento2.TabIndex = 2;
            // 
            // tarjetaEvento
            // 
            this.tarjetaEvento.Location = new System.Drawing.Point(5, 76);
            this.tarjetaEvento.Name = "tarjetaEvento";
            this.tarjetaEvento.Size = new System.Drawing.Size(280, 129);
            this.tarjetaEvento.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(20, 21);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(179, 49);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eventos Proximos";
            // 
            // imagenes
            // 
            this.imagenes.Location = new System.Drawing.Point(120, 121);
            this.imagenes.Name = "imagenes";
            this.imagenes.Size = new System.Drawing.Size(499, 283);
            this.imagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenes.TabIndex = 30;
            this.imagenes.TabStop = false;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImage = global::ProyectoOOIA.Properties.Resources.log_out__1_;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(1070, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(35, 34);
            this.btnAtras.TabIndex = 23;
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ProyectoOOIA.Properties.Resources.log_out__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(966, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 34);
            this.button1.TabIndex = 25;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmPrincipalProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1013, 637);
            this.Controls.Add(this.imagenes);
            this.Controls.Add(this.panelEventos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtHorarios);
            this.MaximizeBox = false;
            this.Name = "frmPrincipalProfesor";
            this.Text = "Menú Principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            this.panelEventos.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private OvalPictureBox ovalPictureBox1;
        private System.Windows.Forms.Label txtHorarios;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelEventos;
        private Componentes.CardEvento tarjetaEvento3;
        private Componentes.CardEvento tarjetaEvento2;
        private Componentes.CardEvento tarjetaEvento;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imagenes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Timer timer1;
    }
}