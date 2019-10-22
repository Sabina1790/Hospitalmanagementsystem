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
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }
        BusinessLogicLayer blc = new BusinessLogicLayer();
        StaffClass stc = new StaffClass();
        HelperClass hc = new HelperClass();
        public int StaffId;

        private void Btnadd_Click(object sender, EventArgs e)
        {
            if (txtstaffno.Text == "")
            {
                MessageBox.Show("Provide Staff No: Full information required");
                return;
            }
            else if (txtstaffname.Text == "")
            {
                MessageBox.Show("Provide Staff Name: Full information required");
                return;
            }
            else if (txtcategory.Text == "")
            {
                MessageBox.Show("Provide Category: Full information required");
                return;
            }
            else if (txtwardno.Text == "")
            {
                MessageBox.Show("Provide Ward No: Full information required");
                return;
            }
            else if (txtqualification.Text == "")
            {
                MessageBox.Show("Provide Qualification: Full information required");
                return;
            }
            else if (dtpdob.Text == "")
            {
                MessageBox.Show("Provide DOB: Full information required");
                return;
            }
            else if (cmbgender.SelectedIndex == -1)
            {
                MessageBox.Show("Provide Gender: Full information required");
                return;
            }
            else if (cmbmaritalstatus.SelectedIndex == -1)
            {
                MessageBox.Show("Provide Maritial Stattus: Full information required");
                return;
            }
            else if (cmbbloodgroup.SelectedIndex == -1)
            {
                MessageBox.Show("Provide Blood Group: Full information required");
                return;
            }
            else if (dtpdutytime.Text == "")
            {
                MessageBox.Show("Provide Duty Time: Full information required");
                return;
            }
            else if (dtpendtime.Text == "")
            {
                MessageBox.Show("Provide end Time: Full information required");
                return;
            }
            else if (btnbrowse.Text == "")
            {
                MessageBox.Show("Provide Image: Full information required");
                return;
            }
            else if (DublicateStaff() == true)
            {
                MessageBox.Show("Staff with same name already exists");
                txtstaffname.Clear();
                txtstaffname.Focus();
                return;
            }
            { CreateStaff(); }
        }

        //create staff
        private void CreateStaff()
        {
            //try catch exception
            try
            {
                bool res = blc.StaffTable(0,
                   Convert.ToInt32(txtstaffno.Text),
                   txtstaffname.Text,
                   txtcategory.Text,
                   Convert.ToInt32(txtwardno.Text),
                   txtqualification.Text,
                   Convert.ToDateTime(dtpdob.Text),
                   cmbgender.Text,
                   cmbmaritalstatus.Text,
                   cmbbloodgroup.Text,
                   Convert.ToDateTime(dtpdutytime.Text),
                   Convert.ToDateTime(dtpendtime.Text),
                   HelperClass.imageConverter(pictureBox1),
                       1);
                if (res == true)
                {
                    //display message of adding staff in database
                    MessageBox.Show("Success to Add staff");
                    dgvstaffdetails.DataSource = stc.GetAllStaffs();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
                }
                else
                {
                    //display error message as data cannot be stored
                    MessageBox.Show("Couldn't Add selected staff");
                    dgvstaffdetails.DataSource = stc.GetAllStaffs();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //helps in data store as if staffs have same information
        public bool DublicateStaff()
        {
            int x = 0;
            try
            {

                for (int i = 0; i < dgvstaffdetails.Rows.Count; i++)
                {
                    if (txtstaffname.Text == dgvstaffdetails.Rows[i].Cells["StaffName"].Value.ToString())
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
                bool res = blc.StaffTable(StaffId,
                   Convert.ToInt32(txtstaffno.Text),
                   txtstaffname.Text,
                   txtcategory.Text,
                   Convert.ToInt32(txtwardno.Text),
                   txtqualification.Text,
                   Convert.ToDateTime(dtpdob.Text),
                   cmbgender.Text,
                   cmbmaritalstatus.Text,
                   cmbbloodgroup.Text,
                   Convert.ToDateTime(dtpdutytime.Text),
                   Convert.ToDateTime(dtpendtime.Text),
                   HelperClass.imageConverter(pictureBox1),
                       2);
                if (res == true)
                {
                    //display message of adding staff in database
                    MessageBox.Show("Success to Update staff");
                    dgvstaffdetails.DataSource = stc.GetAllStaffs();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
                }
                else
                {
                    //display error message as data cannot be stored
                    MessageBox.Show("Couldn't Update selected staff");
                    dgvstaffdetails.DataSource = stc.GetAllStaffs();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
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
                bool res = blc.StaffTable(StaffId,
                   Convert.ToInt32(txtstaffno.Text),
                   txtstaffname.Text,
                   txtcategory.Text,
                   Convert.ToInt32(txtwardno.Text),
                   txtqualification.Text,
                   Convert.ToDateTime(dtpdob.Text),
                   cmbgender.Text,
                   cmbmaritalstatus.Text,
                   cmbbloodgroup.Text,
                   Convert.ToDateTime(dtpdutytime.Text),
                   Convert.ToDateTime(dtpendtime.Text),
                   HelperClass.imageConverter(pictureBox1),
                       3);
                if (res == true)
                {
                    //display message of adding staff in database
                    MessageBox.Show("Success to Delete staff");
                    dgvstaffdetails.DataSource = stc.GetAllStaffs();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
                }
                else
                {
                    //display error message as data cannot be stored
                    MessageBox.Show("Couldn't Delete selected staff");
                    dgvstaffdetails.DataSource = stc.GetAllStaffs();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btnbrowse_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox1.Image = Image.FromFile(ofd.FileName);

                    }
                    else
                    {
                        MessageBox.Show("Please select a staff picture");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            dgvstaffdetails.DataSource = stc.GetAllStaffs();
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvstaffdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                StaffId = Convert.ToInt32(dgvstaffdetails.SelectedRows[0].Cells["StaffId"].Value.ToString());
                txtstaffno.Text = dgvstaffdetails.SelectedRows[0].Cells["StaffNo"].Value.ToString();
                txtstaffname.Text = dgvstaffdetails.SelectedRows[0].Cells["StaffName"].Value.ToString();
                txtcategory.Text = dgvstaffdetails.SelectedRows[0].Cells["Category"].Value.ToString();
                txtwardno.Text = dgvstaffdetails.SelectedRows[0].Cells["WardNo"].Value.ToString();
                txtqualification.Text = dgvstaffdetails.SelectedRows[0].Cells["Qualification"].Value.ToString();
                dtpdob.Text = dgvstaffdetails.SelectedRows[0].Cells["DOB"].Value.ToString();
                cmbgender.Text = dgvstaffdetails.SelectedRows[0].Cells["Gender"].Value.ToString();
                cmbmaritalstatus.Text = dgvstaffdetails.SelectedRows[0].Cells["MaritalStatus"].Value.ToString();
                cmbbloodgroup.Text = dgvstaffdetails.SelectedRows[0].Cells["BloodGroup"].Value.ToString();
                dtpdutytime.Text = dgvstaffdetails.SelectedRows[0].Cells["DutyTime"].Value.ToString();
                dtpendtime.Text = dgvstaffdetails.SelectedRows[0].Cells["DutyTime"].Value.ToString();
                MemoryStream memoryStream = new MemoryStream((byte[])dgvstaffdetails.SelectedRows[0].Cells["Image"].Value);
                pictureBox1.Image = Image.FromStream(memoryStream);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
