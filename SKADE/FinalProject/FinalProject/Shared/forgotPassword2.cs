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
using DataLibrary.AuthDSTableAdapters;
using ClassLibrary;

namespace FinalProject
{
    public partial class forgotPassword : Form
    {
        public forgotPassword()
        {
            InitializeComponent();
        }

        private void forgotPassword_Load(object sender, EventArgs e)
        {
            
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Logins login = new Logins();
            AuthenticateTableAdapter authTable = new AuthenticateTableAdapter();
            //login.userName = username.Text;
            
            try
            {
                DataTable dataTable = new DataTable();
                authTable.ForgotPassword(authDS.Authenticate, login.userName);
                if(authDS.Tables[0].Rows.Count == 1)
                {
                     
                    
                   
                        
                    
                }
            }
            catch
            {

            }


        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
