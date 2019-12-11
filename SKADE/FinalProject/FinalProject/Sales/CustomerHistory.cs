using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary.SalesDSTableAdapters;
using DataLibrary;



namespace FinalProject.Sales
{
    public partial class CustomerHistory : Form
    {
        public CustomerHistory()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            customerTableAdapter custda = new customerTableAdapter();

            custda.Fill(salesDS1.customer);

        }
    }
}
