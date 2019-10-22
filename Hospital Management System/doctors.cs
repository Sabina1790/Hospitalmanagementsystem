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
    public partial class doctors : Form
    {
        public doctors()
        {
            InitializeComponent();
        }

        BusinessLogicLayer blc = new BusinessLogicLayer();
        DoctorClass dc = new DoctorClass();
        HelperClass hc = new HelperClass();
        public int DoctorId;

        private void Btnadd_Click(object sender, System.EventArgs e)
        {
            if (txtreferringno.Text == "")
            {
                MessageBox.Show("Provide Referring No: Full information required");
                return;
            }
            else if (txtfirstname.Text == "")
            {
                MessageBox.Show("Provide First Name: Full information required");
                return;
            }
            else if (txtlastname.Text == "")
            {
                MessageBox.Show("Provide Last Name: Full information required");
                return;
            }
            else if (txtspeciality.Text == "")
            {
                MessageBox.Show("Provide Speciality: Full information required");
                return;
            }
            else if (txtcontact.Text == "")
            {
                MessageBox.Show("Provide Contact No: Full information required");
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
            else if (txtreferringrate.Text == "")
            {
                MessageBox.Show("Provide Referring Rate: Full information required");
                return;
            }
            else if (cmbbloodgroup.SelectedIndex == -1)
            {
                MessageBox.Show("Provide Blood Group: Full information required");
                return;
            }
            else if (btnbrowse.Text == "")
            {
                MessageBox.Show("Provide Image: Full information required");
                return;
            }
            else if (DublicateDoctor() == true)
            {
                MessageBox.Show("Doctor with same name already exists");
                txtfirstname.Clear();
                txtfirstname.Focus();
                return;
            }
            { CreateDoctor(); }
        }

        //create user
        private void CreateDoctor()
        {
            //try catch exception
            try
            {
                bool res = blc.DoctorTable(0,
                   Convert.ToInt32(txtreferringno.Text),
                   txtfirstname.Text,
                   txtlastname.Text,
                   txtspeciality.Text,
                   Convert.ToInt32(txtcontact.Text),
                   Convert.ToDateTime(dtpdob.Text),
                   cmbgender.Text,
                   txtaddress.Text,
                   Convert.ToInt32(txtreferringrate.Text),
                   cmbbloodgroup.Text,
                   HelperClass.imageConverter(pictureBox1),
                       1);
                if (res == true)
                {
                    //display message of adding doctor in database
                    MessageBox.Show("Success to Add Doctor");
                    dgvdoctorsdetails.DataSource = dc.GetAllDoctors();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
                }
                else
                {
                    //display error message as data cannot be stored
                    MessageBox.Show("Couldn't Add selected doctor");
                    dgvdoctorsdetails.DataSource = dc.GetAllDoctors();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //helps in data store as if doctors have same information
        public bool DublicateDoctor()
        {
            int x = 0;
            try
            {

                for (int i = 0; i < dgvdoctorsdetails.Rows.Count; i++)
                {
                    if (txtfirstname.Text == dgvdoctorsdetails.Rows[i].Cells["FirstName"].Value.ToString())
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
                        MessageBox.Show("Please select a doctor picture");
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

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            //try catch exception
            try
            {
                bool res = blc.DoctorTable(DoctorId,
                   Convert.ToInt32(txtreferringno.Text),
                   txtfirstname.Text,
                   txtlastname.Text,
                   txtspeciality.Text,
                   Convert.ToInt32(txtcontact.Text),
                   Convert.ToDateTime(dtpdob.Text),
                   cmbgender.Text,
                   txtaddress.Text,
                   Convert.ToInt32(txtreferringrate.Text),
                   cmbbloodgroup.Text,
                   HelperClass.imageConverter(pictureBox1),
                       2);
                if (res == true)
                {
                    //display message of adding doctor in database
                    MessageBox.Show("Success to Update Doctor");
                    dgvdoctorsdetails.DataSource = dc.GetAllDoctors();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
                }
                else
                {
                    //display error message as data cannot be stored
                    MessageBox.Show("Couldn't Update selected doctor");
                    dgvdoctorsdetails.DataSource = dc.GetAllDoctors();
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
            //try catch exception
            try
            {
                bool res = blc.DoctorTable(DoctorId,
                   Convert.ToInt32(txtreferringno.Text),
                   txtfirstname.Text,
                   txtlastname.Text,
                   txtspeciality.Text,
                   Convert.ToInt32(txtcontact.Text),
                   Convert.ToDateTime(dtpdob.Text),
                   cmbgender.Text,
                   txtaddress.Text,
                   Convert.ToInt32(txtreferringrate.Text),
                   cmbbloodgroup.Text,
                   HelperClass.imageConverter(pictureBox1),
                       3);
                if (res == true)
                {
                    //display message of adding doctor in database
                    MessageBox.Show("Success to Delete Doctor");
                    dgvdoctorsdetails.DataSource = dc.GetAllDoctors();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
                }
                else
                {
                    //display error message as data cannot be stored
                    MessageBox.Show("Couldn't Delete selected doctor");
                    dgvdoctorsdetails.DataSource = dc.GetAllDoctors();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Doctors_Load(object sender, EventArgs e)
        {
            dgvdoctorsdetails.DataSource = dc.GetAllDoctors();
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvdoctorsdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DoctorId = Convert.ToInt32(dgvdoctorsdetails.SelectedRows[0].Cells["DoctorId"].Value.ToString());
                txtreferringno.Text = dgvdoctorsdetails.SelectedRows[0].Cells["ReferringNo"].Value.ToString();
                txtfirstname.Text = dgvdoctorsdetails.SelectedRows[0].Cells["FirstName"].Value.ToString();
                txtlastname.Text = dgvdoctorsdetails.SelectedRows[0].Cells["LastName"].Value.ToString();
                txtspeciality.Text = dgvdoctorsdetails.SelectedRows[0].Cells["Speciality"].Value.ToString();
                txtcontact.Text = dgvdoctorsdetails.SelectedRows[0].Cells["ContactNo"].Value.ToString();
                dtpdob.Text = dgvdoctorsdetails.SelectedRows[0].Cells["DOB"].Value.ToString();
                cmbgender.Text = dgvdoctorsdetails.SelectedRows[0].Cells["Gender"].Value.ToString();
                txtaddress.Text = dgvdoctorsdetails.SelectedRows[0].Cells["Address"].Value.ToString();
                txtreferringrate.Text = dgvdoctorsdetails.SelectedRows[0].Cells["ReferringRate"].Value.ToString();
                cmbbloodgroup.Text = dgvdoctorsdetails.SelectedRows[0].Cells["BloodGroup"].Value.ToString();
                MemoryStream memoryStream = new MemoryStream((byte[])dgvdoctorsdetails.SelectedRows[0].Cells["Image"].Value);
                pictureBox1.Image = Image.FromStream(memoryStream);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
