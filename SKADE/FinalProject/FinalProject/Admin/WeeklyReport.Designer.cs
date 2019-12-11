namespace FinalProject
{
    partial class WeeklyReport
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
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblStartDateForWeeklyReports = new System.Windows.Forms.Label();
            this.dtpStartDateForWeeklyReports = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adminDS1 = new DataLibrary.AdminDS();
            this.ordNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordPaidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDS1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(464, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 104);
            this.button2.TabIndex = 26;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "End Date For Weekly Reports:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1361, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 67);
            this.button3.TabIndex = 23;
            this.button3.Text = "Return to Admin Main";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // lblStartDateForWeeklyReports
            // 
            this.lblStartDateForWeeklyReports.AutoSize = true;
            this.lblStartDateForWeeklyReports.Location = new System.Drawing.Point(18, 16);
            this.lblStartDateForWeeklyReports.Name = "lblStartDateForWeeklyReports";
            this.lblStartDateForWeeklyReports.Size = new System.Drawing.Size(150, 13);
            this.lblStartDateForWeeklyReports.TabIndex = 22;
            this.lblStartDateForWeeklyReports.Text = "Start Date For Weekly Report:";
            // 
            // dtpStartDateForWeeklyReports
            // 
            this.dtpStartDateForWeeklyReports.Location = new System.Drawing.Point(174, 10);
            this.dtpStartDateForWeeklyReports.Name = "dtpStartDateForWeeklyReports";
            this.dtpStartDateForWeeklyReports.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDateForWeeklyReports.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 112);
            this.button1.TabIndex = 20;
            this.button1.Text = "Number of Reports For The Week";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordNumberDataGridViewTextBoxColumn,
            this.ordDateDataGridViewTextBoxColumn,
            this.paymentIDDataGridViewTextBoxColumn,
            this.custIDDataGridViewTextBoxColumn,
            this.empIDDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn,
            this.paymentTypeDataGridViewTextBoxColumn,
            this.ordPaidDataGridViewCheckBoxColumn});
            this.dataGridView1.DataMember = "WeeklySalesReport";
            this.dataGridView1.DataSource = this.adminDS1;
            this.dataGridView1.Location = new System.Drawing.Point(4, 146);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1426, 611);
            this.dataGridView1.TabIndex = 19;
            // 
            // adminDS1
            // 
            this.adminDS1.DataSetName = "AdminDS";
            this.adminDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // paymentIDDataGridViewTextBoxColumn
            // 
            this.paymentIDDataGridViewTextBoxColumn.DataPropertyName = "paymentID";
            this.paymentIDDataGridViewTextBoxColumn.HeaderText = "paymentID";
            this.paymentIDDataGridViewTextBoxColumn.Name = "paymentIDDataGridViewTextBoxColumn";
            this.paymentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "custID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "custID";
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            this.custIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "empID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "empID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentTypeDataGridViewTextBoxColumn
            // 
            this.paymentTypeDataGridViewTextBoxColumn.DataPropertyName = "Payment Type";
            this.paymentTypeDataGridViewTextBoxColumn.HeaderText = "Payment Type";
            this.paymentTypeDataGridViewTextBoxColumn.Name = "paymentTypeDataGridViewTextBoxColumn";
            this.paymentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordPaidDataGridViewCheckBoxColumn
            // 
            this.ordPaidDataGridViewCheckBoxColumn.DataPropertyName = "ordPaid";
            this.ordPaidDataGridViewCheckBoxColumn.HeaderText = "ordPaid";
            this.ordPaidDataGridViewCheckBoxColumn.Name = "ordPaidDataGridViewCheckBoxColumn";
            this.ordPaidDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // WeeklyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 761);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblStartDateForWeeklyReports);
            this.Controls.Add(this.dtpStartDateForWeeklyReports);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WeeklyReport";
            this.Text = "WeeklyReport";
            this.Load += new System.EventHandler(this.WeeklyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDS1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblStartDateForWeeklyReports;
        private System.Windows.Forms.DateTimePicker dtpStartDateForWeeklyReports;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ordPaidDataGridViewCheckBoxColumn;
        private DataLibrary.AdminDS adminDS1;
    }
}