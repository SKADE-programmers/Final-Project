using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary;
using DataLibrary.InventoryDSTableAdapters;

namespace FinalProject
{
    public partial class InventoryCount : Form
    {
        InventorySearchTableAdapter search = new InventorySearchTableAdapter();
        public InventoryCount()
        {
            InitializeComponent();
        }

        private void InventoryCount_Load(object sender, EventArgs e)
        {
            
            search.Fill(inventoryDS.InventorySearch);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //search.FillByID(dt, lBoxType.SelectedValue)
            lblBrandText.Text = dt.Rows[0].ItemArray[7].ToString();
            lblItemName.Text = dt.Rows[0].ItemArray[5].ToString();
            lblDescText.Text = dt.Rows[0].ItemArray[6].ToString();
            lblHiddenID.Text = dt.Rows[0].ItemArray[0].ToString();
            lblMeasureText.Text = dt.Rows[0].ItemArray[3].ToString();
            txtCount.Text = dt.Rows[0].ItemArray[1].ToString();




        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Commands.UpdateInventoryCount(Convert.ToInt32(txtCount.Text), Convert.ToInt32(lblHiddenID.Text));
            search.Fill(inventoryDS.InventorySearch);
            lBoxType_SelectedIndexChanged( sender,  e);
        }
    }
}
