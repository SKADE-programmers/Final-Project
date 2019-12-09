namespace FinalProject
{
    partial class InventoryMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryMain));
            this.btnCount = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.panek = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRequest = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRequests = new System.Windows.Forms.Button();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCount
            // 
            this.btnCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.ForeColor = System.Drawing.Color.LightCyan;
            this.btnCount.Location = new System.Drawing.Point(0, 275);
            this.btnCount.Name = "btnCount";
            this.btnCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCount.Size = new System.Drawing.Size(290, 46);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "Inventory Count";
            this.btnCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.LightCyan;
            this.btnPlaceOrder.Location = new System.Drawing.Point(0, 229);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(290, 46);
            this.btnPlaceOrder.TabIndex = 1;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // panek
            // 
            this.panek.BackColor = System.Drawing.Color.DimGray;
            this.panek.Controls.Add(this.panel1);
            this.panek.Dock = System.Windows.Forms.DockStyle.Top;
            this.panek.Enabled = false;
            this.panek.Location = new System.Drawing.Point(0, 0);
            this.panek.Name = "panek";
            this.panek.Size = new System.Drawing.Size(290, 186);
            this.panek.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(289, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 597);
            this.panel1.TabIndex = 3;
            // 
            // btnRequest
            // 
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.ForeColor = System.Drawing.Color.LightCyan;
            this.btnRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRequest.Location = new System.Drawing.Point(0, 183);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(290, 46);
            this.btnRequest.TabIndex = 0;
            this.btnRequest.Text = "Requests";
            this.btnRequest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(289, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1161, 719);
            this.panel2.TabIndex = 11;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(3, 706);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 36);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(9, 329);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(33, 28);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 1;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(9, 239);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnRequests
            // 
            this.btnRequests.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequests.ForeColor = System.Drawing.Color.Black;
            this.btnRequests.Location = new System.Drawing.Point(1272, 86);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Size = new System.Drawing.Size(142, 113);
            this.btnRequests.TabIndex = 10;
            this.btnRequests.Text = "No Requests";
            this.btnRequests.UseVisualStyleBackColor = false;
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.DimGray;
            this.panelSideBar.Controls.Add(this.lblDate);
            this.panelSideBar.Controls.Add(this.pictureBox8);
            this.panelSideBar.Controls.Add(this.pictureBox1);
            this.panelSideBar.Controls.Add(this.pictureBox3);
            this.panelSideBar.Controls.Add(this.pictureBox4);
            this.panelSideBar.Controls.Add(this.pictureBox2);
            this.panelSideBar.Controls.Add(this.btnInventory);
            this.panelSideBar.Controls.Add(this.btnCount);
            this.panelSideBar.Controls.Add(this.btnOrderHistory);
            this.panelSideBar.Controls.Add(this.btnPlaceOrder);
            this.panelSideBar.Controls.Add(this.btnRequest);
            this.panelSideBar.Controls.Add(this.panek);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(290, 800);
            this.panelSideBar.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 372);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // btnInventory
            // 
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.LightCyan;
            this.btnInventory.Location = new System.Drawing.Point(0, 320);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(290, 46);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Inventory List";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderHistory.ForeColor = System.Drawing.Color.LightCyan;
            this.btnOrderHistory.Location = new System.Drawing.Point(0, 365);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Size = new System.Drawing.Size(290, 46);
            this.btnOrderHistory.TabIndex = 1;
            this.btnOrderHistory.Text = "Order History";
            this.btnOrderHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrderHistory.UseVisualStyleBackColor = true;
            this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DimGray;
            this.panelTop.Controls.Add(this.pictureBox6);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Location = new System.Drawing.Point(290, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1160, 82);
            this.panelTop.TabIndex = 6;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(990, 32);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(49, 47);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(7, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inventory Name ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(1045, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logout";
            // 
            // InventoryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 800);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRequests);
            this.Controls.Add(this.panelSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryMain";
            this.Text = "InventoryMain";
            this.panek.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSideBar.ResumeLayout(false);
            this.panelSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Panel panek;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRequests;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrderHistory;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}