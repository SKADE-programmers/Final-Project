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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radBDebit = new System.Windows.Forms.RadioButton();
            this.radBAmericanExpress = new System.Windows.Forms.RadioButton();
            this.radBMastercard = new System.Windows.Forms.RadioButton();
            this.radBVisa = new System.Windows.Forms.RadioButton();
            this.radBcash = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDS1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustname
            // 
            this.txtCustname.Location = new System.Drawing.Point(31, 43);
            this.txtCustname.Name = "txtCustname";
            this.txtCustname.Size = new System.Drawing.Size(156, 20);
            this.txtCustname.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtCustNumber
            // 
            this.txtCustNumber.Location = new System.Drawing.Point(31, 81);
            this.txtCustNumber.Name = "txtCustNumber";
            this.txtCustNumber.Size = new System.Drawing.Size(156, 20);
            this.txtCustNumber.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(31, 107);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radBDebit);
            this.groupBox2.Controls.Add(this.radBAmericanExpress);
            this.groupBox2.Controls.Add(this.radBMastercard);
            this.groupBox2.Controls.Add(this.radBVisa);
            this.groupBox2.Controls.Add(this.radBcash);
            this.groupBox2.Location = new System.Drawing.Point(660, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 139);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Method";
            // 
            // radBDebit
            // 
            this.radBDebit.AutoSize = true;
            this.radBDebit.Location = new System.Drawing.Point(7, 112);
            this.radBDebit.Name = "radBDebit";
            this.radBDebit.Size = new System.Drawing.Size(50, 17);
            this.radBDebit.TabIndex = 0;
            this.radBDebit.TabStop = true;
            this.radBDebit.Text = "Debit";
            this.radBDebit.UseVisualStyleBackColor = true;
            // 
            // radBAmericanExpress
            // 
            this.radBAmericanExpress.AutoSize = true;
            this.radBAmericanExpress.Location = new System.Drawing.Point(7, 89);
            this.radBAmericanExpress.Name = "radBAmericanExpress";
            this.radBAmericanExpress.Size = new System.Drawing.Size(109, 17);
            this.radBAmericanExpress.TabIndex = 0;
            this.radBAmericanExpress.TabStop = true;
            this.radBAmericanExpress.Text = "American Express";
            this.radBAmericanExpress.UseVisualStyleBackColor = true;
            // 
            // radBMastercard
            // 
            this.radBMastercard.AutoSize = true;
            this.radBMastercard.Location = new System.Drawing.Point(6, 66);
            this.radBMastercard.Name = "radBMastercard";
            this.radBMastercard.Size = new System.Drawing.Size(78, 17);
            this.radBMastercard.TabIndex = 0;
            this.radBMastercard.TabStop = true;
            this.radBMastercard.Text = "Mastercard";
            this.radBMastercard.UseVisualStyleBackColor = true;
            // 
            // radBVisa
            // 
            this.radBVisa.AutoSize = true;
            this.radBVisa.Location = new System.Drawing.Point(6, 43);
            this.radBVisa.Name = "radBVisa";
            this.radBVisa.Size = new System.Drawing.Size(45, 17);
            this.radBVisa.TabIndex = 0;
            this.radBVisa.TabStop = true;
            this.radBVisa.Text = "Visa";
            this.radBVisa.UseVisualStyleBackColor = true;
            // 
            // radBcash
            // 
            this.radBcash.AutoSize = true;
            this.radBcash.Location = new System.Drawing.Point(7, 20);
            this.radBcash.Name = "radBcash";
            this.radBcash.Size = new System.Drawing.Size(49, 17);
            this.radBcash.TabIndex = 0;
            this.radBcash.TabStop = true;
            this.radBcash.Text = "Cash";
            this.radBcash.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(667, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(31, 24);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(90, 13);
            this.lblSearchName.TabIndex = 7;
            this.lblSearchName.Text = "Search By Name:";
            // 
            // lblSearchPhone
            // 
            this.lblSearchPhone.AutoSize = true;
            this.lblSearchPhone.Location = new System.Drawing.Point(31, 65);
            this.lblSearchPhone.Name = "lblSearchPhone";
            this.lblSearchPhone.Size = new System.Drawing.Size(108, 13);
            this.lblSearchPhone.TabIndex = 7;
            this.lblSearchPhone.Text = "Search By Phones #:";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.salesDS1;
            this.listBox1.DisplayMember = "customerSimple.Customer Name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(31, 136);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 95);
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
            this.cBoxCustEquip.FormattingEnabled = true;
            this.cBoxCustEquip.Location = new System.Drawing.Point(31, 310);
            this.cBoxCustEquip.Name = "cBoxCustEquip";
            this.cBoxCustEquip.Size = new System.Drawing.Size(156, 21);
            this.cBoxCustEquip.TabIndex = 9;
            this.cBoxCustEquip.ValueMember = "equipment.id";
            this.cBoxCustEquip.SelectedIndexChanged += new System.EventHandler(this.cBoxCustEquip_SelectedIndexChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 21);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(6, 46);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 10;
            this.lblTax.Text = "Tax";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 70);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total";
            // 
            // listBox2
            // 
            this.listBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesDS1, "service.id", true));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(217, 81);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(104, 160);
            this.listBox2.TabIndex = 11;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(352, 81);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(104, 160);
            this.listBox3.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(217, 247);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Service";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(352, 251);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(104, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove Service";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(31, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 59);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale Type";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Purchase";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(83, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Service";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.lblPrice);
            this.groupBox3.Controls.Add(this.lblTax);
            this.groupBox3.Location = new System.Drawing.Point(660, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 163);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Costs";
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.cBoxCustEquip);
            this.Controls.Add(this.lblSearchPhone);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCustNumber);
            this.Controls.Add(this.txtCustname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sale";
            this.Text = "Sale";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDS1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtCustNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radBVisa;
        private System.Windows.Forms.RadioButton radBcash;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.Label lblSearchPhone;
        private System.Windows.Forms.ComboBox cBoxCustEquip;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.RadioButton radBDebit;
        private System.Windows.Forms.RadioButton radBAmericanExpress;
        private System.Windows.Forms.RadioButton radBMastercard;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private DataLibrary.SalesDS salesDS1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}