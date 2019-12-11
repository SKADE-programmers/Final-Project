namespace FinalProject
{
    partial class InventoryOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxProductOrderNum = new System.Windows.Forms.TextBox();
            this.checkBoxPaid = new System.Windows.Forms.CheckBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.inventoryDS1 = new DataLibrary.InventoryDS();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDS1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBoxProductOrderNum);
            this.panel1.Controls.Add(this.checkBoxPaid);
            this.panel1.Controls.Add(this.dtpOrderDate);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.Create);
            this.panel1.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(-13, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 658);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(133, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 35);
            this.label3.TabIndex = 38;
            this.label3.Text = "Order Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(133, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 35);
            this.label2.TabIndex = 38;
            this.label2.Text = "Order Number";
            // 
            // txtBoxProductOrderNum
            // 
            this.txtBoxProductOrderNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxProductOrderNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxProductOrderNum.Location = new System.Drawing.Point(347, 137);
            this.txtBoxProductOrderNum.Name = "txtBoxProductOrderNum";
            this.txtBoxProductOrderNum.Size = new System.Drawing.Size(455, 33);
            this.txtBoxProductOrderNum.TabIndex = 37;
            // 
            // checkBoxPaid
            // 
            this.checkBoxPaid.AutoSize = true;
            this.checkBoxPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxPaid.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPaid.ForeColor = System.Drawing.Color.SteelBlue;
            this.checkBoxPaid.Location = new System.Drawing.Point(139, 340);
            this.checkBoxPaid.Name = "checkBoxPaid";
            this.checkBoxPaid.Size = new System.Drawing.Size(57, 29);
            this.checkBoxPaid.TabIndex = 35;
            this.checkBoxPaid.Text = "Paid";
            this.checkBoxPaid.UseVisualStyleBackColor = true;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.CalendarForeColor = System.Drawing.Color.CornflowerBlue;
            this.dtpOrderDate.CalendarMonthBackground = System.Drawing.Color.LightBlue;
            this.dtpOrderDate.CalendarTitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dtpOrderDate.CalendarTitleForeColor = System.Drawing.Color.SteelBlue;
            this.dtpOrderDate.CalendarTrailingForeColor = System.Drawing.Color.SteelBlue;
            this.dtpOrderDate.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrderDate.Location = new System.Drawing.Point(347, 250);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(298, 42);
            this.dtpOrderDate.TabIndex = 33;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancel.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(144, 406);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(192, 54);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Create.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.Create.ForeColor = System.Drawing.Color.White;
            this.Create.Location = new System.Drawing.Point(393, 406);
            this.Create.Margin = new System.Windows.Forms.Padding(2);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(197, 55);
            this.Create.TabIndex = 29;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // inventoryDS1
            // 
            this.inventoryDS1.DataSetName = "InventoryDS";
            this.inventoryDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Place Order\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Location = new System.Drawing.Point(347, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 2);
            this.panel2.TabIndex = 39;
            // 
            // InventoryOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1150, 719);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryOrder";
            this.Text = "InventoryOrder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDS1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.CheckBox checkBoxPaid;
        private System.Windows.Forms.TextBox txtBoxProductOrderNum;
        private DataLibrary.InventoryDS inventoryDS1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}