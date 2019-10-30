namespace Hospital_Management_System
{
    partial class sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.grpContainer = new System.Windows.Forms.GroupBox();
            this.txtvisitorno = new System.Windows.Forms.TextBox();
            this.cmbdoctorname = new System.Windows.Forms.ComboBox();
            this.cmbpatientname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgrandtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txttotalprice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsalesprice = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvsalesdetails = new System.Windows.Forms.DataGridView();
            this.txtreferredmedicines = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.grpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalesdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.grpContainer);
            this.panel1.Location = new System.Drawing.Point(76, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 590);
            this.panel1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(306, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(459, 54);
            this.label11.TabIndex = 38;
            this.label11.Text = "DETAILS OF SALES";
            // 
            // grpContainer
            // 
            this.grpContainer.Controls.Add(this.txtvisitorno);
            this.grpContainer.Controls.Add(this.cmbdoctorname);
            this.grpContainer.Controls.Add(this.cmbpatientname);
            this.grpContainer.Controls.Add(this.label3);
            this.grpContainer.Controls.Add(this.label4);
            this.grpContainer.Controls.Add(this.label1);
            this.grpContainer.Controls.Add(this.label2);
            this.grpContainer.Controls.Add(this.txtgrandtotal);
            this.grpContainer.Controls.Add(this.label7);
            this.grpContainer.Controls.Add(this.txtdiscount);
            this.grpContainer.Controls.Add(this.btnprint);
            this.grpContainer.Controls.Add(this.label6);
            this.grpContainer.Controls.Add(this.txttotalprice);
            this.grpContainer.Controls.Add(this.label8);
            this.grpContainer.Controls.Add(this.label9);
            this.grpContainer.Controls.Add(this.txtsalesprice);
            this.grpContainer.Controls.Add(this.txtquantity);
            this.grpContainer.Controls.Add(this.label5);
            this.grpContainer.Controls.Add(this.dgvsalesdetails);
            this.grpContainer.Controls.Add(this.txtreferredmedicines);
            this.grpContainer.Controls.Add(this.btnclose);
            this.grpContainer.Controls.Add(this.btndelete);
            this.grpContainer.Controls.Add(this.btnupdate);
            this.grpContainer.Controls.Add(this.btnadd);
            this.grpContainer.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContainer.Location = new System.Drawing.Point(3, 80);
            this.grpContainer.Name = "grpContainer";
            this.grpContainer.Size = new System.Drawing.Size(1197, 488);
            this.grpContainer.TabIndex = 37;
            this.grpContainer.TabStop = false;
            this.grpContainer.Text = "Enter the following details:";
            // 
            // txtvisitorno
            // 
            this.txtvisitorno.Location = new System.Drawing.Point(149, 73);
            this.txtvisitorno.Name = "txtvisitorno";
            this.txtvisitorno.Size = new System.Drawing.Size(172, 22);
            this.txtvisitorno.TabIndex = 67;
            // 
            // cmbdoctorname
            // 
            this.cmbdoctorname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdoctorname.FormattingEnabled = true;
            this.cmbdoctorname.Location = new System.Drawing.Point(149, 111);
            this.cmbdoctorname.Name = "cmbdoctorname";
            this.cmbdoctorname.Size = new System.Drawing.Size(172, 24);
            this.cmbdoctorname.TabIndex = 66;
            this.cmbdoctorname.SelectedIndexChanged += new System.EventHandler(this.cmbdoctorname_SelectedIndexChanged);
            // 
            // cmbpatientname
            // 
            this.cmbpatientname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpatientname.FormattingEnabled = true;
            this.cmbpatientname.Location = new System.Drawing.Point(169, 30);
            this.cmbpatientname.Name = "cmbpatientname";
            this.cmbpatientname.Size = new System.Drawing.Size(172, 24);
            this.cmbpatientname.TabIndex = 65;
            this.cmbpatientname.SelectedIndexChanged += new System.EventHandler(this.cmbpatientname_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "Doctor\'s Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 64;
            this.label4.Text = "Visitor No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "Patient Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Grand Total:";
            // 
            // txtgrandtotal
            // 
            this.txtgrandtotal.Location = new System.Drawing.Point(505, 170);
            this.txtgrandtotal.Name = "txtgrandtotal";
            this.txtgrandtotal.Size = new System.Drawing.Size(172, 22);
            this.txtgrandtotal.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 53;
            this.label7.Text = "Discount:";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(505, 131);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(172, 22);
            this.txtdiscount.TabIndex = 51;
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(805, 68);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(98, 25);
            this.btnprint.TabIndex = 50;
            this.btnprint.Text = "PRINT";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Total Price:";
            // 
            // txttotalprice
            // 
            this.txttotalprice.Location = new System.Drawing.Point(505, 93);
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.Size = new System.Drawing.Size(172, 22);
            this.txttotalprice.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(426, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 45;
            this.label8.Text = "Sales Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(439, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 46;
            this.label9.Text = "Quantity:";
            // 
            // txtsalesprice
            // 
            this.txtsalesprice.Location = new System.Drawing.Point(505, 18);
            this.txtsalesprice.Name = "txtsalesprice";
            this.txtsalesprice.Size = new System.Drawing.Size(172, 22);
            this.txtsalesprice.TabIndex = 6;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(505, 54);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(172, 22);
            this.txtquantity.TabIndex = 7;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Referred Medicines:";
            // 
            // dgvsalesdetails
            // 
            this.dgvsalesdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsalesdetails.Location = new System.Drawing.Point(16, 255);
            this.dgvsalesdetails.Name = "dgvsalesdetails";
            this.dgvsalesdetails.Size = new System.Drawing.Size(1159, 196);
            this.dgvsalesdetails.TabIndex = 35;
            this.dgvsalesdetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsalesdetails_CellClick);
            // 
            // txtreferredmedicines
            // 
            this.txtreferredmedicines.Location = new System.Drawing.Point(161, 146);
            this.txtreferredmedicines.Multiline = true;
            this.txtreferredmedicines.Name = "txtreferredmedicines";
            this.txtreferredmedicines.Size = new System.Drawing.Size(172, 86);
            this.txtreferredmedicines.TabIndex = 5;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(1074, 207);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(98, 25);
            this.btnclose.TabIndex = 12;
            this.btnclose.Text = "CLOSE";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(950, 207);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(98, 25);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(835, 207);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(98, 25);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.Btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(718, 207);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(98, 25);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.Btnadd_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Name = "sales";
            this.Text = "sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpContainer.ResumeLayout(false);
            this.grpContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalesdetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grpContainer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtreferredmedicines;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsalesprice;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttotalprice;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgrandtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtvisitorno;
        private System.Windows.Forms.ComboBox cmbdoctorname;
        private System.Windows.Forms.ComboBox cmbpatientname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvsalesdetails;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}