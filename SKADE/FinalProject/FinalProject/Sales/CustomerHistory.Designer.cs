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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.emmasDataSet1 = new DataLibrary.EmmasDataSet();
            this.custEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custLastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custFirstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emmasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "customer";
            this.bindingSource1.DataSource = this.emmasDataSet1;
            // 
            // emmasDataSet1
            // 
            this.emmasDataSet1.DataSetName = "EmmasDataSet";
            this.emmasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // custEmailDataGridViewTextBoxColumn
            // 
            this.custEmailDataGridViewTextBoxColumn.DataPropertyName = "custEmail";
            this.custEmailDataGridViewTextBoxColumn.HeaderText = "custEmail";
            this.custEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custEmailDataGridViewTextBoxColumn.Name = "custEmailDataGridViewTextBoxColumn";
            this.custEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.custEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // custPostalDataGridViewTextBoxColumn
            // 
            this.custPostalDataGridViewTextBoxColumn.DataPropertyName = "custPostal";
            this.custPostalDataGridViewTextBoxColumn.HeaderText = "custPostal";
            this.custPostalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custPostalDataGridViewTextBoxColumn.Name = "custPostalDataGridViewTextBoxColumn";
            this.custPostalDataGridViewTextBoxColumn.ReadOnly = true;
            this.custPostalDataGridViewTextBoxColumn.Width = 125;
            // 
            // custCityDataGridViewTextBoxColumn
            // 
            this.custCityDataGridViewTextBoxColumn.DataPropertyName = "custCity";
            this.custCityDataGridViewTextBoxColumn.HeaderText = "custCity";
            this.custCityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custCityDataGridViewTextBoxColumn.Name = "custCityDataGridViewTextBoxColumn";
            this.custCityDataGridViewTextBoxColumn.ReadOnly = true;
            this.custCityDataGridViewTextBoxColumn.Width = 125;
            // 
            // custAddressDataGridViewTextBoxColumn
            // 
            this.custAddressDataGridViewTextBoxColumn.DataPropertyName = "custAddress";
            this.custAddressDataGridViewTextBoxColumn.HeaderText = "custAddress";
            this.custAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custAddressDataGridViewTextBoxColumn.Name = "custAddressDataGridViewTextBoxColumn";
            this.custAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.custAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // custPhoneDataGridViewTextBoxColumn
            // 
            this.custPhoneDataGridViewTextBoxColumn.DataPropertyName = "custPhone";
            this.custPhoneDataGridViewTextBoxColumn.HeaderText = "custPhone";
            this.custPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custPhoneDataGridViewTextBoxColumn.Name = "custPhoneDataGridViewTextBoxColumn";
            this.custPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.custPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // custLastDataGridViewTextBoxColumn
            // 
            this.custLastDataGridViewTextBoxColumn.DataPropertyName = "custLast";
            this.custLastDataGridViewTextBoxColumn.HeaderText = "custLast";
            this.custLastDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custLastDataGridViewTextBoxColumn.Name = "custLastDataGridViewTextBoxColumn";
            this.custLastDataGridViewTextBoxColumn.ReadOnly = true;
            this.custLastDataGridViewTextBoxColumn.Width = 125;
            // 
            // custFirstDataGridViewTextBoxColumn
            // 
            this.custFirstDataGridViewTextBoxColumn.DataPropertyName = "custFirst";
            this.custFirstDataGridViewTextBoxColumn.HeaderText = "custFirst";
            this.custFirstDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custFirstDataGridViewTextBoxColumn.Name = "custFirstDataGridViewTextBoxColumn";
            this.custFirstDataGridViewTextBoxColumn.ReadOnly = true;
            this.custFirstDataGridViewTextBoxColumn.Width = 125;
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
            this.custEmailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(14, 118);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 589);
            this.dataGridView1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 91);
            this.button1.TabIndex = 18;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(138, 32);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(152, 20);
            this.textBox4.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 58);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 84);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Customer Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Customer City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Customer Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Customer First Name:";
            // 
            // CustomerHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 719);
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
            this.Load += new System.EventHandler(this.CustomerHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emmasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.BindingSource bindingSource1;
        private DataLibrary.EmmasDataSet emmasDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn custEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custLastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custFirstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
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
    }
}