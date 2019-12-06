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
//Scott Stratton
//Need redesign of text sizes/ button conformity/ button placement
namespace FinalProject
{
    public partial class EmployeDetailForm : Form
    {
        int posID = 0;
        string log = "";
        string pass = "";
        public EmployeDetailForm()
        {
            InitializeComponent();
            EmployeeSimpleTableAdapter empLoad = new EmployeeSimpleTableAdapter();
            empLoad.Fill(adminDS.EmployeeSimple);
            PositionTableAdapter position = new PositionTableAdapter();
            position.Fill(adminDS.Position);
        }

        private void EmployeDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            visableControls();
            txtFirst.Text = lblFirst.Text;
            txtLast.Text = lblLast.Text;
            txtID.Text = lblID.Text;
            cBoxPos.SelectedValue = posID;
            txtLogin.Text = "*****";
            txtPass.Text = "*****";
            txtLogin.ReadOnly = true;
            txtPass.ReadOnly = true;
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete?","Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning );
            if (dialogResult == DialogResult.Yes)
            {
                Commands.DeleteEmployee(Convert.ToInt32(txtID.Text));
                //EmployeeCreate_DeleteTableAdapter del = new EmployeeCreate_DeleteTableAdapter();
               // del.DeleteLogin(Convert.ToInt32(lblID.Text));
               // del.DeleteEmployee(Convert.ToInt32(txtID.Text));
                visableControls();

                EmployeeSimpleTableAdapter empLoad = new EmployeeSimpleTableAdapter();
                empLoad.Fill(adminDS.EmployeeSimple);

            }

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            btnEditLogin.Visible = false;
            txtLogin.ReadOnly = false;
            txtPass.ReadOnly = false;
            txtLogin.Text = log;
            txtPass.Text = pass;
            
        }

        private void visableControls()
        {
            
            if(txtFirst.Visible != true)
            {
                btnDelete.Visible = true;
                btnEdit.Text = "Cancel";
                btnEditLogin.Visible = true;
                btnSave.Visible = true;
                lblFirst.Visible = false;
                lblLast.Visible = false;
                lblID.Visible = false;
                lblPos.Visible = false;
                lblLogin.Visible = false;
                lblPass.Visible = false;
                txtFirst.Visible = true;
                txtID.Visible = true;
                txtLast.Visible = true;
                txtLogin.Visible = true;
                txtPass.Visible = true;
                cBoxPos.Visible = true;
            }
            else
            {
                btnDelete.Visible = false;
                btnEdit.Text = "Edit";
                btnEditLogin.Visible = false;
                btnSave.Visible = false;
                lblFirst.Visible = true;
                lblLast.Visible = true;
                lblID.Visible = true;
                lblPos.Visible = true;
                lblLogin.Visible = true;
                lblPass.Visible = true;
                txtFirst.Visible = false;
                txtID.Visible = false;
                txtLast.Visible = false;
                txtLogin.Visible = false;
                txtPass.Visible = false;
                cBoxPos.Visible = false;
            }

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            EmployeeCreate employeeCreate = new EmployeeCreate();
            employeeCreate.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            employeeCreate.Show();

        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            EmployeeSimpleTableAdapter empLoad = new EmployeeSimpleTableAdapter();
            empLoad.Fill(adminDS.EmployeeSimple);
        }

        private void button1_Click_Save(object sender, EventArgs e)
        {
            //EmployeeUpdateTableAdapter empUpd = new EmployeeUpdateTableAdapter();
            if (txtLogin.Text != "*****")
            {
                log = txtLogin.Text;
                pass = txtPass.Text;
            }
                Commands.UpdateEmployee(txtFirst.Text, txtLast.Text, Convert.ToInt32(cBoxPos.SelectedValue), log, pass, Convert.ToInt32(txtID.Text));
            ListBox1_SelectedIndexChanged( sender,  e);
            //empUpd.UpdateEmployee(txtFirst.Text, txtLast.Text, Convert.ToInt32(cBoxPos.SelectedValue), Convert.ToInt32(txtID.Text));

            // if (txtLogin.Text != "******")
            // {
            //   empUpd.UpdateLogin(txtLogin.Text,txtPass.Text, Convert.ToInt32(txtID.Text));
            //}
            visableControls();
           

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {                
                
                EmployeeDetailsTableAdapter emp = new EmployeeDetailsTableAdapter();                
                emp.FillByID(adminDS.EmployeeDetails, Convert.ToInt32(listBox1.SelectedValue));                
                    lblID.Text = adminDS.Tables[1].Rows[0].ItemArray[0].ToString();
                    lblFirst.Text = adminDS.Tables[1].Rows[0].ItemArray[1].ToString();
                    lblLast.Text = adminDS.Tables[1].Rows[0].ItemArray[2].ToString();
                    lblPos.Text = adminDS.Tables[1].Rows[0].ItemArray[4].ToString();
                    posID = int.Parse(adminDS.Tables[1].Rows[0].ItemArray[3].ToString());
                    lblLogin.Text = "*****";
                    lblPass.Text = "*****";
                    log = adminDS.Tables[1].Rows[0].ItemArray[5].ToString();
                    pass = adminDS.Tables[1].Rows[0].ItemArray[6].ToString();                
                
            }
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            
            this.Close();
        }

    }
}
