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
        public int attempts = 1;

        private void Button1_Click(object sender, EventArgs e)
        {
            Logins login = new Logins();
            AuthenticateTableAdapter taAuth = new AuthenticateTableAdapter();
            login.userName = userText.Text;
            login.passWord = userPass.Text;
            try
            {
                DataTable dt = new DataTable();     
                taAuth.Fill(authDS.Authenticate, login.userName, login.passWord);
                if (authDS.Tables[0].Rows.Count == 1)
                {
                    Ready_Label.Text = "Login Success!";
                    MessageBox.Show("Welcome " + " " + login.userName + " :)");
                    Main main = new Main();
                    //this.Hide();
                    main.Show();
                    
                    

                    
                }
                else {
                    Ready_Label.Text = "login unsucessful\n" + attempts 
                 + "out of 3";
                    attempts++;
                }

                if (login.userName == userText.Text && login.passWord == "")
                {
                    Ready_Label.Text = "Please enter the password";
                }
                
                if  (login.userName == "" && login.passWord == "")
                {
                    Ready_Label.Text = "Please enter the username and password";
                }
                
                

            }
            catch (Exception ex)
            {
                Ready_Label.Text = "Something went wrong... please try again\n"  + ex.Message;
            }
            if(attempts == 4)
            {
                
                MessageBox.Show("You have reached maximum number of attempts... ");
            }

        }
        

        private void LoginPage_Load(object sender, EventArgs e)
        {
            



        }

       

        private void forgotPassword_Click_1(object sender, EventArgs e)
        {
            forgotPassword forgot = new forgotPassword();
            forgot.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
