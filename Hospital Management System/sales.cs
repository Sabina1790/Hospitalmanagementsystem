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
    public partial class sales : Form
    {
        public sales()
        {
            InitializeComponent();
        }
        SaleClass sc = new SaleClass();
        BusinessLogicLayer blc = new BusinessLogicLayer();
        HelperClass hc = new HelperClass();
        public int SaleId;
        PatientClass pc = new PatientClass();
        DoctorClass dc = new DoctorClass();

        private void Btnadd_Click(object sender, EventArgs e)
        {
            if (txtvisitorno.Text == "")
            {
                MessageBox.Show("Provide Visitor No: Full information required");
                return;
            }
            else if (txtpatientname.Text == "")
            {
                MessageBox.Show("Provide patient Name: Full information required");
                return;
            }
            else if (txtreferringno.Text == "")
            {
                MessageBox.Show("Provide Referring No: Full information required");
                return;
            }
            else if (txtdoctorsname.Text == "")
            {
                MessageBox.Show("Provide Doctor Name: Full information required");
                return;
            }
            else if (txtreferredmedicines.Text == "")
            {
                MessageBox.Show("Provide Referred Medicines: Full information required");
                return;
            }
            else if (txtsalesprice.Text == "")
            {
                MessageBox.Show("Provide Sales Price: Full information required");
                return;
            }
            else if (txtquantity.Text == "")
            {
                MessageBox.Show("Provide Quantity: Full information required");
                return;
            }
            else if (txttotalprice.Text == "")
            {
                MessageBox.Show("Provide Total Price: Full information required");
                return;
            }

            else if (Dublicatesale() == true)
            {
                MessageBox.Show("Already exists");
                txtvisitorno.Clear();
                txtvisitorno.Focus();
                return;
            }
            { CreateSale(); }
        }

        //create sale
        private void CreateSale()
        {
            //try catch exception
            try
            {
                bool res = blc.SaleTable(0,
                   Convert.ToInt32(txtvisitorno.Text),
                   txtpatientname.Text,
                   Convert.ToInt32(txtreferringno.Text),
                   txtdoctorsname.Text,
                   txtreferredmedicines.Text,
                   Convert.ToInt32(txtsalesprice.Text),
                   Convert.ToInt32(txtquantity.Text),
                   Convert.ToInt32(txttotalprice.Text),
                   HelperClass.imageConverter(pictureBox1),
                   HelperClass.imageConverter(pictureBox2),
                       1);
                if (res == true)
                {
                    //display message of adding sale in database
                    MessageBox.Show("Success to Add Sale");
                    dgvsalesdetails.DataSource = sc.GetAllSales();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;
                }
                else
                {
                    //display error message as data cannot be stored
                    MessageBox.Show("Couldn't Add selected sale");
                    dgvsalesdetails.DataSource = sc.GetAllSales();
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
        public bool Dublicatesale()
        {
            int x = 0;
            try
            {

                for (int i = 0; i < dgvsalesdetails.Rows.Count; i++)
                {
                    if (txtvisitorno.Text == dgvsalesdetails.Rows[i].Cells["VisitirNo"].Value.ToString())
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
                bool res = blc.SaleTable(SaleId,
                   Convert.ToInt32(txtvisitorno.Text),
                   txtpatientname.Text,
                   Convert.ToInt32(txtreferringno.Text),
                   txtdoctorsname.Text,
                   txtreferredmedicines.Text,
                   Convert.ToInt32(txtsalesprice.Text),
                   Convert.ToInt32(txtquantity.Text),
                   Convert.ToInt32(txttotalprice.Text),
                   HelperClass.imageConverter(pictureBox1),
                   HelperClass.imageConverter(pictureBox2),
                       2);
                if (res == true)
                {
                    //display message of adding memeber in database
                    MessageBox.Show("Success to Update Sale");
                    dgvsalesdetails.DataSource = sc.GetAllSales();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;
                }
                else
                {
                    //display error message as data cannot be stored
                    MessageBox.Show("Couldn't Update selected sale");
                    dgvsalesdetails.DataSource = sc.GetAllSales();
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
                bool res = blc.SaleTable(SaleId,
                   Convert.ToInt32(txtvisitorno.Text),
                   txtpatientname.Text,
                   Convert.ToInt32(txtreferringno.Text),
                   txtdoctorsname.Text,
                   txtreferredmedicines.Text,
                   Convert.ToInt32(txtsalesprice.Text),
                   Convert.ToInt32(txtquantity.Text),
                   Convert.ToInt32(txttotalprice.Text),
                   HelperClass.imageConverter(pictureBox1),
                   HelperClass.imageConverter(pictureBox2),
                       3);
                if (res == true)
                {
                    //display message of adding memeber in database
                    MessageBox.Show("Success to Delete Sale");
                    dgvsalesdetails.DataSource = sc.GetAllSales();
                    HelperClass.makeFieldsBlank(grpContainer);
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;
                }
                else
                {
                    //display error message as data cannot be stored
                    MessageBox.Show("Couldn't Delete selected sale");
                    dgvsalesdetails.DataSource = sc.GetAllSales();
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

        private void Dgvsalesdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SaleId = Convert.ToInt32(dgvsalesdetails.SelectedRows[0].Cells["SaleId"].Value.ToString());
                txtvisitorno.Text = dgvsalesdetails.SelectedRows[0].Cells["VisitorNo"].Value.ToString();
                txtpatientname.Text = dgvsalesdetails.SelectedRows[0].Cells["PatientName"].Value.ToString();
                txtreferringno.Text = dgvsalesdetails.SelectedRows[0].Cells["ReferringNo"].Value.ToString();
                txtdoctorsname.Text = dgvsalesdetails.SelectedRows[0].Cells["DoctorName"].Value.ToString();
                txtreferredmedicines.Text = dgvsalesdetails.SelectedRows[0].Cells["ReferredMedicines"].Value.ToString();
                txtsalesprice.Text = dgvsalesdetails.SelectedRows[0].Cells["SalesPrice"].Value.ToString();
                txtquantity.Text = dgvsalesdetails.SelectedRows[0].Cells["Quantity"].Value.ToString();
                txttotalprice.Text = dgvsalesdetails.SelectedRows[0].Cells["TotalPrice"].Value.ToString();
                MemoryStream memoryStream = new MemoryStream((byte[])dgvsalesdetails.SelectedRows[0].Cells["Image"].Value);
                pictureBox1.Image = Image.FromStream(memoryStream);
                pictureBox2.Image = Image.FromStream(memoryStream);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            dgvsalesdetails.DataSource = sc.GetAllSales();
            
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnprint_Click(object sender, EventArgs e)
        {

        }
    }
}
