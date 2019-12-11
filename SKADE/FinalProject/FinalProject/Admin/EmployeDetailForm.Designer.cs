namespace FinalProject
{//Scott Stratton
    partial class EmployeDetailForm
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
            this.lblFirstis = new System.Windows.Forms.Label();
            this.lblLastis = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.adminDS = new DataLibrary.AdminDS();
            this.lblIDis = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.lblLoginIs = new System.Windows.Forms.Label();
            this.lblPassis = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cBoxPos = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditLogin = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adminDS)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstis
            // 
            this.lblFirstis.AutoSize = true;
            this.lblFirstis.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstis.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblFirstis.Location = new System.Drawing.Point(10, 194);
            this.lblFirstis.Name = "lblFirstis";
            this.lblFirstis.Size = new System.Drawing.Size(156, 35);
            this.lblFirstis.TabIndex = 0;
            this.lblFirstis.Text = "FirstName:";
            // 
            // lblLastis
            // 
            this.lblLastis.AutoSize = true;
            this.lblLastis.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastis.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblLastis.Location = new System.Drawing.Point(10, 265);
            this.lblLastis.Name = "lblLastis";
            this.lblLastis.Size = new System.Drawing.Size(153, 35);
            this.lblLastis.TabIndex = 2;
            this.lblLastis.Text = "LastName:";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.BackColor = System.Drawing.Color.White;
            this.lblFirst.Font = new System.Drawing.Font("Bahnschrift Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblFirst.Location = new System.Drawing.Point(242, 224);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(67, 35);
            this.lblFirst.TabIndex = 19;
            this.lblFirst.Text = "Text";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.BackColor = System.Drawing.Color.White;
            this.lblLast.Font = new System.Drawing.Font("Bahnschrift Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblLast.Location = new System.Drawing.Point(242, 295);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(67, 35);
            this.lblLast.TabIndex = 20;
            this.lblLast.Text = "Text";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightBlue;
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.adminDS, "EmployeeSimple.id", true));
            this.listBox1.DataSource = this.adminDS;
            this.listBox1.DisplayMember = "EmployeeSimple.empFirst";
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 33;
            this.listBox1.Location = new System.Drawing.Point(635, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(427, 466);
            this.listBox1.TabIndex = 27;
            this.listBox1.TabStop = false;
            this.listBox1.ValueMember = "EmployeeSimple.id";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // adminDS
            // 
            this.adminDS.DataSetName = "AdminDS";
            this.adminDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblIDis
            // 
            this.lblIDis.AutoSize = true;
            this.lblIDis.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDis.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIDis.Location = new System.Drawing.Point(10, 123);
            this.lblIDis.Name = "lblIDis";
            this.lblIDis.Size = new System.Drawing.Size(183, 35);
            this.lblIDis.TabIndex = 28;
            this.lblIDis.Text = "Employee ID:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.Font = new System.Drawing.Font("Bahnschrift Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblID.Location = new System.Drawing.Point(242, 153);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(67, 35);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(10, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Position:";
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.BackColor = System.Drawing.Color.White;
            this.lblPos.Font = new System.Drawing.Font("Bahnschrift Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblPos.Location = new System.Drawing.Point(242, 366);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(67, 35);
            this.lblPos.TabIndex = 20;
            this.lblPos.Text = "Text";
            // 
            // lblLoginIs
            // 
            this.lblLoginIs.AutoSize = true;
            this.lblLoginIs.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginIs.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblLoginIs.Location = new System.Drawing.Point(10, 407);
            this.lblLoginIs.Name = "lblLoginIs";
            this.lblLoginIs.Size = new System.Drawing.Size(94, 35);
            this.lblLoginIs.TabIndex = 2;
            this.lblLoginIs.Text = "Login:";
            // 
            // lblPassis
            // 
            this.lblPassis.AutoSize = true;
            this.lblPassis.BackColor = System.Drawing.Color.White;
            this.lblPassis.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassis.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPassis.Location = new System.Drawing.Point(39, 505);
            this.lblPassis.Name = "lblPassis";
            this.lblPassis.Size = new System.Drawing.Size(150, 35);
            this.lblPassis.TabIndex = 2;
            this.lblPassis.Text = "Password:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.White;
            this.lblLogin.Font = new System.Drawing.Font("Bahnschrift Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblLogin.Location = new System.Drawing.Point(242, 437);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(67, 35);
            this.lblLogin.TabIndex = 20;
            this.lblLogin.Text = "Text";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.White;
            this.lblPass.Font = new System.Drawing.Font("Bahnschrift Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblPass.Location = new System.Drawing.Point(242, 508);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(67, 35);
            this.lblPass.TabIndex = 20;
            this.lblPass.Text = "Text";
            // 
            // txtFirst
            // 
            this.txtFirst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirst.Font = new System.Drawing.Font("Bahnschrift Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.Location = new System.Drawing.Point(199, 191);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(375, 35);
            this.txtFirst.TabIndex = 51;
            this.txtFirst.Visible = false;
            // 
            // txtLast
            // 
            this.txtLast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLast.Font = new System.Drawing.Font("Bahnschrift Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast.Location = new System.Drawing.Point(202, 262);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(375, 35);
            this.txtLast.TabIndex = 51;
            this.txtLast.Visible = false;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.White;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Font = new System.Drawing.Font("Bahnschrift Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(199, 403);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.ReadOnly = true;
            this.txtLogin.Size = new System.Drawing.Size(375, 35);
            this.txtLogin.TabIndex = 51;
            this.txtLogin.Visible = false;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Bahnschrift Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(202, 475);
            this.txtPass.Name = "txtPass";
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(375, 35);
            this.txtPass.TabIndex = 51;
            this.txtPass.Visible = false;
            // 
            // cBoxPos
            // 
            this.cBoxPos.DataSource = this.adminDS;
            this.cBoxPos.DisplayMember = "Position.posName";
            this.cBoxPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.cBoxPos.FormattingEnabled = true;
            this.cBoxPos.Location = new System.Drawing.Point(202, 326);
            this.cBoxPos.Name = "cBoxPos";
            this.cBoxPos.Size = new System.Drawing.Size(375, 41);
            this.cBoxPos.TabIndex = 53;
            this.cBoxPos.ValueMember = "Position.id";
            this.cBoxPos.Visible = false;
            this.cBoxPos.SelectedIndexChanged += new System.EventHandler(this.CBoxPos_SelectedIndexChanged);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Bahnschrift Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(199, 120);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(375, 35);
            this.txtID.TabIndex = 51;
            this.txtID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(228, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 2);
            this.panel1.TabIndex = 55;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Location = new System.Drawing.Point(228, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 2);
            this.panel2.TabIndex = 55;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Location = new System.Drawing.Point(228, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 2);
            this.panel3.TabIndex = 55;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Location = new System.Drawing.Point(228, 402);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(385, 2);
            this.panel4.TabIndex = 55;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Location = new System.Drawing.Point(228, 473);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(385, 2);
            this.panel5.TabIndex = 55;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel6.Location = new System.Drawing.Point(228, 544);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(385, 2);
            this.panel6.TabIndex = 55;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.btnSave);
            this.panel7.Controls.Add(this.btnDelete);
            this.panel7.Controls.Add(this.btnEditLogin);
            this.panel7.Controls.Add(this.btnEdit);
            this.panel7.Controls.Add(this.btnNew);
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.listBox1);
            this.panel7.Controls.Add(this.lblLastis);
            this.panel7.Controls.Add(this.lblFirstis);
            this.panel7.Controls.Add(this.lblLoginIs);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.lblIDis);
            this.panel7.Controls.Add(this.txtFirst);
            this.panel7.Controls.Add(this.cBoxPos);
            this.panel7.Controls.Add(this.txtPass);
            this.panel7.Controls.Add(this.txtID);
            this.panel7.Controls.Add(this.txtLogin);
            this.panel7.Controls.Add(this.txtLast);
            this.panel7.Location = new System.Drawing.Point(29, 33);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1092, 655);
            this.panel7.TabIndex = 56;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(842, 580);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 46);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click_Save);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(694, 580);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 46);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditLogin
            // 
            this.btnEditLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditLogin.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditLogin.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditLogin.ForeColor = System.Drawing.Color.White;
            this.btnEditLogin.Location = new System.Drawing.Point(554, 580);
            this.btnEditLogin.Name = "btnEditLogin";
            this.btnEditLogin.Size = new System.Drawing.Size(111, 46);
            this.btnEditLogin.TabIndex = 57;
            this.btnEditLogin.Text = "Edit Login";
            this.btnEditLogin.UseVisualStyleBackColor = false;
            this.btnEditLogin.Visible = false;
            this.btnEditLogin.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(409, 580);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 46);
            this.btnEdit.TabIndex = 56;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(267, 580);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(111, 46);
            this.btnNew.TabIndex = 55;
            this.btnNew.Text = "Create New Employee";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(133, 580);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 46);
            this.button2.TabIndex = 54;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label10.Location = new System.Drawing.Point(31, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(259, 36);
            this.label10.TabIndex = 18;
            this.label10.Text = "Employee Details";
            // 
            // EmployeDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1161, 719);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblPassis);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "e";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminDS)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstis;
        private System.Windows.Forms.Label lblLastis;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblIDis;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Label lblLoginIs;
        private System.Windows.Forms.Label lblPassis;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.ComboBox cBoxPos;
        private System.Windows.Forms.TextBox txtID;
        private DataLibrary.AdminDS adminDS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditLogin;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button button2;
    }
}