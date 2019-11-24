namespace Hospital_Management_System
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsignin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoctors = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMedicines = new System.Windows.Forms.ToolStripMenuItem();
            this.menucabin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOthers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSales = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnsignin);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 747);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 642);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "New User? Sign in:";
            // 
            // btnsignin
            // 
            this.btnsignin.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignin.Location = new System.Drawing.Point(257, 638);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.Size = new System.Drawing.Size(102, 33);
            this.btnsignin.TabIndex = 12;
            this.btnsignin.Text = "SIGN IN ";
            this.btnsignin.UseVisualStyleBackColor = true;
            this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1233, 642);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHome,
            this.menuPatient,
            this.menuDoctors,
            this.menuMedicines,
            this.menucabin,
            this.menuStaff,
            this.menuOthers,
            this.menuSales,
            this.menuSearch});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1363, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHome
            // 
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(52, 20);
            this.menuHome.Text = "Home";
            this.menuHome.Click += new System.EventHandler(this.menuHome_Click);
            // 
            // menuPatient
            // 
            this.menuPatient.Name = "menuPatient";
            this.menuPatient.Size = new System.Drawing.Size(61, 20);
            this.menuPatient.Text = "Patients";
            this.menuPatient.Click += new System.EventHandler(this.PatientsToolStripMenuItem_Click);
            // 
            // menuDoctors
            // 
            this.menuDoctors.Name = "menuDoctors";
            this.menuDoctors.Size = new System.Drawing.Size(60, 20);
            this.menuDoctors.Text = "Doctors";
            this.menuDoctors.Click += new System.EventHandler(this.DoctorsToolStripMenuItem_Click);
            // 
            // menuMedicines
            // 
            this.menuMedicines.Name = "menuMedicines";
            this.menuMedicines.Size = new System.Drawing.Size(73, 20);
            this.menuMedicines.Text = "Medicines";
            this.menuMedicines.Click += new System.EventHandler(this.MedicinesToolStripMenuItem_Click);
            // 
            // menucabin
            // 
            this.menucabin.Name = "menucabin";
            this.menucabin.Size = new System.Drawing.Size(50, 20);
            this.menucabin.Text = "Cabin";
            this.menucabin.Click += new System.EventHandler(this.CabinToolStripMenuItem_Click);
            // 
            // menuStaff
            // 
            this.menuStaff.Name = "menuStaff";
            this.menuStaff.Size = new System.Drawing.Size(43, 20);
            this.menuStaff.Text = "Staff";
            this.menuStaff.Click += new System.EventHandler(this.StaffToolStripMenuItem_Click);
            // 
            // menuOthers
            // 
            this.menuOthers.Name = "menuOthers";
            this.menuOthers.Size = new System.Drawing.Size(54, 20);
            this.menuOthers.Text = "Others";
            this.menuOthers.Click += new System.EventHandler(this.othersToolStripMenuItem_Click);
            // 
            // menuSales
            // 
            this.menuSales.Name = "menuSales";
            this.menuSales.Size = new System.Drawing.Size(45, 20);
            this.menuSales.Text = "Sales";
            this.menuSales.Click += new System.EventHandler(this.SalesToolStripMenuItem_Click);
            // 
            // menuSearch
            // 
            this.menuSearch.Name = "menuSearch";
            this.menuSearch.Size = new System.Drawing.Size(54, 20);
            this.menuSearch.Text = "Search";
            this.menuSearch.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 681);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "dashboard";
            this.Text = "Hospital Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ToolStripMenuItem menuPatient;
        public System.Windows.Forms.ToolStripMenuItem menuDoctors;
        public System.Windows.Forms.ToolStripMenuItem menuHome;
        public System.Windows.Forms.ToolStripMenuItem menuMedicines;
        public System.Windows.Forms.ToolStripMenuItem menucabin;
        public System.Windows.Forms.ToolStripMenuItem menuStaff;
        public System.Windows.Forms.ToolStripMenuItem menuOthers;
        public System.Windows.Forms.ToolStripMenuItem menuSales;
        public System.Windows.Forms.ToolStripMenuItem menuSearch;
        public System.Windows.Forms.Button btnsignin;
    }
}