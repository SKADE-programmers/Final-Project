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
            this.CustomerDetails = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.adminDS1 = new DataLibrary.AdminDS();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.adminDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerSearch
            // 
            this.CustomerSearch.AutoSize = true;
            this.CustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.CustomerSearch.Location = new System.Drawing.Point(64, 39);
            this.CustomerSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerSearch.Name = "CustomerSearch";
            this.CustomerSearch.Size = new System.Drawing.Size(266, 33);
            this.CustomerSearch.TabIndex = 0;
            this.CustomerSearch.Text = "Customer Search:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(70, 76);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 40);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(418, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 77);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // list
            // 
            this.list.AutoSize = true;
            this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.list.Location = new System.Drawing.Point(624, 39);
            this.list.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(269, 33);
            this.list.TabIndex = 3;
            this.list.Text = "List of Customers:";
            this.list.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateCustomer
            // 
            this.CreateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.CreateCustomer.Location = new System.Drawing.Point(1236, 145);
            this.CreateCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.CreateCustomer.Name = "CreateCustomer";
            this.CreateCustomer.Size = new System.Drawing.Size(185, 77);
            this.CreateCustomer.TabIndex = 7;
            this.CreateCustomer.Text = "Create Customer";
            this.CreateCustomer.UseVisualStyleBackColor = true;
            this.CreateCustomer.Click += new System.EventHandler(this.CreateCustomer_Click);
            // 
            // CustomerDetails
            // 
            this.CustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.CustomerDetails.Location = new System.Drawing.Point(1236, 39);
            this.CustomerDetails.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerDetails.Name = "CustomerDetails";
            this.CustomerDetails.Size = new System.Drawing.Size(185, 77);
            this.CustomerDetails.TabIndex = 5;
            this.CustomerDetails.Text = "Customer Details";
            this.CustomerDetails.UseVisualStyleBackColor = true;
            this.CustomerDetails.Click += new System.EventHandler(this.CustomerDetails_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.adminDS1;
            this.comboBox1.DisplayMember = "customer.Customer Name";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(934, 39);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 41);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "customer.id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // adminDS1
            // 
            this.adminDS1.DataSetName = "AdminDS";
            this.adminDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn1,
            this.custPhone,
            this.custAddress,
            this.custCity,
            this.custPostal,
            this.custEmail});
            this.dgv.DataMember = "CustomerSimple";
            this.dgv.DataSource = this.adminDS1;
            this.dgv.Location = new System.Drawing.Point(14, 263);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv.Size = new System.Drawing.Size(1418, 516);
            this.dgv.TabIndex = 8;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellContentClick);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(418, 145);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(185, 77);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Customer Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 225;
            // 
            // custPhone
            // 
            this.custPhone.DataPropertyName = "custPhone";
            this.custPhone.HeaderText = "custPhone";
            this.custPhone.MinimumWidth = 6;
            this.custPhone.Name = "custPhone";
            this.custPhone.ReadOnly = true;
            this.custPhone.Width = 170;
            // 
            // custAddress
            // 
            this.custAddress.DataPropertyName = "custAddress";
            this.custAddress.HeaderText = "custAddress";
            this.custAddress.MinimumWidth = 6;
            this.custAddress.Name = "custAddress";
            this.custAddress.ReadOnly = true;
            this.custAddress.Width = 250;
            // 
            // custCity
            // 
            this.custCity.DataPropertyName = "custCity";
            this.custCity.HeaderText = "custCity";
            this.custCity.MinimumWidth = 6;
            this.custCity.Name = "custCity";
            this.custCity.ReadOnly = true;
            this.custCity.Width = 203;
            // 
            // custPostal
            // 
            this.custPostal.DataPropertyName = "custPostal";
            this.custPostal.HeaderText = "custPostal";
            this.custPostal.MinimumWidth = 6;
            this.custPostal.Name = "custPostal";
            this.custPostal.ReadOnly = true;
            this.custPostal.Width = 150;
            // 
            // custEmail
            // 
            this.custEmail.DataPropertyName = "custEmail";
            this.custEmail.HeaderText = "custEmail";
            this.custEmail.MinimumWidth = 6;
            this.custEmail.Name = "custEmail";
            this.custEmail.ReadOnly = true;
            this.custEmail.Width = 320;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 800);
            this.Controls.Add(this.CreateCustomer);
            this.Controls.Add(this.CustomerDetails);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.list);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CustomerSearch);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Customer";
            this.Text = "Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
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
        private System.Windows.Forms.Button CustomerDetails;
        private DataLibrary.AdminDS adminDS1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn custAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn custCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn custEmail;
    }
}