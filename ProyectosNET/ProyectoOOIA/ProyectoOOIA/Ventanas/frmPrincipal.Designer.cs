﻿
namespace ProyectoOOIA.Ventanas
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCargaDatos = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnEventos = new System.Windows.Forms.Button();
            this.txtEventos = new System.Windows.Forms.Label();
            this.btnCitas = new System.Windows.Forms.Button();
            this.txtCitas = new System.Windows.Forms.Label();
            this.pnlCitas = new System.Windows.Forms.Panel();
            this.pnlEventos = new System.Windows.Forms.Panel();
            this.pnlEventosProximos = new System.Windows.Forms.Panel();
            this.pnlEventosProx = new System.Windows.Forms.Panel();
            this.lblEventosProximos = new System.Windows.Forms.Label();
            this.imagenes = new System.Windows.Forms.PictureBox();
            this.ImageTimer = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlTramites = new System.Windows.Forms.Panel();
            this.btnTramites = new System.Windows.Forms.Button();
            this.lblTramites = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlCitas.SuspendLayout();
            this.pnlEventos.SuspendLayout();
            this.pnlEventosProximos.SuspendLayout();
            this.pnlEventosProx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenes)).BeginInit();
            this.pnlTramites.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.btnCargaDatos);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 102);
            this.panel1.TabIndex = 18;
            // 
            // btnCargaDatos
            // 
            this.btnCargaDatos.FlatAppearance.BorderSize = 0;
            this.btnCargaDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargaDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaDatos.ForeColor = System.Drawing.Color.White;
            this.btnCargaDatos.Location = new System.Drawing.Point(935, 30);
            this.btnCargaDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargaDatos.Name = "btnCargaDatos";
            this.btnCargaDatos.Size = new System.Drawing.Size(171, 57);
            this.btnCargaDatos.TabIndex = 13;
            this.btnCargaDatos.Text = "Cargar Datos";
            this.btnCargaDatos.UseVisualStyleBackColor = true;
            this.btnCargaDatos.Click += new System.EventHandler(this.btnCargaDatos_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(153, 36);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(289, 38);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Solorzano Tapia, José";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImage = global::ProyectoOOIA.Properties.Resources.log_out__1_;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(1289, 37);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(47, 42);
            this.btnAtras.TabIndex = 12;
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.BackColor = System.Drawing.Color.Transparent;
            this.btnEventos.BackgroundImage = global::ProyectoOOIA.Properties.Resources.foto_29;
            this.btnEventos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEventos.FlatAppearance.BorderSize = 0;
            this.btnEventos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEventos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventos.Location = new System.Drawing.Point(8, 41);
            this.btnEventos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEventos.Size = new System.Drawing.Size(303, 210);
            this.btnEventos.TabIndex = 22;
            this.btnEventos.UseVisualStyleBackColor = false;
            this.btnEventos.Click += new System.EventHandler(this.botonEventos_Click);
            // 
            // txtEventos
            // 
            this.txtEventos.AutoSize = true;
            this.txtEventos.Font = new System.Drawing.Font("Gill Sans MT", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventos.ForeColor = System.Drawing.Color.Black;
            this.txtEventos.Location = new System.Drawing.Point(104, 5);
            this.txtEventos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEventos.Name = "txtEventos";
            this.txtEventos.Size = new System.Drawing.Size(124, 40);
            this.txtEventos.TabIndex = 20;
            this.txtEventos.Text = "Eventos";
            // 
            // btnCitas
            // 
            this.btnCitas.AccessibleDescription = "Hola cliente";
            this.btnCitas.AccessibleName = "hola";
            this.btnCitas.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnCitas.BackColor = System.Drawing.Color.Transparent;
            this.btnCitas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCitas.BackgroundImage")));
            this.btnCitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitas.FlatAppearance.BorderSize = 0;
            this.btnCitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCitas.Location = new System.Drawing.Point(7, 48);
            this.btnCitas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCitas.Size = new System.Drawing.Size(296, 207);
            this.btnCitas.TabIndex = 21;
            this.btnCitas.UseVisualStyleBackColor = false;
            this.btnCitas.Click += new System.EventHandler(this.botonCitas_Click);
            // 
            // txtCitas
            // 
            this.txtCitas.AutoSize = true;
            this.txtCitas.Font = new System.Drawing.Font("Gill Sans MT", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCitas.ForeColor = System.Drawing.Color.Black;
            this.txtCitas.Location = new System.Drawing.Point(107, 12);
            this.txtCitas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCitas.Name = "txtCitas";
            this.txtCitas.Size = new System.Drawing.Size(86, 40);
            this.txtCitas.TabIndex = 19;
            this.txtCitas.Text = "Citas";
            this.txtCitas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCitas
            // 
            this.pnlCitas.Controls.Add(this.btnCitas);
            this.pnlCitas.Controls.Add(this.txtCitas);
            this.pnlCitas.Location = new System.Drawing.Point(305, 492);
            this.pnlCitas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCitas.Name = "pnlCitas";
            this.pnlCitas.Size = new System.Drawing.Size(311, 258);
            this.pnlCitas.TabIndex = 23;
            // 
            // pnlEventos
            // 
            this.pnlEventos.Controls.Add(this.txtEventos);
            this.pnlEventos.Controls.Add(this.btnEventos);
            this.pnlEventos.Location = new System.Drawing.Point(616, 496);
            this.pnlEventos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlEventos.Name = "pnlEventos";
            this.pnlEventos.Size = new System.Drawing.Size(317, 255);
            this.pnlEventos.TabIndex = 24;
            // 
            // pnlEventosProximos
            // 
            this.pnlEventosProximos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlEventosProximos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEventosProximos.Controls.Add(this.pnlEventosProx);
            this.pnlEventosProximos.Location = new System.Drawing.Point(935, 101);
            this.pnlEventosProximos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlEventosProximos.Name = "pnlEventosProximos";
            this.pnlEventosProximos.Size = new System.Drawing.Size(415, 649);
            this.pnlEventosProximos.TabIndex = 25;
            // 
            // pnlEventosProx
            // 
            this.pnlEventosProx.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlEventosProx.Controls.Add(this.lblEventosProximos);
            this.pnlEventosProx.Location = new System.Drawing.Point(-1, -1);
            this.pnlEventosProx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlEventosProx.Name = "pnlEventosProx";
            this.pnlEventosProx.Size = new System.Drawing.Size(427, 86);
            this.pnlEventosProx.TabIndex = 0;
            // 
            // lblEventosProximos
            // 
            this.lblEventosProximos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventosProximos.AutoSize = true;
            this.lblEventosProximos.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventosProximos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEventosProximos.Location = new System.Drawing.Point(75, 30);
            this.lblEventosProximos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventosProximos.Name = "lblEventosProximos";
            this.lblEventosProximos.Size = new System.Drawing.Size(248, 38);
            this.lblEventosProximos.TabIndex = 0;
            this.lblEventosProximos.Text = "Eventos Próximos";
            this.lblEventosProximos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imagenes
            // 
            this.imagenes.Location = new System.Drawing.Point(0, 101);
            this.imagenes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imagenes.Name = "imagenes";
            this.imagenes.Size = new System.Drawing.Size(933, 394);
            this.imagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenes.TabIndex = 26;
            this.imagenes.TabStop = false;
            this.imagenes.Click += new System.EventHandler(this.imagenes_Click);
            // 
            // ImageTimer
            // 
            this.ImageTimer.Enabled = true;
            this.ImageTimer.Interval = 5000;
            this.ImageTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "EEGGCC.jpg");
            this.imageList1.Images.SetKeyName(1, "Estudiante.png");
            this.imageList1.Images.SetKeyName(2, "foto-29.jpg");
            this.imageList1.Images.SetKeyName(3, "pexels-pixabay-261621.jpg");
            // 
            // pnlTramites
            // 
            this.pnlTramites.Controls.Add(this.btnTramites);
            this.pnlTramites.Controls.Add(this.lblTramites);
            this.pnlTramites.Location = new System.Drawing.Point(0, 496);
            this.pnlTramites.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTramites.Name = "pnlTramites";
            this.pnlTramites.Size = new System.Drawing.Size(304, 251);
            this.pnlTramites.TabIndex = 24;
            // 
            // btnTramites
            // 
            this.btnTramites.AccessibleDescription = "Hola cliente";
            this.btnTramites.AccessibleName = "hola";
            this.btnTramites.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnTramites.BackColor = System.Drawing.Color.Transparent;
            this.btnTramites.BackgroundImage = global::ProyectoOOIA.Properties.Resources.pexels_pixabay_261621;
            this.btnTramites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTramites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTramites.Enabled = false;
            this.btnTramites.FlatAppearance.BorderSize = 0;
            this.btnTramites.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTramites.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTramites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTramites.Location = new System.Drawing.Point(4, 48);
            this.btnTramites.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTramites.Name = "btnTramites";
            this.btnTramites.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTramites.Size = new System.Drawing.Size(293, 199);
            this.btnTramites.TabIndex = 21;
            this.btnTramites.UseVisualStyleBackColor = false;
            // 
            // lblTramites
            // 
            this.lblTramites.AutoSize = true;
            this.lblTramites.BackColor = System.Drawing.SystemColors.Control;
            this.lblTramites.Enabled = false;
            this.lblTramites.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramites.ForeColor = System.Drawing.Color.Black;
            this.lblTramites.Location = new System.Drawing.Point(87, 5);
            this.lblTramites.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramites.Name = "lblTramites";
            this.lblTramites.Size = new System.Drawing.Size(133, 38);
            this.lblTramites.TabIndex = 19;
            this.lblTramites.Text = "Trámites";
            this.lblTramites.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 752);
            this.Controls.Add(this.pnlTramites);
            this.Controls.Add(this.imagenes);
            this.Controls.Add(this.pnlEventosProximos);
            this.Controls.Add(this.pnlEventos);
            this.Controls.Add(this.pnlCitas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCitas.ResumeLayout(false);
            this.pnlCitas.PerformLayout();
            this.pnlEventos.ResumeLayout(false);
            this.pnlEventos.PerformLayout();
            this.pnlEventosProximos.ResumeLayout(false);
            this.pnlEventosProx.ResumeLayout(false);
            this.pnlEventosProx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenes)).EndInit();
            this.pnlTramites.ResumeLayout(false);
            this.pnlTramites.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Label txtEventos;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Label txtCitas;
        private System.Windows.Forms.Panel pnlCitas;
        private System.Windows.Forms.Panel pnlEventos;
        private System.Windows.Forms.Panel pnlEventosProximos;
        private System.Windows.Forms.Panel pnlEventosProx;
        private System.Windows.Forms.Label lblEventosProximos;
        private System.Windows.Forms.PictureBox imagenes;
        private System.Windows.Forms.Timer ImageTimer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlTramites;
        private System.Windows.Forms.Button btnTramites;
        private System.Windows.Forms.Label lblTramites;
        private System.Windows.Forms.Button btnCargaDatos;
    }
}