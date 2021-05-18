
namespace ProyectoOOIA.Ventanas
{
    partial class frmPrincipal
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.pbUsername = new System.Windows.Forms.PictureBox();
        this.txtUsername = new System.Windows.Forms.Label();
        this.txtEventos = new System.Windows.Forms.Label();
        this.pbEventos = new System.Windows.Forms.PictureBox();
        this.txtCitas = new System.Windows.Forms.Label();
        this.pbCitas = new System.Windows.Forms.PictureBox();
        this.txtTramites = new System.Windows.Forms.Label();
        this.pbTramites = new System.Windows.Forms.PictureBox();
        this.txtHorarios = new System.Windows.Forms.Label();
        this.pbHorarios = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pbEventos)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pbCitas)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pbTramites)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pbHorarios)).BeginInit();
        this.SuspendLayout();
        // 
        // pictureBox1
        // 
        this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        this.pictureBox1.Location = new System.Drawing.Point(754, 12);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(34, 37);
        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.pictureBox1.TabIndex = 10;
        this.pictureBox1.TabStop = false;
        // 
        // pbUsername
        // 
        this.pbUsername.Image = ((System.Drawing.Image)(resources.GetObject("pbUsername.Image")));
        this.pbUsername.Location = new System.Drawing.Point(12, 12);
        this.pbUsername.Name = "pbUsername";
        this.pbUsername.Size = new System.Drawing.Size(64, 63);
        this.pbUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.pbUsername.TabIndex = 0;
        this.pbUsername.TabStop = false;
        this.pbUsername.Click += new System.EventHandler(this.pictureBox1_Click);
        // 
        // txtUsername
        // 
        this.txtUsername.AutoSize = true;
        this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtUsername.Location = new System.Drawing.Point(82, 12);
        this.txtUsername.Name = "txtUsername";
        this.txtUsername.Size = new System.Drawing.Size(337, 37);
        this.txtUsername.TabIndex = 1;
        this.txtUsername.Text = "Solorzano Tapia, José";
        // 
        // txtEventos
        // 
        this.txtEventos.AutoSize = true;
        this.txtEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtEventos.Location = new System.Drawing.Point(182, 271);
        this.txtEventos.Name = "txtEventos";
        this.txtEventos.Size = new System.Drawing.Size(78, 24);
        this.txtEventos.TabIndex = 8;
        this.txtEventos.Text = "Eventos";
        // 
        // pbEventos
        // 
        this.pbEventos.Location = new System.Drawing.Point(144, 298);
        this.pbEventos.Name = "pbEventos";
        this.pbEventos.Size = new System.Drawing.Size(162, 125);
        this.pbEventos.TabIndex = 4;
        this.pbEventos.TabStop = false;
        // 
        // txtCitas
        // 
        this.txtCitas.AutoSize = true;
        this.txtCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtCitas.Location = new System.Drawing.Point(192, 76);
        this.txtCitas.Name = "txtCitas";
        this.txtCitas.Size = new System.Drawing.Size(50, 24);
        this.txtCitas.TabIndex = 6;
        this.txtCitas.Text = "Citas";
        this.txtCitas.Click += new System.EventHandler(this.label2_Click);
        // 
        // pbCitas
        // 
        this.pbCitas.Location = new System.Drawing.Point(144, 103);
        this.pbCitas.Name = "pbCitas";
        this.pbCitas.Size = new System.Drawing.Size(162, 125);
        this.pbCitas.TabIndex = 2;
        this.pbCitas.TabStop = false;
        // 
        // txtTramites
        // 
        this.txtTramites.AutoSize = true;
        this.txtTramites.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtTramites.Location = new System.Drawing.Point(536, 271);
        this.txtTramites.Name = "txtTramites";
        this.txtTramites.Size = new System.Drawing.Size(82, 24);
        this.txtTramites.TabIndex = 9;
        this.txtTramites.Text = "Trámites";
        this.txtTramites.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // pbTramites
        // 
        this.pbTramites.Location = new System.Drawing.Point(497, 298);
        this.pbTramites.Name = "pbTramites";
        this.pbTramites.Size = new System.Drawing.Size(162, 125);
        this.pbTramites.TabIndex = 5;
        this.pbTramites.TabStop = false;
        // 
        // txtHorarios
        // 
        this.txtHorarios.AutoSize = true;
        this.txtHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtHorarios.Location = new System.Drawing.Point(537, 76);
        this.txtHorarios.Name = "txtHorarios";
        this.txtHorarios.Size = new System.Drawing.Size(81, 24);
        this.txtHorarios.TabIndex = 7;
        this.txtHorarios.Text = "Horarios";
        this.txtHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // pbHorarios
        // 
        this.pbHorarios.Location = new System.Drawing.Point(497, 103);
        this.pbHorarios.Name = "pbHorarios";
        this.pbHorarios.Size = new System.Drawing.Size(162, 125);
        this.pbHorarios.TabIndex = 3;
        this.pbHorarios.TabStop = false;
        // 
        // frmPrincipal
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.pictureBox1);
        this.Controls.Add(this.txtTramites);
        this.Controls.Add(this.txtEventos);
        this.Controls.Add(this.txtHorarios);
        this.Controls.Add(this.txtCitas);
        this.Controls.Add(this.pbTramites);
        this.Controls.Add(this.pbEventos);
        this.Controls.Add(this.pbHorarios);
        this.Controls.Add(this.pbCitas);
        this.Controls.Add(this.txtUsername);
        this.Controls.Add(this.pbUsername);
        this.MaximizeBox = false;
        this.Name = "frmPrincipal";
        this.Text = "Principal";
        this.Load += new System.EventHandler(this.frmPrincipal_Load);
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pbEventos)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pbCitas)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pbTramites)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pbHorarios)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pbUsername;
    private System.Windows.Forms.Label txtUsername;
    private System.Windows.Forms.Label txtEventos;
    private System.Windows.Forms.PictureBox pbEventos;
    private System.Windows.Forms.Label txtCitas;
    private System.Windows.Forms.PictureBox pbCitas;
    private System.Windows.Forms.Label txtTramites;
    private System.Windows.Forms.PictureBox pbTramites;
    private System.Windows.Forms.Label txtHorarios;
    private System.Windows.Forms.PictureBox pbHorarios;
}
}

