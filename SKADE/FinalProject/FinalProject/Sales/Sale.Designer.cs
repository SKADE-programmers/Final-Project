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
            this.button1 = new System.Windows.Forms.Button();
            this.txtCustNumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.lblSearchPhone = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cBoxCustEquip = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBService = new System.Windows.Forms.RadioButton();
            this.radBPurchase = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cBoxPayment = new System.Windows.Forms.ComboBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.salesDS1 = new DataLibrary.SalesDS();
            this.chkBoxWarranty = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDS1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustname
            // 
            this.txtCustname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtCustname.Location = new System.Drawing.Point(52, 232);
            this.txtCustname.Name = "txtCustname";
            this.txtCustname.Size = new System.Drawing.Size(273, 40);
            this.txtCustname.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(364, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtCustNumber
            // 
            this.txtCustNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtCustNumber.Location = new System.Drawing.Point(52, 323);
            this.txtCustNumber.Name = "txtCustNumber";
            this.txtCustNumber.Size = new System.Drawing.Size(273, 40);
            this.txtCustNumber.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(364, 230);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 43);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(1251, 681);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(164, 45);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Complete";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblSearchName.Location = new System.Drawing.Point(67, 196);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(258, 33);
            this.lblSearchName.TabIndex = 7;
            this.lblSearchName.Text = "Search By Name:";
            // 
            // lblSearchPhone
            // 
            this.lblSearchPhone.AutoSize = true;
            this.lblSearchPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblSearchPhone.Location = new System.Drawing.Point(46, 278);
            this.lblSearchPhone.Name = "lblSearchPhone";
            this.lblSearchPhone.Size = new System.Drawing.Size(290, 33);
            this.lblSearchPhone.TabIndex = 7;
            this.lblSearchPhone.Text = "Search By Phone #:";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.salesDS1;
            this.listBox1.DisplayMember = "customerSimple.Customer Name";
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 33;
            this.listBox1.Location = new System.Drawing.Point(52, 388);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(273, 70);
            this.listBox1.TabIndex = 2;
            this.listBox1.ValueMember = "customerSimple.id";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cBoxCustEquip
            // 
            this.cBoxCustEquip.DataSource = this.salesDS1;
            this.cBoxCustEquip.DisplayMember = "equipment.Equipment Name";
            this.cBoxCustEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.cBoxCustEquip.FormattingEnabled = true;
            this.cBoxCustEquip.Location = new System.Drawing.Point(46, 496);
            this.cBoxCustEquip.Name = "cBoxCustEquip";
            this.cBoxCustEquip.Size = new System.Drawing.Size(279, 41);
            this.cBoxCustEquip.TabIndex = 9;
            this.cBoxCustEquip.ValueMember = "equipment.id";
            this.cBoxCustEquip.Visible = false;
            this.cBoxCustEquip.SelectedIndexChanged += new System.EventHandler(this.cBoxCustEquip_SelectedIndexChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(6, 35);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(87, 33);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblTax.Location = new System.Drawing.Point(6, 74);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(67, 33);
            this.lblTax.TabIndex = 10;
            this.lblTax.Text = "Tax";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(6, 107);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(85, 33);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total";
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 33;
            this.listBox2.Location = new System.Drawing.Point(534, 205);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(219, 235);
            this.listBox2.TabIndex = 11;
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 33;
            this.listBox3.Location = new System.Drawing.Point(890, 205);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(253, 235);
            this.listBox3.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(757, 255);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 51);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnRemove.Location = new System.Drawing.Point(757, 312);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(129, 51);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBService);
            this.groupBox1.Controls.Add(this.radBPurchase);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(348, 388);
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
            this.radBService.Size = new System.Drawing.Size(138, 37);
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
            this.radBPurchase.Size = new System.Drawing.Size(164, 37);
            this.radBPurchase.TabIndex = 0;
            this.radBPurchase.TabStop = true;
            this.radBPurchase.Text = "Purchase";
            this.radBPurchase.UseVisualStyleBackColor = true;
            this.radBPurchase.CheckedChanged += new System.EventHandler(this.radBPurchase_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.lblPrice);
            this.groupBox3.Controls.Add(this.lblTax);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(1173, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(156, 163);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Costs";
            // 
            // cBoxPayment
            // 
            this.cBoxPayment.DataSource = this.salesDS1;
            this.cBoxPayment.DisplayMember = "equipment.Equipment Name";
            this.cBoxPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.cBoxPayment.FormattingEnabled = true;
            this.cBoxPayment.Location = new System.Drawing.Point(1173, 514);
            this.cBoxPayment.Name = "cBoxPayment";
            this.cBoxPayment.Size = new System.Drawing.Size(242, 41);
            this.cBoxPayment.TabIndex = 9;
            this.cBoxPayment.ValueMember = "equipment.id";
            this.cBoxPayment.Visible = false;
            this.cBoxPayment.SelectedIndexChanged += new System.EventHandler(this.cBoxCustEquip_SelectedIndexChanged);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblPayment.Location = new System.Drawing.Point(1167, 448);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(248, 33);
            this.lblPayment.TabIndex = 7;
            this.lblPayment.Text = "Payment Method";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(46, 681);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 45);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // salesDS1
            // 
            this.salesDS1.DataSetName = "SalesDS";
            this.salesDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkBoxWarranty
            // 
            this.chkBoxWarranty.AutoSize = true;
            this.chkBoxWarranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.chkBoxWarranty.Location = new System.Drawing.Point(890, 448);
            this.chkBoxWarranty.Name = "chkBoxWarranty";
            this.chkBoxWarranty.Size = new System.Drawing.Size(253, 37);
            this.chkBoxWarranty.TabIndex = 14;
            this.chkBoxWarranty.Text = "Under Warranty";
            this.chkBoxWarranty.UseVisualStyleBackColor = true;
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 800);
            this.Controls.Add(this.chkBoxWarranty);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.cBoxPayment);
            this.Controls.Add(this.cBoxCustEquip);
            this.Controls.Add(this.lblSearchPhone);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCustNumber);
            this.Controls.Add(this.txtCustname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDS1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtCustNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.Label lblSearchPhone;
        private System.Windows.Forms.ComboBox cBoxCustEquip;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
       // private DataLibrary.SalesDS salesDS1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBService;
        private System.Windows.Forms.RadioButton radBPurchase;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cBoxPayment;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Button btnCancel;
        private DataLibrary.SalesDS salesDS1;
        private System.Windows.Forms.CheckBox chkBoxWarranty;
    }
}