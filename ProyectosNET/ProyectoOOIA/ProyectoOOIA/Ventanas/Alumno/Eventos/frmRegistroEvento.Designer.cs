
namespace ProyectoOOIA.Ventanas
{
    partial class frmRegistroEvento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroEvento));
            this.tabEventos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.dtpFechaInscritos = new System.Windows.Forms.DateTimePicker();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnDetInscritos = new System.Windows.Forms.Button();
            this.btnBuscarInscritos = new System.Windows.Forms.Button();
            this.lblEventosInscritos = new System.Windows.Forms.Label();
            this.dvgInscritos = new System.Windows.Forms.DataGridView();
            this.txtHoraInscritos = new System.Windows.Forms.TextBox();
            this.lblFechaInscritos = new System.Windows.Forms.Label();
            this.lblHoraInscritos = new System.Windows.Forms.Label();
            this.txtCategoriaInscritos = new System.Windows.Forms.TextBox();
            this.lblCategoriaInscritos = new System.Windows.Forms.Label();
            this.txtNombreInscritos = new System.Windows.Forms.TextBox();
            this.lblNombreInscritos = new System.Windows.Forms.Label();
            this.tabHistorial = new System.Windows.Forms.TabPage();
            this.dtpFechaHistorial = new System.Windows.Forms.DateTimePicker();
            this.txtHoraHistorial = new System.Windows.Forms.TextBox();
            this.lblFechaHistorial = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarHistorial = new System.Windows.Forms.Button();
            this.txtCategoriaHistorial = new System.Windows.Forms.TextBox();
            this.lblCategoriaHistorial = new System.Windows.Forms.Label();
            this.txtNombreHistorial = new System.Windows.Forms.TextBox();
            this.lblNombresHistorial = new System.Windows.Forms.Label();
            this.lblEventosPasados = new System.Windows.Forms.Label();
            this.btnDetHistorial = new System.Windows.Forms.Button();
            this.dvgHistorial = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblEventos = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.NombreEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabEventos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgInscritos)).BeginInit();
            this.tabHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgHistorial)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEventos
            // 
            this.tabEventos.Controls.Add(this.tabPage1);
            this.tabEventos.Controls.Add(this.tabHistorial);
            this.tabEventos.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEventos.Location = new System.Drawing.Point(0, 77);
            this.tabEventos.Name = "tabEventos";
            this.tabEventos.SelectedIndex = 0;
            this.tabEventos.Size = new System.Drawing.Size(1014, 536);
            this.tabEventos.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnAcceder);
            this.tabPage1.Controls.Add(this.dtpFechaInscritos);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnRegistrar);
            this.tabPage1.Controls.Add(this.btnDetInscritos);
            this.tabPage1.Controls.Add(this.btnBuscarInscritos);
            this.tabPage1.Controls.Add(this.lblEventosInscritos);
            this.tabPage1.Controls.Add(this.dvgInscritos);
            this.tabPage1.Controls.Add(this.txtHoraInscritos);
            this.tabPage1.Controls.Add(this.lblFechaInscritos);
            this.tabPage1.Controls.Add(this.lblHoraInscritos);
            this.tabPage1.Controls.Add(this.txtCategoriaInscritos);
            this.tabPage1.Controls.Add(this.lblCategoriaInscritos);
            this.tabPage1.Controls.Add(this.txtNombreInscritos);
            this.tabPage1.Controls.Add(this.lblNombreInscritos);
            this.tabPage1.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1006, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Eventos inscritos";
            // 
            // btnAcceder
            // 
            this.btnAcceder.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.Location = new System.Drawing.Point(634, 122);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(79, 29);
            this.btnAcceder.TabIndex = 43;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // dtpFechaInscritos
            // 
            this.dtpFechaInscritos.Location = new System.Drawing.Point(150, 82);
            this.dtpFechaInscritos.Name = "dtpFechaInscritos";
            this.dtpFechaInscritos.Size = new System.Drawing.Size(200, 21);
            this.dtpFechaInscritos.TabIndex = 42;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(804, 122);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 29);
            this.btnEliminar.TabIndex = 41;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(719, 122);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(79, 29);
            this.btnRegistrar.TabIndex = 40;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnDetInscritos
            // 
            this.btnDetInscritos.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetInscritos.Location = new System.Drawing.Point(885, 122);
            this.btnDetInscritos.Name = "btnDetInscritos";
            this.btnDetInscritos.Size = new System.Drawing.Size(95, 29);
            this.btnDetInscritos.TabIndex = 39;
            this.btnDetInscritos.Text = "Ver detalles";
            this.btnDetInscritos.UseVisualStyleBackColor = true;
            this.btnDetInscritos.Click += new System.EventHandler(this.btnDetInscritos_Click);
            // 
            // btnBuscarInscritos
            // 
            this.btnBuscarInscritos.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarInscritos.Location = new System.Drawing.Point(445, 24);
            this.btnBuscarInscritos.Name = "btnBuscarInscritos";
            this.btnBuscarInscritos.Size = new System.Drawing.Size(87, 26);
            this.btnBuscarInscritos.TabIndex = 38;
            this.btnBuscarInscritos.Text = "Buscar";
            this.btnBuscarInscritos.UseVisualStyleBackColor = true;
            this.btnBuscarInscritos.Click += new System.EventHandler(this.btnBuscarInscritos_Click);
            // 
            // lblEventosInscritos
            // 
            this.lblEventosInscritos.AutoSize = true;
            this.lblEventosInscritos.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventosInscritos.Location = new System.Drawing.Point(22, 133);
            this.lblEventosInscritos.Name = "lblEventosInscritos";
            this.lblEventosInscritos.Size = new System.Drawing.Size(122, 21);
            this.lblEventosInscritos.TabIndex = 37;
            this.lblEventosInscritos.Text = "Eventos Inscritos";
            // 
            // dvgInscritos
            // 
            this.dvgInscritos.AllowUserToDeleteRows = false;
            this.dvgInscritos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgInscritos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgInscritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgInscritos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreEvento,
            this.Fecha,
            this.HoraInicio,
            this.HoraFin,
            this.Categoria});
            this.dvgInscritos.EnableHeadersVisualStyles = false;
            this.dvgInscritos.Location = new System.Drawing.Point(22, 157);
            this.dvgInscritos.Name = "dvgInscritos";
            this.dvgInscritos.RowHeadersWidth = 51;
            this.dvgInscritos.Size = new System.Drawing.Size(958, 327);
            this.dvgInscritos.TabIndex = 36;
            // 
            // txtHoraInscritos
            // 
            this.txtHoraInscritos.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraInscritos.Location = new System.Drawing.Point(445, 82);
            this.txtHoraInscritos.Name = "txtHoraInscritos";
            this.txtHoraInscritos.Size = new System.Drawing.Size(74, 23);
            this.txtHoraInscritos.TabIndex = 35;
            // 
            // lblFechaInscritos
            // 
            this.lblFechaInscritos.AutoSize = true;
            this.lblFechaInscritos.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInscritos.Location = new System.Drawing.Point(22, 82);
            this.lblFechaInscritos.Name = "lblFechaInscritos";
            this.lblFechaInscritos.Size = new System.Drawing.Size(46, 21);
            this.lblFechaInscritos.TabIndex = 34;
            this.lblFechaInscritos.Text = "Fecha:";
            // 
            // lblHoraInscritos
            // 
            this.lblHoraInscritos.AutoSize = true;
            this.lblHoraInscritos.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInscritos.Location = new System.Drawing.Point(362, 82);
            this.lblHoraInscritos.Name = "lblHoraInscritos";
            this.lblHoraInscritos.Size = new System.Drawing.Size(77, 21);
            this.lblHoraInscritos.TabIndex = 32;
            this.lblHoraInscritos.Text = "Hora inicio:";
            // 
            // txtCategoriaInscritos
            // 
            this.txtCategoriaInscritos.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaInscritos.Location = new System.Drawing.Point(150, 53);
            this.txtCategoriaInscritos.Name = "txtCategoriaInscritos";
            this.txtCategoriaInscritos.Size = new System.Drawing.Size(137, 23);
            this.txtCategoriaInscritos.TabIndex = 31;
            // 
            // lblCategoriaInscritos
            // 
            this.lblCategoriaInscritos.AutoSize = true;
            this.lblCategoriaInscritos.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaInscritos.Location = new System.Drawing.Point(22, 53);
            this.lblCategoriaInscritos.Name = "lblCategoriaInscritos";
            this.lblCategoriaInscritos.Size = new System.Drawing.Size(70, 21);
            this.lblCategoriaInscritos.TabIndex = 30;
            this.lblCategoriaInscritos.Text = "Categoria:";
            // 
            // txtNombreInscritos
            // 
            this.txtNombreInscritos.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreInscritos.Location = new System.Drawing.Point(150, 24);
            this.txtNombreInscritos.Name = "txtNombreInscritos";
            this.txtNombreInscritos.Size = new System.Drawing.Size(289, 23);
            this.txtNombreInscritos.TabIndex = 29;
            // 
            // lblNombreInscritos
            // 
            this.lblNombreInscritos.AutoSize = true;
            this.lblNombreInscritos.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreInscritos.Location = new System.Drawing.Point(22, 24);
            this.lblNombreInscritos.Name = "lblNombreInscritos";
            this.lblNombreInscritos.Size = new System.Drawing.Size(128, 21);
            this.lblNombreInscritos.TabIndex = 28;
            this.lblNombreInscritos.Text = "Nombre del evento:";
            // 
            // tabHistorial
            // 
            this.tabHistorial.BackColor = System.Drawing.SystemColors.Control;
            this.tabHistorial.Controls.Add(this.dtpFechaHistorial);
            this.tabHistorial.Controls.Add(this.txtHoraHistorial);
            this.tabHistorial.Controls.Add(this.lblFechaHistorial);
            this.tabHistorial.Controls.Add(this.label5);
            this.tabHistorial.Controls.Add(this.btnBuscarHistorial);
            this.tabHistorial.Controls.Add(this.txtCategoriaHistorial);
            this.tabHistorial.Controls.Add(this.lblCategoriaHistorial);
            this.tabHistorial.Controls.Add(this.txtNombreHistorial);
            this.tabHistorial.Controls.Add(this.lblNombresHistorial);
            this.tabHistorial.Controls.Add(this.lblEventosPasados);
            this.tabHistorial.Controls.Add(this.btnDetHistorial);
            this.tabHistorial.Controls.Add(this.dvgHistorial);
            this.tabHistorial.Location = new System.Drawing.Point(4, 27);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistorial.Size = new System.Drawing.Size(1006, 505);
            this.tabHistorial.TabIndex = 1;
            this.tabHistorial.Text = "Historial de eventos";
            // 
            // dtpFechaHistorial
            // 
            this.dtpFechaHistorial.Location = new System.Drawing.Point(150, 82);
            this.dtpFechaHistorial.Name = "dtpFechaHistorial";
            this.dtpFechaHistorial.Size = new System.Drawing.Size(200, 21);
            this.dtpFechaHistorial.TabIndex = 54;
            // 
            // txtHoraHistorial
            // 
            this.txtHoraHistorial.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraHistorial.Location = new System.Drawing.Point(445, 82);
            this.txtHoraHistorial.Name = "txtHoraHistorial";
            this.txtHoraHistorial.Size = new System.Drawing.Size(74, 23);
            this.txtHoraHistorial.TabIndex = 53;
            // 
            // lblFechaHistorial
            // 
            this.lblFechaHistorial.AutoSize = true;
            this.lblFechaHistorial.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHistorial.Location = new System.Drawing.Point(22, 82);
            this.lblFechaHistorial.Name = "lblFechaHistorial";
            this.lblFechaHistorial.Size = new System.Drawing.Size(46, 21);
            this.lblFechaHistorial.TabIndex = 52;
            this.lblFechaHistorial.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 51;
            this.label5.Text = "Hora inicio:";
            // 
            // btnBuscarHistorial
            // 
            this.btnBuscarHistorial.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHistorial.Location = new System.Drawing.Point(445, 24);
            this.btnBuscarHistorial.Name = "btnBuscarHistorial";
            this.btnBuscarHistorial.Size = new System.Drawing.Size(87, 26);
            this.btnBuscarHistorial.TabIndex = 50;
            this.btnBuscarHistorial.Text = "Buscar";
            this.btnBuscarHistorial.UseVisualStyleBackColor = true;
            // 
            // txtCategoriaHistorial
            // 
            this.txtCategoriaHistorial.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaHistorial.Location = new System.Drawing.Point(150, 53);
            this.txtCategoriaHistorial.Name = "txtCategoriaHistorial";
            this.txtCategoriaHistorial.Size = new System.Drawing.Size(137, 23);
            this.txtCategoriaHistorial.TabIndex = 45;
            // 
            // lblCategoriaHistorial
            // 
            this.lblCategoriaHistorial.AutoSize = true;
            this.lblCategoriaHistorial.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaHistorial.Location = new System.Drawing.Point(22, 53);
            this.lblCategoriaHistorial.Name = "lblCategoriaHistorial";
            this.lblCategoriaHistorial.Size = new System.Drawing.Size(70, 21);
            this.lblCategoriaHistorial.TabIndex = 44;
            this.lblCategoriaHistorial.Text = "Categoria:";
            // 
            // txtNombreHistorial
            // 
            this.txtNombreHistorial.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreHistorial.Location = new System.Drawing.Point(150, 24);
            this.txtNombreHistorial.Name = "txtNombreHistorial";
            this.txtNombreHistorial.Size = new System.Drawing.Size(289, 23);
            this.txtNombreHistorial.TabIndex = 43;
            // 
            // lblNombresHistorial
            // 
            this.lblNombresHistorial.AutoSize = true;
            this.lblNombresHistorial.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombresHistorial.Location = new System.Drawing.Point(22, 24);
            this.lblNombresHistorial.Name = "lblNombresHistorial";
            this.lblNombresHistorial.Size = new System.Drawing.Size(128, 21);
            this.lblNombresHistorial.TabIndex = 42;
            this.lblNombresHistorial.Text = "Nombre del evento:";
            // 
            // lblEventosPasados
            // 
            this.lblEventosPasados.AutoSize = true;
            this.lblEventosPasados.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventosPasados.Location = new System.Drawing.Point(22, 133);
            this.lblEventosPasados.Name = "lblEventosPasados";
            this.lblEventosPasados.Size = new System.Drawing.Size(117, 21);
            this.lblEventosPasados.TabIndex = 41;
            this.lblEventosPasados.Text = "Eventos Pasados";
            // 
            // btnDetHistorial
            // 
            this.btnDetHistorial.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetHistorial.Location = new System.Drawing.Point(885, 122);
            this.btnDetHistorial.Name = "btnDetHistorial";
            this.btnDetHistorial.Size = new System.Drawing.Size(95, 29);
            this.btnDetHistorial.TabIndex = 40;
            this.btnDetHistorial.Text = "Ver detalles";
            this.btnDetHistorial.UseVisualStyleBackColor = true;
            this.btnDetHistorial.Click += new System.EventHandler(this.btnDetHistorial_Click);
            // 
            // dvgHistorial
            // 
            this.dvgHistorial.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dvgHistorial.EnableHeadersVisualStyles = false;
            this.dvgHistorial.Location = new System.Drawing.Point(22, 157);
            this.dvgHistorial.Name = "dvgHistorial";
            this.dvgHistorial.RowHeadersWidth = 51;
            this.dvgHistorial.Size = new System.Drawing.Size(958, 327);
            this.dvgHistorial.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblEventos);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 71);
            this.panel1.TabIndex = 43;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = global::ProyectoOOIA.Properties.Resources.log_out__1_;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(953, 29);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(35, 34);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblEventos
            // 
            this.lblEventos.AutoSize = true;
            this.lblEventos.Font = new System.Drawing.Font("Gill Sans MT", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventos.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEventos.Location = new System.Drawing.Point(40, 30);
            this.lblEventos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(168, 33);
            this.lblEventos.TabIndex = 3;
            this.lblEventos.Text = "Lista de Eventos";
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(11, 30);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(25, 25);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 2;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // NombreEvento
            // 
            this.NombreEvento.HeaderText = "Nombre";
            this.NombreEvento.MinimumWidth = 6;
            this.NombreEvento.Name = "NombreEvento";
            this.NombreEvento.Width = 400;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.MinimumWidth = 6;
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.Width = 120;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Hora Fin";
            this.HoraFin.MinimumWidth = 6;
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.Width = 120;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 140;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 400;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Hora Inicio";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Hora Fin";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // frmRegistroEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabEventos);
            this.Name = "frmRegistroEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.frmRegistroEvento_Load);
            this.tabEventos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgInscritos)).EndInit();
            this.tabHistorial.ResumeLayout(false);
            this.tabHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgHistorial)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEventos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnDetInscritos;
        private System.Windows.Forms.Button btnBuscarInscritos;
        private System.Windows.Forms.Label lblEventosInscritos;
        private System.Windows.Forms.DataGridView dvgInscritos;
        private System.Windows.Forms.TextBox txtHoraInscritos;
        private System.Windows.Forms.Label lblFechaInscritos;
        private System.Windows.Forms.Label lblHoraInscritos;
        private System.Windows.Forms.TextBox txtCategoriaInscritos;
        private System.Windows.Forms.Label lblCategoriaInscritos;
        private System.Windows.Forms.TextBox txtNombreInscritos;
        private System.Windows.Forms.Label lblNombreInscritos;
        private System.Windows.Forms.TabPage tabHistorial;
        private System.Windows.Forms.Button btnDetHistorial;
        private System.Windows.Forms.DataGridView dvgHistorial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label lblEventos;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblEventosPasados;
        private System.Windows.Forms.Button btnBuscarHistorial;
        private System.Windows.Forms.TextBox txtCategoriaHistorial;
        private System.Windows.Forms.Label lblCategoriaHistorial;
        private System.Windows.Forms.TextBox txtNombreHistorial;
        private System.Windows.Forms.Label lblNombresHistorial;
        private System.Windows.Forms.DateTimePicker dtpFechaInscritos;
        private System.Windows.Forms.DateTimePicker dtpFechaHistorial;
        private System.Windows.Forms.TextBox txtHoraHistorial;
        private System.Windows.Forms.Label lblFechaHistorial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}