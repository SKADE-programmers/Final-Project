using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using DataLibrary;
using DataLibrary.SalesDSTableAdapters;

namespace FinalProject.Sales
{
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
        }
        public List<Service> services = new List<Service>();
        public List<Service> Selectedservices = new List<Service>();
        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
             customerSimpleTableAdapter cust = new customerSimpleTableAdapter();
            if (!string.IsNullOrWhiteSpace(txtCustname.Text))
            {
                //customerSimpleTableAdapter cust = new customerSimpleTableAdapter();
                cust.Fill(salesDS1.customerSimple, txtCustname.Text);
            }
            else if (txtCustNumber.Text != "")
            {
                cust.FillByPhone(salesDS1.customerSimple, txtCustNumber.Text);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CustomerCreate CC = new CustomerCreate();            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            equipmentTableAdapter eq = new equipmentTableAdapter();
            eq.Fill(salesDS1.equipment, listBox1.SelectedIndex);
        }

        private void cBoxCustEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            serviceTableAdapter sv = new serviceTableAdapter();
            sv.Fill(salesDS1.service);            

            foreach (DataRow r in salesDS1.service)
            {
                Service service = new Service();
                service.Name = r.ItemArray[0].ToString();
                service.ID =Convert.ToInt32(r.ItemArray[3].ToString());
                service.Price = r.ItemArray[2].ToString();
                service.Description = r.ItemArray[1].ToString();                
                services.Add(service);

            }
            listBox2.DataSource = services;
            listBox2.DisplayMember = "Name";
            listBox2.ValueMember = "ID";
            listBox3.DataSource = Selectedservices;
            listBox3.DisplayMember = "Name";
            listBox3.ValueMember = "ID";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Selectedservices.Add(services[listBox2.SelectedIndex]);
            services.Remove(services[listBox2.SelectedIndex]);
            listBox2.Refresh();
            listBox2.DataSource = services;
            listBox2.DisplayMember = "Name";
            listBox2.ValueMember = "ID";
            listBox3.DataSource = Selectedservices;
            listBox3.DisplayMember = "Name";
            listBox3.ValueMember = "ID";
            
            
        }

       

        private void radBPurchase_CheckedChanged(object sender, EventArgs e)
        {
            cBoxCustEquip.Visible = false;
        }

        private void radBService_CheckedChanged(object sender, EventArgs e)
        {
            cBoxCustEquip.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void Btnsrch_Click(object sender, EventArgs e)
        {
            customerSimpleTableAdapter cust = new customerSimpleTableAdapter();
            if (!string.IsNullOrWhiteSpace(txtCustname.Text))
            {
                //customerSimpleTableAdapter cust = new customerSimpleTableAdapter();
                cust.Fill(salesDS1.customerSimple, txtCustname.Text);
            }
            else if (txtCustNumber.Text != "")
            {
                cust.FillByPhone(salesDS1.customerSimple, txtCustNumber.Text);
            }
        }

        private void Btncncl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            CustomerCreate CC = new CustomerCreate();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Selectedservices.Add(services[listBox2.SelectedIndex]);
            services.Remove(services[listBox2.SelectedIndex]);
            listBox2.Refresh();
            listBox2.DataSource = services;
            listBox2.DisplayMember = "Name";
            listBox2.ValueMember = "ID";
            listBox3.DataSource = Selectedservices;
            listBox3.DisplayMember = "Name";
            listBox3.ValueMember = "ID";

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
