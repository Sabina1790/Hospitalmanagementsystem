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
    public partial class sales : Form
    {
        public sales()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        MedicineClass mc = new MedicineClass();
        BusinessLogicLayer blc = new BusinessLogicLayer();
        HelperClass hc = new HelperClass();
        PatientClass pc = new PatientClass();
        DoctorClass dc = new DoctorClass();
        SaleClass sc = new SaleClass();
        public int SaleId;

        private void Btnadd_Click(object sender, EventArgs e)
        {
            //Get Product Name, Rate and Qty customer wants to buy
            decimal Rate = decimal.Parse(txtsalesprice.Text);
            decimal Qty = decimal.Parse(txtquantity.Text);

            decimal SubTotal = Rate * Qty; //Total=RatexQty

            //Display the Subtotal in textbox
            //Get the subtotal value from textbox
            decimal subTotal = decimal.Parse(txttotalprice.Text);


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
            else if (txtsalesprice.Text == "")
            {
                MessageBox.Show("Provide Sales Price: Full information required");
                return;
            }
            else if (txttotalprice.Text == "")
            {
                MessageBox.Show("Provide Total Price: Full information required");
                return;
            }
            else if (txtgrandtotal.Text == "")
            {
                MessageBox.Show("Provide Grand Total Price: Full information required");
                return;
            }

            //else if (Dublicatesale() == true)
            //{
            //    MessageBox.Show("Already exists");
            //    cmbpatientname.Clear();
            //    cmbpatientname.Focus();
            //    return;
            //}
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
                   cmbpatientname.Text,
                   cmbdoctorname.Text,
                   txtreferredmedicines.Text,
                   Convert.ToDouble(txtsalesprice.Text),
                   Convert.ToInt32(txtquantity.Text),
                   Convert.ToDouble(txttotalprice.Text),
                   Convert.ToDouble(txtdiscount.Text),
                   Convert.ToDouble(txtgrandtotal.Text),
                       1);
                if (res == true)
                {
                    //display message of adding sale in database
                    MessageBox.Show("Success to Add Sale");
                    dgvsalesdetails.DataSource = sc.GetAllSales();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
                else
                {
                    //display error message as data cannot be stored
                    MessageBox.Show("Couldn't Add selected sale");
                    dgvsalesdetails.DataSource = sc.GetAllSales();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //helps in data store as if users have same information
        //public bool Dublicatesale()
        //{
        //    int x = 0;
        //    try
        //    {

        //        for (int i = 0; i < dgvsalesdetails.Rows.Count; i++)
        //        {
        //            if (txtvisitorno.Text == dgvsalesdetails.Rows[i].Cells["PatientName"].Value.ToString())
        //                x = 1;
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //    if (x == 1)
        //        return true;
        //    else
        //        return false;

        //}

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = blc.SaleTable(SaleId,
                   Convert.ToInt32(txtvisitorno.Text),
                   cmbpatientname.Text,
                   cmbdoctorname.Text,
                   txtreferredmedicines.Text,
                   Convert.ToDouble(txtsalesprice.Text),
                   Convert.ToInt32(txtquantity.Text),
                   Convert.ToDouble(txttotalprice.Text),
                   Convert.ToDouble(txtdiscount.Text),
                   Convert.ToDouble(txtgrandtotal.Text),
                       2);
                if (res == true)
                {
                    //display message of adding memeber in database
                    MessageBox.Show("Success to Update Sale");
                    dgvsalesdetails.DataSource = sc.GetAllSales();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
                else
                {
                    //display error message as data cannot be stored
                    MessageBox.Show("Couldn't Update selected sale");
                    dgvsalesdetails.DataSource = sc.GetAllSales();
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
            try
            {
                bool res = blc.SaleTable(SaleId,
                   Convert.ToInt32(txtvisitorno.Text),
                   cmbpatientname.Text,
                   cmbdoctorname.Text,
                   txtreferredmedicines.Text,
                   Convert.ToDouble(txtsalesprice.Text),
                   Convert.ToInt32(txtquantity.Text),
                   Convert.ToDouble(txttotalprice.Text),
                   Convert.ToDouble(txtdiscount.Text),
                   Convert.ToDouble(txtgrandtotal.Text),
                       3);
                if (res == true)
                {
                    //display message of adding memeber in database
                    MessageBox.Show("Success to Delete Sale");
                    dgvsalesdetails.DataSource = sc.GetAllSales();
                    HelperClass.makeFieldsBlank(grpContainer);
                    
                }
                else
                {
                    //display error message as data cannot be stored
                    MessageBox.Show("Couldn't Delete selected sale");
                    dgvsalesdetails.DataSource = sc.GetAllSales();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Sales_Load(object sender, EventArgs e)
        {
            dgvsalesdetails.DataSource = sc.GetAllSales();
            cmbpatientname.DataSource = pc.GetAllPatients();
            cmbdoctorname.DataSource = mc.GetAllmedicines();
            cmbpatientname.DisplayMember = "PatientName";
            cmbpatientname.ValueMember = "PatientName";
            cmbpatientname.SelectedValue = -1;
            cmbdoctorname.DisplayMember = "DoctorName";
            cmbdoctorname.ValueMember = "DoctorName";
            cmbdoctorname.SelectedValue = -1;

        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

              
        /// <summary>
        /// get data of visitorno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbpatientname_SelectedIndexChanged(object sender, EventArgs e)
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
                    return;
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

        private void cmbdoctorname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from MedicinesTable where DoctorName ='" + cmbdoctorname.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string ReferredMedicines = (string)dr["ReferredMedicines"].ToString();
                    txtreferredmedicines.Text = ReferredMedicines;
                    return;
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

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            //Get the value fro discount textbox
            string value = txtdiscount.Text;

            if (value == "")
            {
                //Display Error Message
                MessageBox.Show("Please Add Discount First");
            }
            else
            {
                //Get the discount in decimal value
                decimal SubTotal = decimal.Parse(txttotalprice.Text);
                decimal discount = decimal.Parse(txtdiscount.Text);

                //Calculate the grandtotal based on discount
                decimal grandTotal = ((100 - discount) / 100) * SubTotal;

                //Display the GrandTotla in TextBox
                txtgrandtotal.Text = grandTotal.ToString();
            }
        }


        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            //Get the value fro discount textbox
            string value = txtquantity.Text;

            if (value == "")
            {
                //Display Error Message
                MessageBox.Show("Please Add quantity First");
            }
            else
            {
                //Get the discount in decimal value
                decimal Rate = decimal.Parse(txtsalesprice.Text);
                decimal Qty = decimal.Parse(txtquantity.Text);

                //Calculate the grandtotal based on discount
                decimal SubTotal = Rate * Qty;

                //Display the GrandTotla in TextBox
                txttotalprice.Text = SubTotal.ToString();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;

        private void btnprint_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void dgvsalesdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SaleId = Convert.ToInt32(dgvsalesdetails.SelectedRows[0].Cells["SaleId"].Value.ToString());
                txtvisitorno.Text = dgvsalesdetails.SelectedRows[0].Cells["VisitorNo"].Value.ToString();
                cmbpatientname.Text = dgvsalesdetails.SelectedRows[0].Cells["PatientName"].Value.ToString();
                cmbdoctorname.Text = dgvsalesdetails.SelectedRows[0].Cells["DoctorName"].Value.ToString();
                txtreferredmedicines.Text = dgvsalesdetails.SelectedRows[0].Cells["ReferredMedicines"].Value.ToString();
                txtsalesprice.Text = dgvsalesdetails.SelectedRows[0].Cells["SalesPrice"].Value.ToString();
                txtquantity.Text = dgvsalesdetails.SelectedRows[0].Cells["Quantity"].Value.ToString();
                txttotalprice.Text = dgvsalesdetails.SelectedRows[0].Cells["TotalPrice"].Value.ToString();
                txtdiscount.Text = dgvsalesdetails.SelectedRows[0].Cells["Discount"].Value.ToString();
                txtgrandtotal.Text = dgvsalesdetails.SelectedRows[0].Cells["GrandTotal"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
