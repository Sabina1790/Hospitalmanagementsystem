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

namespace Hospital_Management_System
{
    public partial class medicines : Form
    {
        public medicines()
        {
            InitializeComponent();
        }
        MedicineClass mc = new MedicineClass();
        BusinessLogicLayer blc = new BusinessLogicLayer();
        HelperClass hc = new HelperClass();
        public int MedicineId;


        private void Btnadd_Click(object sender, EventArgs e)
        {
            if (txtvisitorno.Text == "")
            {
                MessageBox.Show("Provide Visitor No: Full information required");
            }
            if (txtpatientname.Text == "")
            {
                MessageBox.Show("Provide patient Name: Full information required");
            }
            if (txtreferringno.Text == "")
            {
                MessageBox.Show("Provide Referring No: Full information required");
            }
            if (txtdoctorsname.Text == "")
            {
                MessageBox.Show("Provide Doctor Name: Full information required");
            }
            if (txtreferredmedicines.Text == "")
            {
                MessageBox.Show("Provide Referred Medicines: Full information required");
            }
            if (dtpmfgdate.Text == "")
            {
                MessageBox.Show("Provide Mfg Date: Full information required");
            }
            if(dtpexpireddate.Text == "")
            {
                MessageBox.Show("Provide Expired Date: Full information required");
            }
            if (txtsuppliername.Text == "")
            {
                MessageBox.Show("Provide Supplier Name: Full information required");
            }
            if (txtcompanyname.Text == "")
            {
                MessageBox.Show("Provide Company Name: Full information required");
            }

            else if (DublicateMedicine() == true)
            {
                MessageBox.Show("Already exists");
                txtvisitorno.Clear();
                txtvisitorno.Focus();
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
                   txtpatientname.Text,
                   Convert.ToInt32(txtreferringno.Text),
                   txtdoctorsname.Text,
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


        //helps in data store as if users have same information
        public bool DublicateMedicine()
        {
            int x = 0;
            try
            {

                for (int i = 0; i < dgvmedicinesdetails.Rows.Count; i++)
                {
                    if (txtvisitorno.Text == dgvmedicinesdetails.Rows[i].Cells["VisitirNo"].Value.ToString())
                        x = 1;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            if (x == 1)
                return true;
            else
                return false;

        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = blc.MedicineTable(MedicineId,
                   Convert.ToInt32(txtvisitorno.Text),
                   txtpatientname.Text,
                   Convert.ToInt32(txtreferringno.Text),
                   txtdoctorsname.Text,
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
            try
            {
                bool res = blc.MedicineTable(MedicineId,
                   Convert.ToInt32(txtvisitorno.Text),
                   txtpatientname.Text,
                   Convert.ToInt32(txtreferringno.Text),
                   txtdoctorsname.Text,
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
                txtpatientname.Text = dgvmedicinesdetails.SelectedRows[0].Cells["PatientName"].Value.ToString();
                txtreferringno.Text = dgvmedicinesdetails.SelectedRows[0].Cells["ReferringNo"].Value.ToString();
                txtdoctorsname.Text = dgvmedicinesdetails.SelectedRows[0].Cells["DoctorName"].Value.ToString();
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
        }
    }
}
