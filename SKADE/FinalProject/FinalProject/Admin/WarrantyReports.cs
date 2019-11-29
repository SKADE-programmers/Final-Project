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
            // TODO: This line of code loads data into the 'emmasWSReportDataSet1.service_order' table. You can move, or remove it, as needed.
           // this.service_orderTableAdapter.Fill(this.emmasWSReportDataSet1.service_order);
            // TODO: This line of code loads data into the 'emmasDataSet.service_order' table. You can move, or remove it, as needed.
          //  this.service_orderTableAdapter.Fill(this.emmasDataSet.service_order);
            // TODO: This line of code loads data into the 'emmasDataSet.service_order' table. You can move, or remove it, as needed.

            // dgvSearchResults.Rows
            //DateTime todaDate = DateTime.Now;
           // this.tslTimeOfDay.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");



            //tslTimeOfDay.ToolTipText = "DateTime" + System.DateTime.Today.ToString("dddd, dd MMMM yyyy HH:mm");
            //.ToString("dddd, dd MMMM yyyy HH:mm");
        }

        private void BtnWarrantySearch_Click(object sender, EventArgs e)
        {
            int counter = 0;
            if(DtpWarrantyStartDate_ValueChanged() > 0)
            {
                counter++;
            }
            
            DateTime dtpStart = dtpWarrantyStartDate.Value;
            DateTime dtpEnd = dtpWarrantyEndDate.Value;
            int dtpSTMonth = dtpStart.Month;
            int dtpEDMonth = dtpEnd.Month;

            service_orderTableAdapter daSerOr = new service_orderTableAdapter();
            if (counter == 0)
            {



                
                    
               


            }
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
           // tslNumberOfSearchResults = null;
        }

        private void FillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.service_orderTableAdapter.Fill(this.emmasDataSet.service_order);
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
    }
}
        //private void BtnClearTable_Click(object sender, EventArgs e)
        //{
        //    txtWarrantyStartDate.Text = "";
        //    txtWarrantyEndDate.Text = "";
        //    cboSpecificDay.SelectedIndex = -1;
        //    cboSpecificMonth.SelectedItem = "";
        //    cboSpecificYear.SelectedIndex = -1;
        //    dgvSearchResults.Columns.Clear();
        //    chbxSortByDays.Checked = false;
        //    chbxSortByMonths.Checked = false;
        //    chbxSortByYear.Checked = false;
        //    tslNumberOfSearchResults = null;

        //}
        