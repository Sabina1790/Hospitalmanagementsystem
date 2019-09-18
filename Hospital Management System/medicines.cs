using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Access_Layer;
using Business_Logic_Layer;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;
using System.IO;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class medicines : Form
    {
        public medicines()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        MedicineClass mc = new MedicineClass();
        BusinessLogicLayer blc = new BusinessLogicLayer();
        HelperClass hc = new HelperClass();
        PatientClass pc = new PatientClass();
        DoctorClass dc = new DoctorClass();
        public int MedicineId;


        private void Btnadd_Click(object sender, EventArgs e)
        {
            if (txtvisitorno.Text == "")
            {
                MessageBox.Show("Provide Visitor No: Full information required");
                return;
            }
            else if (cmbpatientname.Text == "")
            {
                MessageBox.Show("Provide patient Name: Full information required");
                return;
            }
            else if (txtreferringno.Text == "")
            {
                MessageBox.Show("Provide Referring No: Full information required");
                return;
            }
            else if (cmbdoctorname.Text == "")
            {
                MessageBox.Show("Provide Doctor Name: Full information required");
                return;
            }
            else if (txtreferredmedicines.Text == "")
            {
                MessageBox.Show("Provide Referred Medicines: Full information required");
                return;
            }
            else if (dtpmfgdate.Text == "")
            {
                MessageBox.Show("Provide Mfg Date: Full information required");
                return;
            }
            else if(dtpexpireddate.Text == "")
            {
                MessageBox.Show("Provide Expired Date: Full information required");
                return;
            }
            else if (txtsuppliername.Text == "")
            {
                MessageBox.Show("Provide Supplier Name: Full information required");
                return;
            }
            else if (txtcompanyname.Text == "")
            {
                MessageBox.Show("Provide Company Name: Full information required");
                return;
            }
            { CreateMedicine(); }
        }

        //create user
        private void CreateMedicine()
        {
            //try catch exception
            try
            {
                bool res = blc.MedicineTable(0,
                   Convert.ToInt32(txtvisitorno.Text),
                   cmbpatientname.Text,
                   Convert.ToInt32(txtreferringno.Text),
                   cmbdoctorname.Text,
                   txtreferredmedicines.Text,
                   Convert.ToDateTime(dtpmfgdate.Text),
                   Convert.ToDateTime(dtpexpireddate.Text),
                   txtsuppliername.Text,
                   txtcompanyname.Text,
                   HelperClass.imageConverter(pictureBox1),
                   HelperClass.imageConverter(pictureBox2),
                       1);
                if (res == true)
                {
                    //display message of adding memeber in database
                    MessageBox.Show("Success to Add Medicine");
                    dgvmedicinesdetails.DataSource = mc.GetAllmedicines();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;
                }
                else
                {
                    //display error message as data cannot be stored
                    MessageBox.Show("Couldn't Add selected medicine");
                    dgvmedicinesdetails.DataSource = mc.GetAllmedicines();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void Btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = blc.MedicineTable(MedicineId,
                   Convert.ToInt32(txtvisitorno.Text),
                   cmbpatientname.Text,
                   Convert.ToInt32(txtreferringno.Text),
                   cmbdoctorname.Text,
                   txtreferredmedicines.Text,
                   Convert.ToDateTime(dtpmfgdate.Text),
                   Convert.ToDateTime(dtpexpireddate.Text),
                   txtsuppliername.Text,
                   txtcompanyname.Text,
                   HelperClass.imageConverter(pictureBox1),
                   HelperClass.imageConverter(pictureBox2),
                       2);
                if (res == true)
                {
                    //display message of adding memeber in database
                    MessageBox.Show("Success to update Medicine");
                    dgvmedicinesdetails.DataSource = mc.GetAllmedicines();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;
                }
                else
                {
                    //display error message as data cannot be stored
                    MessageBox.Show("Couldn't update selected medicine");
                    dgvmedicinesdetails.DataSource = mc.GetAllmedicines();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you surely want to delete?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                bool res = blc.MedicineTable(MedicineId,
                   Convert.ToInt32(txtvisitorno.Text),
                   cmbpatientname.Text,
                   Convert.ToInt32(txtreferringno.Text),
                   cmbdoctorname.Text,
                   txtreferredmedicines.Text,
                   Convert.ToDateTime(dtpmfgdate.Text),
                   Convert.ToDateTime(dtpexpireddate.Text),
                   txtsuppliername.Text,
                   txtcompanyname.Text,
                   HelperClass.imageConverter(pictureBox1),
                   HelperClass.imageConverter(pictureBox2),
                       3);
                if (res == true)
                {
                    //display message of adding memeber in database
                    MessageBox.Show("Success to delete Medicine");
                    dgvmedicinesdetails.DataSource = mc.GetAllmedicines();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;
                }
                else
                {
                    //display error message as data cannot be stored
                    MessageBox.Show("Couldn't delete selected medicine");
                    dgvmedicinesdetails.DataSource = mc.GetAllmedicines();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void Dgvmedicinesdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MedicineId = Convert.ToInt32(dgvmedicinesdetails.SelectedRows[0].Cells["MedicineId"].Value.ToString());
                txtvisitorno.Text = dgvmedicinesdetails.SelectedRows[0].Cells["VisitorNo"].Value.ToString();
                cmbpatientname.Text = dgvmedicinesdetails.SelectedRows[0].Cells["PatientName"].Value.ToString();
                cmbdoctorname.Text = dgvmedicinesdetails.SelectedRows[0].Cells["ReferringNo"].Value.ToString();
                txtreferringno.Text = dgvmedicinesdetails.SelectedRows[0].Cells["DoctorName"].Value.ToString();
                txtreferredmedicines.Text = dgvmedicinesdetails.SelectedRows[0].Cells["ReferredMedicines"].Value.ToString();
                dtpmfgdate.Text = dgvmedicinesdetails.SelectedRows[0].Cells["MfgDate"].Value.ToString();
                dtpexpireddate.Text = dgvmedicinesdetails.SelectedRows[0].Cells["ExpiredDate"].Value.ToString();
                txtsuppliername.Text = dgvmedicinesdetails.SelectedRows[0].Cells["SupplierName"].Value.ToString();
                txtcompanyname.Text = dgvmedicinesdetails.SelectedRows[0].Cells["CompanyName"].Value.ToString();
                MemoryStream memoryStream = new MemoryStream((byte[])dgvmedicinesdetails.SelectedRows[0].Cells["Image"].Value);
                pictureBox1.Image = Image.FromStream(memoryStream);
                pictureBox2.Image = Image.FromStream(memoryStream);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Medicines_Load(object sender, EventArgs e)
        {
            dgvmedicinesdetails.DataSource = mc.GetAllmedicines();
            cmbpatientname.DataSource = pc.GetAllPatients();
            cmbdoctorname.DataSource = dc.GetAllDoctors();
            cmbpatientname.DisplayMember = "PatientName";
            cmbpatientname.ValueMember = "PatientName";
            cmbpatientname.SelectedValue = -1;
            cmbdoctorname.DisplayMember = "FirstName";
            cmbdoctorname.ValueMember = "FirstName";
            cmbdoctorname.SelectedValue = -1;

        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void Cmbdoctorname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from DoctorTable where FirstName ='" + cmbdoctorname.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string ReferringNo = (string)dr["ReferringNo"].ToString();
                    txtreferringno.Text = ReferringNo;

                    string Image = (string)dr["Image"].ToString();
                    pictureBox2.Text = Image;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }

        private void Cmbpatientname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from PatientTable where PatientName ='" + cmbpatientname.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string VisitorNo = (string)dr["VisitorNo"].ToString();
                    txtvisitorno.Text = VisitorNo;

                    string Image = (string)dr["Image"].ToString();
                    pictureBox1.Text = Image;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
