namespace FinalProject
{
    partial class InventoryCount
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblBrandText = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblMeasureText = new System.Windows.Forms.Label();
            this.lblMeasure = new System.Windows.Forms.Label();
            this.lblDescText = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblNameText = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lBoxType = new System.Windows.Forms.ListBox();
            this.inventoryDS = new DataLibrary.InventoryDS();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblHiddenID = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDS)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(47, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 32);
            this.label2.TabIndex = 81;
            this.label2.Text = "Inventory Count";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblHiddenID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtCount);
            this.panel2.Controls.Add(this.lblBrandText);
            this.panel2.Controls.Add(this.lblBrand);
            this.panel2.Controls.Add(this.lblMeasureText);
            this.panel2.Controls.Add(this.lblMeasure);
            this.panel2.Controls.Add(this.lblDescText);
            this.panel2.Controls.Add(this.lblDesc);
            this.panel2.Controls.Add(this.lblNameText);
            this.panel2.Controls.Add(this.lblCount);
            this.panel2.Controls.Add(this.lblItemName);
            this.panel2.Controls.Add(this.lBoxType);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Location = new System.Drawing.Point(-37, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1217, 673);
            this.panel2.TabIndex = 95;
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtCount.Location = new System.Drawing.Point(592, 360);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(222, 38);
            this.txtCount.TabIndex = 100;
            // 
            // lblBrandText
            // 
            this.lblBrandText.AutoSize = true;
            this.lblBrandText.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandText.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblBrandText.Location = new System.Drawing.Point(595, 106);
            this.lblBrandText.Name = "lblBrandText";
            this.lblBrandText.Size = new System.Drawing.Size(88, 33);
            this.lblBrandText.TabIndex = 99;
            this.lblBrandText.Text = "Brand";
            this.lblBrandText.Click += new System.EventHandler(this.LblBrandText_Click);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBrand.Location = new System.Drawing.Point(495, 106);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(94, 33);
            this.lblBrand.TabIndex = 99;
            this.lblBrand.Text = "Brand:";
            // 
            // lblMeasureText
            // 
            this.lblMeasureText.AutoSize = true;
            this.lblMeasureText.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeasureText.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMeasureText.Location = new System.Drawing.Point(624, 229);
            this.lblMeasureText.Name = "lblMeasureText";
            this.lblMeasureText.Size = new System.Drawing.Size(119, 33);
            this.lblMeasureText.TabIndex = 99;
            this.lblMeasureText.Text = "Measure";
            // 
            // lblMeasure
            // 
            this.lblMeasure.AutoSize = true;
            this.lblMeasure.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeasure.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMeasure.Location = new System.Drawing.Point(494, 229);
            this.lblMeasure.Name = "lblMeasure";
            this.lblMeasure.Size = new System.Drawing.Size(124, 33);
            this.lblMeasure.TabIndex = 99;
            this.lblMeasure.Text = "Measure:";
            // 
            // lblDescText
            // 
            this.lblDescText.AutoSize = true;
            this.lblDescText.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescText.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDescText.Location = new System.Drawing.Point(660, 293);
            this.lblDescText.Name = "lblDescText";
            this.lblDescText.Size = new System.Drawing.Size(154, 33);
            this.lblDescText.TabIndex = 99;
            this.lblDescText.Text = "Description";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDesc.Location = new System.Drawing.Point(494, 293);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(160, 33);
            this.lblDesc.TabIndex = 99;
            this.lblDesc.Text = "Description:";
            // 
            // lblNameText
            // 
            this.lblNameText.AutoSize = true;
            this.lblNameText.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameText.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNameText.Location = new System.Drawing.Point(590, 166);
            this.lblNameText.Name = "lblNameText";
            this.lblNameText.Size = new System.Drawing.Size(85, 33);
            this.lblNameText.TabIndex = 99;
            this.lblNameText.Text = "Name";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCount.Location = new System.Drawing.Point(494, 365);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(92, 33);
            this.lblCount.TabIndex = 99;
            this.lblCount.Text = "Count:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblItemName.Location = new System.Drawing.Point(494, 166);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(90, 33);
            this.lblItemName.TabIndex = 99;
            this.lblItemName.Text = "Name:";
            // 
            // lBoxType
            // 
            this.lBoxType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.inventoryDS, "InventorySearch.id", true));
            this.lBoxType.DataSource = this.inventoryDS;
            this.lBoxType.DisplayMember = "InventorySearch.prodName";
            this.lBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lBoxType.FormattingEnabled = true;
            this.lBoxType.ItemHeight = 31;
            this.lBoxType.Location = new System.Drawing.Point(94, 91);
            this.lBoxType.Name = "lBoxType";
            this.lBoxType.Size = new System.Drawing.Size(303, 469);
            this.lBoxType.TabIndex = 98;
            this.lBoxType.ValueMember = "InventorySearch.id";
            this.lBoxType.SelectedIndexChanged += new System.EventHandler(this.lBoxType_SelectedIndexChanged);
            // 
            // inventoryDS
            // 
            this.inventoryDS.DataSetName = "InventoryDS";
            this.inventoryDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(500, 429);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 51);
            this.btnUpdate.TabIndex = 97;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(94, 577);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(137, 51);
            this.btnSubmit.TabIndex = 93;
            this.btnSubmit.Text = "Return";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblHiddenID
            // 
            this.lblHiddenID.AutoSize = true;
            this.lblHiddenID.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiddenID.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblHiddenID.Location = new System.Drawing.Point(1005, 25);
            this.lblHiddenID.Name = "lblHiddenID";
            this.lblHiddenID.Size = new System.Drawing.Size(88, 33);
            this.lblHiddenID.TabIndex = 101;
            this.lblHiddenID.Text = "Brand";
            this.lblHiddenID.Visible = false;
            // 
            // InventoryCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1161, 719);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryCount";
            this.Text = "InventoryCount";
            this.Load += new System.EventHandler(this.InventoryCount_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lBoxType;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblMeasure;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblBrandText;
        private System.Windows.Forms.Label lblMeasureText;
        private System.Windows.Forms.Label lblDescText;
        private System.Windows.Forms.Label lblNameText;
        private System.Windows.Forms.TextBox txtCount;
        private DataLibrary.InventoryDS inventoryDS;
        private System.Windows.Forms.Label lblHiddenID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}