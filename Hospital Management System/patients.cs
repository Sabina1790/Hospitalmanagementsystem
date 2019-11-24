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
    public partial class patients : Form
    {
        public patients()
        {
            InitializeComponent();
        }

        PatientClass pc = new PatientClass();
        BusinessLogicLayer blc = new BusinessLogicLayer();
        HelperClass hc = new HelperClass();
        public int PatientId;

        private void Patients_Load(object sender, System.EventArgs e)
        {
            dgvpatientsdetails.DataSource = pc.GetAllPatients();
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            if (txtvisitorno.Text == "")
            {
                MessageBox.Show("Provide Visitor No: Full information required");
                return;
            }
            else if (txttitle.Text == "")
            {
                MessageBox.Show("Provide Title: Full information required");
                return;
            }
            else if (txtpatientname.Text == "")
            {
                MessageBox.Show("Provide Patient Name: Full information required");
                return;
            }
            else if (txtaddress.Text == "")
            {
                MessageBox.Show("Provide Address: Full information required");
                return;
            }
            else if (txtcontactno.Text == "")
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
            else if (cmbpatienttype.SelectedIndex == -1)
            {
                MessageBox.Show("Provide Patient Type: Full information required");
                return;
            }
            else if (cmbpatienttype.SelectedIndex == -1)
            {
                MessageBox.Show("Provide Maritial Status: Full information required");
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
            else if (DublicatePatientNo() == true)
            {
                MessageBox.Show("Patient with same number already exists");
                txtpatientname.Clear();
                txtpatientname.Focus();
                return;
            }
            { CreatePatient(); }
        }

        //create user
        private void CreatePatient()
        {
            //try catch exception
            try
            {
                bool res = blc.PatientTable(0,
                   Convert.ToInt32(txtvisitorno.Text),
                   txttitle.Text,
                   txtpatientname.Text,
                   txtaddress.Text,
                   Convert.ToInt32(txtcontactno.Text),
                   Convert.ToDateTime(dtpdob.Text),
                   cmbgender.Text,
                   cmbpatienttype.Text,
                   cmbmaritalstatus.Text,
                   cmbbloodgroup.Text,
                   HelperClass.imageConverter(pictureBox1),
                       1);
                if (res == true)
                {
                    //display message of adding memeber in database
                    MessageBox.Show("Success to Add patient");
                    dgvpatientsdetails.DataSource = pc.GetAllPatients();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
                }
                else
                {
                    //display error message as data cannot be stored
                    MessageBox.Show("Couldn't Add selected patient");
                    dgvpatientsdetails.DataSource = pc.GetAllPatients();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //helps in data store as if users have same information
        public bool DublicatePatientNo()
        {
            int x = 0;
            try
            {

                for (int i = 0; i < dgvpatientsdetails.Rows.Count; i++)
                {
                    if (txtvisitorno.Text == dgvpatientsdetails.Rows[i].Cells["VisitorNo"].Value.ToString())
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
                        MessageBox.Show("Please select a patient picture");
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
            try
            {
                bool res = blc.PatientTable(PatientId,
                   Convert.ToInt32(txtvisitorno.Text),
                   txttitle.Text,
                   txtpatientname.Text,
                   txtaddress.Text,
                   Convert.ToInt32(txtcontactno.Text),
                   Convert.ToDateTime(dtpdob.Text),
                   cmbgender.Text,
                   cmbpatienttype.Text,
                   cmbmaritalstatus.Text,
                   cmbbloodgroup.Text,
                   HelperClass.imageConverter(pictureBox1),
                       2);
                if (res == true)
                {
                    
                    MessageBox.Show("Success to Update patient");
                    dgvpatientsdetails.DataSource = pc.GetAllPatients();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
                }
                else
                {
                    //display error message as data cannot be updated
                    MessageBox.Show("Couldn't Update selected patient");
                    dgvpatientsdetails.DataSource = pc.GetAllPatients();
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
            if (dr == DialogResult.Yes)
            {
                try
                {
                    bool res = blc.PatientTable(PatientId,
                       Convert.ToInt32(txtvisitorno.Text),
                       txttitle.Text,
                       txtpatientname.Text,
                       txtaddress.Text,
                       Convert.ToInt32(txtcontactno.Text),
                       Convert.ToDateTime(dtpdob.Text),
                       cmbgender.Text,
                       cmbpatienttype.Text,
                       cmbmaritalstatus.Text,
                       cmbbloodgroup.Text,
                       HelperClass.imageConverter(pictureBox1),
                           3);
                    if (res == true)
                    {
                        //display message of successfully deleted
                        MessageBox.Show("Success to Delete patient");
                        dgvpatientsdetails.DataSource = pc.GetAllPatients();
                        HelperClass.makeFieldsBlank(grpContainer);
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        //display error message as data cannot be deleted
                        MessageBox.Show("Couldn't Delete selected patient");
                        dgvpatientsdetails.DataSource = pc.GetAllPatients();
                        HelperClass.makeFieldsBlank(grpContainer);
                        pictureBox1.Image = null;
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

        private void dgvpatientsdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PatientId = Convert.ToInt32(dgvpatientsdetails.SelectedRows[0].Cells["PatientId"].Value.ToString());
                txtvisitorno.Text = dgvpatientsdetails.SelectedRows[0].Cells["VisitorNo"].Value.ToString();
                txttitle.Text = dgvpatientsdetails.SelectedRows[0].Cells["Title"].Value.ToString();
                txtpatientname.Text = dgvpatientsdetails.SelectedRows[0].Cells["PatientName"].Value.ToString();
                txtaddress.Text = dgvpatientsdetails.SelectedRows[0].Cells["Address"].Value.ToString();
                txtcontactno.Text = dgvpatientsdetails.SelectedRows[0].Cells["ContactNo"].Value.ToString();
                dtpdob.Text = dgvpatientsdetails.SelectedRows[0].Cells["DOB"].Value.ToString();
                cmbgender.Text = dgvpatientsdetails.SelectedRows[0].Cells["Gender"].Value.ToString();
                cmbpatienttype.Text = dgvpatientsdetails.SelectedRows[0].Cells["PatientType"].Value.ToString();
                cmbmaritalstatus.Text = dgvpatientsdetails.SelectedRows[0].Cells["MaritialStatus"].Value.ToString();
                cmbbloodgroup.Text = dgvpatientsdetails.SelectedRows[0].Cells["BloodGroup"].Value.ToString();
                MemoryStream memoryStream = new MemoryStream((byte[])dgvpatientsdetails.SelectedRows[0].Cells["Image"].Value);
                pictureBox1.Image = Image.FromStream(memoryStream);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}
