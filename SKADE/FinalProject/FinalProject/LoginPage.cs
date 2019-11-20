using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary.AuthDSTableAdapters;
using DataLibrary;
using ClassLibrary;

namespace FinalProject
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

       

       

        private void LinkLabel1_MouseHover(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.FromArgb(0, 0, 255);
        }

        private void LinkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.Gray;
        }

        private void BtnLogin_MouseHover(object sender, EventArgs e)
        {
            btnlogin.BackColor = Color.LightGray;
            btnlogin.ForeColor = Color.Black;
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnlogin.BackColor = Color.White;
            btnlogin.ForeColor = Color.Gray;
           
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "Username";
            txtPassword.Text = "Password";
            btnlogin.FlatAppearance.BorderSize = 0;
            DateTime today = DateTime.Today;
            lblDate.Text = today.ToString();
           
        }

        

       

        private void TxtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            txtUserName.ForeColor = Color.Black;
            if (txtUserName.Text == "Username")
            {
                txtUserName.Text = "";
            }
        }

        private void TxtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
            txtPassword.PasswordChar = Convert.ToChar("*");
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
            }
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            Logins login = new Logins();
            AuthenticateTableAdapter taAuth = new AuthenticateTableAdapter();
            login.userName = txtUserName.Text;
            login.passWord = txtPassword.Text;
            int attempts = 1;
            try
            {
                DataTable dt = new DataTable();
                taAuth.Fill(authDS.Authenticate, login.userName, login.passWord);
                if (authDS.Tables[0].Rows.Count == 1)
                {
                    panel1.Text = "Login Success!";
                    MessageBox.Show("Welcome " + " " + login.userName + " :)");
                    Main main = new Main();
                    this.Hide();
                    // ^ this hides the login box after they login but then we cant exit the program properly so we have to figure that out.
                    main.Show();



                }
                else
                {
                    panel1.Text = "login unsucessful " + attempts
                 + "out of 3";
                    attempts++;
                }

                if (login.userName == txtUserName.Text && login.passWord == "")
                {
                    panel1.Text = "Please enter the password";
                }

                if (login.userName == "" && login.passWord == "")
                {
                    panel1.Text = "Please enter the username and password";
                }



            }
            catch (Exception ex)
            {
                panel1.Text = "Something went wrong... please try again " + ex.Message;
            }
            if (attempts == 4)
            {

                MessageBox.Show("You have reached maximum number of attempts... ");
            }

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotPassword forgot = new forgotPassword();
            forgot.Show();
        }
    }
}
