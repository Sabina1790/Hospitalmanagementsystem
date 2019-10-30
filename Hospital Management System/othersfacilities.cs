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
    public partial class othersfacilities : Form
    {
        public othersfacilities()
        {
            InitializeComponent();
        }
        BusinessLogicLayer blc = new BusinessLogicLayer();
        others o = new others();
        HelperClass hc = new HelperClass();
        public int Id;

        private void othersfacilities_Load(object sender, EventArgs e)
        {
            dgvothers.DataSource = o.GetAllOthers();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtambulancedriver.Text == "")
            {
                MessageBox.Show("Provide Driver's Name: Full information required");
                return;
            }
            else if (txtcontact.Text == "")
            {
                MessageBox.Show("Provide Contact: Full information required");
                return;
            }
            else if (txtdoctorfee.Text == "")
            {
                MessageBox.Show("Provide Doctor's Fee: Full information required");
                return;
            }
            else if (txtstafffee.Text == "")
            {
                MessageBox.Show("Provide Staff's Fee: Full information required");
                return;
            }
            else if (dtpdate.Text == "")
            {
                MessageBox.Show("Provide Date: Full information required");
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
                bool res = blc.Others(0,
                    txtambulancedriver.Text,
                   Convert.ToInt32(txtcontact.Text),
                   Convert.ToInt32(txtdoctorfee.Text),
                   Convert.ToInt32(txtstafffee.Text),
                   Convert.ToDateTime(dtpdate.Text),
                       1);
                if (res == true)
                {
                    //display message of adding cabin in database
                    MessageBox.Show("Success to Add Others");
                    dgvothers.DataSource = o.GetAllOthers();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
                else
                {
                    //display error message as data cannot be stored
                    MessageBox.Show("Couldn't Add selected Others");
                    dgvothers.DataSource = o.GetAllOthers();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = blc.Others(Id,
                    txtambulancedriver.Text,
                   Convert.ToInt32(txtcontact.Text),
                   Convert.ToInt32(txtdoctorfee.Text),
                   Convert.ToInt32(txtstafffee.Text),
                   Convert.ToDateTime(dtpdate.Text),
                       2);
                if (res == true)
                {

                    MessageBox.Show("Success to Update Others");
                    dgvothers.DataSource = o.GetAllOthers();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
                else
                {
                    //display error message as data cannot be updated
                    MessageBox.Show("Couldn't Update selected Others");
                    dgvothers.DataSource = o.GetAllOthers();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you surely want to delete?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                bool res = blc.Others(Id,
                    txtambulancedriver.Text,
                   Convert.ToInt32(txtcontact.Text),
                   Convert.ToInt32(txtdoctorfee.Text),
                   Convert.ToInt32(txtstafffee.Text),
                   Convert.ToDateTime(dtpdate.Text),
                       3);
                if (res == true)
                {
                    //display message of successfully deleted
                    MessageBox.Show("Success to Delete others information");
                    dgvothers.DataSource = o.GetAllOthers();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
                else
                {
                    //display error message as data cannot be deleted
                    MessageBox.Show("Couldn't Delete selected Others information");
                    dgvothers.DataSource = o.GetAllOthers();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvothers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(dgvothers.SelectedRows[0].Cells["PatientId"].Value.ToString());
                txtambulancedriver.Text = dgvothers.SelectedRows[0].Cells["AmbulanceDriver"].Value.ToString();
                txtcontact.Text = dgvothers.SelectedRows[0].Cells["Contact"].Value.ToString();
                txtdoctorfee.Text = dgvothers.SelectedRows[0].Cells["DoctorsFee"].Value.ToString();
                txtstafffee.Text = dgvothers.SelectedRows[0].Cells["StaffsFee"].Value.ToString();
                dtpdate.Text = dgvothers.SelectedRows[0].Cells["Date"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
