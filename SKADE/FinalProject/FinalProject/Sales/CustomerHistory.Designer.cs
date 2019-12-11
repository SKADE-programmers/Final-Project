namespace FinalProject.Sales
{
    partial class CustomerHistory
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salesDS1 = new DataLibrary.SalesDS();
            this.emmasDataSet1 = new DataLibrary.EmmasDataSet();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custFirstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custLastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordPaidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.paymentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emmasDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 91);
            this.button1.TabIndex = 28;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(138, 35);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(152, 20);
            this.textBox4.TabIndex = 27;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 58);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 20);
            this.textBox3.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 84);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Customer Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Customer City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Customer Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Customer First Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.custFirstDataGridViewTextBoxColumn,
            this.custLastDataGridViewTextBoxColumn,
            this.custPhoneDataGridViewTextBoxColumn,
            this.custAddressDataGridViewTextBoxColumn,
            this.custCityDataGridViewTextBoxColumn,
            this.custPostalDataGridViewTextBoxColumn,
            this.custEmailDataGridViewTextBoxColumn,
            this.ordNumberDataGridViewTextBoxColumn,
            this.ordDateDataGridViewTextBoxColumn,
            this.ordPaidDataGridViewCheckBoxColumn,
            this.paymentIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "customer";
            this.dataGridView1.DataSource = this.salesDS1;
            this.dataGridView1.Location = new System.Drawing.Point(7, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1195, 589);
            this.dataGridView1.TabIndex = 29;
            // 
            // salesDS1
            // 
            this.salesDS1.DataSetName = "SalesDS";
            this.salesDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emmasDataSet1
            // 
            this.emmasDataSet1.DataSetName = "EmmasDataSet";
            this.emmasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custFirstDataGridViewTextBoxColumn
            // 
            this.custFirstDataGridViewTextBoxColumn.DataPropertyName = "custFirst";
            this.custFirstDataGridViewTextBoxColumn.HeaderText = "custFirst";
            this.custFirstDataGridViewTextBoxColumn.Name = "custFirstDataGridViewTextBoxColumn";
            this.custFirstDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custLastDataGridViewTextBoxColumn
            // 
            this.custLastDataGridViewTextBoxColumn.DataPropertyName = "custLast";
            this.custLastDataGridViewTextBoxColumn.HeaderText = "custLast";
            this.custLastDataGridViewTextBoxColumn.Name = "custLastDataGridViewTextBoxColumn";
            this.custLastDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custPhoneDataGridViewTextBoxColumn
            // 
            this.custPhoneDataGridViewTextBoxColumn.DataPropertyName = "custPhone";
            this.custPhoneDataGridViewTextBoxColumn.HeaderText = "custPhone";
            this.custPhoneDataGridViewTextBoxColumn.Name = "custPhoneDataGridViewTextBoxColumn";
            this.custPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custAddressDataGridViewTextBoxColumn
            // 
            this.custAddressDataGridViewTextBoxColumn.DataPropertyName = "custAddress";
            this.custAddressDataGridViewTextBoxColumn.HeaderText = "custAddress";
            this.custAddressDataGridViewTextBoxColumn.Name = "custAddressDataGridViewTextBoxColumn";
            this.custAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custCityDataGridViewTextBoxColumn
            // 
            this.custCityDataGridViewTextBoxColumn.DataPropertyName = "custCity";
            this.custCityDataGridViewTextBoxColumn.HeaderText = "custCity";
            this.custCityDataGridViewTextBoxColumn.Name = "custCityDataGridViewTextBoxColumn";
            this.custCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custPostalDataGridViewTextBoxColumn
            // 
            this.custPostalDataGridViewTextBoxColumn.DataPropertyName = "custPostal";
            this.custPostalDataGridViewTextBoxColumn.HeaderText = "custPostal";
            this.custPostalDataGridViewTextBoxColumn.Name = "custPostalDataGridViewTextBoxColumn";
            this.custPostalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custEmailDataGridViewTextBoxColumn
            // 
            this.custEmailDataGridViewTextBoxColumn.DataPropertyName = "custEmail";
            this.custEmailDataGridViewTextBoxColumn.HeaderText = "custEmail";
            this.custEmailDataGridViewTextBoxColumn.Name = "custEmailDataGridViewTextBoxColumn";
            this.custEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordNumberDataGridViewTextBoxColumn
            // 
            this.ordNumberDataGridViewTextBoxColumn.DataPropertyName = "ordNumber";
            this.ordNumberDataGridViewTextBoxColumn.HeaderText = "ordNumber";
            this.ordNumberDataGridViewTextBoxColumn.Name = "ordNumberDataGridViewTextBoxColumn";
            this.ordNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordDateDataGridViewTextBoxColumn
            // 
            this.ordDateDataGridViewTextBoxColumn.DataPropertyName = "ordDate";
            this.ordDateDataGridViewTextBoxColumn.HeaderText = "ordDate";
            this.ordDateDataGridViewTextBoxColumn.Name = "ordDateDataGridViewTextBoxColumn";
            this.ordDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordPaidDataGridViewCheckBoxColumn
            // 
            this.ordPaidDataGridViewCheckBoxColumn.DataPropertyName = "ordPaid";
            this.ordPaidDataGridViewCheckBoxColumn.HeaderText = "ordPaid";
            this.ordPaidDataGridViewCheckBoxColumn.Name = "ordPaidDataGridViewCheckBoxColumn";
            this.ordPaidDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // paymentIDDataGridViewTextBoxColumn
            // 
            this.paymentIDDataGridViewTextBoxColumn.DataPropertyName = "paymentID";
            this.paymentIDDataGridViewTextBoxColumn.HeaderText = "paymentID";
            this.paymentIDDataGridViewTextBoxColumn.Name = "paymentIDDataGridViewTextBoxColumn";
            this.paymentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CustomerHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 719);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerHistory";
            this.Text = "CustomerHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emmasDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DataLibrary.EmmasDataSet emmasDataSet1;
        private DataLibrary.SalesDS salesDS1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custFirstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custLastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ordPaidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentIDDataGridViewTextBoxColumn;
    }
}