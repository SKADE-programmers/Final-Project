using DataLibrary.AdminDSTableAdapters;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataLibrary;
//Scott Stratton
namespace FinalProject
{
    public partial class EmployeeCreate : Form
    {
        
        public EmployeeCreate()
        {
            
            InitializeComponent();
            PositionTableAdapter position = new PositionTableAdapter();
            position.Fill(adminPosDS.Position);
        }


        private void button1_Click(object sender, EventArgs e)
        {

            EmployeeCreate_DeleteTableAdapter employeeCreate = new EmployeeCreate_DeleteTableAdapter();
            EmployeeSimpleTableAdapter employee = new EmployeeSimpleTableAdapter();

            //employeeCreate.CreateEmplyee(txtFirst.Text, txtLast.Text, Convert.ToInt32(ddlPos.SelectedValue));

            Commands.CreateEmployee(txtFirst.Text, txtLast.Text, Convert.ToInt32(ddlPos.SelectedValue), txtUser.Text, txtPass.Text);

            //employee.FillBy(adminDS.EmployeeSimple, txtFirst.Text, txtLast.Text);
            //int currentID = int.Parse(adminDS.Tables[0].Rows[0].ItemArray[0].ToString());
            //Commands.createEmployeeLogin(currentID, txtUser.Text, txtPass.Text);
            //employeeCreate.CreateLogin(currentID, txtUser.Text, txtPass.Text);
            this.Close();
        }

        private void txtFirst_Leave(object sender, EventArgs e)
        {
            string firstLetter = "";
            string lastNamePart = "";
            if (!String.IsNullOrEmpty(txtFirst.Text))
            {
                firstLetter = txtFirst.Text[0].ToString();
            }
            if (txtLast.Text.Length < 4)
            {
                lastNamePart = txtLast.Text;
            }
            else
            {
                lastNamePart = txtLast.Text.Substring(0, 4);
            }
            txtUser.Text = firstLetter + lastNamePart;


        }

        private void txtLast_Leave(object sender, EventArgs e)
        {
            string firstLetter = "";
            string lastNamePart = "";
            if (!String.IsNullOrEmpty(txtFirst.Text))
            {
                firstLetter = txtFirst.Text[0].ToString();
            }
            if (txtLast.Text.Length < 4)
            {
                lastNamePart = txtLast.Text;
            }
            else
            {
                lastNamePart = txtLast.Text.Substring(0, 4);
            }
            txtUser.Text = firstLetter + lastNamePart;
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        private void EmployeeCreate_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
