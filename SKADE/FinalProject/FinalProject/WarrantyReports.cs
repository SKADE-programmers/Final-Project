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
            this.service_orderTableAdapter.Fill(this.emmasDataSet.service_order);
            EmmasDataSet dsemms = new EmmasDataSet();
            

        }

        private void FillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.service_orderTableAdapter.FillBy1(this.emmasDataSet.service_order);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void TxtSpecificMonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void FillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.service_orderTableAdapter.FillBy1(this.emmasDataSet.service_order);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
