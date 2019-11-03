using System;
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

        private void SalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sales sal = new sales();
            sal.Show();
        }

        private void CabinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cabin cab = new cabin();
            cab.Show();
        }

        private void StaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff sta = new staff();
            sta.Show();
        }

        private void BillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billing bil = new billing();
            bil.Show();
        }

        private void MedicinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            medicines med = new medicines();
            med.Show();
        }

        private void othersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            othersfacilities of = new othersfacilities();
            of.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
