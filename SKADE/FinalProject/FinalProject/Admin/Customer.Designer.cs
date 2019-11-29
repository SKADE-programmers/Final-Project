namespace FinalProject
{
    partial class Customer
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
            this.CustomerSearch = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.Label();
            this.CreateCustomer = new System.Windows.Forms.Button();
            this.EditCustomer = new System.Windows.Forms.Button();
            this.CustomerDetails = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.custPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminDS1 = new DataLibrary.AdminDS();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDS1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerSearch
            // 
            this.CustomerSearch.AutoSize = true;
            this.CustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSearch.Location = new System.Drawing.Point(8, 27);
            this.CustomerSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerSearch.Name = "CustomerSearch";
            this.CustomerSearch.Size = new System.Drawing.Size(137, 20);
            this.CustomerSearch.TabIndex = 0;
            this.CustomerSearch.Text = "Customer Search:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // list
            // 
            this.list.AutoSize = true;
            this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.Location = new System.Drawing.Point(368, 27);
            this.list.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(137, 20);
            this.list.TabIndex = 3;
            this.list.Text = "List of Customers:";
            this.list.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateCustomer
            // 
            this.CreateCustomer.Location = new System.Drawing.Point(614, 107);
            this.CreateCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.CreateCustomer.Name = "CreateCustomer";
            this.CreateCustomer.Size = new System.Drawing.Size(134, 25);
            this.CreateCustomer.TabIndex = 7;
            this.CreateCustomer.Text = "Create New Customer";
            this.CreateCustomer.UseVisualStyleBackColor = true;
            this.CreateCustomer.Click += new System.EventHandler(this.CreateCustomer_Click);
            // 
            // EditCustomer
            // 
            this.EditCustomer.Location = new System.Drawing.Point(614, 68);
            this.EditCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.EditCustomer.Name = "EditCustomer";
            this.EditCustomer.Size = new System.Drawing.Size(134, 23);
            this.EditCustomer.TabIndex = 6;
            this.EditCustomer.Text = "Edit Customer";
            this.EditCustomer.UseVisualStyleBackColor = true;
            this.EditCustomer.Click += new System.EventHandler(this.EditCustomer_Click);
            // 
            // CustomerDetails
            // 
            this.CustomerDetails.Location = new System.Drawing.Point(614, 25);
            this.CustomerDetails.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerDetails.Name = "CustomerDetails";
            this.CustomerDetails.Size = new System.Drawing.Size(134, 20);
            this.CustomerDetails.TabIndex = 5;
            this.CustomerDetails.Text = "Customer Details";
            this.CustomerDetails.UseVisualStyleBackColor = true;
            this.CustomerDetails.Click += new System.EventHandler(this.CustomerDetails_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.adminDS1;
            this.comboBox1.DisplayMember = "customer.Customer Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(499, 27);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "customer.id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custPhone,
            this.custAddress,
            this.custCity,
            this.custPostal,
            this.custEmail,
            this.Column1});
            this.dgv.DataSource = this.adminDS1;
            this.dgv.Location = new System.Drawing.Point(2, 196);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(818, 271);
            this.dgv.TabIndex = 8;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellContentClick);
            // 
            // custPhone
            // 
            this.custPhone.DataPropertyName = "custPhone";
            this.custPhone.HeaderText = "custPhone";
            this.custPhone.Name = "custPhone";
            // 
            // custAddress
            // 
            this.custAddress.DataPropertyName = "custAddress";
            this.custAddress.HeaderText = "custAddress";
            this.custAddress.Name = "custAddress";
            // 
            // custCity
            // 
            this.custCity.DataPropertyName = "custCity";
            this.custCity.HeaderText = "custCity";
            this.custCity.Name = "custCity";
            // 
            // custPostal
            // 
            this.custPostal.DataPropertyName = "custPostal";
            this.custPostal.HeaderText = "custPostal";
            this.custPostal.Name = "custPostal";
            // 
            // custEmail
            // 
            this.custEmail.DataPropertyName = "custEmail";
            this.custEmail.HeaderText = "custEmail";
            this.custEmail.Name = "custEmail";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // adminDS1
            // 
            this.adminDS1.DataSetName = "AdminDS";
            this.adminDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 464);
            this.Controls.Add(this.CreateCustomer);
            this.Controls.Add(this.EditCustomer);
            this.Controls.Add(this.CustomerDetails);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.list);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CustomerSearch);
            this.Controls.Add(this.dgv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDS1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label list;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CreateCustomer;
        private System.Windows.Forms.Button EditCustomer;
        private System.Windows.Forms.Button CustomerDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn custAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn custCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn custEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private DataLibrary.AdminDS adminDS1;
    }
}