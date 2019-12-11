using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataLibrary.AdminDSTableAdapters;
using DataLibrary;

namespace FinalProject
{
    public partial class WeeklyReport : Form
    {
        public WeeklyReport()
        {
            InitializeComponent();
        }

        private void WeeklyReport_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
           

            WeeklySalesReportTableAdapter da = new WeeklySalesReportTableAdapter();
            AdminDS.WeeklySalesReportDataTable admds = new AdminDS.WeeklySalesReportDataTable();
            
             da.Fill(adminDS1.WeeklySalesReport, dtpStartDateForWeeklyReports.Value.ToString(), dateTimePicker1.Value.ToString());

            //dataGridView1.DataSource = da;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
             int count = dataGridView1.Rows.Count;
            MessageBox.Show("We had " + count + " amount of Weekly Reports");
        }
    }
}
