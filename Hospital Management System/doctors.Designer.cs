namespace Hospital_Management_System
{
    partial class doctors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doctors));
            this.grpContainer = new System.Windows.Forms.GroupBox();
            this.cmbbloodgroup = new System.Windows.Forms.ComboBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.dgvdoctorsdetails = new System.Windows.Forms.DataGridView();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtreferringrate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.btnclose = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtspeciality = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtreferringno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoctorsdetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpContainer
            // 
            this.grpContainer.Controls.Add(this.cmbbloodgroup);
            this.grpContainer.Controls.Add(this.cmbgender);
            this.grpContainer.Controls.Add(this.dgvdoctorsdetails);
            this.grpContainer.Controls.Add(this.btnbrowse);
            this.grpContainer.Controls.Add(this.pictureBox1);
            this.grpContainer.Controls.Add(this.txtreferringrate);
            this.grpContainer.Controls.Add(this.label7);
            this.grpContainer.Controls.Add(this.txtaddress);
            this.grpContainer.Controls.Add(this.dtpdob);
            this.grpContainer.Controls.Add(this.btnclose);
            this.grpContainer.Controls.Add(this.btndelete);
            this.grpContainer.Controls.Add(this.btnupdate);
            this.grpContainer.Controls.Add(this.btnadd);
            this.grpContainer.Controls.Add(this.txtcontact);
            this.grpContainer.Controls.Add(this.txtspeciality);
            this.grpContainer.Controls.Add(this.txtlastname);
            this.grpContainer.Controls.Add(this.txtfirstname);
            this.grpContainer.Controls.Add(this.txtreferringno);
            this.grpContainer.Controls.Add(this.label10);
            this.grpContainer.Controls.Add(this.label9);
            this.grpContainer.Controls.Add(this.label8);
            this.grpContainer.Controls.Add(this.label6);
            this.grpContainer.Controls.Add(this.label5);
            this.grpContainer.Controls.Add(this.label4);
            this.grpContainer.Controls.Add(this.label3);
            this.grpContainer.Controls.Add(this.label2);
            this.grpContainer.Controls.Add(this.label1);
            this.grpContainer.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContainer.Location = new System.Drawing.Point(12, 82);
            this.grpContainer.Name = "grpContainer";
            this.grpContainer.Size = new System.Drawing.Size(1163, 426);
            this.grpContainer.TabIndex = 1;
            this.grpContainer.TabStop = false;
            this.grpContainer.Text = "Enter the following details:";
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
            this.cmbbloodgroup.Location = new System.Drawing.Point(470, 179);
            this.cmbbloodgroup.Name = "cmbbloodgroup";
            this.cmbbloodgroup.Size = new System.Drawing.Size(172, 24);
            this.cmbbloodgroup.TabIndex = 36;
            // 
            // cmbgender
            // 
            this.cmbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cmbgender.Location = new System.Drawing.Point(470, 74);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(172, 24);
            this.cmbgender.TabIndex = 35;
            // 
            // dgvdoctorsdetails
            // 
            this.dgvdoctorsdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdoctorsdetails.Location = new System.Drawing.Point(18, 228);
            this.dgvdoctorsdetails.Name = "dgvdoctorsdetails";
            this.dgvdoctorsdetails.Size = new System.Drawing.Size(1123, 161);
            this.dgvdoctorsdetails.TabIndex = 34;
            this.dgvdoctorsdetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvdoctorsdetails_CellContentClick);
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(968, 88);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(138, 25);
            this.btnbrowse.TabIndex = 11;
            this.btnbrowse.Text = "BROWSE IMAGE";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.Btnbrowse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(709, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 129);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // txtreferringrate
            // 
            this.txtreferringrate.Location = new System.Drawing.Point(470, 144);
            this.txtreferringrate.Name = "txtreferringrate";
            this.txtreferringrate.Size = new System.Drawing.Size(172, 22);
            this.txtreferringrate.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Referring Rate:";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(470, 111);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(172, 22);
            this.txtaddress.TabIndex = 8;
            // 
            // dtpdob
            // 
            this.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdob.Location = new System.Drawing.Point(470, 39);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(172, 22);
            this.dtpdob.TabIndex = 6;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(1043, 178);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(98, 25);
            this.btnclose.TabIndex = 15;
            this.btnclose.Text = "CLOSE";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(919, 178);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(98, 25);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(804, 178);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(98, 25);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.Btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(687, 178);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(98, 25);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.Btnadd_Click);
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(115, 186);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(172, 22);
            this.txtcontact.TabIndex = 5;
            // 
            // txtspeciality
            // 
            this.txtspeciality.Location = new System.Drawing.Point(115, 150);
            this.txtspeciality.Name = "txtspeciality";
            this.txtspeciality.Size = new System.Drawing.Size(172, 22);
            this.txtspeciality.TabIndex = 4;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(115, 111);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(172, 22);
            this.txtlastname.TabIndex = 3;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(115, 76);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(172, 22);
            this.txtfirstname.TabIndex = 2;
            // 
            // txtreferringno
            // 
            this.txtreferringno.Location = new System.Drawing.Point(115, 39);
            this.txtreferringno.Name = "txtreferringno";
            this.txtreferringno.Size = new System.Drawing.Size(172, 22);
            this.txtreferringno.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(377, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Blood Group:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "First Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Referring No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Speciality:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(306, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(536, 54);
            this.label11.TabIndex = 35;
            this.label11.Text = "DETAILS OF DOCTORS";
            // 
            // doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 535);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grpContainer);
            this.Name = "doctors";
            this.Text = "doctors";
            this.Load += new System.EventHandler(this.Doctors_Load);
            this.grpContainer.ResumeLayout(false);
            this.grpContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoctorsdetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpContainer;
        private System.Windows.Forms.TextBox txtreferringrate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.TextBox txtspeciality;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtreferringno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvdoctorsdetails;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.ComboBox cmbbloodgroup;
    }
}