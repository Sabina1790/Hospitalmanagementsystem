using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void PatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patients pat = new patients();
            pat.Show();
        }

        private void DoctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doctors doc = new doctors();
            doc.Show();
        }
    }
}
