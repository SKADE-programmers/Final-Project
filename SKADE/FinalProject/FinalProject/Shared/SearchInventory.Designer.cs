namespace FinalProject
{
    partial class SearchInventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inventoryDS1 = new DataLibrary.InventoryDS();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invMeasureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDS1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 53);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 33);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(811, 23);
            this.Search.Margin = new System.Windows.Forms.Padding(2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(148, 61);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.invQuantityDataGridViewTextBoxColumn,
            this.invSizeDataGridViewTextBoxColumn,
            this.invMeasureDataGridViewTextBoxColumn,
            this.invPriceDataGridViewTextBoxColumn,
            this.prodNameDataGridViewTextBoxColumn,
            this.prodDescriptionDataGridViewTextBoxColumn,
            this.prodBrandDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "InventorySearch";
            this.dataGridView1.DataSource = this.inventoryDS1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1106, 540);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // inventoryDS1
            // 
            this.inventoryDS1.DataSetName = "InventoryDS";
            this.inventoryDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Brand:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(219, 53);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 33);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(417, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Minimum Price:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(614, 11);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 33);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Maximum Price:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(614, 57);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(181, 29);
            this.textBox4.TabIndex = 11;
            this.textBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(975, 23);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 61);
            this.button3.TabIndex = 12;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(17, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 55);
            this.button1.TabIndex = 13;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 695);
            this.panel1.TabIndex = 14;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 21;
            // 
            // invQuantityDataGridViewTextBoxColumn
            // 
            this.invQuantityDataGridViewTextBoxColumn.DataPropertyName = "invQuantity";
            this.invQuantityDataGridViewTextBoxColumn.HeaderText = "invQuantity";
            this.invQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.invQuantityDataGridViewTextBoxColumn.Name = "invQuantityDataGridViewTextBoxColumn";
            this.invQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.invQuantityDataGridViewTextBoxColumn.Width = 85;
            // 
            // invSizeDataGridViewTextBoxColumn
            // 
            this.invSizeDataGridViewTextBoxColumn.DataPropertyName = "invSize";
            this.invSizeDataGridViewTextBoxColumn.HeaderText = "invSize";
            this.invSizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.invSizeDataGridViewTextBoxColumn.Name = "invSizeDataGridViewTextBoxColumn";
            this.invSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invMeasureDataGridViewTextBoxColumn
            // 
            this.invMeasureDataGridViewTextBoxColumn.DataPropertyName = "invMeasure";
            this.invMeasureDataGridViewTextBoxColumn.HeaderText = "invMeasure";
            this.invMeasureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.invMeasureDataGridViewTextBoxColumn.Name = "invMeasureDataGridViewTextBoxColumn";
            this.invMeasureDataGridViewTextBoxColumn.ReadOnly = true;
            this.invMeasureDataGridViewTextBoxColumn.Width = 87;
            // 
            // invPriceDataGridViewTextBoxColumn
            // 
            this.invPriceDataGridViewTextBoxColumn.DataPropertyName = "invPrice";
            this.invPriceDataGridViewTextBoxColumn.HeaderText = "invPrice";
            this.invPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.invPriceDataGridViewTextBoxColumn.Name = "invPriceDataGridViewTextBoxColumn";
            this.invPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.invPriceDataGridViewTextBoxColumn.Width = 120;
            // 
            // prodNameDataGridViewTextBoxColumn
            // 
            this.prodNameDataGridViewTextBoxColumn.DataPropertyName = "prodName";
            this.prodNameDataGridViewTextBoxColumn.HeaderText = "prodName";
            this.prodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodNameDataGridViewTextBoxColumn.Name = "prodNameDataGridViewTextBoxColumn";
            this.prodNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // prodDescriptionDataGridViewTextBoxColumn
            // 
            this.prodDescriptionDataGridViewTextBoxColumn.DataPropertyName = "prodDescription";
            this.prodDescriptionDataGridViewTextBoxColumn.HeaderText = "prodDescription";
            this.prodDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodDescriptionDataGridViewTextBoxColumn.Name = "prodDescriptionDataGridViewTextBoxColumn";
            this.prodDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodDescriptionDataGridViewTextBoxColumn.Width = 360;
            // 
            // prodBrandDataGridViewTextBoxColumn
            // 
            this.prodBrandDataGridViewTextBoxColumn.DataPropertyName = "prodBrand";
            this.prodBrandDataGridViewTextBoxColumn.HeaderText = "prodBrand";
            this.prodBrandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodBrandDataGridViewTextBoxColumn.Name = "prodBrandDataGridViewTextBoxColumn";
            this.prodBrandDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodBrandDataGridViewTextBoxColumn.Width = 152;
            // 
            // SearchInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1161, 719);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchInventory";
            this.Text = "InventoryMain";
            this.Load += new System.EventHandler(this.InventoryMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDS1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataLibrary.InventoryDS inventoryDS1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invMeasureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodBrandDataGridViewTextBoxColumn;
    }
}