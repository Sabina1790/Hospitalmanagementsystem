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


namespace Hospital_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        UserClass uc = new UserClass();

        private void Btnsignin_Click(object sender, System.EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.Show();
        }

        private void Btnlogin_Click(object sender, System.EventArgs e)
        {
            try
            {
                String Role = uc.Login(txtusername.Text, txtpassword.Text);
                if (Role == "Admin")
                {
                    dashboard db = new dashboard();
                    db.Show();
                }
                else if (Role == "User")
                {
                    dashboard db = new dashboard();
                    //frm.btnUsers.Enabled = false;
                    //frm.btnProduct.Enabled = false;
                    //frm.btnCategory.Enabled = false;
                    db.Show();
                }
                else
                {
                    MessageBox.Show("Invalid user name or password");
                    txtusername.Clear();
                    txtpassword.Clear();
                    txtusername.Focus();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid user name or password");
                txtusername.Clear();
                txtpassword.Clear();
                txtusername.Focus();
                txtusername.BackColor = Color.Red;
                txtpassword.BackColor = Color.Red;
            }
        }

        private void Txtusername_MouseClick(object sender, MouseEventArgs e)
        {
            txtusername.BackColor = Color.Gray;
        }

        private void Txtpassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtpassword.BackColor = Color.Gray;
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
