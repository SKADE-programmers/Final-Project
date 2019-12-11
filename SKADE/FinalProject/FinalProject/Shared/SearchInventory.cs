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
using ClassLibrary;
using DataLibrary.InventoryDSTableAdapters;

namespace FinalProject
{
    public partial class SearchInventory : Form
    {
        DataRow[] row;
        public SearchInventory()
        {

             InitializeComponent();
            InventorySearchTableAdapter inventory = new InventorySearchTableAdapter();
            inventory.Fill(inventoryDS1.InventorySearch);
           
        }

        private void InventoryMain_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Searching();
            }

            if(!string.IsNullOrEmpty(textBox2.Text))
            {
                SearchBrand();
            }

            if(!string.IsNullOrEmpty(textBox3.Text) || !string.IsNullOrEmpty(textBox4.Text))
            {
                SearchPrice();
            }

           
            string creteria = "";
            creteria += row = (creteria.Length > 0) ? inventoryDS1.InventorySearch.Select(creteria) : inventoryDS1.InventorySearch.Select();
            
          
           
        }

        private void Searching()
        {
            InventorySearchTableAdapter search = new InventorySearchTableAdapter();
            search.SearchByName(inventoryDS1.InventorySearch, textBox1.Text);
        }

       

        private void SearchBrand()
        {
            InventorySearchTableAdapter brandSearch = new InventorySearchTableAdapter();
            brandSearch.SearchByBrand(inventoryDS1.InventorySearch, textBox2.Text);
            string creteria = "";
            creteria += row = (creteria.Length > 0) ? inventoryDS1.InventorySearch.Select(creteria) : inventoryDS1.InventorySearch.Select();

           
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            SearchPrice();
        }

        private void SearchPrice()
        {
            InventorySearchTableAdapter price = new InventorySearchTableAdapter();
            if(textBox3.Text != null || textBox4.Text != null)
            {
                //WIP NEEDS CHECK FOR BOTH BOXES
                price.SearchByPrice(inventoryDS1.InventorySearch, Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text));
            }
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            textBox1.Text = "";
            Searching();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
