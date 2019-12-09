namespace FinalProject
{
    partial class WarrantyReports
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
            this.adminDS1 = new DataLibrary.AdminDS();
            this.serviceorderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.button1 = new System.Windows.Forms.Button();
            this.dtpWarrantyStartDate = new System.Windows.Forms.DateTimePicker();
            this.emmasDataSet = new DataLibrary.EmmasDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceorderBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emmasDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWarrantyStartDate
            // 
            this.lblWarrantyStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarrantyStartDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblWarrantyStartDate.Location = new System.Drawing.Point(23, 13);
            this.lblWarrantyStartDate.Name = "lblWarrantyStartDate";
            this.lblWarrantyStartDate.Size = new System.Drawing.Size(74, 24);
            this.lblWarrantyStartDate.TabIndex = 0;
            this.lblWarrantyStartDate.Text = "Warranty Start Date:";
            // 
            // lblWarrantyEndDate
            // 
            this.lblWarrantyEndDate.AutoSize = true;
            this.lblWarrantyEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarrantyEndDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblWarrantyEndDate.Location = new System.Drawing.Point(23, 81);
            this.lblWarrantyEndDate.Name = "lblWarrantyEndDate";
            this.lblWarrantyEndDate.Size = new System.Drawing.Size(149, 20);
            this.lblWarrantyEndDate.TabIndex = 2;
            this.lblWarrantyEndDate.Text = "Warranty End Date:";
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.AllowUserToAddRows = false;
            this.dgvSearchResults.AllowUserToDeleteRows = false;
            this.dgvSearchResults.AutoGenerateColumns = false;
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.DataSource = this.adminDS1;
            this.dgvSearchResults.Location = new System.Drawing.Point(3, 0);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.ReadOnly = true;
            this.dgvSearchResults.RowHeadersWidth = 51;
            this.dgvSearchResults.Size = new System.Drawing.Size(379, 491);
            this.dgvSearchResults.TabIndex = 4;
            // 
            // adminDS1
            // 
            this.adminDS1.DataSetName = "AdminDS";
            this.adminDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceorderBindingSource1
            // 
            this.serviceorderBindingSource1.DataMember = "service_order";
            // 
            // lblTitleWarrantyReportSearch
            // 
            this.lblTitleWarrantyReportSearch.BackColor = System.Drawing.Color.White;
            this.lblTitleWarrantyReportSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleWarrantyReportSearch.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTitleWarrantyReportSearch.Location = new System.Drawing.Point(3, 6);
            this.lblTitleWarrantyReportSearch.Name = "lblTitleWarrantyReportSearch";
            this.lblTitleWarrantyReportSearch.Size = new System.Drawing.Size(112, 54);
            this.lblTitleWarrantyReportSearch.TabIndex = 5;
            this.lblTitleWarrantyReportSearch.Text = "Warranty \r\nReport";
            // 
            // lblSpecificDay
            // 
            this.lblSpecificDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecificDay.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblSpecificDay.Location = new System.Drawing.Point(23, 148);
            this.lblSpecificDay.Name = "lblSpecificDay";
            this.lblSpecificDay.Size = new System.Drawing.Size(113, 27);
            this.lblSpecificDay.TabIndex = 6;
            this.lblSpecificDay.Text = "Specific Day:";
            // 
            // lblSpecificMonth
            // 
            this.lblSpecificMonth.AutoSize = true;
            this.lblSpecificMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecificMonth.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblSpecificMonth.Location = new System.Drawing.Point(23, 223);
            this.lblSpecificMonth.Name = "lblSpecificMonth";
            this.lblSpecificMonth.Size = new System.Drawing.Size(122, 20);
            this.lblSpecificMonth.TabIndex = 8;
            this.lblSpecificMonth.Text = "Specific Month: ";
            // 
            // lblSpecificYear
            // 
            this.lblSpecificYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecificYear.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblSpecificYear.Location = new System.Drawing.Point(23, 287);
            this.lblSpecificYear.Name = "lblSpecificYear";
            this.lblSpecificYear.Size = new System.Drawing.Size(118, 23);
            this.lblSpecificYear.TabIndex = 11;
            this.lblSpecificYear.Text = "Specific Year:";
            // 
            // btnWarrantySearch
            // 
            this.btnWarrantySearch.Location = new System.Drawing.Point(145, 439);
            this.btnWarrantySearch.Name = "btnWarrantySearch";
            this.btnWarrantySearch.Size = new System.Drawing.Size(22, 49);
            this.btnWarrantySearch.TabIndex = 17;
            this.btnWarrantySearch.Text = "Search";
            this.btnWarrantySearch.UseVisualStyleBackColor = true;
            this.btnWarrantySearch.Click += new System.EventHandler(this.BtnWarrantySearch_Click);
            // 
            // btnClearTable
            // 
            this.btnClearTable.Location = new System.Drawing.Point(181, 430);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(22, 48);
            this.btnClearTable.TabIndex = 19;
            this.btnClearTable.Text = "Clear";
            this.btnClearTable.UseVisualStyleBackColor = true;
            this.btnClearTable.Click += new System.EventHandler(this.BtnClearTable_Click);
            // 
            // chbxSortByYear
            // 
            this.chbxSortByYear.AutoSize = true;
            this.chbxSortByYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxSortByYear.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.chbxSortByYear.Location = new System.Drawing.Point(21, 417);
            this.chbxSortByYear.Name = "chbxSortByYear";
            this.chbxSortByYear.Size = new System.Drawing.Size(124, 24);
            this.chbxSortByYear.TabIndex = 21;
            this.chbxSortByYear.Text = "Sort by Years";
            this.chbxSortByYear.UseVisualStyleBackColor = true;
            // 
            // chbxSortByMonths
            // 
            this.chbxSortByMonths.AutoSize = true;
            this.chbxSortByMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxSortByMonths.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.chbxSortByMonths.Location = new System.Drawing.Point(21, 380);
            this.chbxSortByMonths.Name = "chbxSortByMonths";
            this.chbxSortByMonths.Size = new System.Drawing.Size(137, 24);
            this.chbxSortByMonths.TabIndex = 22;
            this.chbxSortByMonths.Text = "Sort By Months";
            this.chbxSortByMonths.UseVisualStyleBackColor = true;
            // 
            // chbxSortByDays
            // 
            this.chbxSortByDays.AutoSize = true;
            this.chbxSortByDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxSortByDays.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.chbxSortByDays.Location = new System.Drawing.Point(21, 343);
            this.chbxSortByDays.Name = "chbxSortByDays";
            this.chbxSortByDays.Size = new System.Drawing.Size(120, 24);
            this.chbxSortByDays.TabIndex = 23;
            this.chbxSortByDays.Text = "Sort By Days";
            this.chbxSortByDays.UseVisualStyleBackColor = true;
            // 
            // cboSpecificDay
            // 
            this.cboSpecificDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSpecificDay.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSpecificDay.ForeColor = System.Drawing.Color.SteelBlue;
            this.cboSpecificDay.FormattingEnabled = true;
            this.cboSpecificDay.Location = new System.Drawing.Point(28, 185);
            this.cboSpecificDay.Name = "cboSpecificDay";
            this.cboSpecificDay.Size = new System.Drawing.Size(229, 24);
            this.cboSpecificDay.TabIndex = 25;
            // 
            // cboSpecificMonth
            // 
            this.cboSpecificMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSpecificMonth.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSpecificMonth.ForeColor = System.Drawing.Color.SteelBlue;
            this.cboSpecificMonth.FormattingEnabled = true;
            this.cboSpecificMonth.Location = new System.Drawing.Point(28, 253);
            this.cboSpecificMonth.Name = "cboSpecificMonth";
            this.cboSpecificMonth.Size = new System.Drawing.Size(229, 24);
            this.cboSpecificMonth.TabIndex = 26;
            // 
            // cboSpecificYear
            // 
            this.cboSpecificYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSpecificYear.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSpecificYear.ForeColor = System.Drawing.Color.SteelBlue;
            this.cboSpecificYear.FormattingEnabled = true;
            this.cboSpecificYear.Location = new System.Drawing.Point(26, 313);
            this.cboSpecificYear.Name = "cboSpecificYear";
            this.cboSpecificYear.Size = new System.Drawing.Size(229, 24);
            this.cboSpecificYear.TabIndex = 27;
            // 
            // dtpWarrantyEndDate
            // 
            this.dtpWarrantyEndDate.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWarrantyEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWarrantyEndDate.Location = new System.Drawing.Point(28, 111);
            this.dtpWarrantyEndDate.Name = "dtpWarrantyEndDate";
            this.dtpWarrantyEndDate.Size = new System.Drawing.Size(212, 23);
            this.dtpWarrantyEndDate.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClearTable);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dgvSearchResults);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(950, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 725);
            this.panel1.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(114, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 35);
            this.button1.TabIndex = 99;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dtpWarrantyStartDate
            // 
            this.dtpWarrantyStartDate.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWarrantyStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWarrantyStartDate.Location = new System.Drawing.Point(29, 40);
            this.dtpWarrantyStartDate.Name = "dtpWarrantyStartDate";
            this.dtpWarrantyStartDate.Size = new System.Drawing.Size(212, 23);
            this.dtpWarrantyStartDate.TabIndex = 32;
            // 
            // emmasDataSet
            // 
            this.emmasDataSet.DataSetName = "EmmasDataSet";
            this.emmasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 73);
            this.panel2.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.cboSpecificYear);
            this.panel3.Controls.Add(this.btnWarrantySearch);
            this.panel3.Controls.Add(this.chbxSortByYear);
            this.panel3.Controls.Add(this.dtpWarrantyEndDate);
            this.panel3.Controls.Add(this.cboSpecificMonth);
            this.panel3.Controls.Add(this.chbxSortByMonths);
            this.panel3.Controls.Add(this.lblSpecificYear);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.cboSpecificDay);
            this.panel3.Controls.Add(this.chbxSortByDays);
            this.panel3.Controls.Add(this.dtpWarrantyStartDate);
            this.panel3.Controls.Add(this.lblSpecificMonth);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.lblWarrantyStartDate);
            this.panel3.Controls.Add(this.lblWarrantyEndDate);
            this.panel3.Controls.Add(this.lblSpecificDay);
            this.panel3.Location = new System.Drawing.Point(93, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1345, 725);
            this.panel3.TabIndex = 34;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Navy;
            this.panel8.Location = new System.Drawing.Point(26, 336);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(225, 1);
            this.panel8.TabIndex = 102;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Navy;
            this.panel7.Location = new System.Drawing.Point(29, 276);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(225, 1);
            this.panel7.TabIndex = 101;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Navy;
            this.panel6.Location = new System.Drawing.Point(28, 208);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(225, 1);
            this.panel6.TabIndex = 99;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Location = new System.Drawing.Point(28, 133);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(225, 1);
            this.panel5.TabIndex = 100;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Location = new System.Drawing.Point(32, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 1);
            this.panel4.TabIndex = 99;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(88, 453);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 35);
            this.button5.TabIndex = 98;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // WarrantyReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1450, 800);
            this.Controls.Add(this.lblTitleWarrantyReportSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarrantyReports";
            this.Text = "frmWarrantyReports";
            this.Load += new System.EventHandler(this.FrmWarrantyReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceorderBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emmasDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

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

        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serordDateInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serordDateOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serordIssueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn serordWarrantyDataGridViewCheckBoxColumn;
      //  private EmmasDataSetTableAdapters.service_orderTableAdapter service_orderTableAdapter;
        private System.Windows.Forms.BindingSource serviceorderBindingSource1;
     //   private EmmasDataSet emmasDataSet;
        private DataLibrary.AdminDS adminDS1;
        private DataLibrary.EmmasDataSet emmasDataSet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}