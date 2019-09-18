namespace Hospital_Management_System
{
    partial class cabin
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
            this.label11 = new System.Windows.Forms.Label();
            this.grpContainer = new System.Windows.Forms.GroupBox();
            this.cmbcabintype = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdoctoravailable = new System.Windows.Forms.TextBox();
            this.dgvcabindetails = new System.Windows.Forms.DataGridView();
            this.btnclose = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtstaffavailable = new System.Windows.Forms.TextBox();
            this.txtroomno = new System.Windows.Forms.TextBox();
            this.txtcabinno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcabindetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(390, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(461, 54);
            this.label11.TabIndex = 36;
            this.label11.Text = "DETAILS OF CABIN";
            // 
            // grpContainer
            // 
            this.grpContainer.Controls.Add(this.cmbcabintype);
            this.grpContainer.Controls.Add(this.label7);
            this.grpContainer.Controls.Add(this.txtdoctoravailable);
            this.grpContainer.Controls.Add(this.dgvcabindetails);
            this.grpContainer.Controls.Add(this.btnclose);
            this.grpContainer.Controls.Add(this.btndelete);
            this.grpContainer.Controls.Add(this.btnupdate);
            this.grpContainer.Controls.Add(this.btnadd);
            this.grpContainer.Controls.Add(this.txtstaffavailable);
            this.grpContainer.Controls.Add(this.txtroomno);
            this.grpContainer.Controls.Add(this.txtcabinno);
            this.grpContainer.Controls.Add(this.label9);
            this.grpContainer.Controls.Add(this.label4);
            this.grpContainer.Controls.Add(this.label3);
            this.grpContainer.Controls.Add(this.label1);
            this.grpContainer.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContainer.Location = new System.Drawing.Point(230, 132);
            this.grpContainer.Name = "grpContainer";
            this.grpContainer.Size = new System.Drawing.Size(784, 414);
            this.grpContainer.TabIndex = 0;
            this.grpContainer.TabStop = false;
            this.grpContainer.Text = "Enter the following details:";
            // 
            // cmbcabintype
            // 
            this.cmbcabintype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcabintype.FormattingEnabled = true;
            this.cmbcabintype.Items.AddRange(new object[] {
            "High",
            "Low",
            "Middle"});
            this.cmbcabintype.Location = new System.Drawing.Point(171, 113);
            this.cmbcabintype.Name = "cmbcabintype";
            this.cmbcabintype.Size = new System.Drawing.Size(172, 24);
            this.cmbcabintype.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Doctor Available:";
            // 
            // txtdoctoravailable
            // 
            this.txtdoctoravailable.Location = new System.Drawing.Point(495, 66);
            this.txtdoctoravailable.Name = "txtdoctoravailable";
            this.txtdoctoravailable.Size = new System.Drawing.Size(172, 22);
            this.txtdoctoravailable.TabIndex = 4;
            // 
            // dgvcabindetails
            // 
            this.dgvcabindetails.AllowUserToAddRows = false;
            this.dgvcabindetails.AllowUserToDeleteRows = false;
            this.dgvcabindetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcabindetails.Location = new System.Drawing.Point(69, 224);
            this.dgvcabindetails.Name = "dgvcabindetails";
            this.dgvcabindetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcabindetails.Size = new System.Drawing.Size(609, 157);
            this.dgvcabindetails.TabIndex = 35;
            this.dgvcabindetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvcabindetails_CellContentClick);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(590, 171);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(98, 25);
            this.btnclose.TabIndex = 9;
            this.btnclose.Text = "CLOSE";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(466, 171);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(98, 25);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(351, 171);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(98, 25);
            this.btnupdate.TabIndex = 7;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.Btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(234, 171);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(98, 25);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.Btnadd_Click);
            // 
            // txtstaffavailable
            // 
            this.txtstaffavailable.Location = new System.Drawing.Point(495, 102);
            this.txtstaffavailable.Name = "txtstaffavailable";
            this.txtstaffavailable.Size = new System.Drawing.Size(172, 22);
            this.txtstaffavailable.TabIndex = 5;
            // 
            // txtroomno
            // 
            this.txtroomno.Location = new System.Drawing.Point(171, 81);
            this.txtroomno.Name = "txtroomno";
            this.txtroomno.Size = new System.Drawing.Size(172, 22);
            this.txtroomno.TabIndex = 2;
            // 
            // txtcabinno
            // 
            this.txtcabinno.Location = new System.Drawing.Point(171, 44);
            this.txtcabinno.Name = "txtcabinno";
            this.txtcabinno.Size = new System.Drawing.Size(172, 22);
            this.txtcabinno.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Room No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cabin No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Staff Available:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cabin Type:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.grpContainer);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 608);
            this.panel1.TabIndex = 1;
            // 
            // cabin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 617);
            this.Controls.Add(this.panel1);
            this.Name = "cabin";
            this.Text = "cabin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cabin_Load);
            this.grpContainer.ResumeLayout(false);
            this.grpContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcabindetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grpContainer;
        private System.Windows.Forms.DataGridView dgvcabindetails;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtstaffavailable;
        private System.Windows.Forms.TextBox txtroomno;
        private System.Windows.Forms.TextBox txtcabinno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdoctoravailable;
        private System.Windows.Forms.ComboBox cmbcabintype;
    }
}