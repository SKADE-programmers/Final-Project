namespace FinalProject
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userText = new System.Windows.Forms.TextBox();
            this.userPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.ForgotPassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.authDS = new DataLibrary.AuthDS();
            this.Ready_Label = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label4 = new System.Windows.Forms.Label();
            this.NewUser = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.authDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(239, 76);
            this.userText.Margin = new System.Windows.Forms.Padding(4);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(273, 22);
            this.userText.TabIndex = 1;
            // 
            // userPass
            // 
            this.userPass.Location = new System.Drawing.Point(239, 121);
            this.userPass.Margin = new System.Windows.Forms.Padding(4);
            this.userPass.Name = "userPass";
            this.userPass.PasswordChar = '*';
            this.userPass.Size = new System.Drawing.Size(272, 22);
            this.userPass.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(555, 76);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(132, 28);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ForgotPassword
            // 
            this.ForgotPassword.Location = new System.Drawing.Point(387, 171);
            this.ForgotPassword.Margin = new System.Windows.Forms.Padding(4);
            this.ForgotPassword.Name = "ForgotPassword";
            this.ForgotPassword.Size = new System.Drawing.Size(125, 28);
            this.ForgotPassword.TabIndex = 4;
            this.ForgotPassword.Text = "Forgot Password";
            this.ForgotPassword.UseVisualStyleBackColor = true;
            this.ForgotPassword.Click += new System.EventHandler(this.forgotPassword_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // authDS
            // 
            this.authDS.DataSetName = "AuthDS";
            this.authDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Ready_Label
            // 
            this.Ready_Label.AutoSize = true;
            this.Ready_Label.Location = new System.Drawing.Point(137, 242);
            this.Ready_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ready_Label.Name = "Ready_Label";
            this.Ready_Label.Size = new System.Drawing.Size(49, 17);
            this.Ready_Label.TabIndex = 7;
            this.Ready_Label.Text = "Ready";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 8;
            // 
            // NewUser
            // 
            this.NewUser.Location = new System.Drawing.Point(261, 171);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(81, 28);
            this.NewUser.TabIndex = 9;
            this.NewUser.Text = "New User";
            this.NewUser.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(555, 117);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(132, 26);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 441);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NewUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Ready_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ForgotPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.userPass);
            this.Controls.Add(this.userText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.TextBox userPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button ForgotPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DataLibrary.AuthDS authDS;
        private System.Windows.Forms.Label Ready_Label;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button NewUser;
        private System.Windows.Forms.Label label4;
    }
}