namespace Hospital_Management_System
{
    partial class patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patients));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvpatientsdetails = new System.Windows.Forms.DataGridView();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.cmbbloodgroup = new System.Windows.Forms.ComboBox();
            this.cmbmaritalstatus = new System.Windows.Forms.ComboBox();
            this.cmbpatienttype = new System.Windows.Forms.ComboBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.txtcontactname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtpatientname = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtvisitorno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpatientsdetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 498);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(277, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(536, 54);
            this.label11.TabIndex = 36;
            this.label11.Text = "DETAILS OF PATIENTS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvpatientsdetails);
            this.groupBox1.Controls.Add(this.btnbrowse);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnclose);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.cmbbloodgroup);
            this.groupBox1.Controls.Add(this.cmbmaritalstatus);
            this.groupBox1.Controls.Add(this.cmbpatienttype);
            this.groupBox1.Controls.Add(this.cmbgender);
            this.groupBox1.Controls.Add(this.dtpdob);
            this.groupBox1.Controls.Add(this.txtcontactname);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.txtpatientname);
            this.groupBox1.Controls.Add(this.txttitle);
            this.groupBox1.Controls.Add(this.txtvisitorno);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1212, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter the following details:";
            // 
            // dgvpatientsdetails
            // 
            this.dgvpatientsdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpatientsdetails.Location = new System.Drawing.Point(19, 228);
            this.dgvpatientsdetails.Name = "dgvpatientsdetails";
            this.dgvpatientsdetails.Size = new System.Drawing.Size(1159, 161);
            this.dgvpatientsdetails.TabIndex = 35;
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(993, 87);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(138, 25);
            this.btnbrowse.TabIndex = 11;
            this.btnbrowse.Text = "BROWSE IMAGE";
            this.btnbrowse.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(734, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 129);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(1080, 186);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(98, 25);
            this.btnclose.TabIndex = 15;
            this.btnclose.Text = "CLOSE";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(956, 186);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(98, 25);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(841, 186);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(98, 25);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(724, 186);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(98, 25);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // cmbbloodgroup
            // 
            this.cmbbloodgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbloodgroup.FormattingEnabled = true;
            this.cmbbloodgroup.Items.AddRange(new object[] {
            "O+",
            "B+",
            "A+",
            "A-",
            "AB+",
            "AB-"});
            this.cmbbloodgroup.Location = new System.Drawing.Point(474, 187);
            this.cmbbloodgroup.Name = "cmbbloodgroup";
            this.cmbbloodgroup.Size = new System.Drawing.Size(172, 24);
            this.cmbbloodgroup.TabIndex = 10;
            // 
            // cmbmaritalstatus
            // 
            this.cmbmaritalstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmaritalstatus.FormattingEnabled = true;
            this.cmbmaritalstatus.Items.AddRange(new object[] {
            "Married",
            "Unmarried"});
            this.cmbmaritalstatus.Location = new System.Drawing.Point(474, 148);
            this.cmbmaritalstatus.Name = "cmbmaritalstatus";
            this.cmbmaritalstatus.Size = new System.Drawing.Size(172, 24);
            this.cmbmaritalstatus.TabIndex = 9;
            // 
            // cmbpatienttype
            // 
            this.cmbpatienttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpatienttype.FormattingEnabled = true;
            this.cmbpatienttype.Items.AddRange(new object[] {
            "Normal",
            "Critical"});
            this.cmbpatienttype.Location = new System.Drawing.Point(474, 107);
            this.cmbpatienttype.Name = "cmbpatienttype";
            this.cmbpatienttype.Size = new System.Drawing.Size(172, 24);
            this.cmbpatienttype.TabIndex = 8;
            // 
            // cmbgender
            // 
            this.cmbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cmbgender.Location = new System.Drawing.Point(474, 70);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(172, 24);
            this.cmbgender.TabIndex = 7;
            // 
            // dtpdob
            // 
            this.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdob.Location = new System.Drawing.Point(474, 33);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(172, 22);
            this.dtpdob.TabIndex = 6;
            // 
            // txtcontactname
            // 
            this.txtcontactname.Location = new System.Drawing.Point(116, 182);
            this.txtcontactname.Name = "txtcontactname";
            this.txtcontactname.Size = new System.Drawing.Size(172, 22);
            this.txtcontactname.TabIndex = 5;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(116, 146);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(172, 22);
            this.txtaddress.TabIndex = 4;
            // 
            // txtpatientname
            // 
            this.txtpatientname.Location = new System.Drawing.Point(116, 107);
            this.txtpatientname.Name = "txtpatientname";
            this.txtpatientname.Size = new System.Drawing.Size(172, 22);
            this.txtpatientname.TabIndex = 3;
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(116, 72);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(172, 22);
            this.txttitle.TabIndex = 2;
            // 
            // txtvisitorno
            // 
            this.txtvisitorno.Location = new System.Drawing.Point(116, 35);
            this.txtvisitorno.Name = "txtvisitorno";
            this.txtvisitorno.Size = new System.Drawing.Size(172, 22);
            this.txtvisitorno.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(357, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Blood Group:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Title:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Marital Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Patient Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Visitor No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Name:";
            // 
            // patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 524);
            this.Controls.Add(this.panel1);
            this.Name = "patients";
            this.Text = "patients";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpatientsdetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcontactname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtpatientname;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.TextBox txtvisitorno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbloodgroup;
        private System.Windows.Forms.ComboBox cmbmaritalstatus;
        private System.Windows.Forms.ComboBox cmbpatienttype;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvpatientsdetails;
        private System.Windows.Forms.Label label11;
    }
}