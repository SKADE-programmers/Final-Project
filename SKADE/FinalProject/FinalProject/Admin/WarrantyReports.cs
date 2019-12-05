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
using System.Data.SqlClient;
using DataLibrary.EmmasDataSetTableAdapters;
using System.Configuration;
using DataLibrary.AdminDSTableAdapters;

namespace FinalProject
{
    public partial class WarrantyReports : Form
    {
        public WarrantyReports()
        {
            InitializeComponent();
        }

        private void FrmWarrantyReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emmasDataSet1.service_order' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'emmasWSReportDataSet1.service_order' table. You can move, or remove it, as needed.
            //this.service_orderTableAdapter.Fill(this.emmasWSReportDataSet12.service_order, dtpWarrantyStartDate.Value, dtpWarrantyEndDate.Value);
            //MessageBox.Show(Convert.ToString(DateTime)))
            DateTimePicker timePicker = new DateTimePicker();
            timePicker = dtpWarrantyStartDate;
            timePicker.CustomFormat = "MMMM dd, yyyy dddd";
            timePicker.Format = DateTimePickerFormat.Custom;
            DateTimePicker timePicker1 = new DateTimePicker();
            timePicker1 = dtpWarrantyEndDate;
            timePicker1.CustomFormat = "MMMM dd, yyyy dddd";
            timePicker1.Format = DateTimePickerFormat.Custom;
            // dgvSearchResults.Rows
            //DateTime todaDate = DateTime.Now;
            //this.tslTimeOfDay.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");

            //MessageBox.Show(DtpWarrantyStartDate_ValueChanged, "Hello", MessageBoxButtons.OK);

            //tslTimeOfDay.ToolTipText = "DateTime" + System.DateTime.Today.ToString("dddd, dd MMMM yyyy HH:mm");
            //.ToString("dddd, dd MMMM yyyy HH:mm");
        }
        //public static EmmasDataSet.service_orderDataTable GetWarranty(String id, out DataTable DataTable) 
        //{
        //    string results = "No Date In Records";

        //    SqlCommand cmd = new SqlCommand();


        //    cmd.Connection = Data.con;

        //    cmd.CommandText = "select * from service_order Where serordDateIn >= " +  + " and  serordDateOut <= " + DT

        //}\\

        //internal static class Data
        // {
        //static internal SqlConnection con = new SqlConnection();

        //static Data()
        //{
        //    con.ConnectionString = global::FinalProject.Properties.Settings.Default.EmmasConnectionString;
        //}

        //}


        //   public static WarrantySearch GetWarrantySearch( DateTimePicker dateStarts, DateTimePicker dateEnds )
        //    {
        //            dateStarts = new DateTimePicker();
        //        dateStarts.Format.ToString("dddd, dd MMMM yyyy HH:mm");
        //             dateEnds = new DateTimePicker();
        //        dateEnds.Format.ToString("dddd, dd MMMM yyyy HH:mm");

        //        ClassLibrary.For_Final_Project.WarrantySearch das = new ClassLibrary.For_Final_Project.WarrantySearch();

        //        //results = "Not In Records";
        //        DataTable dt = new DataTable();
        //    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

        //        //service_orderTableAdapter serOrdTabAda = new service_orderTableAdapter();
        //    cmd.Connection = Data.con;

        //        cmd.CommandText = "select * from service_order Where serordDateIn >=" + dateStarts.Value  + " and serordDateOut <=" + dateEnds.Value;
        //        service_orderTableAdapter serOrdTabAda = new service_orderTableAdapter();
        //        try
        //        {
        //            Data.con.Open();

        //            SqlDataReader records = cmd.ExecuteReader();

        //            if (records.Read())
        //            {
        //                dt.Rows.Add(records);
        //                //das.ID = Convert.ToInt32(records[0]);
        //                //das.serordDateIn = Convert.ToDateTime(records[1]);
        //                //das.serordDateOut = Convert.ToDateTime(records[2]);
        //                //das.serordWarranty = records[3].ToString();

        //                //results = "Found Records";

        //                return dt;

        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //           // results = ex.Message;
        //        }
        //        finally
        //        {
        //            if (Data.con.State == ConnectionState.Open)
        //                Data.con.Close();
        //        }
        //        return das;
        //}
        //SqlConnection con = new SqlConnection("Data Source = (LocalDB)'\'MSSQLLocalDB; AttachDbFilename=" + "C:'\'Users'\'exbf1'\'OneDrive - NC'\'Final-Project-ShadowsHuntUs-patch-2'\'SKADE'\'FinalProject'\'FinalProject'\'Emmas.mdf" + ";Integrated Security = True");

        //SqlConnection con = new SqlConnection("Data Source = (LocalDB)/MSSQLLocalDB; AttachDbFilename = " + "C:/Users/Administrator/OneDrive - NC/Final-Project-ShadowsHuntUs-patch-2/SKADE/FinalProject/FinalProject/Emmas.mdf" + "; Integrated Security = True");
        private void BtnWarrantySearch_Click(object sender, EventArgs e)
        {
            // SqlConnection con = new SqlConnection("Data Source = (LocalDB)/MSSQLLocalDB; AttachDbFilename = " + "C:/Users/Administrator/OneDrive - NC/Final-Project-ShadowsHuntUs-patch-2/SKADE/FinalProject/FinalProject/Emmas.mdf" + "; Integrated Security = True");

            WarrantyReportTableAdapter warranty = new WarrantyReportTableAdapter();
            
            
            warranty.Fill(adminDS1.WarrantyReport, dtpWarrantyStartDate.Value.ToString("MM/dd/yyyy dddd"), dtpWarrantyEndDate.Value.ToString("MM/dd/yyyy dddd"));
            MessageBox.Show(dtpWarrantyStartDate.Value.ToString("MM/dd/yyyy dddd") + ' ' + dtpWarrantyEndDate.Value.ToString("MM/dd/yyyy dddd"));
            // dgvSearchResults.DataSource = 

            ////using(var connection = new SqlConnection("Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\Administrator\OneDrive - NC\Final-Project-ShadowsHuntUs-patch-2\SKADE\Database\Emmas.mdf"))
           //// try
           // {

               
           //     //SqlCommand cmd = new SqlCommand();
           //     SqlDataAdapter sqls = new SqlDataAdapter("select serordDateIn, serordDateOut, serordIssue, serordWarranty from service_order where serordDateIn and serordDateOut between '" + dtpWarrantyStartDate.Value.ToString() + "' and '" + dtpWarrantyEndDate.Value.ToString() + "'", cnnn);
           //     //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=EManage;");
           //     //if(!dtpWarrantyStartDate.Value)
           //     DataTable dt = new DataTable();
           //     sqls.Fill(dt);

           //     //DataSet newServiceOrder = new DataSet(dt);
           //     dgvSearchResults.DataSource = dt;
           //     MessageBox.Show(dt.Rows.Count.ToString());
           // }catch(Exception ex)
           // {
           //     MessageBox.Show(ex.Message);
           // }

        }
            //DataTable dt = new DataTable();
            //Data.con.Open();
            //system.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            //cmd.CommandText = "SELECT  id, serordDateIn, serordDateOut, serordIssue, serordWarranty FROM service_order WHERE serordDateIn BETWEEN @date1 and @date2 AND serordDateOut BETWEEN @date 1 and @date2";
            //System.Data.SqlClient.SqlDataReader records = cmd.ExecuteReader();

            //foreach(Data d in records)
            //{
            //  if (dtpWarrantyStartDate.Value >=  Convert.ToDateTime(emmasDataSet.service_order.serordDateInColumn))
            //    dt += records

            //}





            private void BtnClearTable_Click(object sender, EventArgs e)
        {
            cboSpecificDay.SelectedIndex = -1;
            cboSpecificMonth.SelectedItem = "";
            cboSpecificYear.SelectedIndex = -1;
            dgvSearchResults.Columns.Clear();
            chbxSortByDays.Checked = false;
            chbxSortByMonths.Checked = false;
            chbxSortByYear.Checked = false;
            //tslNumberOfSearchResults = null;
        }

        //private void DtpWarrantyStartDate_ValueChanged(object sender, EventArgs e)
        //{
        //    SqlConnection sqltb = new SqlConnection("Data Source = (LocalDB)/MSSQLLocalDB; AttachDbFilename = " + "C:/Users/Administrator/OneDrive - NC/Final-Project-ShadowsHuntUs-patch-2/SKADE/FinalProject/FinalProject/Emmas.mdf" + "; Integrated Security = True");
        //    DataTable dt = new DataTable();
        //    if(dtpWarrantyStartDate.Value != DateTime.Now)
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        DataSet dst = new DataSet();
        //        cmd.CommandText = "select serordDateIn, serordDateOut, serordIssue, serordWarranty from service_order where serordDateIn and serordDateOut between " + dtpWarrantyStartDate.Value.ToString() + " and " + dtpWarrantyEndDate.Value.ToString();
        //        //dst.Tables.Add()
        //        if (records.Read())
        //        {

        //            SqlDataAdapter sqlsda = new SqlDataAdapter();
        //            sqlsda.Fill(dt);
        //            dst.Tables.Add(dt);
        //            dgvSearchResults.DataSource = dst;

        //        }

        //    }
        //    else
        //    {

        //    }
        //}

      
    }

}