namespace Hospital_Management_System
{
    partial class medicines
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
            this.label11 = new System.Windows.Forms.Label();
            this.grpContainer = new System.Windows.Forms.GroupBox();
            this.txtvisitorno = new System.Windows.Forms.TextBox();
            this.cmbdoctorname = new System.Windows.Forms.ComboBox();
            this.cmbpatientname = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsuppliername = new System.Windows.Forms.TextBox();
            this.txtcompanyname = new System.Windows.Forms.TextBox();
            this.dtpexpireddate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpmfgdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtreferredmedicines = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvmedicinesdetails = new System.Windows.Forms.DataGridView();
            this.btnclose = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmedicinesdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.grpContainer);
            this.panel1.Location = new System.Drawing.Point(49, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 583);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(306, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(584, 54);
            this.label11.TabIndex = 38;
            this.label11.Text = "DETAILS OF MEDICINES";
            // 
            // grpContainer
            // 
            this.grpContainer.Controls.Add(this.txtvisitorno);
            this.grpContainer.Controls.Add(this.cmbdoctorname);
            this.grpContainer.Controls.Add(this.cmbpatientname);
            this.grpContainer.Controls.Add(this.label8);
            this.grpContainer.Controls.Add(this.label9);
            this.grpContainer.Controls.Add(this.txtsuppliername);
            this.grpContainer.Controls.Add(this.txtcompanyname);
            this.grpContainer.Controls.Add(this.dtpexpireddate);
            this.grpContainer.Controls.Add(this.label7);
            this.grpContainer.Controls.Add(this.dtpmfgdate);
            this.grpContainer.Controls.Add(this.label5);
            this.grpContainer.Controls.Add(this.label6);
            this.grpContainer.Controls.Add(this.txtreferredmedicines);
            this.grpContainer.Controls.Add(this.label3);
            this.grpContainer.Controls.Add(this.dgvmedicinesdetails);
            this.grpContainer.Controls.Add(this.btnclose);
            this.grpContainer.Controls.Add(this.btndelete);
            this.grpContainer.Controls.Add(this.btnupdate);
            this.grpContainer.Controls.Add(this.btnadd);
            this.grpContainer.Controls.Add(this.label4);
            this.grpContainer.Controls.Add(this.label1);
            this.grpContainer.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContainer.Location = new System.Drawing.Point(3, 80);
            this.grpContainer.Name = "grpContainer";
            this.grpContainer.Size = new System.Drawing.Size(1197, 484);
            this.grpContainer.TabIndex = 37;
            this.grpContainer.TabStop = false;
            this.grpContainer.Text = "Enter the following details:";
            // 
            // txtvisitorno
            // 
            this.txtvisitorno.Location = new System.Drawing.Point(343, 80);
            this.txtvisitorno.Name = "txtvisitorno";
            this.txtvisitorno.Size = new System.Drawing.Size(172, 22);
            this.txtvisitorno.TabIndex = 61;
            // 
            // cmbdoctorname
            // 
            this.cmbdoctorname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdoctorname.FormattingEnabled = true;
            this.cmbdoctorname.Location = new System.Drawing.Point(343, 118);
            this.cmbdoctorname.Name = "cmbdoctorname";
            this.cmbdoctorname.Size = new System.Drawing.Size(172, 24);
            this.cmbdoctorname.TabIndex = 60;
            this.cmbdoctorname.SelectedIndexChanged += new System.EventHandler(this.cmbdoctorname_SelectedIndexChanged);
            // 
            // cmbpatientname
            // 
            this.cmbpatientname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpatientname.FormattingEnabled = true;
            this.cmbpatientname.Location = new System.Drawing.Point(343, 39);
            this.cmbpatientname.Name = "cmbpatientname";
            this.cmbpatientname.Size = new System.Drawing.Size(172, 24);
            this.cmbpatientname.TabIndex = 59;
            this.cmbpatientname.SelectedIndexChanged += new System.EventHandler(this.cmbpatientname_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(571, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 55;
            this.label8.Text = "Supplier Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(565, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 16);
            this.label9.TabIndex = 56;
            this.label9.Text = "Company Name:";
            // 
            // txtsuppliername
            // 
            this.txtsuppliername.Location = new System.Drawing.Point(671, 103);
            this.txtsuppliername.Name = "txtsuppliername";
            this.txtsuppliername.Size = new System.Drawing.Size(172, 22);
            this.txtsuppliername.TabIndex = 57;
            // 
            // txtcompanyname
            // 
            this.txtcompanyname.Location = new System.Drawing.Point(671, 138);
            this.txtcompanyname.Name = "txtcompanyname";
            this.txtcompanyname.Size = new System.Drawing.Size(172, 22);
            this.txtcompanyname.TabIndex = 58;
            // 
            // dtpexpireddate
            // 
            this.dtpexpireddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpexpireddate.Location = new System.Drawing.Point(671, 72);
            this.dtpexpireddate.Name = "dtpexpireddate";
            this.dtpexpireddate.Size = new System.Drawing.Size(172, 22);
            this.dtpexpireddate.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(579, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 53;
            this.label7.Text = "Expired Date:";
            // 
            // dtpmfgdate
            // 
            this.dtpmfgdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpmfgdate.Location = new System.Drawing.Point(671, 37);
            this.dtpmfgdate.Name = "dtpmfgdate";
            this.dtpmfgdate.Size = new System.Drawing.Size(172, 22);
            this.dtpmfgdate.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Referred Medicines:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(601, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 51;
            this.label6.Text = "Mfg Date:";
            // 
            // txtreferredmedicines
            // 
            this.txtreferredmedicines.Location = new System.Drawing.Point(343, 160);
            this.txtreferredmedicines.Name = "txtreferredmedicines";
            this.txtreferredmedicines.Size = new System.Drawing.Size(172, 22);
            this.txtreferredmedicines.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doctor\'s Name:";
            // 
            // dgvmedicinesdetails
            // 
            this.dgvmedicinesdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmedicinesdetails.Location = new System.Drawing.Point(97, 257);
            this.dgvmedicinesdetails.Name = "dgvmedicinesdetails";
            this.dgvmedicinesdetails.Size = new System.Drawing.Size(950, 190);
            this.dgvmedicinesdetails.TabIndex = 35;
            this.dgvmedicinesdetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmedicinesdetails_CellClick);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(908, 204);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(98, 25);
            this.btnclose.TabIndex = 11;
            this.btnclose.Text = "CLOSE";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(784, 204);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(98, 25);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(669, 204);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(98, 25);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.Btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(552, 204);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(98, 25);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.Btnadd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Visitor No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Name:";
            // 
            // medicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Name = "medicines";
            this.Text = "medicines";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Medicines_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpContainer.ResumeLayout(false);
            this.grpContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmedicinesdetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grpContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvmedicinesdetails;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsuppliername;
        private System.Windows.Forms.TextBox txtcompanyname;
        private System.Windows.Forms.DateTimePicker dtpexpireddate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpmfgdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtreferredmedicines;
        private System.Windows.Forms.ComboBox cmbdoctorname;
        private System.Windows.Forms.ComboBox cmbpatientname;
        private System.Windows.Forms.TextBox txtvisitorno;
    }
}