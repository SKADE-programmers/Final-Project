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
        int panelwidth;
        bool hidden;
        public LoginPage()
        {
            InitializeComponent();
            panelwidth = panel3.Width;
            hidden = true;
        }

        int attempts = 1;



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
                         

            try
            {
                DataTable dt = new DataTable();
                taAuth.Fill(authDS.Authenticate, login.userName, login.passWord);
                if (authDS.Tables[0].Rows.Count == 1)
                {
                    login.ID = int.Parse(authDS.Tables[0].Rows[0].ItemArray[0].ToString());
                    StatusLabel.Text = "Login Success!";
                    // MessageBox.Show("Welcome " + " " + login.userName + " :) " + login.ID.ToString());
                    int pos = int.Parse(authDS.Tables[0].Rows[0].ItemArray[1].ToString());
                    Main main = new Main();
                    main.FormClosing += new FormClosingEventHandler(ChildFormClosing);

                    if (pos == 1)
                    {
                        SalesMain salesMain = new SalesMain();
                        salesMain.MdiParent = main;
                        salesMain.Show();
                    }
                    else if (pos == 2)
                    {
                        RepairMain repairMain = new RepairMain();
                        repairMain.MdiParent = main;
                        repairMain.Show();
                    }
                    else if (pos == 3)
                    {//Admin
                        AdminMain adminMain = new AdminMain();
                        adminMain.MdiParent = main;
                        adminMain.Show();
                    }
                    else if (pos == 4)
                    {//Manager
                        AdminMain adminMain = new AdminMain();
                        adminMain.MdiParent = main;
                        main.MainMenuStrip.Items[3].Visible = true;
                        adminMain.Show();
                    }
                    else if (pos == 5)
                    {
                        InventoryMain inventoryMain = new InventoryMain();
                        inventoryMain.MdiParent = main;
                        inventoryMain.Show();

                    }
                    this.Hide();
                    // ^ this hides the login box after they login but then we cant exit the program properly so we have to figure that out.
                    main.Show();



                }
                else{

                    StatusLabel.Text = "login unsucessful " + attempts + "out of 3";
                    attempts++;
                }
                    

                if (login.userName == txtUserName.Text && login.passWord == "")
                {
                    StatusLabel.Text = "Please enter the password";
                }

                if (login.userName == "" && login.passWord == "")
                {
                    StatusLabel.Text = "Please enter the username and password";
                }



            }
            catch (Exception ex)
            {
                StatusLabel.Text = "Something went wrong... please try again " + ex.Message;
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
        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            txtUserName.Text = "Username";
            txtPassword.Text = "Password";
            attempts = 1;
            this.Show();
        }

        //private void panel3_MouseHover(object sender, EventArgs e)
        //{
        //    timer1.Start();
        //}
        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                panel3.Width = panel3.Width + 29;
                if (panel3.Width >= panelwidth)
                {
                    timer1.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panel3.Width = panel3.Width - 29;
                if (panel3.Width <= panelwidth)
                {
                    timer1.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

       
    }
}
