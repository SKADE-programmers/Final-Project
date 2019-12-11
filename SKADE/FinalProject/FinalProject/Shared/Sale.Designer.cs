namespace FinalProject.Sales
{
    partial class Sale
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
            this.txtCustname = new System.Windows.Forms.TextBox();
            this.txtCustNumber = new System.Windows.Forms.TextBox();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.lblSearchPhone = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.salesDS1 = new DataLibrary.SalesDS();
            this.cBoxCustEquip = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBService = new System.Windows.Forms.RadioButton();
            this.radBPurchase = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cBoxPayment = new System.Windows.Forms.ComboBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.chkBoxWarranty = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btncmplt = new System.Windows.Forms.Button();
            this.btncncl = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnsrch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesDS1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustname
            // 
            this.txtCustname.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustname.Location = new System.Drawing.Point(47, 143);
            this.txtCustname.Name = "txtCustname";
            this.txtCustname.Size = new System.Drawing.Size(273, 42);
            this.txtCustname.TabIndex = 0;
            // 
            // txtCustNumber
            // 
            this.txtCustNumber.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustNumber.Location = new System.Drawing.Point(47, 297);
            this.txtCustNumber.Name = "txtCustNumber";
            this.txtCustNumber.Size = new System.Drawing.Size(273, 42);
            this.txtCustNumber.TabIndex = 0;
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.BackColor = System.Drawing.Color.White;
            this.lblSearchName.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblSearchName.Location = new System.Drawing.Point(41, 87);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(237, 35);
            this.lblSearchName.TabIndex = 7;
            this.lblSearchName.Text = "Search By Name:";
            // 
            // lblSearchPhone
            // 
            this.lblSearchPhone.AutoSize = true;
            this.lblSearchPhone.BackColor = System.Drawing.Color.White;
            this.lblSearchPhone.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPhone.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblSearchPhone.Location = new System.Drawing.Point(41, 236);
            this.lblSearchPhone.Name = "lblSearchPhone";
            this.lblSearchPhone.Size = new System.Drawing.Size(270, 35);
            this.lblSearchPhone.TabIndex = 7;
            this.lblSearchPhone.Text = "Search By Phone #:";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.salesDS1;
            this.listBox1.DisplayMember = "customerSimple.Customer Name";
            this.listBox1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 35;
            this.listBox1.Location = new System.Drawing.Point(47, 360);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(273, 39);
            this.listBox1.TabIndex = 2;
            this.listBox1.ValueMember = "customerSimple.id";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // salesDS1
            // 
            this.salesDS1.DataSetName = "SalesDS";
            this.salesDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cBoxCustEquip
            // 
            this.cBoxCustEquip.DataSource = this.salesDS1;
            this.cBoxCustEquip.DisplayMember = "equipment.Equipment Name";
            this.cBoxCustEquip.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxCustEquip.FormattingEnabled = true;
            this.cBoxCustEquip.Location = new System.Drawing.Point(41, 426);
            this.cBoxCustEquip.Name = "cBoxCustEquip";
            this.cBoxCustEquip.Size = new System.Drawing.Size(279, 43);
            this.cBoxCustEquip.TabIndex = 9;
            this.cBoxCustEquip.ValueMember = "equipment.id";
            this.cBoxCustEquip.Visible = false;
            this.cBoxCustEquip.SelectedIndexChanged += new System.EventHandler(this.cBoxCustEquip_SelectedIndexChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPrice.Location = new System.Drawing.Point(6, 35);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(81, 35);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(6, 72);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(58, 35);
            this.lblTax.TabIndex = 10;
            this.lblTax.Text = "Tax";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(6, 107);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 35);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total";
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 35;
            this.listBox2.Location = new System.Drawing.Point(422, 143);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(164, 179);
            this.listBox2.TabIndex = 11;
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 35;
            this.listBox3.Location = new System.Drawing.Point(670, 143);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(151, 179);
            this.listBox3.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.radBService);
            this.groupBox1.Controls.Add(this.radBPurchase);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(868, 453);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 132);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale Type";
            // 
            // radBService
            // 
            this.radBService.AutoSize = true;
            this.radBService.Location = new System.Drawing.Point(6, 82);
            this.radBService.Name = "radBService";
            this.radBService.Size = new System.Drawing.Size(131, 39);
            this.radBService.TabIndex = 0;
            this.radBService.TabStop = true;
            this.radBService.Text = "Service";
            this.radBService.UseVisualStyleBackColor = true;
            this.radBService.CheckedChanged += new System.EventHandler(this.radBService_CheckedChanged);
            // 
            // radBPurchase
            // 
            this.radBPurchase.AutoSize = true;
            this.radBPurchase.Location = new System.Drawing.Point(6, 39);
            this.radBPurchase.Name = "radBPurchase";
            this.radBPurchase.Size = new System.Drawing.Size(154, 39);
            this.radBPurchase.TabIndex = 0;
            this.radBPurchase.TabStop = true;
            this.radBPurchase.Text = "Purchase";
            this.radBPurchase.UseVisualStyleBackColor = true;
            this.radBPurchase.CheckedChanged += new System.EventHandler(this.radBPurchase_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.lblPrice);
            this.groupBox3.Controls.Add(this.lblTax);
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox3.Location = new System.Drawing.Point(870, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 159);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Costs";
            // 
            // cBoxPayment
            // 
            this.cBoxPayment.DataSource = this.salesDS1;
            this.cBoxPayment.DisplayMember = "equipment.Equipment Name";
            this.cBoxPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxPayment.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPayment.FormattingEnabled = true;
            this.cBoxPayment.Location = new System.Drawing.Point(712, 62);
            this.cBoxPayment.Name = "cBoxPayment";
            this.cBoxPayment.Size = new System.Drawing.Size(242, 43);
            this.cBoxPayment.TabIndex = 9;
            this.cBoxPayment.ValueMember = "equipment.id";
            this.cBoxPayment.Visible = false;
            this.cBoxPayment.SelectedIndexChanged += new System.EventHandler(this.cBoxCustEquip_SelectedIndexChanged);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblPayment.Location = new System.Drawing.Point(479, 65);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(231, 35);
            this.lblPayment.TabIndex = 7;
            this.lblPayment.Text = "Payment Method";
            // 
            // chkBoxWarranty
            // 
            this.chkBoxWarranty.AutoSize = true;
            this.chkBoxWarranty.BackColor = System.Drawing.Color.White;
            this.chkBoxWarranty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBoxWarranty.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxWarranty.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.chkBoxWarranty.Location = new System.Drawing.Point(804, 374);
            this.chkBoxWarranty.Name = "chkBoxWarranty";
            this.chkBoxWarranty.Size = new System.Drawing.Size(235, 39);
            this.chkBoxWarranty.TabIndex = 14;
            this.chkBoxWarranty.Text = "Under Warranty";
            this.chkBoxWarranty.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cBoxCustEquip);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSearchPhone);
            this.panel1.Controls.Add(this.txtCustNumber);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.lblSearchName);
            this.panel1.Controls.Add(this.btncmplt);
            this.panel1.Controls.Add(this.cBoxPayment);
            this.panel1.Controls.Add(this.btncncl);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnsrch);
            this.panel1.Controls.Add(this.chkBoxWarranty);
            this.panel1.Controls.Add(this.lblPayment);
            this.panel1.Controls.Add(this.listBox3);
            this.panel1.Controls.Add(this.txtCustname);
            this.panel1.Location = new System.Drawing.Point(38, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 643);
            this.panel1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(591, 203);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 38);
            this.button2.TabIndex = 36;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(591, 250);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 38);
            this.button1.TabIndex = 35;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btncmplt
            // 
            this.btncmplt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btncmplt.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncmplt.ForeColor = System.Drawing.Color.White;
            this.btncmplt.Location = new System.Drawing.Point(562, 544);
            this.btncmplt.Margin = new System.Windows.Forms.Padding(2);
            this.btncmplt.Name = "btncmplt";
            this.btncmplt.Size = new System.Drawing.Size(148, 38);
            this.btncmplt.TabIndex = 34;
            this.btncmplt.Text = "Complete";
            this.btncmplt.UseVisualStyleBackColor = false;
            // 
            // btncncl
            // 
            this.btncncl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btncncl.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncncl.ForeColor = System.Drawing.Color.White;
            this.btncncl.Location = new System.Drawing.Point(562, 488);
            this.btncncl.Margin = new System.Windows.Forms.Padding(2);
            this.btncncl.Name = "btncncl";
            this.btncncl.Size = new System.Drawing.Size(148, 38);
            this.btncncl.TabIndex = 33;
            this.btncncl.Text = "Cancel";
            this.btncncl.UseVisualStyleBackColor = false;
            this.btncncl.Click += new System.EventHandler(this.Btncncl_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNew.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(562, 374);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(148, 38);
            this.btnNew.TabIndex = 32;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnsrch
            // 
            this.btnsrch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnsrch.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrch.ForeColor = System.Drawing.Color.White;
            this.btnsrch.Location = new System.Drawing.Point(562, 431);
            this.btnsrch.Margin = new System.Windows.Forms.Padding(2);
            this.btnsrch.Name = "btnsrch";
            this.btnsrch.Size = new System.Drawing.Size(148, 38);
            this.btnsrch.TabIndex = 31;
            this.btnsrch.Text = "Search";
            this.btnsrch.UseVisualStyleBackColor = false;
            this.btnsrch.Click += new System.EventHandler(this.Btnsrch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 36);
            this.label1.TabIndex = 37;
            this.label1.Text = "Create Sales";
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1161, 719);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.salesDS1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustname;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtCustNumber;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.Label lblSearchPhone;
        private System.Windows.Forms.ComboBox cBoxCustEquip;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBService;
        private System.Windows.Forms.RadioButton radBPurchase;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cBoxPayment;
        private System.Windows.Forms.Label lblPayment;
        private DataLibrary.SalesDS salesDS1;
        private System.Windows.Forms.CheckBox chkBoxWarranty;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncmplt;
        private System.Windows.Forms.Button btncncl;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnsrch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}