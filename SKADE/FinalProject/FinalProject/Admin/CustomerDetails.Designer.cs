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
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.customerid = new System.Windows.Forms.Label();
            this.adminDS2 = new DataLibrary.AdminDS();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.adminDS2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLast
            // 
            this.txtLast.BackColor = System.Drawing.Color.White;
            this.txtLast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtLast.Location = new System.Drawing.Point(204, 359);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(225, 31);
            this.txtLast.TabIndex = 75;
            this.txtLast.Visible = false;
            // 
            // txtFirst
            // 
            this.txtFirst.BackColor = System.Drawing.Color.White;
            this.txtFirst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtFirst.Location = new System.Drawing.Point(204, 248);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(225, 31);
            this.txtFirst.TabIndex = 74;
            this.txtFirst.Visible = false;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtID.Location = new System.Drawing.Point(209, 137);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(225, 31);
            this.txtID.TabIndex = 73;
            this.txtID.Visible = false;
            this.txtID.TextChanged += new System.EventHandler(this.TxtID_TextChanged);
            // 
            // customerid
            // 
            this.customerid.AutoSize = true;
            this.customerid.BackColor = System.Drawing.Color.White;
            this.customerid.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerid.ForeColor = System.Drawing.Color.SteelBlue;
            this.customerid.Location = new System.Drawing.Point(203, 96);
            this.customerid.Name = "customerid";
            this.customerid.Size = new System.Drawing.Size(166, 33);
            this.customerid.TabIndex = 72;
            this.customerid.Text = "Customer ID";
            // 
            // adminDS2
            // 
            this.adminDS2.DataSetName = "AdminDS";
            this.adminDS2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.lblLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblLast.Location = new System.Drawing.Point(204, 359);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(93, 31);
            this.lblLast.TabIndex = 65;
            this.lblLast.Text = "lblLast";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblID.Location = new System.Drawing.Point(204, 137);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(69, 31);
            this.lblID.TabIndex = 64;
            this.lblID.Text = "lblID";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.BackColor = System.Drawing.Color.White;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblFirst.Location = new System.Drawing.Point(204, 248);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(95, 31);
            this.lblFirst.TabIndex = 63;
            this.lblFirst.Text = "lblFirst";
            this.lblFirst.Click += new System.EventHandler(this.LblFirst_Click);
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.BackColor = System.Drawing.Color.White;
            this.lblphone.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblphone.Location = new System.Drawing.Point(204, 415);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(196, 33);
            this.lblphone.TabIndex = 56;
            this.lblphone.Text = "Phone Number";
            // 
            // lblLastis
            // 
            this.lblLastis.AutoSize = true;
            this.lblLastis.BackColor = System.Drawing.Color.White;
            this.lblLastis.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastis.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblLastis.Location = new System.Drawing.Point(204, 309);
            this.lblLastis.Name = "lblLastis";
            this.lblLastis.Size = new System.Drawing.Size(137, 33);
            this.lblLastis.TabIndex = 59;
            this.lblLastis.Text = "LastName";
            // 
            // lblFirstis
            // 
            this.lblFirstis.AutoSize = true;
            this.lblFirstis.BackColor = System.Drawing.Color.White;
            this.lblFirstis.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstis.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblFirstis.Location = new System.Drawing.Point(204, 198);
            this.lblFirstis.Name = "lblFirstis";
            this.lblFirstis.Size = new System.Drawing.Size(142, 33);
            this.lblFirstis.TabIndex = 55;
            this.lblFirstis.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 72);
            this.label2.TabIndex = 81;
            this.label2.Text = "Customer \r\nDetails";
            // 
            // txtPostal
            // 
            this.txtPostal.BackColor = System.Drawing.Color.White;
            this.txtPostal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostal.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPostal.Location = new System.Drawing.Point(647, 359);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(225, 31);
            this.txtPostal.TabIndex = 77;
            this.txtPostal.Visible = false;
            // 
            // lblpostal
            // 
            this.lblpostal.AutoSize = true;
            this.lblpostal.BackColor = System.Drawing.Color.White;
            this.lblpostal.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpostal.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblpostal.Location = new System.Drawing.Point(647, 309);
            this.lblpostal.Name = "lblpostal";
            this.lblpostal.Size = new System.Drawing.Size(91, 33);
            this.lblpostal.TabIndex = 58;
            this.lblpostal.Text = "Postal";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtAddress.Location = new System.Drawing.Point(653, 137);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(225, 31);
            this.txtAddress.TabIndex = 76;
            this.txtAddress.Visible = false;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.BackColor = System.Drawing.Color.White;
            this.lbladdress.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbladdress.Location = new System.Drawing.Point(647, 96);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(116, 33);
            this.lbladdress.TabIndex = 57;
            this.lbladdress.Text = "Address";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPhone.Location = new System.Drawing.Point(204, 465);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(225, 31);
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
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtEmail.Location = new System.Drawing.Point(647, 465);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 31);
            this.txtEmail.TabIndex = 87;
            this.txtEmail.Visible = false;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.White;
            this.lblemail.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblemail.Location = new System.Drawing.Point(647, 415);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(83, 33);
            this.lblemail.TabIndex = 85;
            this.lblemail.Text = "Email";
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
            this.lblcity.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcity.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblcity.Location = new System.Drawing.Point(647, 198);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(61, 33);
            this.lblcity.TabIndex = 90;
            this.lblcity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.White;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtCity.Location = new System.Drawing.Point(647, 248);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(225, 31);
            this.txtCity.TabIndex = 91;
            this.txtCity.Visible = false;
            // 
            // lblphonedet
            // 
            this.lblphonedet.AutoSize = true;
            this.lblphonedet.BackColor = System.Drawing.Color.White;
            this.lblphonedet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphonedet.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblphonedet.Location = new System.Drawing.Point(204, 465);
            this.lblphonedet.Name = "lblphonedet";
            this.lblphonedet.Size = new System.Drawing.Size(116, 31);
            this.lblphonedet.TabIndex = 57;
            this.lblphonedet.Text = "lblphone";
            // 
            // label4city
            // 
            this.label4city.AutoSize = true;
            this.label4city.BackColor = System.Drawing.Color.White;
            this.label4city.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4city.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4city.Location = new System.Drawing.Point(647, 248);
            this.label4city.Name = "label4city";
            this.label4city.Size = new System.Drawing.Size(70, 31);
            this.label4city.TabIndex = 92;
            this.label4city.Text = "City:";
            // 
            // lblAddressdes
            // 
            this.lblAddressdes.AutoSize = true;
            this.lblAddressdes.BackColor = System.Drawing.Color.White;
            this.lblAddressdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressdes.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblAddressdes.Location = new System.Drawing.Point(647, 137);
            this.lblAddressdes.Name = "lblAddressdes";
            this.lblAddressdes.Size = new System.Drawing.Size(116, 31);
            this.lblAddressdes.TabIndex = 57;
            this.lblAddressdes.Text = "lblphone";
            // 
            // lblPostaldes
            // 
            this.lblPostaldes.AutoSize = true;
            this.lblPostaldes.BackColor = System.Drawing.Color.White;
            this.lblPostaldes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostaldes.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblPostaldes.Location = new System.Drawing.Point(647, 359);
            this.lblPostaldes.Name = "lblPostaldes";
            this.lblPostaldes.Size = new System.Drawing.Size(98, 31);
            this.lblPostaldes.TabIndex = 58;
            this.lblPostaldes.Text = "Postal:";
            // 
            // lblEmaildes
            // 
            this.lblEmaildes.AutoSize = true;
            this.lblEmaildes.BackColor = System.Drawing.Color.White;
            this.lblEmaildes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmaildes.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblEmaildes.Location = new System.Drawing.Point(647, 465);
            this.lblEmaildes.Name = "lblEmaildes";
            this.lblEmaildes.Size = new System.Drawing.Size(89, 31);
            this.lblEmaildes.TabIndex = 85;
            this.lblEmaildes.Text = "Email:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Controls.Add(this.label4city);
            this.panel2.Controls.Add(this.lblLast);
            this.panel2.Controls.Add(this.lblcity);
            this.panel2.Controls.Add(this.lblEmaildes);
            this.panel2.Controls.Add(this.lblAddressdes);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.lblemail);
            this.panel2.Controls.Add(this.lblPostaldes);
            this.panel2.Controls.Add(this.txtCity);
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
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1137, 695);
            this.panel2.TabIndex = 94;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(822, 565);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 63);
            this.btnSave.TabIndex = 97;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(458, 565);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 63);
            this.btnDelete.TabIndex = 96;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(640, 565);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(176, 63);
            this.btnEdit.TabIndex = 95;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(276, 565);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(176, 63);
            this.btnCreate.TabIndex = 94;
            this.btnCreate.Text = "New";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(94, 565);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(176, 63);
            this.btnSubmit.TabIndex = 93;
            this.btnSubmit.Text = "Return";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(210, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 1);
            this.panel1.TabIndex = 98;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel3.Location = new System.Drawing.Point(653, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 1);
            this.panel3.TabIndex = 98;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel4.Location = new System.Drawing.Point(653, 283);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 1);
            this.panel4.TabIndex = 98;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel5.Location = new System.Drawing.Point(653, 389);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(258, 1);
            this.panel5.TabIndex = 98;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel6.Location = new System.Drawing.Point(653, 499);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(258, 1);
            this.panel6.TabIndex = 98;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SteelBlue;
            this.panel7.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel7.Location = new System.Drawing.Point(209, 278);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(258, 1);
            this.panel7.TabIndex = 98;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SteelBlue;
            this.panel8.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel8.Location = new System.Drawing.Point(210, 393);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(258, 1);
            this.panel8.TabIndex = 98;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SteelBlue;
            this.panel9.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel9.Location = new System.Drawing.Point(210, 499);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(258, 1);
            this.panel9.TabIndex = 98;
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1161, 719);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblPos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomerDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminDS2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label customerid;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFirst;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}