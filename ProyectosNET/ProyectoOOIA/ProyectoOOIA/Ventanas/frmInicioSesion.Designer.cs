﻿
namespace ProyectoOOIA.Ventanas
{
    partial class frmInicioSesion
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIncorrecto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkContraseña = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCorreo = new System.Windows.Forms.ToolStripButton();
            this.btnCelular = new System.Windows.Forms.ToolStripButton();
            this.btnTelefono = new System.Windows.Forms.ToolStripButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toggle1 = new ProyectoOOIA.Componente.toggle();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toggle1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblIncorrecto);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.linkContraseña);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtContraseña);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Controls.Add(this.btnIngresar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(318, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 523);
            this.panel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "OOIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Alumno";
            // 
            // lblIncorrecto
            // 
            this.lblIncorrecto.AutoSize = true;
            this.lblIncorrecto.ForeColor = System.Drawing.Color.Red;
            this.lblIncorrecto.Location = new System.Drawing.Point(233, 323);
            this.lblIncorrecto.Name = "lblIncorrecto";
            this.lblIncorrecto.Size = new System.Drawing.Size(112, 13);
            this.lblIncorrecto.TabIndex = 7;
            this.lblIncorrecto.Text = "Contraseña Incorrecta";
            this.lblIncorrecto.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 115);
            this.label1.TabIndex = 0;
            this.label1.Text = "OOIA";
            // 
            // linkContraseña
            // 
            this.linkContraseña.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.linkContraseña.AutoSize = true;
            this.linkContraseña.DisabledLinkColor = System.Drawing.Color.Gray;
            this.linkContraseña.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkContraseña.LinkColor = System.Drawing.Color.Gray;
            this.linkContraseña.Location = new System.Drawing.Point(214, 448);
            this.linkContraseña.Name = "linkContraseña";
            this.linkContraseña.Size = new System.Drawing.Size(131, 13);
            this.linkContraseña.TabIndex = 6;
            this.linkContraseña.TabStop = true;
            this.linkContraseña.Text = "¿Olvidaste tu contraseña?";
            this.linkContraseña.VisitedLinkColor = System.Drawing.Color.Silver;
            this.linkContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkContraseña_LinkClicked_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contrasela:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(269, 269);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(183, 20);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(269, 199);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(183, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnIngresar.Location = new System.Drawing.Point(246, 356);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(99, 36);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 523);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCorreo,
            this.btnCelular,
            this.btnTelefono});
            this.toolStrip1.Location = new System.Drawing.Point(9, 459);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(116, 30);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCorreo
            // 
            this.btnCorreo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCorreo.Image = global::ProyectoOOIA.Properties.Resources._013_mail;
            this.btnCorreo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCorreo.Name = "btnCorreo";
            this.btnCorreo.Size = new System.Drawing.Size(29, 27);
            this.btnCorreo.Text = "toolStripButton1";
            // 
            // btnCelular
            // 
            this.btnCelular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCelular.Image = global::ProyectoOOIA.Properties.Resources._017_mobile_phone;
            this.btnCelular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCelular.Name = "btnCelular";
            this.btnCelular.Size = new System.Drawing.Size(29, 27);
            this.btnCelular.Text = "toolStripButton2";
            // 
            // btnTelefono
            // 
            this.btnTelefono.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTelefono.Image = global::ProyectoOOIA.Properties.Resources._028_telephone_2;
            this.btnTelefono.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTelefono.Name = "btnTelefono";
            this.btnTelefono.Size = new System.Drawing.Size(29, 27);
            this.btnTelefono.Text = "toolStripButton3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoOOIA.Properties.Resources._1200px_PUCP_text_logo_svg;
            this.pictureBox2.Location = new System.Drawing.Point(66, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ProyectoOOIA.Properties.Resources.EEGGCC;
            this.pictureBox1.Location = new System.Drawing.Point(52, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(312, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1, 523);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // toggle1
            // 
            this.toggle1.AutoSize = true;
            this.toggle1.Location = new System.Drawing.Point(264, 406);
            this.toggle1.Name = "toggle1";
            this.toggle1.Padding = new System.Windows.Forms.Padding(6);
            this.toggle1.Size = new System.Drawing.Size(73, 29);
            this.toggle1.TabIndex = 11;
            this.toggle1.Text = "toggle1";
            this.toggle1.UseVisualStyleBackColor = true;
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(936, 523);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "frmInicioSesion";
            this.Text = "Inicio de Sesion";
            this.Load += new System.EventHandler(this.frmInicioSesion_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnIngresar;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCorreo;
        private System.Windows.Forms.ToolStripButton btnCelular;
        private System.Windows.Forms.ToolStripButton btnTelefono;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Splitter splitter1;


        private System.Windows.Forms.Label lblIncorrecto;


        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Componente.toggle toggle1;
    }
}