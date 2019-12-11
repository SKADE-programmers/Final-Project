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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblStartDateForWeeklyReports = new System.Windows.Forms.Label();
            this.dtpStartDateForWeeklyReports = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordPaidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.adminDS1 = new DataLibrary.AdminDS();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDS1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1014, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 63);
            this.button2.TabIndex = 26;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F);
            this.dateTimePicker1.Location = new System.Drawing.Point(586, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(423, 40);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F);
            this.label1.Location = new System.Drawing.Point(199, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 33);
            this.label1.TabIndex = 24;
            this.label1.Text = "End Date For Weekly Reports:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(14, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 63);
            this.button3.TabIndex = 23;
            this.button3.Text = "Return";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // lblStartDateForWeeklyReports
            // 
            this.lblStartDateForWeeklyReports.AutoSize = true;
            this.lblStartDateForWeeklyReports.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F);
            this.lblStartDateForWeeklyReports.Location = new System.Drawing.Point(198, 26);
            this.lblStartDateForWeeklyReports.Name = "lblStartDateForWeeklyReports";
            this.lblStartDateForWeeklyReports.Size = new System.Drawing.Size(374, 33);
            this.lblStartDateForWeeklyReports.TabIndex = 22;
            this.lblStartDateForWeeklyReports.Text = "Start Date For Weekly Report:";
            // 
            // dtpStartDateForWeeklyReports
            // 
            this.dtpStartDateForWeeklyReports.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F);
            this.dtpStartDateForWeeklyReports.Location = new System.Drawing.Point(586, 20);
            this.dtpStartDateForWeeklyReports.Name = "dtpStartDateForWeeklyReports";
            this.dtpStartDateForWeeklyReports.Size = new System.Drawing.Size(422, 40);
            this.dtpStartDateForWeeklyReports.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1014, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 63);
            this.button1.TabIndex = 20;
            this.button1.Text = "Number of Sales";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(14, 154);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 657);
            this.dataGridView1.TabIndex = 19;
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
            // adminDS1
            // 
            this.adminDS1.DataSetName = "AdminDS";
            this.adminDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.lblStartDateForWeeklyReports);
            this.panel1.Controls.Add(this.dtpStartDateForWeeklyReports);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 701);
            this.panel1.TabIndex = 27;
            // 
            // WeeklyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1227, 725);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeeklyReport";
            this.Text = "WeeklyReport";
            this.Load += new System.EventHandler(this.WeeklyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDS1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
    }
}