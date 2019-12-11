using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class SearchRepairRecord : Form
    {
        public SearchRepairRecord()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Form main = this.MdiParent;
            RepairRecordDetails repairDetails = new RepairRecordDetails();
            Form parent = this.ParentForm;
            repairDetails.MdiParent = main;
            repairDetails.TopLevel = false;
            parent.Controls["panel2"].Controls.Add(repairDetails);
            repairDetails.Show();
        }
    }
}
