﻿
namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{
    partial class frmCargarPsicologo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarPsicologo));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.txtHeader = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPersona = new System.Windows.Forms.TabPage();
            this.pnlPersona = new System.Windows.Forms.Panel();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblPersona = new System.Windows.Forms.Label();
            this.tabPsico = new System.Windows.Forms.TabPage();
            this.btnImagen = new System.Windows.Forms.Button();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblMiembroPucp = new System.Windows.Forms.Label();
            this.lblPsico = new System.Windows.Forms.Label();
            this.lblIdPsico = new System.Windows.Forms.Label();
            this.txtIdPsico = new System.Windows.Forms.TextBox();
            this.ofd_Imagen = new System.Windows.Forms.OpenFileDialog();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPersona.SuspendLayout();
            this.pnlPersona.SuspendLayout();
            this.tabPsico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.txtHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(991, 94);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::ProyectoOOIA.Properties.Resources.arrowWhite;
            this.btnBack.Location = new System.Drawing.Point(35, 34);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(33, 31);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 3;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtHeader
            // 
            this.txtHeader.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.txtHeader.Location = new System.Drawing.Point(88, 34);
            this.txtHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(317, 43);
            this.txtHeader.TabIndex = 2;
            this.txtHeader.Text = "Cargar Psicologo";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbModificar,
            this.tsbEliminar,
            this.tsbBuscar,
            this.tsbCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 94);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(991, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(76, 24);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.ToolTipText = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(86, 24);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(97, 24);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(87, 24);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(76, 24);
            this.tsbBuscar.Text = "Buscar";
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(90, 24);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPersona);
            this.tabControl.Controls.Add(this.tabPsico);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Location = new System.Drawing.Point(0, 121);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(991, 342);
            this.tabControl.TabIndex = 4;
            // 
            // tabPersona
            // 
            this.tabPersona.Controls.Add(this.pnlPersona);
            this.tabPersona.Location = new System.Drawing.Point(4, 25);
            this.tabPersona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPersona.Name = "tabPersona";
            this.tabPersona.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPersona.Size = new System.Drawing.Size(983, 313);
            this.tabPersona.TabIndex = 1;
            this.tabPersona.Text = "Datos Persona";
            this.tabPersona.UseVisualStyleBackColor = true;
            // 
            // pnlPersona
            // 
            this.pnlPersona.Controls.Add(this.txtCorreo);
            this.pnlPersona.Controls.Add(this.lblCorreo);
            this.pnlPersona.Controls.Add(this.txtDireccion);
            this.pnlPersona.Controls.Add(this.lblDireccion);
            this.pnlPersona.Controls.Add(this.txtEdad);
            this.pnlPersona.Controls.Add(this.lblEdad);
            this.pnlPersona.Controls.Add(this.txtNombre);
            this.pnlPersona.Controls.Add(this.lblNombre);
            this.pnlPersona.Controls.Add(this.txtDni);
            this.pnlPersona.Controls.Add(this.lblDni);
            this.pnlPersona.Controls.Add(this.lblPersona);
            this.pnlPersona.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPersona.Location = new System.Drawing.Point(4, 4);
            this.pnlPersona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPersona.Name = "pnlPersona";
            this.pnlPersona.Size = new System.Drawing.Size(975, 299);
            this.pnlPersona.TabIndex = 9;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(187, 165);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(360, 22);
            this.txtCorreo.TabIndex = 21;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(9, 160);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(70, 27);
            this.lblCorreo.TabIndex = 20;
            this.lblCorreo.Text = "Correo";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(187, 133);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(360, 22);
            this.txtDireccion.TabIndex = 19;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(9, 129);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(87, 27);
            this.lblDireccion.TabIndex = 18;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(187, 100);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(132, 22);
            this.txtEdad.TabIndex = 17;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(9, 95);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(50, 27);
            this.lblEdad.TabIndex = 16;
            this.lblEdad.Text = "Edad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(187, 68);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(360, 22);
            this.txtNombre.TabIndex = 15;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(9, 64);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(161, 27);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre Completo";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(187, 36);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(132, 22);
            this.txtDni.TabIndex = 13;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(9, 33);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(46, 27);
            this.lblDni.TabIndex = 10;
            this.lblDni.Text = "DNI";
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersona.Location = new System.Drawing.Point(4, 0);
            this.lblPersona.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(213, 34);
            this.lblPersona.TabIndex = 8;
            this.lblPersona.Text = "Datos de Persona";
            // 
            // tabPsico
            // 
            this.tabPsico.Controls.Add(this.btnImagen);
            this.tabPsico.Controls.Add(this.pbPerfil);
            this.tabPsico.Controls.Add(this.pnlDatos);
            this.tabPsico.Location = new System.Drawing.Point(4, 25);
            this.tabPsico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPsico.Name = "tabPsico";
            this.tabPsico.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPsico.Size = new System.Drawing.Size(983, 313);
            this.tabPsico.TabIndex = 0;
            this.tabPsico.Text = "Datos Psicologo";
            this.tabPsico.UseVisualStyleBackColor = true;
            // 
            // btnImagen
            // 
            this.btnImagen.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen.Location = new System.Drawing.Point(749, 263);
            this.btnImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(185, 39);
            this.btnImagen.TabIndex = 5;
            this.btnImagen.Text = "Seleccionar Imagen";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // pbPerfil
            // 
            this.pbPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPerfil.Location = new System.Drawing.Point(708, 7);
            this.pbPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(261, 248);
            this.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfil.TabIndex = 4;
            this.pbPerfil.TabStop = false;
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.txtUsuario);
            this.pnlDatos.Controls.Add(this.txtPassword);
            this.pnlDatos.Controls.Add(this.lblPassword);
            this.pnlDatos.Controls.Add(this.lblUsuario);
            this.pnlDatos.Controls.Add(this.lblMiembroPucp);
            this.pnlDatos.Controls.Add(this.lblPsico);
            this.pnlDatos.Controls.Add(this.lblIdPsico);
            this.pnlDatos.Controls.Add(this.txtIdPsico);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDatos.Location = new System.Drawing.Point(4, 4);
            this.pnlDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(696, 305);
            this.pnlDatos.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(203, 37);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(192, 22);
            this.txtUsuario.TabIndex = 13;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(203, 69);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(192, 22);
            this.txtPassword.TabIndex = 12;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(8, 69);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(101, 27);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(8, 33);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 27);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblMiembroPucp
            // 
            this.lblMiembroPucp.AutoSize = true;
            this.lblMiembroPucp.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiembroPucp.Location = new System.Drawing.Point(4, 0);
            this.lblMiembroPucp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiembroPucp.Name = "lblMiembroPucp";
            this.lblMiembroPucp.Size = new System.Drawing.Size(303, 34);
            this.lblMiembroPucp.TabIndex = 7;
            this.lblMiembroPucp.Text = "Datos de Miembro PUCP";
            // 
            // lblPsico
            // 
            this.lblPsico.AutoSize = true;
            this.lblPsico.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPsico.Location = new System.Drawing.Point(7, 123);
            this.lblPsico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPsico.Name = "lblPsico";
            this.lblPsico.Size = new System.Drawing.Size(236, 34);
            this.lblPsico.TabIndex = 4;
            this.lblPsico.Text = "Datos del Psicologo";
            // 
            // lblIdPsico
            // 
            this.lblIdPsico.AutoSize = true;
            this.lblIdPsico.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPsico.Location = new System.Drawing.Point(7, 159);
            this.lblIdPsico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdPsico.Name = "lblIdPsico";
            this.lblIdPsico.Size = new System.Drawing.Size(107, 27);
            this.lblIdPsico.TabIndex = 1;
            this.lblIdPsico.Text = "ID Psicologo";
            // 
            // txtIdPsico
            // 
            this.txtIdPsico.Location = new System.Drawing.Point(203, 160);
            this.txtIdPsico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdPsico.Name = "txtIdPsico";
            this.txtIdPsico.Size = new System.Drawing.Size(132, 22);
            this.txtIdPsico.TabIndex = 0;
            // 
            // ofd_Imagen
            // 
            this.ofd_Imagen.FileName = "Alumno_Perfil";
            // 
            // frmCargarPsicologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 491);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCargarPsicologo";
            this.Text = "Cargar Alumno";
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPersona.ResumeLayout(false);
            this.pnlPersona.ResumeLayout(false);
            this.pnlPersona.PerformLayout();
            this.tabPsico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label txtHeader;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPersona;
        private System.Windows.Forms.Panel pnlPersona;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.TabPage tabPsico;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.PictureBox pbPerfil;
        private System.Windows.Forms.OpenFileDialog ofd_Imagen;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblMiembroPucp;
        private System.Windows.Forms.Label lblPsico;
        private System.Windows.Forms.Label lblIdPsico;
        private System.Windows.Forms.TextBox txtIdPsico;
    }
}