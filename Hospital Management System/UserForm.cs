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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        BusinessLogicLayer blc = new BusinessLogicLayer();
        UserClass uc = new UserClass();
        HelperClass hc = new HelperClass();
        public int UserId;

        private void UserForm_Load(object sender, EventArgs e)
        {
            dgvuserdetails.DataSource = uc.GetAllUsers();
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                MessageBox.Show("Need to provide username");
                return;
            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("Need to provide password");
                return;
            }
            else if (txtcpassword.Text == "")
            {
                MessageBox.Show("Need to provide your password");
                return;
            }
            else if (cmbrole.SelectedIndex == -1)
            {
                MessageBox.Show("Need to select a role");
                return;
            }
            else if (txtpassword.Text != txtcpassword.Text)
            {
                MessageBox.Show("Password need to be matched");
                txtpassword.Clear();
                txtcpassword.Clear();
                txtpassword.Focus();
                return;
            }
            else if (DublicateUser() == true)
            {
                MessageBox.Show("User with same name already exists");
                txtusername.Clear();
                txtusername.Focus();
                return;
            }
            { CreateUser(); }
        }

        private void CreateUser()
        {
            try
            {
                bool res = blc.UserTable(0,
                   txtusername.Text,
                   txtpassword.Text,
                   cmbrole.Text,
                       1);
                if (res == true)
                {
                    MessageBox.Show("Success to Create User");
                    dgvuserdetails.DataSource = uc.GetAllUsers();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
                else
                {
                    MessageBox.Show("Couldn't create selected user");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public bool DublicateUser()
        {
            int x = 0;
            try
            {

                for (int i = 0; i < dgvuserdetails.Rows.Count; i++)
                {
                    if (txtusername.Text == dgvuserdetails.Rows[i].Cells["UserName"].Value.ToString())
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
                bool res = blc.UserTable(UserId,
                   txtusername.Text,
                   txtpassword.Text,
                   cmbrole.Text,
                       2);
                if (res == true)
                {
                    MessageBox.Show("Success to update User");
                    dgvuserdetails.DataSource = uc.GetAllUsers();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
                else
                {
                    MessageBox.Show("Couldn't update selected user");
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
                bool res = blc.UserTable(UserId,
                   txtusername.Text,
                   txtpassword.Text,
                   cmbrole.Text,
                       3);
                if (res == true)
                {
                    MessageBox.Show("Success to delete User");
                    dgvuserdetails.DataSource = uc.GetAllUsers();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
                else
                {
                    MessageBox.Show("Couldn't delete selected user");
                }
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

        private void dgvuserdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                UserId = Convert.ToInt32(dgvuserdetails.SelectedRows[0].Cells["UserId"].Value.ToString());
                txtusername.Text = dgvuserdetails.SelectedRows[0].Cells["UserName"].Value.ToString();
                txtpassword.Text = dgvuserdetails.SelectedRows[0].Cells["Password"].Value.ToString();
                txtcpassword.Text = dgvuserdetails.SelectedRows[0].Cells["Password"].Value.ToString();
                cmbrole.Text = dgvuserdetails.SelectedRows[0].Cells["Role"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
