using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary.AuthDSTableAdapters;
using DataLibrary;
using ClassLibrary;

namespace FinalProject
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            string datestring = today.ToShortDateString();
            lblDate.Text = datestring;
            btnCreateNewEmployee.FlatAppearance.BorderSize = 0;
            btnSalesReports.FlatAppearance.BorderSize = 0;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnManageCustomers.FlatAppearance.BorderSize = 0;
            btnWarrantyReport.FlatAppearance.BorderSize = 0;

        }

        private void AdminMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {

        }

        private void adminLandingDeptmanagement1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateNewEmployee_Click(object sender, EventArgs e)
        {
            Form main = this.MdiParent;
            EmployeDetailForm employeDetailForm = new EmployeDetailForm();
            employeDetailForm.MdiParent = main;
            //employeDetailForm.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            //this.Hide();
            panel2.Controls.Add(employeDetailForm);
            employeDetailForm.Show();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            Form main = this.MdiParent;
            Customer customer = new Customer();
            customer.MdiParent = main;
            //customer.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            //this.Hide();
            panel2.Controls.Add(customer);
            customer.Show();
        }

        private void btnSalesReports_Click(object sender, EventArgs e)
        {
            Form main = this.MdiParent;
            WeeklyReport weeklyReport = new WeeklyReport();
            weeklyReport.MdiParent = main;
            //weeklyReport.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            //this.Hide();
            panel2.Controls.Add(weeklyReport);
            weeklyReport.Show();
        }

        private void btnWarrantyReport_Click(object sender, EventArgs e)
        {
            Form main = this.MdiParent;
            WarrantyReports warranty = new WarrantyReports();
            warranty.MdiParent = main;
            //warranty.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            //this.Hide();
            panel2.Controls.Add(warranty);
            warranty.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Form main = this.MdiParent;
            SearchInventory inventory = new SearchInventory();
            inventory.MdiParent = main;
            panel2.Controls.Add(inventory);
            inventory.Show();
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WiP", "Not implemented yet");
        }


        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void PanelSideBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
