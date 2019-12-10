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

namespace FinalProject
{
    public partial class WeeklyReport : Form
    {
        public WeeklyReport()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
        }

        private void WeeklyReport_Load(object sender, EventArgs e)
        {
            WeeklySalesReportTableAdapter newDA = new WeeklySalesReportTableAdapter();
            if(DtpStartDateForWeeklyReports_ValueChanged >= 0)

            
 
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            WeeklySalesReportTableAdapter da = new WeeklySalesReportTableAdapter();

            da.Fill(adminDS1.WeeklySalesReport, dtpStartDateForWeeklyReports.Value.ToString(), dateTimePicker1.Value.ToString());

            //if (button2.Click = true) ;

        }

        private void DtpStartDateForWeeklyReports_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
