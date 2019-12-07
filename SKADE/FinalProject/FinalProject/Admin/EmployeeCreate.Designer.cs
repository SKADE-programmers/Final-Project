namespace FinalProject
{//Scott Stratton
    partial class EmployeeCreate
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
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.ddlPos = new System.Windows.Forms.ComboBox();
            this.adminPosDS = new DataLibrary.AdminDS();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.adminDS = new DataLibrary.AdminDS();
            ((System.ComponentModel.ISupportInitialize)(this.adminPosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDS)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(100, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(165, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 24);
            this.label10.TabIndex = 35;
            this.label10.Text = "Create Employee";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(319, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Position :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "LastName :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "FirstName :";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(169, 85);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(174, 20);
            this.txtFirst.TabIndex = 1;
            this.txtFirst.Leave += new System.EventHandler(this.txtFirst_Leave);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(169, 205);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(174, 20);
            this.txtUser.TabIndex = 4;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(169, 130);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(174, 20);
            this.txtLast.TabIndex = 2;
            this.txtLast.Leave += new System.EventHandler(this.txtLast_Leave);
            // 
            // ddlPos
            // 
            this.ddlPos.DataSource = this.adminPosDS;
            this.ddlPos.DisplayMember = "Position.posName";
            this.ddlPos.FormattingEnabled = true;
            this.ddlPos.Location = new System.Drawing.Point(169, 167);
            this.ddlPos.Name = "ddlPos";
            this.ddlPos.Size = new System.Drawing.Size(174, 21);
            this.ddlPos.TabIndex = 3;
            this.ddlPos.ValueMember = "Position.id";
            // 
            // adminPosDS
            // 
            this.adminPosDS.DataSetName = "AdminDS";
            this.adminPosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Password :";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(169, 239);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(174, 20);
            this.txtPass.TabIndex = 5;
            // 
            // adminDS
            // 
            this.adminDS.DataSetName = "AdminDS";
            this.adminDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmployeeCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ddlPos);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "edit";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeCreate_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.adminPosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.ComboBox ddlPos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPass;
        private DataLibrary.AdminDS adminPosDS;
        private DataLibrary.AdminDS adminDS;
    }
}