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
            this.lblWarrantyEndDate = new System.Windows.Forms.Label();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
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
            this.tslResultsandTimeTeller = new System.Windows.Forms.ToolStrip();
            this.tslTimeOfDay = new System.Windows.Forms.ToolStripLabel();
            this.tslNumberOfSearchResults = new System.Windows.Forms.ToolStripLabel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serordDateInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serordDateOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serordIssueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serordWarrantyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.serviceorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emmasDataSet = new FinalProject.EmmasDataSet();
            this.service_orderTableAdapter = new FinalProject.EmmasDataSetTableAdapters.service_orderTableAdapter();
            this.fill1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fill1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            this.panel1.SuspendLayout();
            this.tslResultsandTimeTeller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emmasDataSet)).BeginInit();
            this.fill1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWarrantyStartDate
            // 
            this.lblWarrantyStartDate.Location = new System.Drawing.Point(751, 73);
            this.lblWarrantyStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarrantyStartDate.Name = "lblWarrantyStartDate";
            this.lblWarrantyStartDate.Size = new System.Drawing.Size(140, 17);
            this.lblWarrantyStartDate.TabIndex = 0;
            this.lblWarrantyStartDate.Text = "Warranty Start Date:";
            // 
            // lblWarrantyEndDate
            // 
            this.lblWarrantyEndDate.AutoSize = true;
            this.lblWarrantyEndDate.Location = new System.Drawing.Point(747, 124);
            this.lblWarrantyEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarrantyEndDate.Name = "lblWarrantyEndDate";
            this.lblWarrantyEndDate.Size = new System.Drawing.Size(133, 17);
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
            this.idDataGridViewTextBoxColumn,
            this.serordDateInDataGridViewTextBoxColumn,
            this.serordDateOutDataGridViewTextBoxColumn,
            this.serordIssueDataGridViewTextBoxColumn,
            this.serordWarrantyDataGridViewCheckBoxColumn});
            this.dgvSearchResults.DataSource = this.serviceorderBindingSource;
            this.dgvSearchResults.Location = new System.Drawing.Point(0, 0);
            this.dgvSearchResults.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.ReadOnly = true;
            this.dgvSearchResults.RowHeadersWidth = 51;
            this.dgvSearchResults.Size = new System.Drawing.Size(745, 597);
            this.dgvSearchResults.TabIndex = 4;
            // 
            // lblTitleWarrantyReportSearch
            // 
            this.lblTitleWarrantyReportSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleWarrantyReportSearch.Location = new System.Drawing.Point(489, 25);
            this.lblTitleWarrantyReportSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleWarrantyReportSearch.Name = "lblTitleWarrantyReportSearch";
            this.lblTitleWarrantyReportSearch.Size = new System.Drawing.Size(245, 25);
            this.lblTitleWarrantyReportSearch.TabIndex = 5;
            this.lblTitleWarrantyReportSearch.Text = "Warranty Report Search";
            // 
            // lblSpecificDay
            // 
            this.lblSpecificDay.Location = new System.Drawing.Point(791, 178);
            this.lblSpecificDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecificDay.Name = "lblSpecificDay";
            this.lblSpecificDay.Size = new System.Drawing.Size(96, 21);
            this.lblSpecificDay.TabIndex = 6;
            this.lblSpecificDay.Text = "Specific Day:";
            // 
            // lblSpecificMonth
            // 
            this.lblSpecificMonth.AutoSize = true;
            this.lblSpecificMonth.Location = new System.Drawing.Point(775, 258);
            this.lblSpecificMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecificMonth.Name = "lblSpecificMonth";
            this.lblSpecificMonth.Size = new System.Drawing.Size(108, 17);
            this.lblSpecificMonth.TabIndex = 8;
            this.lblSpecificMonth.Text = "Specific Month: ";
            // 
            // lblSpecificYear
            // 
            this.lblSpecificYear.Location = new System.Drawing.Point(791, 340);
            this.lblSpecificYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecificYear.Name = "lblSpecificYear";
            this.lblSpecificYear.Size = new System.Drawing.Size(100, 16);
            this.lblSpecificYear.TabIndex = 11;
            this.lblSpecificYear.Text = "Specific Year:";
            // 
            // btnWarrantySearch
            // 
            this.btnWarrantySearch.Location = new System.Drawing.Point(745, 398);
            this.btnWarrantySearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnWarrantySearch.Name = "btnWarrantySearch";
            this.btnWarrantySearch.Size = new System.Drawing.Size(427, 124);
            this.btnWarrantySearch.TabIndex = 17;
            this.btnWarrantySearch.Text = "Search";
            this.btnWarrantySearch.UseVisualStyleBackColor = true;
            this.btnWarrantySearch.Click += new System.EventHandler(this.BtnWarrantySearch_Click);
            // 
            // btnClearTable
            // 
            this.btnClearTable.Location = new System.Drawing.Point(745, 533);
            this.btnClearTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(427, 129);
            this.btnClearTable.TabIndex = 19;
            this.btnClearTable.Text = "Clear";
            this.btnClearTable.UseVisualStyleBackColor = true;
            this.btnClearTable.Click += new System.EventHandler(this.BtnClearTable_Click);
            // 
            // chbxSortByYear
            // 
            this.chbxSortByYear.AutoSize = true;
            this.chbxSortByYear.Location = new System.Drawing.Point(795, 369);
            this.chbxSortByYear.Margin = new System.Windows.Forms.Padding(4);
            this.chbxSortByYear.Name = "chbxSortByYear";
            this.chbxSortByYear.Size = new System.Drawing.Size(116, 21);
            this.chbxSortByYear.TabIndex = 21;
            this.chbxSortByYear.Text = "Sort by Years";
            this.chbxSortByYear.UseVisualStyleBackColor = true;
            // 
            // chbxSortByMonths
            // 
            this.chbxSortByMonths.AutoSize = true;
            this.chbxSortByMonths.Location = new System.Drawing.Point(795, 288);
            this.chbxSortByMonths.Margin = new System.Windows.Forms.Padding(4);
            this.chbxSortByMonths.Name = "chbxSortByMonths";
            this.chbxSortByMonths.Size = new System.Drawing.Size(126, 21);
            this.chbxSortByMonths.TabIndex = 22;
            this.chbxSortByMonths.Text = "Sort By Months";
            this.chbxSortByMonths.UseVisualStyleBackColor = true;
            // 
            // chbxSortByDays
            // 
            this.chbxSortByDays.AutoSize = true;
            this.chbxSortByDays.Location = new System.Drawing.Point(795, 203);
            this.chbxSortByDays.Margin = new System.Windows.Forms.Padding(4);
            this.chbxSortByDays.Name = "chbxSortByDays";
            this.chbxSortByDays.Size = new System.Drawing.Size(112, 21);
            this.chbxSortByDays.TabIndex = 23;
            this.chbxSortByDays.Text = "Sort By Days";
            this.chbxSortByDays.UseVisualStyleBackColor = true;
            // 
            // cboSpecificDay
            // 
            this.cboSpecificDay.FormattingEnabled = true;
            this.cboSpecificDay.Location = new System.Drawing.Point(889, 175);
            this.cboSpecificDay.Margin = new System.Windows.Forms.Padding(4);
            this.cboSpecificDay.Name = "cboSpecificDay";
            this.cboSpecificDay.Size = new System.Drawing.Size(281, 24);
            this.cboSpecificDay.TabIndex = 25;
            // 
            // cboSpecificMonth
            // 
            this.cboSpecificMonth.FormattingEnabled = true;
            this.cboSpecificMonth.Location = new System.Drawing.Point(889, 255);
            this.cboSpecificMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cboSpecificMonth.Name = "cboSpecificMonth";
            this.cboSpecificMonth.Size = new System.Drawing.Size(281, 24);
            this.cboSpecificMonth.TabIndex = 26;
            // 
            // cboSpecificYear
            // 
            this.cboSpecificYear.FormattingEnabled = true;
            this.cboSpecificYear.Location = new System.Drawing.Point(889, 336);
            this.cboSpecificYear.Margin = new System.Windows.Forms.Padding(4);
            this.cboSpecificYear.Name = "cboSpecificYear";
            this.cboSpecificYear.Size = new System.Drawing.Size(281, 24);
            this.cboSpecificYear.TabIndex = 27;
            // 
            // dtpWarrantyEndDate
            // 
            this.dtpWarrantyEndDate.Location = new System.Drawing.Point(889, 117);
            this.dtpWarrantyEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpWarrantyEndDate.Name = "dtpWarrantyEndDate";
            this.dtpWarrantyEndDate.Size = new System.Drawing.Size(281, 22);
            this.dtpWarrantyEndDate.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSearchResults);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 617);
            this.panel1.TabIndex = 31;
            // 
            // dtpWarrantyStartDate
            // 
            this.dtpWarrantyStartDate.Location = new System.Drawing.Point(889, 65);
            this.dtpWarrantyStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpWarrantyStartDate.Name = "dtpWarrantyStartDate";
            this.dtpWarrantyStartDate.Size = new System.Drawing.Size(281, 22);
            this.dtpWarrantyStartDate.TabIndex = 32;
            // 
            // tslResultsandTimeTeller
            // 
            this.tslResultsandTimeTeller.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tslResultsandTimeTeller.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTimeOfDay,
            this.tslNumberOfSearchResults});
            this.tslResultsandTimeTeller.Location = new System.Drawing.Point(0, 0);
            this.tslResultsandTimeTeller.Name = "tslResultsandTimeTeller";
            this.tslResultsandTimeTeller.Size = new System.Drawing.Size(1174, 25);
            this.tslResultsandTimeTeller.TabIndex = 33;
            this.tslResultsandTimeTeller.Text = "tsl Results and Time Teller";
            // 
            // tslTimeOfDay
            // 
            this.tslTimeOfDay.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslTimeOfDay.Name = "tslTimeOfDay";
            this.tslTimeOfDay.Size = new System.Drawing.Size(92, 22);
            this.tslTimeOfDay.Text = "Time Of Day";
            // 
            // tslNumberOfSearchResults
            // 
            this.tslNumberOfSearchResults.Name = "tslNumberOfSearchResults";
            this.tslNumberOfSearchResults.Size = new System.Drawing.Size(136, 22);
            this.tslNumberOfSearchResults.Text = "# Of Search Results";
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
            // serordDateInDataGridViewTextBoxColumn
            // 
            this.serordDateInDataGridViewTextBoxColumn.DataPropertyName = "serordDateIn";
            this.serordDateInDataGridViewTextBoxColumn.HeaderText = "serordDateIn";
            this.serordDateInDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serordDateInDataGridViewTextBoxColumn.Name = "serordDateInDataGridViewTextBoxColumn";
            this.serordDateInDataGridViewTextBoxColumn.ReadOnly = true;
            this.serordDateInDataGridViewTextBoxColumn.Width = 125;
            // 
            // serordDateOutDataGridViewTextBoxColumn
            // 
            this.serordDateOutDataGridViewTextBoxColumn.DataPropertyName = "serordDateOut";
            this.serordDateOutDataGridViewTextBoxColumn.HeaderText = "serordDateOut";
            this.serordDateOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serordDateOutDataGridViewTextBoxColumn.Name = "serordDateOutDataGridViewTextBoxColumn";
            this.serordDateOutDataGridViewTextBoxColumn.ReadOnly = true;
            this.serordDateOutDataGridViewTextBoxColumn.Width = 125;
            // 
            // serordIssueDataGridViewTextBoxColumn
            // 
            this.serordIssueDataGridViewTextBoxColumn.DataPropertyName = "serordIssue";
            this.serordIssueDataGridViewTextBoxColumn.HeaderText = "serordIssue";
            this.serordIssueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serordIssueDataGridViewTextBoxColumn.Name = "serordIssueDataGridViewTextBoxColumn";
            this.serordIssueDataGridViewTextBoxColumn.ReadOnly = true;
            this.serordIssueDataGridViewTextBoxColumn.Width = 125;
            // 
            // serordWarrantyDataGridViewCheckBoxColumn
            // 
            this.serordWarrantyDataGridViewCheckBoxColumn.DataPropertyName = "serordWarranty";
            this.serordWarrantyDataGridViewCheckBoxColumn.HeaderText = "serordWarranty";
            this.serordWarrantyDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.serordWarrantyDataGridViewCheckBoxColumn.Name = "serordWarrantyDataGridViewCheckBoxColumn";
            this.serordWarrantyDataGridViewCheckBoxColumn.ReadOnly = true;
            this.serordWarrantyDataGridViewCheckBoxColumn.Width = 125;
            // 
            // serviceorderBindingSource
            // 
            this.serviceorderBindingSource.DataMember = "service_order";
            this.serviceorderBindingSource.DataSource = this.emmasDataSet;
            // 
            // emmasDataSet
            // 
            this.emmasDataSet.DataSetName = "EmmasDataSet";
            this.emmasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // service_orderTableAdapter
            // 
            this.service_orderTableAdapter.ClearBeforeFill = true;
            // 
            // fill1ToolStrip
            // 
            this.fill1ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fill1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fill1ToolStripButton});
            this.fill1ToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fill1ToolStrip.Name = "fill1ToolStrip";
            this.fill1ToolStrip.Size = new System.Drawing.Size(1174, 27);
            this.fill1ToolStrip.TabIndex = 34;
            this.fill1ToolStrip.Text = "fill1ToolStrip";
            // 
            // fill1ToolStripButton
            // 
            this.fill1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fill1ToolStripButton.Name = "fill1ToolStripButton";
            this.fill1ToolStripButton.Size = new System.Drawing.Size(40, 22);
            this.fill1ToolStripButton.Text = "Fill1";
            this.fill1ToolStripButton.Click += new System.EventHandler(this.fill1ToolStripButton_Click);
            // 
            // frmWarrantyReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 682);
            this.Controls.Add(this.fill1ToolStrip);
            this.Controls.Add(this.tslResultsandTimeTeller);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmWarrantyReports";
            this.Text = "frmWarrantyReports";
            this.Load += new System.EventHandler(this.FrmWarrantyReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tslResultsandTimeTeller.ResumeLayout(false);
            this.tslResultsandTimeTeller.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emmasDataSet)).EndInit();
            this.fill1ToolStrip.ResumeLayout(false);
            this.fill1ToolStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStrip tslResultsandTimeTeller;
        private System.Windows.Forms.ToolStripLabel tslTimeOfDay;
        private System.Windows.Forms.ToolStripLabel tslNumberOfSearchResults;
        private EmmasDataSet emmasDataSet;
        private System.Windows.Forms.BindingSource serviceorderBindingSource;
        private EmmasDataSetTableAdapters.service_orderTableAdapter service_orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serordDateInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serordDateOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serordIssueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn serordWarrantyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ToolStrip fill1ToolStrip;
        private System.Windows.Forms.ToolStripButton fill1ToolStripButton;
    }
}