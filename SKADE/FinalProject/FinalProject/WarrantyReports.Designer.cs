namespace FinalProject
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
            this.txtWarrantyStartDate = new System.Windows.Forms.TextBox();
            this.lblWarrantyEndDate = new System.Windows.Forms.Label();
            this.txtWarrantyEndDate = new System.Windows.Forms.TextBox();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.lblTitleWarrantyReportSearch = new System.Windows.Forms.Label();
            this.lblSpecificDay = new System.Windows.Forms.Label();
            this.txtSpecificDay = new System.Windows.Forms.TextBox();
            this.lblSpecificMonth = new System.Windows.Forms.Label();
            this.txtSpecificMonth = new System.Windows.Forms.TextBox();
            this.mncldrSpecifc_Full_Date = new System.Windows.Forms.MonthCalendar();
            this.lblSpecificYear = new System.Windows.Forms.Label();
            this.txtSpecificYear = new System.Windows.Forms.TextBox();
            this.lblSpecificFullDate = new System.Windows.Forms.Label();
            this.btnWarrantySearch = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serordWarrantyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.serordDateInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serordDateOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serordIssueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceorderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.emmasDataSet = new FinalProject.EmmasDataSet();
            this.serviceorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.service_orderTableAdapter = new FinalProject.EmmasDataSetTableAdapters.service_orderTableAdapter();
            this.btnEditWarrantyTable = new System.Windows.Forms.Button();
            this.btnClearTable = new System.Windows.Forms.Button();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.chbxSortByYear = new System.Windows.Forms.CheckBox();
            this.chbxSortByMonths = new System.Windows.Forms.CheckBox();
            this.chbxSortByDays = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceorderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emmasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceorderBindingSource)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWarrantyStartDate
            // 
            this.lblWarrantyStartDate.Location = new System.Drawing.Point(3, 77);
            this.lblWarrantyStartDate.Name = "lblWarrantyStartDate";
            this.lblWarrantyStartDate.Size = new System.Drawing.Size(105, 14);
            this.lblWarrantyStartDate.TabIndex = 0;
            this.lblWarrantyStartDate.Text = "Warranty Start Date:";
            // 
            // txtWarrantyStartDate
            // 
            this.txtWarrantyStartDate.Location = new System.Drawing.Point(114, 71);
            this.txtWarrantyStartDate.Name = "txtWarrantyStartDate";
            this.txtWarrantyStartDate.Size = new System.Drawing.Size(115, 20);
            this.txtWarrantyStartDate.TabIndex = 1;
            // 
            // lblWarrantyEndDate
            // 
            this.lblWarrantyEndDate.AutoSize = true;
            this.lblWarrantyEndDate.Location = new System.Drawing.Point(235, 74);
            this.lblWarrantyEndDate.Name = "lblWarrantyEndDate";
            this.lblWarrantyEndDate.Size = new System.Drawing.Size(101, 13);
            this.lblWarrantyEndDate.TabIndex = 2;
            this.lblWarrantyEndDate.Text = "Warranty End Date:";
            // 
            // txtWarrantyEndDate
            // 
            this.txtWarrantyEndDate.Location = new System.Drawing.Point(338, 71);
            this.txtWarrantyEndDate.Name = "txtWarrantyEndDate";
            this.txtWarrantyEndDate.Size = new System.Drawing.Size(109, 20);
            this.txtWarrantyEndDate.TabIndex = 3;
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.AutoGenerateColumns = false;
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.serordWarrantyDataGridViewCheckBoxColumn,
            this.serordDateInDataGridViewTextBoxColumn,
            this.serordDateOutDataGridViewTextBoxColumn,
            this.serordIssueDataGridViewTextBoxColumn});
            this.dgvSearchResults.DataSource = this.serviceorderBindingSource1;
            this.dgvSearchResults.Enabled = false;
            this.dgvSearchResults.Location = new System.Drawing.Point(2, 157);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.Size = new System.Drawing.Size(560, 363);
            this.dgvSearchResults.TabIndex = 4;
            // 
            // lblTitleWarrantyReportSearch
            // 
            this.lblTitleWarrantyReportSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleWarrantyReportSearch.Location = new System.Drawing.Point(248, 37);
            this.lblTitleWarrantyReportSearch.Name = "lblTitleWarrantyReportSearch";
            this.lblTitleWarrantyReportSearch.Size = new System.Drawing.Size(208, 31);
            this.lblTitleWarrantyReportSearch.TabIndex = 5;
            this.lblTitleWarrantyReportSearch.Text = "Warranty Report Search";
            // 
            // lblSpecificDay
            // 
            this.lblSpecificDay.Location = new System.Drawing.Point(3, 114);
            this.lblSpecificDay.Name = "lblSpecificDay";
            this.lblSpecificDay.Size = new System.Drawing.Size(72, 17);
            this.lblSpecificDay.TabIndex = 6;
            this.lblSpecificDay.Text = "Specific Day:";
            // 
            // txtSpecificDay
            // 
            this.txtSpecificDay.Location = new System.Drawing.Point(69, 111);
            this.txtSpecificDay.Name = "txtSpecificDay";
            this.txtSpecificDay.Size = new System.Drawing.Size(39, 20);
            this.txtSpecificDay.TabIndex = 7;
            // 
            // lblSpecificMonth
            // 
            this.lblSpecificMonth.AutoSize = true;
            this.lblSpecificMonth.Location = new System.Drawing.Point(111, 94);
            this.lblSpecificMonth.Name = "lblSpecificMonth";
            this.lblSpecificMonth.Size = new System.Drawing.Size(84, 13);
            this.lblSpecificMonth.TabIndex = 8;
            this.lblSpecificMonth.Text = "Specific Month: ";
            // 
            // txtSpecificMonth
            // 
            this.txtSpecificMonth.Location = new System.Drawing.Point(191, 91);
            this.txtSpecificMonth.Name = "txtSpecificMonth";
            this.txtSpecificMonth.Size = new System.Drawing.Size(100, 20);
            this.txtSpecificMonth.TabIndex = 9;
            this.txtSpecificMonth.TextChanged += new System.EventHandler(this.TxtSpecificMonth_TextChanged);
            // 
            // mncldrSpecifc_Full_Date
            // 
            this.mncldrSpecifc_Full_Date.Location = new System.Drawing.Point(576, 61);
            this.mncldrSpecifc_Full_Date.Name = "mncldrSpecifc_Full_Date";
            this.mncldrSpecifc_Full_Date.TabIndex = 10;
            // 
            // lblSpecificYear
            // 
            this.lblSpecificYear.Location = new System.Drawing.Point(261, 114);
            this.lblSpecificYear.Name = "lblSpecificYear";
            this.lblSpecificYear.Size = new System.Drawing.Size(75, 13);
            this.lblSpecificYear.TabIndex = 11;
            this.lblSpecificYear.Text = "Specific Year:";
            // 
            // txtSpecificYear
            // 
            this.txtSpecificYear.Location = new System.Drawing.Point(337, 111);
            this.txtSpecificYear.Name = "txtSpecificYear";
            this.txtSpecificYear.Size = new System.Drawing.Size(55, 20);
            this.txtSpecificYear.TabIndex = 12;
            // 
            // lblSpecificFullDate
            // 
            this.lblSpecificFullDate.AutoSize = true;
            this.lblSpecificFullDate.Location = new System.Drawing.Point(635, 32);
            this.lblSpecificFullDate.Name = "lblSpecificFullDate";
            this.lblSpecificFullDate.Size = new System.Drawing.Size(90, 13);
            this.lblSpecificFullDate.TabIndex = 16;
            this.lblSpecificFullDate.Text = "Specific Full Date";
            // 
            // btnWarrantySearch
            // 
            this.btnWarrantySearch.Location = new System.Drawing.Point(462, 32);
            this.btnWarrantySearch.Name = "btnWarrantySearch";
            this.btnWarrantySearch.Size = new System.Drawing.Size(100, 43);
            this.btnWarrantySearch.TabIndex = 17;
            this.btnWarrantySearch.Text = "Search";
            this.btnWarrantySearch.UseVisualStyleBackColor = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serordWarrantyDataGridViewCheckBoxColumn
            // 
            this.serordWarrantyDataGridViewCheckBoxColumn.DataPropertyName = "serordWarranty";
            this.serordWarrantyDataGridViewCheckBoxColumn.HeaderText = "serordWarranty";
            this.serordWarrantyDataGridViewCheckBoxColumn.Name = "serordWarrantyDataGridViewCheckBoxColumn";
            // 
            // serordDateInDataGridViewTextBoxColumn
            // 
            this.serordDateInDataGridViewTextBoxColumn.DataPropertyName = "serordDateIn";
            this.serordDateInDataGridViewTextBoxColumn.HeaderText = "serordDateIn";
            this.serordDateInDataGridViewTextBoxColumn.Name = "serordDateInDataGridViewTextBoxColumn";
            // 
            // serordDateOutDataGridViewTextBoxColumn
            // 
            this.serordDateOutDataGridViewTextBoxColumn.DataPropertyName = "serordDateOut";
            this.serordDateOutDataGridViewTextBoxColumn.HeaderText = "serordDateOut";
            this.serordDateOutDataGridViewTextBoxColumn.Name = "serordDateOutDataGridViewTextBoxColumn";
            // 
            // serordIssueDataGridViewTextBoxColumn
            // 
            this.serordIssueDataGridViewTextBoxColumn.DataPropertyName = "serordIssue";
            this.serordIssueDataGridViewTextBoxColumn.HeaderText = "serordIssue";
            this.serordIssueDataGridViewTextBoxColumn.Name = "serordIssueDataGridViewTextBoxColumn";
            // 
            // serviceorderBindingSource1
            // 
            this.serviceorderBindingSource1.DataMember = "service_order";
            this.serviceorderBindingSource1.DataSource = this.emmasDataSet;
            // 
            // emmasDataSet
            // 
            this.emmasDataSet.DataSetName = "EmmasDataSet";
            this.emmasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceorderBindingSource
            // 
            this.serviceorderBindingSource.DataMember = "service_order";
            this.serviceorderBindingSource.DataSource = this.emmasDataSet;
            // 
            // service_orderTableAdapter
            // 
            this.service_orderTableAdapter.ClearBeforeFill = true;
            // 
            // btnEditWarrantyTable
            // 
            this.btnEditWarrantyTable.Location = new System.Drawing.Point(576, 247);
            this.btnEditWarrantyTable.Name = "btnEditWarrantyTable";
            this.btnEditWarrantyTable.Size = new System.Drawing.Size(233, 92);
            this.btnEditWarrantyTable.TabIndex = 18;
            this.btnEditWarrantyTable.Text = "Edit";
            this.btnEditWarrantyTable.UseVisualStyleBackColor = true;
            // 
            // btnClearTable
            // 
            this.btnClearTable.Location = new System.Drawing.Point(576, 401);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(233, 97);
            this.btnClearTable.TabIndex = 19;
            this.btnClearTable.Text = "Clear";
            this.btnClearTable.UseVisualStyleBackColor = true;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(829, 25);
            this.fillBy1ToolStrip.TabIndex = 20;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(106, 22);
            this.toolStripLabel1.Text = "# of Search Results";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(90, 22);
            this.toolStripLabel2.Text = "Time of the Day";
            // 
            // chbxSortByYear
            // 
            this.chbxSortByYear.AutoSize = true;
            this.chbxSortByYear.Location = new System.Drawing.Point(303, 137);
            this.chbxSortByYear.Name = "chbxSortByYear";
            this.chbxSortByYear.Size = new System.Drawing.Size(89, 17);
            this.chbxSortByYear.TabIndex = 21;
            this.chbxSortByYear.Text = "Sort by Years";
            this.chbxSortByYear.UseVisualStyleBackColor = true;
            // 
            // chbxSortByMonths
            // 
            this.chbxSortByMonths.AutoSize = true;
            this.chbxSortByMonths.Location = new System.Drawing.Point(114, 135);
            this.chbxSortByMonths.Name = "chbxSortByMonths";
            this.chbxSortByMonths.Size = new System.Drawing.Size(98, 17);
            this.chbxSortByMonths.TabIndex = 22;
            this.chbxSortByMonths.Text = "Sort By Months";
            this.chbxSortByMonths.UseVisualStyleBackColor = true;
            // 
            // chbxSortByDays
            // 
            this.chbxSortByDays.AutoSize = true;
            this.chbxSortByDays.Location = new System.Drawing.Point(13, 134);
            this.chbxSortByDays.Name = "chbxSortByDays";
            this.chbxSortByDays.Size = new System.Drawing.Size(87, 17);
            this.chbxSortByDays.TabIndex = 23;
            this.chbxSortByDays.Text = "Sort By Days";
            this.chbxSortByDays.UseVisualStyleBackColor = true;
            // 
            // frmWarrantyReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 540);
            this.Controls.Add(this.chbxSortByDays);
            this.Controls.Add(this.chbxSortByMonths);
            this.Controls.Add(this.chbxSortByYear);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.btnClearTable);
            this.Controls.Add(this.btnEditWarrantyTable);
            this.Controls.Add(this.btnWarrantySearch);
            this.Controls.Add(this.lblSpecificFullDate);
            this.Controls.Add(this.txtSpecificYear);
            this.Controls.Add(this.lblSpecificYear);
            this.Controls.Add(this.mncldrSpecifc_Full_Date);
            this.Controls.Add(this.txtSpecificMonth);
            this.Controls.Add(this.lblSpecificMonth);
            this.Controls.Add(this.txtSpecificDay);
            this.Controls.Add(this.lblSpecificDay);
            this.Controls.Add(this.lblTitleWarrantyReportSearch);
            this.Controls.Add(this.dgvSearchResults);
            this.Controls.Add(this.txtWarrantyEndDate);
            this.Controls.Add(this.lblWarrantyEndDate);
            this.Controls.Add(this.txtWarrantyStartDate);
            this.Controls.Add(this.lblWarrantyStartDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWarrantyReports";
            this.Text = "frmWarrantyReports";
            this.Load += new System.EventHandler(this.FrmWarrantyReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceorderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emmasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceorderBindingSource)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarrantyStartDate;
        private System.Windows.Forms.TextBox txtWarrantyStartDate;
        private System.Windows.Forms.Label lblWarrantyEndDate;
        private System.Windows.Forms.TextBox txtWarrantyEndDate;
        private System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.Label lblTitleWarrantyReportSearch;
        private System.Windows.Forms.Label lblSpecificDay;
        private System.Windows.Forms.TextBox txtSpecificDay;
        private System.Windows.Forms.Label lblSpecificMonth;
        private System.Windows.Forms.TextBox txtSpecificMonth;
        private System.Windows.Forms.MonthCalendar mncldrSpecifc_Full_Date;
        private System.Windows.Forms.Label lblSpecificYear;
        private System.Windows.Forms.TextBox txtSpecificYear;
        private System.Windows.Forms.Label lblSpecificFullDate;
        private System.Windows.Forms.Button btnWarrantySearch;
        private EmmasDataSet emmasDataSet;
        private System.Windows.Forms.BindingSource serviceorderBindingSource;
        private EmmasDataSetTableAdapters.service_orderTableAdapter service_orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn serordWarrantyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serordDateInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serordDateOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serordIssueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource serviceorderBindingSource1;
        private System.Windows.Forms.Button btnEditWarrantyTable;
        private System.Windows.Forms.Button btnClearTable;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.CheckBox chbxSortByYear;
        private System.Windows.Forms.CheckBox chbxSortByMonths;
        private System.Windows.Forms.CheckBox chbxSortByDays;
    }
}