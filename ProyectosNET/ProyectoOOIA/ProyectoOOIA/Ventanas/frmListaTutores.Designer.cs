﻿
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTutor = new System.Windows.Forms.TabPage();
            this.card5 = new ProyectoOOIA.Componentes.Card();
            this.card4 = new ProyectoOOIA.Componentes.Card();
            this.card3 = new ProyectoOOIA.Componentes.Card();
            this.card2 = new ProyectoOOIA.Componentes.Card();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.card1 = new ProyectoOOIA.Componentes.Card();
            this.card6 = new ProyectoOOIA.Componentes.Card();
            this.card7 = new ProyectoOOIA.Componentes.Card();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTutor.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 93);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ProyectoOOIA.Properties.Resources.home;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(25, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 1;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de tutores y psicólogos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTutor);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(0, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(6, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(936, 430);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tabTutor
            // 
            this.tabTutor.AutoScrollMargin = new System.Drawing.Size(0, 1000);
            this.tabTutor.Controls.Add(this.card6);
            this.tabTutor.Controls.Add(this.card7);
            this.tabTutor.Controls.Add(this.card5);
            this.tabTutor.Controls.Add(this.card4);
            this.tabTutor.Controls.Add(this.card3);
            this.tabTutor.Controls.Add(this.card2);
            this.tabTutor.Location = new System.Drawing.Point(4, 36);
            this.tabTutor.Name = "tabTutor";
            this.tabTutor.Padding = new System.Windows.Forms.Padding(3);
            this.tabTutor.Size = new System.Drawing.Size(928, 390);
            this.tabTutor.TabIndex = 0;
            this.tabTutor.Text = "Tutores";
            this.tabTutor.UseVisualStyleBackColor = true;
            // 
            // card7
            // 
            this.card7.Location = new System.Drawing.Point(484, 400);
            this.card7.Name = "card5";
            this.card7.Size = new System.Drawing.Size(327, 175);
            this.card7.TabIndex = 6;
            this.card7.Load += new System.EventHandler(this.card7_Load);
            // 
            // card6
            // 
            this.card6.Location = new System.Drawing.Point(69, 400);
            this.card6.Name = "card5";
            this.card6.Size = new System.Drawing.Size(327, 175);
            this.card6.TabIndex = 5;
            this.card6.Load += new System.EventHandler(this.card6_Load);
            // 
            // card5
            // 
            this.card5.Location = new System.Drawing.Point(484, 219);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(327, 175);
            this.card5.TabIndex = 4;
            this.card5.Load += new System.EventHandler(this.card5_Load);
            // 
            // card4
            // 
            this.card4.Location = new System.Drawing.Point(69, 219);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(327, 175);
            this.card4.TabIndex = 3;
            this.card4.Load += new System.EventHandler(this.card4_Load);
            // 
            // card3
            // 
            this.card3.Location = new System.Drawing.Point(484, 38);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(327, 175);
            this.card3.TabIndex = 2;
            this.card3.Load += new System.EventHandler(this.card3_Load);
            // 
            // card2
            // 
            this.card2.Location = new System.Drawing.Point(69, 38);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(327, 175);
            this.card2.TabIndex = 0;
            this.card2.Load += new System.EventHandler(this.card2_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.card1);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(928, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Psicólogos";
            this.tabPage2.UseVisualStyleBackColor = true;
         
            // 
            // frmListaTutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 523);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmListaTutores";
            this.Text = "Tutores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabTutor.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTutor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private Componentes.Card card1;
        private Componentes.Card card2;
        private Componentes.Card card5;
        private Componentes.Card card4;
        private Componentes.Card card3;
        private Componentes.Card card6;
        private Componentes.Card card7;
    }
}