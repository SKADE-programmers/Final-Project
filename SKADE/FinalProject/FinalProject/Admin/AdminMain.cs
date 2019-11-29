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
            lblDate.Text = today.ToString();
            btnCreateNewEmployee.FlatAppearance.BorderSize = 0;
            btnDepartment.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.BorderSize = 0;
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
    }
}
