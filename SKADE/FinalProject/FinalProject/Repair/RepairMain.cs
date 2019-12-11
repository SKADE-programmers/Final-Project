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
    public partial class RepairMain : Form
    {
        public RepairMain()
        {
            InitializeComponent();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            Form main = this.MdiParent;
            RepairRequests requests = new RepairRequests();
            requests.MdiParent = main;
            panel2.Controls.Add(requests);
            requests.Show();
        }

        private void btnUpdateRequests_Click(object sender, EventArgs e)
        {
            Form main = this.MdiParent;
            RepairRequestDetails  requestDetails= new RepairRequestDetails();
            requestDetails.MdiParent = main;
            panel2.Controls.Add(requestDetails);
            requestDetails.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Form main = this.MdiParent;
            SearchInventory inventory = new SearchInventory();
            inventory.MdiParent = main;
            panel2.Controls.Add(inventory);
            inventory.Show();
        }

        private void btnRepairHistory_Click(object sender, EventArgs e)
        {
            Form main = this.MdiParent;
            SearchRepairRecord repairRecord = new SearchRepairRecord();
            repairRecord.MdiParent = main;
            panel2.Controls.Add(repairRecord);
            repairRecord.Show();
        }

        private void LblDate_Click(object sender, EventArgs e)
        {

        }

        private void RepairMain_Load(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
        }
    }
}
