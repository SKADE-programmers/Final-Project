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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adminDS2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(216, 3);
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
            this.btnCreate.Location = new System.Drawing.Point(283, -5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(102, 35);
            this.btnCreate.TabIndex = 78;
            this.btnCreate.Text = "Create New Customer";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // txtLast
            // 
            this.txtLast.BackColor = System.Drawing.Color.White;
            this.txtLast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLast.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtLast.Location = new System.Drawing.Point(69, 178);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(226, 16);
            this.txtLast.TabIndex = 75;
            this.txtLast.Visible = false;
            // 
            // txtFirst
            // 
            this.txtFirst.BackColor = System.Drawing.Color.White;
            this.txtFirst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirst.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtFirst.Location = new System.Drawing.Point(66, 121);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(228, 16);
            this.txtFirst.TabIndex = 74;
            this.txtFirst.Visible = false;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtID.Location = new System.Drawing.Point(69, 61);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(225, 16);
            this.txtID.TabIndex = 73;
            this.txtID.Visible = false;
            this.txtID.TextChanged += new System.EventHandler(this.TxtID_TextChanged);
            // 
            // customerid
            // 
            this.customerid.AutoSize = true;
            this.customerid.BackColor = System.Drawing.Color.White;
            this.customerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerid.ForeColor = System.Drawing.Color.RoyalBlue;
            this.customerid.Location = new System.Drawing.Point(64, 30);
            this.customerid.Name = "customerid";
            this.customerid.Size = new System.Drawing.Size(103, 20);
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
            this.btnSave.Location = new System.Drawing.Point(283, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 26);
            this.btnSave.TabIndex = 69;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(297, -3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 30);
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
            this.lblLast.BackColor = System.Drawing.Color.White;
            this.lblLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.Location = new System.Drawing.Point(65, 188);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(55, 20);
            this.lblLast.TabIndex = 65;
            this.lblLast.Text = "lblLast";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(65, 59);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(41, 20);
            this.lblID.TabIndex = 64;
            this.lblID.Text = "lblID";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.BackColor = System.Drawing.Color.White;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(62, 119);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(55, 20);
            this.lblFirst.TabIndex = 63;
            this.lblFirst.Text = "lblFirst";
            this.lblFirst.Click += new System.EventHandler(this.LblFirst_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(313, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(57, 30);
            this.btnEdit.TabIndex = 60;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.BackColor = System.Drawing.Color.White;
            this.lblphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblphone.Location = new System.Drawing.Point(62, 213);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(119, 20);
            this.lblphone.TabIndex = 56;
            this.lblphone.Text = "Phone Number:";
            // 
            // lblLastis
            // 
            this.lblLastis.AutoSize = true;
            this.lblLastis.BackColor = System.Drawing.Color.White;
            this.lblLastis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastis.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblLastis.Location = new System.Drawing.Point(62, 148);
            this.lblLastis.Name = "lblLastis";
            this.lblLastis.Size = new System.Drawing.Size(86, 20);
            this.lblLastis.TabIndex = 59;
            this.lblLastis.Text = "LastName:";
            // 
            // lblFirstis
            // 
            this.lblFirstis.AutoSize = true;
            this.lblFirstis.BackColor = System.Drawing.Color.White;
            this.lblFirstis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstis.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblFirstis.Location = new System.Drawing.Point(64, 86);
            this.lblFirstis.Name = "lblFirstis";
            this.lblFirstis.Size = new System.Drawing.Size(86, 20);
            this.lblFirstis.TabIndex = 55;
            this.lblFirstis.Text = "FirstName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 50);
            this.label2.TabIndex = 81;
            this.label2.Text = "Customer \r\nDetails";
            // 
            // txtPostal
            // 
            this.txtPostal.BackColor = System.Drawing.Color.White;
            this.txtPostal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPostal.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostal.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPostal.Location = new System.Drawing.Point(364, 177);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(225, 16);
            this.txtPostal.TabIndex = 77;
            this.txtPostal.Visible = false;
            // 
            // lblpostal
            // 
            this.lblpostal.AutoSize = true;
            this.lblpostal.BackColor = System.Drawing.Color.White;
            this.lblpostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpostal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblpostal.Location = new System.Drawing.Point(359, 148);
            this.lblpostal.Name = "lblpostal";
            this.lblpostal.Size = new System.Drawing.Size(57, 20);
            this.lblpostal.TabIndex = 58;
            this.lblpostal.Text = "Postal:";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtAddress.Location = new System.Drawing.Point(364, 60);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(225, 16);
            this.txtAddress.TabIndex = 76;
            this.txtAddress.Visible = false;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.BackColor = System.Drawing.Color.White;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbladdress.Location = new System.Drawing.Point(359, 30);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(72, 20);
            this.lbladdress.TabIndex = 57;
            this.lbladdress.Text = "Address:";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPhone.Location = new System.Drawing.Point(67, 243);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(228, 16);
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
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtEmail.Location = new System.Drawing.Point(364, 243);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 16);
            this.txtEmail.TabIndex = 87;
            this.txtEmail.Visible = false;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.White;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblemail.Location = new System.Drawing.Point(359, 213);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(52, 20);
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
            this.lblcity.BackColor = System.Drawing.Color.White;
            this.lblcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcity.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblcity.Location = new System.Drawing.Point(359, 86);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(39, 20);
            this.lblcity.TabIndex = 90;
            this.lblcity.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.White;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtCity.Location = new System.Drawing.Point(364, 119);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(225, 16);
            this.txtCity.TabIndex = 91;
            this.txtCity.Visible = false;
            // 
            // lblphonedet
            // 
            this.lblphonedet.AutoSize = true;
            this.lblphonedet.BackColor = System.Drawing.Color.White;
            this.lblphonedet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphonedet.Location = new System.Drawing.Point(65, 239);
            this.lblphonedet.Name = "lblphonedet";
            this.lblphonedet.Size = new System.Drawing.Size(69, 20);
            this.lblphonedet.TabIndex = 57;
            this.lblphonedet.Text = "lblphone";
            // 
            // label4city
            // 
            this.label4city.AutoSize = true;
            this.label4city.BackColor = System.Drawing.Color.White;
            this.label4city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4city.Location = new System.Drawing.Point(360, 119);
            this.label4city.Name = "label4city";
            this.label4city.Size = new System.Drawing.Size(39, 20);
            this.label4city.TabIndex = 92;
            this.label4city.Text = "City:";
            // 
            // lblAddressdes
            // 
            this.lblAddressdes.AutoSize = true;
            this.lblAddressdes.BackColor = System.Drawing.Color.White;
            this.lblAddressdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressdes.Location = new System.Drawing.Point(360, 60);
            this.lblAddressdes.Name = "lblAddressdes";
            this.lblAddressdes.Size = new System.Drawing.Size(69, 20);
            this.lblAddressdes.TabIndex = 57;
            this.lblAddressdes.Text = "lblphone";
            // 
            // lblPostaldes
            // 
            this.lblPostaldes.AutoSize = true;
            this.lblPostaldes.BackColor = System.Drawing.Color.White;
            this.lblPostaldes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostaldes.Location = new System.Drawing.Point(360, 179);
            this.lblPostaldes.Name = "lblPostaldes";
            this.lblPostaldes.Size = new System.Drawing.Size(57, 20);
            this.lblPostaldes.TabIndex = 58;
            this.lblPostaldes.Text = "Postal:";
            // 
            // lblEmaildes
            // 
            this.lblEmaildes.AutoSize = true;
            this.lblEmaildes.BackColor = System.Drawing.Color.White;
            this.lblEmaildes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmaildes.Location = new System.Drawing.Point(360, 241);
            this.lblEmaildes.Name = "lblEmaildes";
            this.lblEmaildes.Size = new System.Drawing.Size(52, 20);
            this.lblEmaildes.TabIndex = 85;
            this.lblEmaildes.Text = "Email:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 67);
            this.panel1.TabIndex = 93;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Controls.Add(this.label4city);
            this.panel2.Controls.Add(this.lblLast);
            this.panel2.Controls.Add(this.lblcity);
            this.panel2.Controls.Add(this.lblEmaildes);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.lblAddressdes);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.lblemail);
            this.panel2.Controls.Add(this.lblPostaldes);
            this.panel2.Controls.Add(this.txtCity);
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblphone);
            this.panel2.Controls.Add(this.customerid);
            this.panel2.Controls.Add(this.txtPostal);
            this.panel2.Controls.Add(this.lblphonedet);
            this.panel2.Controls.Add(this.lblpostal);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.txtLast);
            this.panel2.Controls.Add(this.lblFirstis);
            this.panel2.Controls.Add(this.lbladdress);
            this.panel2.Controls.Add(this.lblLastis);
            this.panel2.Controls.Add(this.lblFirst);
            this.panel2.Controls.Add(this.txtFirst);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Location = new System.Drawing.Point(52, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 348);
            this.panel2.TabIndex = 94;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Navy;
            this.panel10.Location = new System.Drawing.Point(364, 264);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(225, 1);
            this.panel10.TabIndex = 103;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Navy;
            this.panel9.Location = new System.Drawing.Point(364, 198);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(225, 1);
            this.panel9.TabIndex = 102;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Navy;
            this.panel8.Location = new System.Drawing.Point(364, 141);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(225, 1);
            this.panel8.TabIndex = 101;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Navy;
            this.panel7.Location = new System.Drawing.Point(364, 82);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(225, 1);
            this.panel7.TabIndex = 100;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Navy;
            this.panel6.Location = new System.Drawing.Point(69, 260);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(225, 1);
            this.panel6.TabIndex = 100;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Location = new System.Drawing.Point(72, 198);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(225, 1);
            this.panel5.TabIndex = 99;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Location = new System.Drawing.Point(72, 144);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 1);
            this.panel4.TabIndex = 99;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Location = new System.Drawing.Point(72, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 1);
            this.panel3.TabIndex = 98;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(158, 288);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 35);
            this.button5.TabIndex = 97;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(256, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 35);
            this.button4.TabIndex = 96;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(354, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 35);
            this.button3.TabIndex = 95;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(452, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 35);
            this.button2.TabIndex = 94;
            this.button2.Text = "New";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(60, 288);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 35);
            this.btnSubmit.TabIndex = 93;
            this.btnSubmit.Text = "Return";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1450, 800);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerDetails";
            this.Text = "CustomerDetails";
            this.Load += new System.EventHandler(this.CustomerDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminDS2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}