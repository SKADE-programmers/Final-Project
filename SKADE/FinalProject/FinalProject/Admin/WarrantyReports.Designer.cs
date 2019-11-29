﻿namespace FinalProject
{
    partial class frmWarrantyReports
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
            this.lblWarrantyStartDate = new System.Windows.Forms.Label();
            this.lblWarrantyEndDate = new System.Windows.Forms.Label();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.serviceorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTitleWarrantyReportSearch = new System.Windows.Forms.Label();
            this.lblSpecificDay = new System.Windows.Forms.Label();
            this.lblSpecificMonth = new System.Windows.Forms.Label();
            this.lblSpecificYear = new System.Windows.Forms.Label();
            this.btnWarrantySearch = new System.Windows.Forms.Button();
            this.btnClearTable = new System.Windows.Forms.Button();
            this.chbxSortByYear = new System.Windows.Forms.CheckBox();
            this.chbxSortByMonths = new System.Windows.Forms.CheckBox();
            this.chbxSortByDays = new System.Windows.Forms.CheckBox();
            this.cboSpecificDay = new System.Windows.Forms.ComboBox();
            this.cboSpecificMonth = new System.Windows.Forms.ComboBox();
            this.cboSpecificYear = new System.Windows.Forms.ComboBox();
            this.dtpWarrantyEndDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpWarrantyStartDate = new System.Windows.Forms.DateTimePicker();
            this.emmasWSReportDataSet1 = new DataLibrary.EmmasDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceorderBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emmasWSReportDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWarrantyStartDate
            // 
            this.lblWarrantyStartDate.Location = new System.Drawing.Point(563, 59);
            this.lblWarrantyStartDate.Name = "lblWarrantyStartDate";
            this.lblWarrantyStartDate.Size = new System.Drawing.Size(105, 14);
            this.lblWarrantyStartDate.TabIndex = 0;
            this.lblWarrantyStartDate.Text = "Warranty Start Date:";
            // 
            // lblWarrantyEndDate
            // 
            this.lblWarrantyEndDate.AutoSize = true;
            this.lblWarrantyEndDate.Location = new System.Drawing.Point(560, 101);
            this.lblWarrantyEndDate.Name = "lblWarrantyEndDate";
            this.lblWarrantyEndDate.Size = new System.Drawing.Size(101, 13);
            this.lblWarrantyEndDate.TabIndex = 2;
            this.lblWarrantyEndDate.Text = "Warranty End Date:";
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.AllowUserToAddRows = false;
            this.dgvSearchResults.AllowUserToDeleteRows = false;
            this.dgvSearchResults.AutoGenerateColumns = false;
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.dgvSearchResults.DataSource = this.serviceorderBindingSource;
            this.dgvSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSearchResults.Location = new System.Drawing.Point(0, 0);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.ReadOnly = true;
            this.dgvSearchResults.Size = new System.Drawing.Size(559, 485);
            this.dgvSearchResults.TabIndex = 4;
            // 
            // serviceorderBindingSource
            // 
            this.serviceorderBindingSource.DataMember = "service_order";
            this.serviceorderBindingSource.DataSource = this.emmasWSReportDataSet1;
            // 
            // lblTitleWarrantyReportSearch
            // 
            this.lblTitleWarrantyReportSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleWarrantyReportSearch.Location = new System.Drawing.Point(287, 25);
            this.lblTitleWarrantyReportSearch.Name = "lblTitleWarrantyReportSearch";
            this.lblTitleWarrantyReportSearch.Size = new System.Drawing.Size(208, 31);
            this.lblTitleWarrantyReportSearch.TabIndex = 5;
            this.lblTitleWarrantyReportSearch.Text = "Warranty Report Search";
            // 
            // lblSpecificDay
            // 
            this.lblSpecificDay.Location = new System.Drawing.Point(593, 145);
            this.lblSpecificDay.Name = "lblSpecificDay";
            this.lblSpecificDay.Size = new System.Drawing.Size(72, 17);
            this.lblSpecificDay.TabIndex = 6;
            this.lblSpecificDay.Text = "Specific Day:";
            // 
            // lblSpecificMonth
            // 
            this.lblSpecificMonth.AutoSize = true;
            this.lblSpecificMonth.Location = new System.Drawing.Point(581, 210);
            this.lblSpecificMonth.Name = "lblSpecificMonth";
            this.lblSpecificMonth.Size = new System.Drawing.Size(84, 13);
            this.lblSpecificMonth.TabIndex = 8;
            this.lblSpecificMonth.Text = "Specific Month: ";
            // 
            // lblSpecificYear
            // 
            this.lblSpecificYear.Location = new System.Drawing.Point(593, 276);
            this.lblSpecificYear.Name = "lblSpecificYear";
            this.lblSpecificYear.Size = new System.Drawing.Size(75, 13);
            this.lblSpecificYear.TabIndex = 11;
            this.lblSpecificYear.Text = "Specific Year:";
            // 
            // btnWarrantySearch
            // 
            this.btnWarrantySearch.Location = new System.Drawing.Point(559, 323);
            this.btnWarrantySearch.Name = "btnWarrantySearch";
            this.btnWarrantySearch.Size = new System.Drawing.Size(320, 101);
            this.btnWarrantySearch.TabIndex = 17;
            this.btnWarrantySearch.Text = "Search";
            this.btnWarrantySearch.UseVisualStyleBackColor = true;
            this.btnWarrantySearch.Click += new System.EventHandler(this.BtnWarrantySearch_Click);
            // 
            // btnClearTable
            // 
            this.btnClearTable.Location = new System.Drawing.Point(559, 433);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(320, 105);
            this.btnClearTable.TabIndex = 19;
            this.btnClearTable.Text = "Clear";
            this.btnClearTable.UseVisualStyleBackColor = true;
            this.btnClearTable.Click += new System.EventHandler(this.BtnClearTable_Click);
            // 
            // chbxSortByYear
            // 
            this.chbxSortByYear.AutoSize = true;
            this.chbxSortByYear.Location = new System.Drawing.Point(596, 300);
            this.chbxSortByYear.Name = "chbxSortByYear";
            this.chbxSortByYear.Size = new System.Drawing.Size(89, 17);
            this.chbxSortByYear.TabIndex = 21;
            this.chbxSortByYear.Text = "Sort by Years";
            this.chbxSortByYear.UseVisualStyleBackColor = true;
            // 
            // chbxSortByMonths
            // 
            this.chbxSortByMonths.AutoSize = true;
            this.chbxSortByMonths.Location = new System.Drawing.Point(596, 234);
            this.chbxSortByMonths.Name = "chbxSortByMonths";
            this.chbxSortByMonths.Size = new System.Drawing.Size(98, 17);
            this.chbxSortByMonths.TabIndex = 22;
            this.chbxSortByMonths.Text = "Sort By Months";
            this.chbxSortByMonths.UseVisualStyleBackColor = true;
            // 
            // chbxSortByDays
            // 
            this.chbxSortByDays.AutoSize = true;
            this.chbxSortByDays.Location = new System.Drawing.Point(596, 165);
            this.chbxSortByDays.Name = "chbxSortByDays";
            this.chbxSortByDays.Size = new System.Drawing.Size(87, 17);
            this.chbxSortByDays.TabIndex = 23;
            this.chbxSortByDays.Text = "Sort By Days";
            this.chbxSortByDays.UseVisualStyleBackColor = true;
            // 
            // cboSpecificDay
            // 
            this.cboSpecificDay.FormattingEnabled = true;
            this.cboSpecificDay.Location = new System.Drawing.Point(667, 142);
            this.cboSpecificDay.Name = "cboSpecificDay";
            this.cboSpecificDay.Size = new System.Drawing.Size(212, 21);
            this.cboSpecificDay.TabIndex = 25;
            // 
            // cboSpecificMonth
            // 
            this.cboSpecificMonth.FormattingEnabled = true;
            this.cboSpecificMonth.Location = new System.Drawing.Point(667, 207);
            this.cboSpecificMonth.Name = "cboSpecificMonth";
            this.cboSpecificMonth.Size = new System.Drawing.Size(212, 21);
            this.cboSpecificMonth.TabIndex = 26;
            // 
            // cboSpecificYear
            // 
            this.cboSpecificYear.FormattingEnabled = true;
            this.cboSpecificYear.Location = new System.Drawing.Point(667, 273);
            this.cboSpecificYear.Name = "cboSpecificYear";
            this.cboSpecificYear.Size = new System.Drawing.Size(212, 21);
            this.cboSpecificYear.TabIndex = 27;
            // 
            // dtpWarrantyEndDate
            // 
            this.dtpWarrantyEndDate.Location = new System.Drawing.Point(667, 95);
            this.dtpWarrantyEndDate.Name = "dtpWarrantyEndDate";
            this.dtpWarrantyEndDate.Size = new System.Drawing.Size(212, 20);
            this.dtpWarrantyEndDate.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSearchResults);
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 485);
            this.panel1.TabIndex = 31;
            // 
            // dtpWarrantyStartDate
            // 
            this.dtpWarrantyStartDate.Location = new System.Drawing.Point(667, 53);
            this.dtpWarrantyStartDate.Name = "dtpWarrantyStartDate";
            this.dtpWarrantyStartDate.Size = new System.Drawing.Size(212, 20);
            this.dtpWarrantyStartDate.TabIndex = 32;
            // 
            // emmasWSReportDataSet1
            // 
            this.emmasWSReportDataSet1.DataSetName = "emmasWSReportDataSet1";
            this.emmasWSReportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "serordDateIn";
            this.dataGridViewTextBoxColumn2.HeaderText = "serordDateIn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "serordDateOut";
            this.dataGridViewTextBoxColumn3.HeaderText = "serordDateOut";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "serordIssue";
            this.dataGridViewTextBoxColumn4.HeaderText = "serordIssue";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "serordWarranty";
            this.dataGridViewCheckBoxColumn1.HeaderText = "serordWarranty";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // frmWarrantyReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 540);
            this.Controls.Add(this.dtpWarrantyStartDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpWarrantyEndDate);
            this.Controls.Add(this.cboSpecificYear);
            this.Controls.Add(this.cboSpecificMonth);
            this.Controls.Add(this.cboSpecificDay);
            this.Controls.Add(this.chbxSortByDays);
            this.Controls.Add(this.chbxSortByMonths);
            this.Controls.Add(this.chbxSortByYear);
            this.Controls.Add(this.btnClearTable);
            this.Controls.Add(this.btnWarrantySearch);
            this.Controls.Add(this.lblSpecificYear);
            this.Controls.Add(this.lblSpecificMonth);
            this.Controls.Add(this.lblSpecificDay);
            this.Controls.Add(this.lblTitleWarrantyReportSearch);
            this.Controls.Add(this.lblWarrantyEndDate);
            this.Controls.Add(this.lblWarrantyStartDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWarrantyReports";
            this.Text = "frmWarrantyReports";
            this.Load += new System.EventHandler(this.FrmWarrantyReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceorderBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emmasWSReportDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarrantyStartDate;
        private System.Windows.Forms.Label lblWarrantyEndDate;
        private System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.Label lblTitleWarrantyReportSearch;
        private System.Windows.Forms.Label lblSpecificDay;
        private System.Windows.Forms.Label lblSpecificMonth;
        private System.Windows.Forms.Label lblSpecificYear;
        private System.Windows.Forms.Button btnWarrantySearch;
        private System.Windows.Forms.Button btnClearTable;
        private System.Windows.Forms.CheckBox chbxSortByYear;
        private System.Windows.Forms.CheckBox chbxSortByMonths;
        private System.Windows.Forms.CheckBox chbxSortByDays;
        private System.Windows.Forms.ComboBox cboSpecificDay;
        private System.Windows.Forms.ComboBox cboSpecificMonth;
        private System.Windows.Forms.ComboBox cboSpecificYear;
        private System.Windows.Forms.DateTimePicker dtpWarrantyEndDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpWarrantyStartDate;
        //private EmmasWSReportDataSet1 emmasWSReportDataSet1;
        private System.Windows.Forms.BindingSource serviceorderBindingSource;
       // private EmmasWSReportDataSet1TableAdapters.service_orderTableAdapter service_orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serordDateInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serordDateOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serordIssueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn serordWarrantyDataGridViewCheckBoxColumn;
        private DataLibrary.EmmasDataSet emmasWSReportDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}