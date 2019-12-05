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
using DataLibrary.AdminDSTableAdapters;

namespace FinalProject
{
    public partial class CustomerDetails : Form
    {
        
        public CustomerDetails(int id)
        {
            InitializeComponent();            
            CustomerDetailsTableAdapter customer = new CustomerDetailsTableAdapter();   
            customer.FillByID(adminDS2.CustomerDetails, id);

                lblID.Text = adminDS2.CustomerDetails.Rows[0].ItemArray[0].ToString();
                lblFirst.Text = adminDS2.CustomerDetails.Rows[0].ItemArray[1].ToString();
                lblLast.Text = adminDS2.CustomerDetails.Rows[0].ItemArray[2].ToString();
                lblphonedet .Text = adminDS2.CustomerDetails.Rows[0].ItemArray[3].ToString();
                lblAddressdes.Text = adminDS2.CustomerDetails.Rows[0].ItemArray[4].ToString();
                label4city.Text = adminDS2.CustomerDetails.Rows[0].ItemArray[5].ToString();
                lblPostaldes.Text = adminDS2.CustomerDetails.Rows[0].ItemArray[6].ToString();
                lblEmaildes.Text = adminDS2.CustomerDetails.Rows[0].ItemArray[7].ToString();
                       
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
           txtFirst.Text = lblFirst.Text;
           txtLast.Text = lblLast.Text;
           txtID.Text = lblID.Text;
           txtPhone.Text = lblphonedet.Text;
           txtPostal.Text = lblPostaldes.Text;
           txtCity.Text = label4city.Text;
           txtEmail.Text = lblEmaildes.Text;
           txtAddress.Text = lblAddressdes.Text;
            VisibleControls();
        }

        private void VisibleControls()
        {
            if (txtFirst.Visible != true)
            {
                //hides labels, shows textboxes
                btnDelete.Visible = true;
                btnEdit.Text = "Cancel";
                btnSave.Visible = true;
                lblFirst.Visible = true;
                lblLast.Visible = true;
                lblID.Visible = true;
                lblphone.Visible = true;
                lbladdress.Visible = true;
                lblpostal.Visible = true;
                lblcity.Visible = true;
                lblemail.Visible = true;
                txtID.Visible = true;
                txtFirst.Visible = true;
                txtLast.Visible = true;
                txtPhone.Visible = true;
                txtAddress.Visible = true;
                txtCity.Visible = true;
                txtPostal.Visible = true;
                txtEmail.Visible = true;
                lblEmaildes.Visible = false;
                lblphonedet.Visible = false;
                lblAddressdes.Visible = false;
                label4city.Visible = false;
            }
            else
            {
                //shows labels, hides textboxes
                btnDelete.Visible = false;
                btnEdit.Text = "Edit";
                btnSave.Visible = false;
                lblFirst.Visible = true;
                lblLast.Visible = true;
                lblID.Visible = true;
                lblphone.Visible = true; ;
                lbladdress.Visible = true;
                lblpostal.Visible = true;
                lblcity.Visible = true;
                lblemail.Visible = true;
                txtFirst.Visible = false;
                txtLast.Visible = false;
                txtPhone.Visible = false;
                txtAddress.Visible = false;
                txtCity.Visible = false;
                txtPostal.Visible = false;
                txtEmail.Visible = false;
                txtID.Visible = false;
                lblEmaildes.Visible = true;
                lblphonedet.Visible = true;
                lblAddressdes.Visible = true;
                label4city.Visible = true;

            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                CustomerCreate_DeleteTableAdapter del = new CustomerCreate_DeleteTableAdapter();
                del.DeleteCustomer(Convert.ToInt32(lblID.Text));
                VisibleControls();
                CustomerSimpleTableAdapter cus = new CustomerSimpleTableAdapter();
                cus.Fill(adminDS2.CustomerSimple);

            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            CustomerUpdateTableAdapter update = new CustomerUpdateTableAdapter();
            update.UpdateCustomer(txtFirst.Text, txtLast.Text, txtCity.Text, txtEmail.Text, txtPhone.Text, txtAddress.Text, txtPostal.Text, Convert.ToInt32((txtID.Text)));
          

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            CustomerCreate customerCreate = new CustomerCreate();
            customerCreate.Show();
            customerCreate.FormClosing += new FormClosingEventHandler(ChildFormClosing);


            this.Hide();
        }

        private void ChildFormClosing(object sender, EventArgs e)
        {


            this.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblFirst_Click(object sender, EventArgs e)
        {

        }
    }
}
