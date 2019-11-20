namespace FinalProject
{
    partial class forgotPassword
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
            this.Password = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newpass = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.reenterpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(82, 50);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(121, 17);
            this.Password.TabIndex = 0;
            this.Password.Text = "Enter UserName: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Password: ";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(251, 47);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(210, 22);
            this.username.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(251, 85);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(210, 22);
            this.pass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter New Password:";
            // 
            // newpass
            // 
            this.newpass.Location = new System.Drawing.Point(252, 123);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(210, 22);
            this.newpass.TabIndex = 5;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(252, 203);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(88, 34);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "R- enter Password: ";
            // 
            // reenterpass
            // 
            this.reenterpass.Location = new System.Drawing.Point(251, 163);
            this.reenterpass.Name = "reenterpass";
            this.reenterpass.Size = new System.Drawing.Size(211, 22);
            this.reenterpass.TabIndex = 8;
            // 
            // forgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reenterpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password);
            this.Name = "forgotPassword";
            this.Text = "forgotPassword";
            this.Load += new System.EventHandler(this.forgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reenterpass;
    }
}