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
            this.btnEdit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.adminDS = new DataLibrary.AdminDS();
            this.lblIDis = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.btnEditLogin = new System.Windows.Forms.Button();
            this.lblLoginIs = new System.Windows.Forms.Label();
            this.lblPassis = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cBoxPos = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adminDS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstis
            // 
            this.lblFirstis.AutoSize = true;
            this.lblFirstis.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstis.Location = new System.Drawing.Point(511, 224);
            this.lblFirstis.Name = "lblFirstis";
            this.lblFirstis.Size = new System.Drawing.Size(169, 33);
            this.lblFirstis.TabIndex = 0;
            this.lblFirstis.Text = "FirstName:";
            // 
            // lblLastis
            // 
            this.lblLastis.AutoSize = true;
            this.lblLastis.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastis.Location = new System.Drawing.Point(515, 295);
            this.lblLastis.Name = "lblLastis";
            this.lblLastis.Size = new System.Drawing.Size(165, 33);
            this.lblLastis.TabIndex = 2;
            this.lblLastis.Text = "LastName:";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(465, 618);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(138, 56);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(459, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(259, 33);
            this.label10.TabIndex = 18;
            this.label10.Text = "Employee Details";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblFirst.Location = new System.Drawing.Point(686, 224);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(76, 33);
            this.lblFirst.TabIndex = 19;
            this.lblFirst.Text = "Text";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblLast.Location = new System.Drawing.Point(686, 295);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(76, 33);
            this.lblLast.TabIndex = 20;
            this.lblLast.Text = "Text";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(775, 618);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 56);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.adminDS, "EmployeeSimple.id", true));
            this.listBox1.DataSource = this.adminDS;
            this.listBox1.DisplayMember = "EmployeeSimple.empFirst";
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 33;
            this.listBox1.Location = new System.Drawing.Point(54, 120);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(345, 466);
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
            this.lblIDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDis.Location = new System.Drawing.Point(478, 153);
            this.lblIDis.Name = "lblIDis";
            this.lblIDis.Size = new System.Drawing.Size(202, 33);
            this.lblIDis.TabIndex = 28;
            this.lblIDis.Text = "Employee ID:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblID.Location = new System.Drawing.Point(686, 153);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(76, 33);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Position:";
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblPos.Location = new System.Drawing.Point(686, 366);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(76, 33);
            this.lblPos.TabIndex = 20;
            this.lblPos.Text = "Text";
            // 
            // btnEditLogin
            // 
            this.btnEditLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditLogin.Location = new System.Drawing.Point(620, 618);
            this.btnEditLogin.Name = "btnEditLogin";
            this.btnEditLogin.Size = new System.Drawing.Size(138, 56);
            this.btnEditLogin.TabIndex = 14;
            this.btnEditLogin.Text = "Edit Login";
            this.btnEditLogin.UseVisualStyleBackColor = true;
            this.btnEditLogin.Visible = false;
            this.btnEditLogin.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblLoginIs
            // 
            this.lblLoginIs.AutoSize = true;
            this.lblLoginIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginIs.Location = new System.Drawing.Point(580, 437);
            this.lblLoginIs.Name = "lblLoginIs";
            this.lblLoginIs.Size = new System.Drawing.Size(100, 33);
            this.lblLoginIs.TabIndex = 2;
            this.lblLoginIs.Text = "Login:";
            // 
            // lblPassis
            // 
            this.lblPassis.AutoSize = true;
            this.lblPassis.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassis.Location = new System.Drawing.Point(520, 508);
            this.lblPassis.Name = "lblPassis";
            this.lblPassis.Size = new System.Drawing.Size(160, 33);
            this.lblPassis.TabIndex = 2;
            this.lblPassis.Text = "Password:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblLogin.Location = new System.Drawing.Point(686, 437);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(76, 33);
            this.lblLogin.TabIndex = 20;
            this.lblLogin.Text = "Text";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblPass.Location = new System.Drawing.Point(686, 508);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(76, 33);
            this.lblPass.TabIndex = 20;
            this.lblPass.Text = "Text";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(930, 618);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 56);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click_Save);
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtFirst.Location = new System.Drawing.Point(689, 221);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(300, 40);
            this.txtFirst.TabIndex = 51;
            this.txtFirst.Visible = false;
            // 
            // txtLast
            // 
            this.txtLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtLast.Location = new System.Drawing.Point(689, 292);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(300, 40);
            this.txtLast.TabIndex = 51;
            this.txtLast.Visible = false;
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtLogin.Location = new System.Drawing.Point(689, 434);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.ReadOnly = true;
            this.txtLogin.Size = new System.Drawing.Size(300, 40);
            this.txtLogin.TabIndex = 51;
            this.txtLogin.Visible = false;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtPass.Location = new System.Drawing.Point(689, 505);
            this.txtPass.Name = "txtPass";
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(300, 40);
            this.txtPass.TabIndex = 51;
            this.txtPass.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCreate.Location = new System.Drawing.Point(261, 618);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(138, 56);
            this.btnCreate.TabIndex = 52;
            this.btnCreate.Text = "Create New Employee";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // cBoxPos
            // 
            this.cBoxPos.DataSource = this.adminDS;
            this.cBoxPos.DisplayMember = "Position.posName";
            this.cBoxPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.cBoxPos.FormattingEnabled = true;
            this.cBoxPos.Location = new System.Drawing.Point(689, 362);
            this.cBoxPos.Name = "cBoxPos";
            this.cBoxPos.Size = new System.Drawing.Size(300, 41);
            this.cBoxPos.TabIndex = 53;
            this.cBoxPos.ValueMember = "Position.id";
            this.cBoxPos.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtID.Location = new System.Drawing.Point(689, 150);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(300, 40);
            this.txtID.TabIndex = 51;
            this.txtID.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(54, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 56);
            this.button1.TabIndex = 54;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // EmployeDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 719);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cBoxPos);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblIDis);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnEditLogin);
            this.Controls.Add(this.lblPassis);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblLoginIs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLastis);
            this.Controls.Add(this.lblFirstis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeDetail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstis;
        private System.Windows.Forms.Label lblLastis;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblIDis;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Button btnEditLogin;
        private System.Windows.Forms.Label lblLoginIs;
        private System.Windows.Forms.Label lblPassis;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cBoxPos;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button button1;
        private DataLibrary.AdminDS adminDS;
    }
}