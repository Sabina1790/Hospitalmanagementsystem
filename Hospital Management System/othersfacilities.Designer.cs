namespace Hospital_Management_System
{
    partial class othersfacilities
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
            this.grpContainer = new System.Windows.Forms.GroupBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdoctorfee = new System.Windows.Forms.TextBox();
            this.dgvothers = new System.Windows.Forms.DataGridView();
            this.btnclose = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtstafffee = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtambulancedriver = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvothers)).BeginInit();
            this.SuspendLayout();
            // 
            // grpContainer
            // 
            this.grpContainer.Controls.Add(this.dtpdate);
            this.grpContainer.Controls.Add(this.label1);
            this.grpContainer.Controls.Add(this.label7);
            this.grpContainer.Controls.Add(this.txtdoctorfee);
            this.grpContainer.Controls.Add(this.dgvothers);
            this.grpContainer.Controls.Add(this.btnclose);
            this.grpContainer.Controls.Add(this.btndelete);
            this.grpContainer.Controls.Add(this.btnupdate);
            this.grpContainer.Controls.Add(this.btnadd);
            this.grpContainer.Controls.Add(this.txtstafffee);
            this.grpContainer.Controls.Add(this.txtcontact);
            this.grpContainer.Controls.Add(this.txtambulancedriver);
            this.grpContainer.Controls.Add(this.label9);
            this.grpContainer.Controls.Add(this.label4);
            this.grpContainer.Controls.Add(this.label3);
            this.grpContainer.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContainer.Location = new System.Drawing.Point(26, 78);
            this.grpContainer.Name = "grpContainer";
            this.grpContainer.Size = new System.Drawing.Size(894, 435);
            this.grpContainer.TabIndex = 37;
            this.grpContainer.TabStop = false;
            this.grpContainer.Text = "Enter the following details:";
            // 
            // dtpdate
            // 
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(199, 185);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(172, 22);
            this.dtpdate.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Doctor\'s Fee:";
            // 
            // txtdoctorfee
            // 
            this.txtdoctorfee.Location = new System.Drawing.Point(199, 112);
            this.txtdoctorfee.Name = "txtdoctorfee";
            this.txtdoctorfee.Size = new System.Drawing.Size(172, 22);
            this.txtdoctorfee.TabIndex = 4;
            // 
            // dgvothers
            // 
            this.dgvothers.AllowUserToAddRows = false;
            this.dgvothers.AllowUserToDeleteRows = false;
            this.dgvothers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvothers.Location = new System.Drawing.Point(81, 228);
            this.dgvothers.Name = "dgvothers";
            this.dgvothers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvothers.Size = new System.Drawing.Size(747, 113);
            this.dgvothers.TabIndex = 35;
            this.dgvothers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvothers_CellClick);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(715, 186);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(98, 25);
            this.btnclose.TabIndex = 9;
            this.btnclose.Text = "CLOSE";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(611, 186);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(98, 25);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(507, 186);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(98, 25);
            this.btnupdate.TabIndex = 7;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(403, 185);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(98, 25);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtstafffee
            // 
            this.txtstafffee.Location = new System.Drawing.Point(199, 148);
            this.txtstafffee.Name = "txtstafffee";
            this.txtstafffee.Size = new System.Drawing.Size(172, 22);
            this.txtstafffee.TabIndex = 5;
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(199, 76);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(172, 22);
            this.txtcontact.TabIndex = 2;
            // 
            // txtambulancedriver
            // 
            this.txtambulancedriver.Location = new System.Drawing.Point(199, 45);
            this.txtambulancedriver.Name = "txtambulancedriver";
            this.txtambulancedriver.Size = new System.Drawing.Size(172, 22);
            this.txtambulancedriver.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(135, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Contact:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ambulance Driver:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Staff\'s Fee:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(334, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 54);
            this.label11.TabIndex = 38;
            this.label11.Text = "Others ";
            // 
            // othersfacilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 525);
            this.Controls.Add(this.grpContainer);
            this.Controls.Add(this.label11);
            this.Name = "othersfacilities";
            this.Text = "othersfacilities";
            this.Load += new System.EventHandler(this.othersfacilities_Load);
            this.grpContainer.ResumeLayout(false);
            this.grpContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvothers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdoctorfee;
        private System.Windows.Forms.DataGridView dgvothers;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtstafffee;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.TextBox txtambulancedriver;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpdate;
    }
}