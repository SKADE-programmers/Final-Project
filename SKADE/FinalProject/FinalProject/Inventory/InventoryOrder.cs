using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary.InventoryDSTableAdapters;
using DataLibrary;

namespace FinalProject
{
    public partial class InventoryOrder : Form
    {


        public InventoryOrder()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Commands.placeOrder(txtBoxProductOrderNum.Text, dtpOrderDate.Value, checkBoxPaid.Checked);
            MessageBox.Show("order Placed", "");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}
