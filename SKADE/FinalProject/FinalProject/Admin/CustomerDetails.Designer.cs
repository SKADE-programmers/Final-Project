namespace FinalProject
{
    partial class CustomerDetails
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.customerid = new System.Windows.Forms.Label();
            this.adminDS2 = new DataLibrary.AdminDS();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblLastis = new System.Windows.Forms.Label();
            this.lblFirstis = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.lblpostal = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblphonedet = new System.Windows.Forms.Label();
            this.label4city = new System.Windows.Forms.Label();
            this.lblAddressdes = new System.Windows.Forms.Label();
            this.lblPostaldes = new System.Windows.Forms.Label();
            this.lblEmaildes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adminDS2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(26, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 80;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnCreate.Location = new System.Drawing.Point(157, 257);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(102, 35);
            this.btnCreate.TabIndex = 78;
            this.btnCreate.Text = "Create New Customer";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(173, 147);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(154, 20);
            this.txtLast.TabIndex = 75;
            this.txtLast.Visible = false;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(173, 107);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(156, 20);
            this.txtFirst.TabIndex = 74;
            this.txtFirst.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(173, 64);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(156, 20);
            this.txtID.TabIndex = 73;
            this.txtID.Visible = false;
            this.txtID.TextChanged += new System.EventHandler(this.TxtID_TextChanged);
            // 
            // customerid
            // 
            this.customerid.AutoSize = true;
            this.customerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerid.Location = new System.Drawing.Point(39, 64);
            this.customerid.Name = "customerid";
            this.customerid.Size = new System.Drawing.Size(115, 20);
            this.customerid.TabIndex = 72;
            this.customerid.Text = "Customer ID:";
            // 
            // adminDS2
            // 
            this.adminDS2.DataSetName = "AdminDS";
            this.adminDS2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(595, 257);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 35);
            this.btnSave.TabIndex = 69;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(453, 257);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 35);
            this.btnDelete.TabIndex = 70;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(471, 257);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(0, 13);
            this.lblPass.TabIndex = 68;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(471, 224);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(0, 13);
            this.lblLogin.TabIndex = 67;
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Location = new System.Drawing.Point(471, 183);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(0, 13);
            this.lblPos.TabIndex = 66;
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.Location = new System.Drawing.Point(169, 145);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(55, 20);
            this.lblLast.TabIndex = 65;
            this.lblLast.Text = "lblLast";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(169, 68);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(41, 20);
            this.lblID.TabIndex = 64;
            this.lblID.Text = "lblID";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(169, 107);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(55, 20);
            this.lblFirst.TabIndex = 63;
            this.lblFirst.Text = "lblFirst";
            this.lblFirst.Click += new System.EventHandler(this.LblFirst_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(320, 257);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(69, 35);
            this.btnEdit.TabIndex = 60;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(39, 183);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(132, 20);
            this.lblphone.TabIndex = 56;
            this.lblphone.Text = "Phone Number:";
            // 
            // lblLastis
            // 
            this.lblLastis.AutoSize = true;
            this.lblLastis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastis.Location = new System.Drawing.Point(39, 145);
            this.lblLastis.Name = "lblLastis";
            this.lblLastis.Size = new System.Drawing.Size(95, 20);
            this.lblLastis.TabIndex = 59;
            this.lblLastis.Text = "LastName:";
            // 
            // lblFirstis
            // 
            this.lblFirstis.AutoSize = true;
            this.lblFirstis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstis.Location = new System.Drawing.Point(39, 107);
            this.lblFirstis.Name = "lblFirstis";
            this.lblFirstis.Size = new System.Drawing.Size(96, 20);
            this.lblFirstis.TabIndex = 55;
            this.lblFirstis.Text = "FirstName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 81;
            this.label2.Text = "Customer Details";
            // 
            // txtPostal
            // 
            this.txtPostal.Location = new System.Drawing.Point(525, 145);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(160, 20);
            this.txtPostal.TabIndex = 77;
            this.txtPostal.Visible = false;
            // 
            // lblpostal
            // 
            this.lblpostal.AutoSize = true;
            this.lblpostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpostal.Location = new System.Drawing.Point(427, 145);
            this.lblpostal.Name = "lblpostal";
            this.lblpostal.Size = new System.Drawing.Size(64, 20);
            this.lblpostal.TabIndex = 58;
            this.lblpostal.Text = "Postal:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(525, 68);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(160, 20);
            this.txtAddress.TabIndex = 76;
            this.txtAddress.Visible = false;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(427, 68);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(80, 20);
            this.lbladdress.TabIndex = 57;
            this.lbladdress.Text = "Address:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(173, 185);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(156, 20);
            this.txtPhone.TabIndex = 82;
            this.txtPhone.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 84;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(525, 187);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 20);
            this.txtEmail.TabIndex = 87;
            this.txtEmail.Visible = false;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(427, 185);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(58, 20);
            this.lblemail.TabIndex = 85;
            this.lblemail.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 89;
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcity.Location = new System.Drawing.Point(427, 107);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(44, 20);
            this.lblcity.TabIndex = 90;
            this.lblcity.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(525, 107);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(160, 20);
            this.txtCity.TabIndex = 91;
            this.txtCity.Visible = false;
            // 
            // lblphonedet
            // 
            this.lblphonedet.AutoSize = true;
            this.lblphonedet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphonedet.Location = new System.Drawing.Point(169, 183);
            this.lblphonedet.Name = "lblphonedet";
            this.lblphonedet.Size = new System.Drawing.Size(69, 20);
            this.lblphonedet.TabIndex = 57;
            this.lblphonedet.Text = "lblphone";
            // 
            // label4city
            // 
            this.label4city.AutoSize = true;
            this.label4city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4city.Location = new System.Drawing.Point(521, 107);
            this.label4city.Name = "label4city";
            this.label4city.Size = new System.Drawing.Size(39, 20);
            this.label4city.TabIndex = 92;
            this.label4city.Text = "City:";
            // 
            // lblAddressdes
            // 
            this.lblAddressdes.AutoSize = true;
            this.lblAddressdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressdes.Location = new System.Drawing.Point(521, 68);
            this.lblAddressdes.Name = "lblAddressdes";
            this.lblAddressdes.Size = new System.Drawing.Size(69, 20);
            this.lblAddressdes.TabIndex = 57;
            this.lblAddressdes.Text = "lblphone";
            // 
            // lblPostaldes
            // 
            this.lblPostaldes.AutoSize = true;
            this.lblPostaldes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostaldes.Location = new System.Drawing.Point(521, 147);
            this.lblPostaldes.Name = "lblPostaldes";
            this.lblPostaldes.Size = new System.Drawing.Size(57, 20);
            this.lblPostaldes.TabIndex = 58;
            this.lblPostaldes.Text = "Postal:";
            // 
            // lblEmaildes
            // 
            this.lblEmaildes.AutoSize = true;
            this.lblEmaildes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmaildes.Location = new System.Drawing.Point(521, 185);
            this.lblEmaildes.Name = "lblEmaildes";
            this.lblEmaildes.Size = new System.Drawing.Size(52, 20);
            this.lblEmaildes.TabIndex = 85;
            this.lblEmaildes.Text = "Email:";
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4city);
            this.Controls.Add(this.lblcity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEmaildes);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.customerid);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblPostaldes);
            this.Controls.Add(this.lblpostal);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblAddressdes);
            this.Controls.Add(this.lblphonedet);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.lblLastis);
            this.Controls.Add(this.lblFirstis);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPostal);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtID);
            this.Name = "CustomerDetails";
            this.Text = "CustomerDetails";
            this.Load += new System.EventHandler(this.CustomerDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminDS2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label customerid;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblLastis;
        private System.Windows.Forms.Label lblFirstis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPostal;
        private System.Windows.Forms.Label lblpostal;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.TextBox txtCity;
        private DataLibrary.AdminDS adminDS2;
        private System.Windows.Forms.Label lblphonedet;
        private System.Windows.Forms.Label label4city;
        private System.Windows.Forms.Label lblAddressdes;
        private System.Windows.Forms.Label lblPostaldes;
        private System.Windows.Forms.Label lblEmaildes;
    }
}