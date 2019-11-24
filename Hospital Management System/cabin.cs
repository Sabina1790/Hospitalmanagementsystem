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
    public partial class cabin : Form
    {
        public cabin()
        {
            InitializeComponent();
        }
        BusinessLogicLayer blc = new BusinessLogicLayer();
        CabinClass cc = new CabinClass();
        HelperClass hc = new HelperClass();
        DoctorClass dc = new DoctorClass();
        StaffClass sc = new StaffClass();

        public int CabinId;

        private void Cabin_Load(object sender, System.EventArgs e)
        {
            dgvcabindetails.DataSource = cc.GetAllCabins();
            cmbdoctorname.DataSource = dc.GetAllDoctors();
            cmbdoctorname.DisplayMember = "FirstName";
            cmbdoctorname.ValueMember = "FirstName";
            cmbdoctorname.SelectedValue = -1;
            cmbstaffname.DataSource = sc.GetAllStaffs();
            cmbstaffname.DisplayMember = "StaffName";
            cmbstaffname.ValueMember = "StaffName";
            cmbstaffname.SelectedValue = -1;
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {

            if (txtcabinno.Text == "")
            {
                MessageBox.Show("Provide Staff No: Full information required");
                return;
            }           
            else if (txtroomno.Text == "")
            {
                MessageBox.Show("Provide Staff Name: Full information required");
                return;
            }
            else if (cmbcabintype.Text == "")
            {
                MessageBox.Show("Provide Category: Full information required");
                return;
            }
           else if (cmbdoctorname.Text == "")
            {
                MessageBox.Show("Provide Doctor's Name: Full information required");
                return;
            }
           else if (cmbstaffname.Text == "")
            {
                MessageBox.Show("Provide Staff's Name: Full information required");
                return;
            }
             else if (DublicateCabin() == true)
            {
                MessageBox.Show("cabin with same number already exists");
                txtcabinno.Clear();
                txtcabinno.Focus();
                return;
            }
            { CreateCabin(); }
        }

        //create staff
        private void CreateCabin()
        {
            //try catch exception
            try
            {
                bool res = blc.CabinTable(0,
                   Convert.ToInt32(txtcabinno.Text),
                   Convert.ToInt32(txtroomno.Text),
                   cmbcabintype.Text,
                   cmbdoctorname.Text,
                   cmbstaffname.Text,
                       1);
                if (res == true)
                {
                    //display message of adding cabin in database
                    MessageBox.Show("Success to Add Cabin");
                    dgvcabindetails.DataSource = cc.GetAllCabins();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
                else
                {
                    //display error message as data cannot be stored
                    MessageBox.Show("Couldn't Add selected Cabin");
                    dgvcabindetails.DataSource = cc.GetAllCabins();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //helps in data store as if users have same information
        public bool DublicateCabin()
        {
            int x = 0;
            try
            {

                for (int i = 0; i < dgvcabindetails.Rows.Count; i++)
                {
                    if (txtcabinno.Text == dgvcabindetails.Rows[i].Cells["CabinNo"].Value.ToString())
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
            //try catch exception
            try
            {
                bool res = blc.CabinTable(CabinId,
                   Convert.ToInt32(txtcabinno.Text),
                   Convert.ToInt32(txtroomno.Text),
                   cmbcabintype.Text,
                   cmbdoctorname.Text,
                   cmbstaffname.Text,
                       2);
                if (res == true)
                {
                    //display message of adding memeber in database
                    MessageBox.Show("Success to Update Cabin");
                    dgvcabindetails.DataSource = cc.GetAllCabins();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
                else
                {
                    //display error message as data cannot be stored
                    MessageBox.Show("Couldn't Update selected Cabin");
                    dgvcabindetails.DataSource = cc.GetAllCabins();
                    HelperClass.makeFieldsBlank(grpContainer);
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
            if (dr == DialogResult.Yes)

            {
                //try catch exception
                try
                {
                    bool res = blc.CabinTable(CabinId,
                       Convert.ToInt32(txtcabinno.Text),
                   Convert.ToInt32(txtroomno.Text),
                   cmbcabintype.Text,
                   cmbdoctorname.Text,
                   cmbstaffname.Text,
                           3);

                    if (res == true)
                    {
                        

                            //display message of adding cabin in database
                            MessageBox.Show("Success to Delete Cabin");
                        dgvcabindetails.DataSource = cc.GetAllCabins();
                        HelperClass.makeFieldsBlank(grpContainer);
                    }
                    else
                    {
                        //display error message as data cannot be stored
                        MessageBox.Show("Couldn't Delete selected Cabin");
                        dgvcabindetails.DataSource = cc.GetAllCabins();
                        HelperClass.makeFieldsBlank(grpContainer);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvcabindetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CabinId = Convert.ToInt32(dgvcabindetails.SelectedRows[0].Cells["CabinId"].Value.ToString());
                txtcabinno.Text = dgvcabindetails.SelectedRows[0].Cells["CabinNo"].Value.ToString();
                txtroomno.Text = dgvcabindetails.SelectedRows[0].Cells["RoomNo"].Value.ToString();
                cmbcabintype.Text = dgvcabindetails.SelectedRows[0].Cells["CabinType"].Value.ToString();
                cmbdoctorname.Text = dgvcabindetails.SelectedRows[0].Cells["Doctor"].Value.ToString();
                cmbstaffname.Text = dgvcabindetails.SelectedRows[0].Cells["Staff"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
