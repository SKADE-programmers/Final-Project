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
            this.adminDS1 = new DataLibrary.AdminDS();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customerid = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adminDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerSearch
            // 
            this.CustomerSearch.AutoSize = true;
            this.CustomerSearch.BackColor = System.Drawing.Color.White;
            this.CustomerSearch.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSearch.ForeColor = System.Drawing.Color.SteelBlue;
            this.CustomerSearch.Location = new System.Drawing.Point(395, 71);
            this.CustomerSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerSearch.Name = "CustomerSearch";
            this.CustomerSearch.Size = new System.Drawing.Size(232, 33);
            this.CustomerSearch.TabIndex = 0;
            this.CustomerSearch.Text = "Customer Search:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(350, 125);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 28);
            this.textBox1.TabIndex = 1;
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
            this.dgv.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
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
            this.dgv.Location = new System.Drawing.Point(0, 357);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv.Size = new System.Drawing.Size(1114, 311);
            this.dgv.TabIndex = 8;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.FillWeight = 61.83746F;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Customer Name";
            this.dataGridViewTextBoxColumn1.FillWeight = 137.778F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 180;
            // 
            // custPhone
            // 
            this.custPhone.DataPropertyName = "custPhone";
            this.custPhone.FillWeight = 91.66967F;
            this.custPhone.HeaderText = "custPhone";
            this.custPhone.MinimumWidth = 6;
            this.custPhone.Name = "custPhone";
            this.custPhone.ReadOnly = true;
            this.custPhone.Width = 148;
            // 
            // custAddress
            // 
            this.custAddress.DataPropertyName = "custAddress";
            this.custAddress.FillWeight = 126.713F;
            this.custAddress.HeaderText = "custAddress";
            this.custAddress.MinimumWidth = 6;
            this.custAddress.Name = "custAddress";
            this.custAddress.ReadOnly = true;
            this.custAddress.Width = 200;
            // 
            // custCity
            // 
            this.custCity.DataPropertyName = "custCity";
            this.custCity.FillWeight = 90.03324F;
            this.custCity.HeaderText = "custCity";
            this.custCity.MinimumWidth = 6;
            this.custCity.Name = "custCity";
            this.custCity.ReadOnly = true;
            this.custCity.Width = 165;
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
            // custEmail
            // 
            this.custEmail.DataPropertyName = "custEmail";
            this.custEmail.FillWeight = 130.082F;
            this.custEmail.HeaderText = "custEmail";
            this.custEmail.MinimumWidth = 6;
            this.custEmail.Name = "custEmail";
            this.custEmail.ReadOnly = true;
            this.custEmail.Width = 280;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.customerid);
            this.panel1.Controls.Add(this.CustomerSearch);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Location = new System.Drawing.Point(24, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 671);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Location = new System.Drawing.Point(350, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 2);
            this.panel2.TabIndex = 103;
            // 
            // customerid
            // 
            this.customerid.AutoSize = true;
            this.customerid.BackColor = System.Drawing.Color.White;
            this.customerid.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerid.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.customerid.Location = new System.Drawing.Point(3, 15);
            this.customerid.Name = "customerid";
            this.customerid.Size = new System.Drawing.Size(239, 32);
            this.customerid.TabIndex = 102;
            this.customerid.Text = "Customer Search";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(350, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 63);
            this.button4.TabIndex = 101;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(925, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 36);
            this.button3.TabIndex = 100;
            this.button3.Text = "Customer Details";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.CustomerDetails_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Location = new System.Drawing.Point(987, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 36);
            this.button2.TabIndex = 99;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.CreateCustomer_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(538, 239);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(176, 63);
            this.btnClear.TabIndex = 98;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1161, 719);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Customer";
            this.Text = "Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CustomerSearch;
        private System.Windows.Forms.TextBox textBox1;
        private DataLibrary.AdminDS adminDS1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn custAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn custCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn custEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label customerid;
        private System.Windows.Forms.Panel panel2;
    }
}