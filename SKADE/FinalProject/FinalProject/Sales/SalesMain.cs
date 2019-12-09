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
    public partial class SalesMain : Form
    {
        public SalesMain()
        {
            InitializeComponent();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            Form main = this.MdiParent;
            Sales.Sale sale = new Sales.Sale();
            sale.MdiParent = main;
            panel2.Controls.Add(sale);
            sale.Show();
        }

        private void btnCreateCustomers_Click(object sender, EventArgs e)
        {
            Form main = this.MdiParent;
            CustomerCreate create = new CustomerCreate();
            create.MdiParent = main;
            panel2.Controls.Add(create);
            create.Show();
        }

        private void btnCustomerHistory_Click(object sender, EventArgs e)
        {
            Form main = this.MdiParent;
            Sales.CustomerHistory custHistory = new Sales.CustomerHistory();
            custHistory.MdiParent = main;
            panel2.Controls.Add(custHistory);
            custHistory.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Form main = this.MdiParent;
            SearchInventory inventory = new SearchInventory();
            inventory.MdiParent = main;
            panel2.Controls.Add(inventory);
            inventory.Show();
        }
    }
}
