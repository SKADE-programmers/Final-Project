using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using DataLibrary;
using DataLibrary.EmmasDataSetTableAdapters;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace FinalProject
{
    public partial class frmWarrantyReports : Form
    {
        public frmWarrantyReports()
        {
            InitializeComponent();
        }

        private void FrmWarrantyReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emmasDataSet.service_order' table. You can move, or remove it, as needed.
            this.service_orderTableAdapter.Fill1(this.emmasDataSet.service_order);

            // dgvSearchResults.Rows
            //DateTime todaDate = DateTime.Now;
            this.tslTimeOfDay.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");



            //tslTimeOfDay.ToolTipText = "DateTime" + System.DateTime.Today.ToString("dddd, dd MMMM yyyy HH:mm");
            //.ToString("dddd, dd MMMM yyyy HH:mm");
        }
        static internal class Data
        {
           static internal System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();

            static Data()
            {
                con.ConnectionString = global::FinalProject.Properties.Settings.Default.EmmasConnectionString;



            }


        }
        private void BtnWarrantySearch_Click(object sender, EventArgs e)
        {
           DataTable dt = new DataTable();
            Data.con.Open();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "SELECT  id, serordDateIn, serordDateOut, serordIssue, serordWarranty FROM service_order WHERE serordDateIn BETWEEN @date1 and @date2 AND serordDateOut BETWEEN @date 1 and @date2";
            System.Data.SqlClient.SqlDataReader records = cmd.ExecuteReader();
            emmasDataSet.service_order[records]

           //string recorded = Convert.ToString(records.GetSqlValue)
            dt = service_orderTableAdapter.FillBy2(records.GetSqlValues()), Convert.ToString(dtpWarrantyStartDate.Value), Convert.ToString(dtpWarrantyEndDate.Value)); ;

            dgvSearchResults.DataSource = dt;
             
           

        }

        private void BtnClearTable_Click(object sender, EventArgs e)
        {
            cboSpecificDay.SelectedIndex = -1;
            cboSpecificMonth.SelectedItem = "";
            cboSpecificYear.SelectedIndex = -1;
            dgvSearchResults.Columns.Clear();
            chbxSortByDays.Checked = false;
            chbxSortByMonths.Checked = false;
            chbxSortByYear.Checked = false;
            tslNumberOfSearchResults = null;
        }

        private void FillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.service_orderTableAdapter.Fill(this.emmasDataSet.service_order);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private int DtpWarrantyStartDate_ValueChanged()
        {
            int dtpSTDTcounter = 0;
            do
            {
                dtpSTDTcounter++;
            } while ( DateTime.Now == dtpWarrantyStartDate.Value);
            return dtpSTDTcounter;
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.service_orderTableAdapter.FillBy2(this.emmasDataSet.service_order, date1ToolStripTextBox.Text, date2ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fill1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.service_orderTableAdapter.Fill1(this.emmasDataSet.service_order);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}