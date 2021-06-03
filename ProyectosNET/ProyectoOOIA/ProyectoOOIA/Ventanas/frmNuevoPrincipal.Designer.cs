
namespace ProyectoOOIA.Ventanas
{
    partial class frmNuevoPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.botonEventos = new System.Windows.Forms.Button();
            this.txtEventos = new System.Windows.Forms.Label();
            this.botonCitas = new System.Windows.Forms.Button();
            this.txtHorarios = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelEventos = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.imagenes = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tarjetaEvento3 = new ProyectoOOIA.Componentes.CardEvento();
            this.tarjetaEvento2 = new ProyectoOOIA.Componentes.CardEvento();
            this.tarjetaEvento = new ProyectoOOIA.Componentes.CardEvento();
            this.ovalPictureBox1 = new OvalPictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelEventos.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.ovalPictureBox1);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 83);
            this.panel1.TabIndex = 18;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(115, 29);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(218, 24);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Solorzano Tapia, José";
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
            this.btnAtras.Location = new System.Drawing.Point(952, 19);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(35, 34);
            this.btnAtras.TabIndex = 12;
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.UseVisualStyleBackColor = false;
            // 
            // botonEventos
            // 
            this.botonEventos.BackColor = System.Drawing.Color.Transparent;
            this.botonEventos.BackgroundImage = global::ProyectoOOIA.Properties.Resources.foto_29;
            this.botonEventos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonEventos.FlatAppearance.BorderSize = 0;
            this.botonEventos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonEventos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEventos.Location = new System.Drawing.Point(37, 39);
            this.botonEventos.Name = "botonEventos";
            this.botonEventos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.botonEventos.Size = new System.Drawing.Size(162, 145);
            this.botonEventos.TabIndex = 22;
            this.botonEventos.UseVisualStyleBackColor = false;
            this.botonEventos.Click += new System.EventHandler(this.botonEventos_Click);
            // 
            // txtEventos
            // 
            this.txtEventos.AutoSize = true;
            this.txtEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventos.ForeColor = System.Drawing.Color.Black;
            this.txtEventos.Location = new System.Drawing.Point(74, 10);
            this.txtEventos.Name = "txtEventos";
            this.txtEventos.Size = new System.Drawing.Size(98, 26);
            this.txtEventos.TabIndex = 20;
            this.txtEventos.Text = "Eventos";
            // 
            // botonCitas
            // 
            this.botonCitas.AccessibleDescription = "Hola cliente";
            this.botonCitas.AccessibleName = "hola";
            this.botonCitas.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.botonCitas.BackColor = System.Drawing.Color.Transparent;
            this.botonCitas.BackgroundImage = global::ProyectoOOIA.Properties.Resources.Icono_Agenda_tu_Cita;
            this.botonCitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCitas.FlatAppearance.BorderSize = 0;
            this.botonCitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonCitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCitas.Location = new System.Drawing.Point(17, 43);
            this.botonCitas.Name = "botonCitas";
            this.botonCitas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.botonCitas.Size = new System.Drawing.Size(162, 145);
            this.botonCitas.TabIndex = 21;
            this.botonCitas.UseVisualStyleBackColor = false;
            this.botonCitas.Click += new System.EventHandler(this.botonCitas_Click);
            // 
            // txtHorarios
            // 
            this.txtHorarios.AutoSize = true;
            this.txtHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorarios.ForeColor = System.Drawing.Color.Black;
            this.txtHorarios.Location = new System.Drawing.Point(65, 14);
            this.txtHorarios.Name = "txtHorarios";
            this.txtHorarios.Size = new System.Drawing.Size(67, 26);
            this.txtHorarios.TabIndex = 19;
            this.txtHorarios.Text = "Citas";
            this.txtHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.botonCitas);
            this.panel2.Controls.Add(this.txtHorarios);
            this.panel2.Location = new System.Drawing.Point(130, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 191);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtEventos);
            this.panel3.Controls.Add(this.botonEventos);
            this.panel3.Location = new System.Drawing.Point(401, 422);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 191);
            this.panel3.TabIndex = 24;
            // 
            // panelEventos
            // 
            this.panelEventos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEventos.Controls.Add(this.tarjetaEvento3);
            this.panelEventos.Controls.Add(this.tarjetaEvento2);
            this.panelEventos.Controls.Add(this.tarjetaEvento);
            this.panelEventos.Controls.Add(this.panel5);
            this.panelEventos.Location = new System.Drawing.Point(701, 119);
            this.panelEventos.Name = "panelEventos";
            this.panelEventos.Size = new System.Drawing.Size(286, 482);
            this.panelEventos.TabIndex = 25;
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
            this.imagenes.Location = new System.Drawing.Point(130, 119);
            this.imagenes.Name = "imagenes";
            this.imagenes.Size = new System.Drawing.Size(499, 283);
            this.imagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenes.TabIndex = 26;
            this.imagenes.TabStop = false;
            this.imagenes.Click += new System.EventHandler(this.imagenes_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // tarjetaEvento3
            // 
            this.tarjetaEvento3.Location = new System.Drawing.Point(5, 278);
            this.tarjetaEvento3.Name = "tarjetaEvento3";
            this.tarjetaEvento3.Size = new System.Drawing.Size(280, 129);
            this.tarjetaEvento3.TabIndex = 3;
            this.tarjetaEvento3.Load += new System.EventHandler(this.tarjetaEvento3_Load);
            // 
            // tarjetaEvento2
            // 
            this.tarjetaEvento2.Location = new System.Drawing.Point(5, 177);
            this.tarjetaEvento2.Name = "tarjetaEvento2";
            this.tarjetaEvento2.Size = new System.Drawing.Size(280, 129);
            this.tarjetaEvento2.TabIndex = 2;
            this.tarjetaEvento2.Load += new System.EventHandler(this.tarjetaEvento2_Load);
            // 
            // tarjetaEvento
            // 
            this.tarjetaEvento.Location = new System.Drawing.Point(5, 76);
            this.tarjetaEvento.Name = "tarjetaEvento";
            this.tarjetaEvento.Size = new System.Drawing.Size(280, 129);
            this.tarjetaEvento.TabIndex = 1;
            this.tarjetaEvento.Load += new System.EventHandler(this.cardEvento1_Load);
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox1.Image = global::ProyectoOOIA.Properties.Resources.Estudiante1;
            this.ovalPictureBox1.Location = new System.Drawing.Point(34, 10);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(75, 71);
            this.ovalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovalPictureBox1.TabIndex = 11;
            this.ovalPictureBox1.TabStop = false;
            // 
            // frmNuevoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 637);
            this.Controls.Add(this.imagenes);
            this.Controls.Add(this.panelEventos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNuevoPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNuevoPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelEventos.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private OvalPictureBox ovalPictureBox1;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button botonEventos;
        private System.Windows.Forms.Label txtEventos;
        private System.Windows.Forms.Button botonCitas;
        private System.Windows.Forms.Label txtHorarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelEventos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private Componentes.CardEvento tarjetaEvento;
        private Componentes.CardEvento tarjetaEvento3;
        private Componentes.CardEvento tarjetaEvento2;
        private System.Windows.Forms.PictureBox imagenes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
    }
}