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
    public partial class InventoryMain : Form
    {
        public InventoryMain()
        {
            InitializeComponent();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            Form main = this.MdiParent;
            InventoryRequests requests = new InventoryRequests();
            requests.MdiParent = main;
            panel2.Controls.Add(requests);
            requests.Show();
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            Form main = this.MdiParent;
            Inventory.OrderHistory history = new Inventory.OrderHistory();
            history.MdiParent = main;
            panel2.Controls.Add(history);
            history.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Form main = this.MdiParent;
            SearchInventory inventory = new SearchInventory();
            inventory.MdiParent = main;
            panel2.Controls.Add(inventory);
            inventory.Show();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            Form main = this.MdiParent;
            InventoryCount inventoryCount = new InventoryCount();
            inventoryCount.MdiParent = main;
            panel2.Controls.Add(inventoryCount);
            inventoryCount.Show();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Form main = this.MdiParent;
            InventoryOrder inventoryOrder = new InventoryOrder();
            inventoryOrder.MdiParent = main;
            panel2.Controls.Add(inventoryOrder);
            inventoryOrder.Show();
        }
    }
}
