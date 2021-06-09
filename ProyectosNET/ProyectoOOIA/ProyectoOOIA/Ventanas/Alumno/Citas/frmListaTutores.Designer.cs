
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    partial class frmListaTutores
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTutor = new System.Windows.Forms.TabPage();
            this.pnlTutorRight = new System.Windows.Forms.Panel();
            this.pnlTutorLeft = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.card8 = new ProyectoOOIA.Componentes.Card();
            this.card1 = new ProyectoOOIA.Componentes.Card();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabTutor.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 71);
            this.panel1.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImage = global::ProyectoOOIA.Properties.Resources.arrowWhite;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(12, 26);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(31, 34);
            this.btnAtras.TabIndex = 13;
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de tutores y psicólogos";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTutor);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 71);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(6, 10);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(936, 459);
            this.tabControl.TabIndex = 1;
            // 
            // tabTutor
            // 
            this.tabTutor.AutoScrollMargin = new System.Drawing.Size(0, 200);
            this.tabTutor.BackColor = System.Drawing.SystemColors.Control;
            this.tabTutor.Controls.Add(this.pnlTutorRight);
            this.tabTutor.Controls.Add(this.pnlTutorLeft);
            this.tabTutor.Location = new System.Drawing.Point(4, 36);
            this.tabTutor.Name = "tabTutor";
            this.tabTutor.Padding = new System.Windows.Forms.Padding(3);
            this.tabTutor.Size = new System.Drawing.Size(928, 419);
            this.tabTutor.TabIndex = 0;
            this.tabTutor.Text = "Tutores";
            // 
            // pnlTutorRight
            // 
            this.pnlTutorRight.AutoSize = true;
            this.pnlTutorRight.Location = new System.Drawing.Point(520, 73);
            this.pnlTutorRight.Name = "pnlTutorRight";
            this.pnlTutorRight.Size = new System.Drawing.Size(400, 338);
            this.pnlTutorRight.TabIndex = 1;
            // 
            // pnlTutorLeft
            // 
            this.pnlTutorLeft.AutoSize = true;
            this.pnlTutorLeft.Location = new System.Drawing.Point(8, 73);
            this.pnlTutorLeft.Name = "pnlTutorLeft";
            this.pnlTutorLeft.Size = new System.Drawing.Size(400, 338);
            this.pnlTutorLeft.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.card8);
            this.tabPage2.Controls.Add(this.card1);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(928, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Psicólogos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // card8
            // 
            this.card8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.card8.Location = new System.Drawing.Point(485, 33);
            this.card8.Margin = new System.Windows.Forms.Padding(4);
            this.card8.Name = "card8";
            this.card8.Size = new System.Drawing.Size(327, 175);
            this.card8.TabIndex = 1;
            // 
            // card1
            // 
            this.card1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.card1.Location = new System.Drawing.Point(69, 33);
            this.card1.Margin = new System.Windows.Forms.Padding(4);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(327, 175);
            this.card1.TabIndex = 0;
            // 
            // frmListaTutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(936, 530);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmListaTutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabTutor.ResumeLayout(false);
            this.tabTutor.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTutor;
        private System.Windows.Forms.TabPage tabPage2;
        private Componentes.Card card1;
        private Componentes.Card card8;
        private Button btnAtras;
        private Panel pnlTutorRight;
        private Panel pnlTutorLeft;
    }
}