using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataLibrary.EmmasDataSetTableAdapters;
using DataLibrary;

namespace FinalProject.Sales
{
    public partial class CustomerHistory : Form
    {
        public CustomerHistory()
        {
            InitializeComponent();
        }

        private void CustomerHistory_Load(object sender, EventArgs e)
        {
        
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            customerTableAdapter custTabda = new customerTableAdapter();

            custTabda.Fill(emmasDataSet1.customer);
        }
    }
}
