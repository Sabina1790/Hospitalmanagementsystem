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
        public int CabinId;

        private void Cabin_Load(object sender, System.EventArgs e)
        {
            dgvcabindetails.DataSource = cc.GetAllCabins();
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
           else if (txtdoctoravailable.Text == "")
            {
                MessageBox.Show("Provide Ward No: Full information required");
                return;
            }
           else if (txtstaffavailable.Text == "")
            {
                MessageBox.Show("Provide Qualification: Full information required");
                return;
            }
             else if (DublicateCabin() == true)
            {
                MessageBox.Show("cabin with same name already exists");
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
                   Convert.ToInt32(txtcabinno.Text),
                   cmbcabintype.Text,
                   txtdoctoravailable.Text,
                   txtstaffavailable.Text,
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
                   Convert.ToInt32(txtcabinno.Text),
                   cmbcabintype.Text,
                   txtdoctoravailable.Text,
                   txtstaffavailable.Text,
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
            //try catch exception
            try
            {
                bool res = blc.CabinTable(CabinId,
                   Convert.ToInt32(txtcabinno.Text),
                   Convert.ToInt32(txtcabinno.Text),
                   cmbcabintype.Text,
                   txtdoctoravailable.Text,
                   txtstaffavailable.Text,
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

        private void Dgvcabindetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CabinId = Convert.ToInt32(dgvcabindetails.SelectedRows[0].Cells["CabinId"].Value.ToString());
                txtcabinno.Text = dgvcabindetails.SelectedRows[0].Cells["CabinNo"].Value.ToString();
                txtroomno.Text = dgvcabindetails.SelectedRows[0].Cells["RoomNo"].Value.ToString();
                cmbcabintype.Text = dgvcabindetails.SelectedRows[0].Cells["CabinType"].Value.ToString();
                txtdoctoravailable.Text = dgvcabindetails.SelectedRows[0].Cells["Doctor"].Value.ToString();
                txtstaffavailable.Text = dgvcabindetails.SelectedRows[0].Cells["Staff"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
