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
   
    public partial class CustomerCreate : Form
    {
        
        public CustomerCreate()
        {
            InitializeComponent();
        }



        private void Create_Click(object sender, EventArgs e)
        {
            Custom custom = new Custom();
            CustomerCreate_DeleteTableAdapter customer = new CustomerCreate_DeleteTableAdapter();
            custom.cusFirstName = textBox1.Text;
            custom.cusLastName = textBox2.Text;
            custom.phone = textBox3.Text;
            custom.cusAddress = textBox4.Text;
            custom.cusCity = textBox5.Text;
            custom.cusPostal = textBox6.Text;
            custom.cusEmail = textBox7.Text;

            try
            {
                if (custom.cusFirstName == "" || custom.cusLastName == "" || custom.phone == "" || custom.cusAddress == "" || custom.cusCity == "" || custom.cusPostal == "" || custom.cusEmail == "")
                {
                    MessageBox.Show("You cannot leave these.", "Alert!", MessageBoxButtons.OK );
                }
                else
                {
                    Commands.CreateCustomer(custom.cusFirstName, custom.cusLastName, custom.phone, custom.cusAddress, custom.cusCity, custom.cusPostal, custom.cusEmail);
                    //DataTable table = new DataTable();
                   // customer.CreateCustomer(custom.cusFirstName, custom.cusLastName, custom.phone, custom.cusAddress, custom.cusCity, custom.cusPostal, custom.cusEmail);
                    MessageBox.Show("Create Successfully", "Create", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                string status = "Not Created" + ex.Message;
            }

            
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

