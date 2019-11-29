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
using DataLibrary.AdminDSTableAdapters;
using ClassLibrary;


namespace FinalProject
{
    public partial class Customer : Form
    {
        static DataRow[] rows;
        public Customer()
        {
            InitializeComponent();
            CustomerSimpleTableAdapter cust = new CustomerSimpleTableAdapter();
            cust.Fill(adminDS1.CustomerSimple);
            customerTableAdapter ddl = new customerTableAdapter();
            ddl.Fill(adminDS1.customer);

        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void CustomerDetails_Click(object sender, EventArgs e)
        {
            CustomerDetails customerdetails = new CustomerDetails();
            customerdetails.Show();
            this.Hide();
        }

        private void EditCustomer_Click(object sender, EventArgs e)
        {
            CustomerEdit customerEdit = new CustomerEdit();
            customerEdit.Show();
            this.Hide();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            CustomerCreate customerCreate = new CustomerCreate();
            customerCreate.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Custom custom = new Custom();
            CustomerSimpleTableAdapter customerSimple = new CustomerSimpleTableAdapter();
            try
            {
                customerSimple.Fill(adminDS1.CustomerSimple);
            }
            catch (Exception ex)
            {
                string status = ex.Message;
            }
            string criteria = "";
            criteria += rows = (criteria.Length > 0) ? adminDS1.CustomerSimple.Select(criteria) : adminDS1.CustomerSimple.Select();
            DisplayCustomer();
            
           

        }

        private void DisplayCustomer()

        {
            CustomerSimpleTableAdapter customerSimple = new CustomerSimpleTableAdapter();
            customerSimple.FillBy1(adminDS1.CustomerSimple, textBox1.Text);

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerSimpleTableAdapter customerSimple = new CustomerSimpleTableAdapter();
            customerSimple.FillBy(adminDS1.CustomerSimple, Convert.ToInt32(comboBox1.SelectedValue));
            textBox1.Clear();
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //private string GetCustomerCreteria()
        //{
        //string criteria = "";
        //criteria = (this.te);
        //}




        //custom.cusFirstName;
    }

       
        //private string GetCustomerRecords()
        //{
        //    string criteria = "";
        //    criteria = (this.Length>0) ? "customer Like '" + this.button1.Text +
        //}
    }

