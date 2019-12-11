namespace FinalProject.Sales
{
    partial class SalesCustomer
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
            this.btnClear = new System.Windows.Forms.Button();
            this.custPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.custEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminDS1 = new DataLibrary.AdminDS();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateCustomer = new System.Windows.Forms.Button();
            this.CustomerDetails = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerSearch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDS1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(732, 19);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 61);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // custPostal
            // 
            this.custPostal.DataPropertyName = "custPostal";
            this.custPostal.FillWeight = 61.88665F;
            this.custPostal.HeaderText = "custPostal";
            this.custPostal.MinimumWidth = 6;
            this.custPostal.Name = "custPostal";
            this.custPostal.ReadOnly = true;
            // 
            // custCity
            // 
            this.custCity.DataPropertyName = "custCity";
            this.custCity.FillWeight = 90.03324F;
            this.custCity.HeaderText = "custCity";
            this.custCity.MinimumWidth = 6;
            this.custCity.Name = "custCity";
            this.custCity.ReadOnly = true;
            // 
            // custAddress
            // 
            this.custAddress.DataPropertyName = "custAddress";
            this.custAddress.FillWeight = 126.713F;
            this.custAddress.HeaderText = "custAddress";
            this.custAddress.MinimumWidth = 6;
            this.custAddress.Name = "custAddress";
            this.custAddress.ReadOnly = true;
            // 
            // custPhone
            // 
            this.custPhone.DataPropertyName = "custPhone";
            this.custPhone.FillWeight = 91.66967F;
            this.custPhone.HeaderText = "custPhone";
            this.custPhone.MinimumWidth = 6;
            this.custPhone.Name = "custPhone";
            this.custPhone.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Customer Name";
            this.dataGridViewTextBoxColumn1.FillWeight = 137.778F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.FillWeight = 61.83746F;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dgv.Location = new System.Drawing.Point(19, 100);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv.Size = new System.Drawing.Size(1169, 651);
            this.dgv.TabIndex = 17;
            // 
            // custEmail
            // 
            this.custEmail.DataPropertyName = "custEmail";
            this.custEmail.FillWeight = 130.082F;
            this.custEmail.HeaderText = "custEmail";
            this.custEmail.MinimumWidth = 6;
            this.custEmail.Name = "custEmail";
            this.custEmail.ReadOnly = true;
            // 
            // adminDS1
            // 
            this.adminDS1.DataSetName = "AdminDS";
            this.adminDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // CreateCustomer
            // 
            this.CreateCustomer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CreateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.CreateCustomer.ForeColor = System.Drawing.Color.White;
            this.CreateCustomer.Location = new System.Drawing.Point(1040, 19);
            this.CreateCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.CreateCustomer.Name = "CreateCustomer";
            this.CreateCustomer.Size = new System.Drawing.Size(148, 61);
            this.CreateCustomer.TabIndex = 16;
            this.CreateCustomer.Text = "Create Customer";
            this.CreateCustomer.UseVisualStyleBackColor = false;
            this.CreateCustomer.Click += new System.EventHandler(this.CreateCustomer_Click);
            // 
            // CustomerDetails
            // 
            this.CustomerDetails.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.CustomerDetails.ForeColor = System.Drawing.Color.White;
            this.CustomerDetails.Location = new System.Drawing.Point(888, 19);
            this.CustomerDetails.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerDetails.Name = "CustomerDetails";
            this.CustomerDetails.Size = new System.Drawing.Size(148, 61);
            this.CustomerDetails.TabIndex = 15;
            this.CustomerDetails.Text = "Customer Details";
            this.CustomerDetails.UseVisualStyleBackColor = false;
            this.CustomerDetails.Click += new System.EventHandler(this.CustomerDetails_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(580, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 61);
            this.button1.TabIndex = 12;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(305, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 35);
            this.textBox1.TabIndex = 10;
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
            // CustomerSearch
            // 
            this.CustomerSearch.AutoSize = true;
            this.CustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.CustomerSearch.Location = new System.Drawing.Point(300, 19);
            this.CustomerSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerSearch.Name = "CustomerSearch";
            this.CustomerSearch.Size = new System.Drawing.Size(221, 29);
            this.CustomerSearch.TabIndex = 9;
            this.CustomerSearch.Text = "Customer Search:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.CustomerSearch);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.CreateCustomer);
            this.panel1.Controls.Add(this.CustomerDetails);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 701);
            this.panel1.TabIndex = 18;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(19, 20);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(148, 61);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // SalesCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1227, 725);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesCustomer";
            this.Text = "SalesCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDS1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn custCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn custAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn custEmail;
        private DataLibrary.AdminDS adminDS1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Button CreateCustomer;
        private System.Windows.Forms.Button CustomerDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label CustomerSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReturn;
    }
}