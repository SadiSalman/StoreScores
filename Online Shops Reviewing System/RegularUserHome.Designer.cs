namespace Online_Shops_Reviewing_System
{
    partial class RegularUserHome
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
            this.dgvShopProduct = new System.Windows.Forms.DataGridView();
            this.sbcLbl = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnBrowseShop = new System.Windows.Forms.Button();
            this.selectedIdLbl = new System.Windows.Forms.Label();
            this.selIdTextbx = new System.Windows.Forms.TextBox();
            this.selNameTxtbx = new System.Windows.Forms.TextBox();
            this.btnGiveReview = new System.Windows.Forms.Button();
            this.btnBrowseProduct = new System.Windows.Forms.Button();
            this.btnMyAccount = new System.Windows.Forms.Button();
            this.btnReadReview = new System.Windows.Forms.Button();
            this.categoryCmbbx = new System.Windows.Forms.ComboBox();
            this.selectedNameLBl = new System.Windows.Forms.Label();
            this.browseLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShopProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShopProduct
            // 
            this.dgvShopProduct.AllowUserToAddRows = false;
            this.dgvShopProduct.AllowUserToDeleteRows = false;
            this.dgvShopProduct.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvShopProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShopProduct.Location = new System.Drawing.Point(173, 80);
            this.dgvShopProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dgvShopProduct.Name = "dgvShopProduct";
            this.dgvShopProduct.ReadOnly = true;
            this.dgvShopProduct.RowHeadersWidth = 51;
            this.dgvShopProduct.Size = new System.Drawing.Size(778, 263);
            this.dgvShopProduct.TabIndex = 1;
            this.dgvShopProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShopProduct_CellClick);
            // 
            // sbcLbl
            // 
            this.sbcLbl.AutoSize = true;
            this.sbcLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbcLbl.ForeColor = System.Drawing.Color.Sienna;
            this.sbcLbl.Location = new System.Drawing.Point(441, 48);
            this.sbcLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sbcLbl.Name = "sbcLbl";
            this.sbcLbl.Size = new System.Drawing.Size(165, 23);
            this.sbcLbl.TabIndex = 7;
            this.sbcLbl.Text = "Search by Category:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.SeaShell;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Sienna;
            this.btnRefresh.Location = new System.Drawing.Point(856, 41);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 32);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.SeaShell;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Sienna;
            this.btnLogOut.Location = new System.Drawing.Point(21, 370);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(108, 30);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnBrowseShop
            // 
            this.btnBrowseShop.BackColor = System.Drawing.Color.SeaShell;
            this.btnBrowseShop.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseShop.ForeColor = System.Drawing.Color.Sienna;
            this.btnBrowseShop.Location = new System.Drawing.Point(21, 90);
            this.btnBrowseShop.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseShop.Name = "btnBrowseShop";
            this.btnBrowseShop.Size = new System.Drawing.Size(108, 54);
            this.btnBrowseShop.TabIndex = 13;
            this.btnBrowseShop.Text = "Browse Shops";
            this.btnBrowseShop.UseVisualStyleBackColor = false;
            this.btnBrowseShop.Click += new System.EventHandler(this.btnBrowseShop_Click);
            // 
            // selectedIdLbl
            // 
            this.selectedIdLbl.AutoSize = true;
            this.selectedIdLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedIdLbl.ForeColor = System.Drawing.Color.Sienna;
            this.selectedIdLbl.Location = new System.Drawing.Point(178, 377);
            this.selectedIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedIdLbl.Name = "selectedIdLbl";
            this.selectedIdLbl.Size = new System.Drawing.Size(100, 23);
            this.selectedIdLbl.TabIndex = 14;
            this.selectedIdLbl.Text = "Selected ID:";
            // 
            // selIdTextbx
            // 
            this.selIdTextbx.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selIdTextbx.Location = new System.Drawing.Point(297, 370);
            this.selIdTextbx.Margin = new System.Windows.Forms.Padding(4);
            this.selIdTextbx.Name = "selIdTextbx";
            this.selIdTextbx.ReadOnly = true;
            this.selIdTextbx.Size = new System.Drawing.Size(169, 30);
            this.selIdTextbx.TabIndex = 15;
            // 
            // selNameTxtbx
            // 
            this.selNameTxtbx.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selNameTxtbx.Location = new System.Drawing.Point(584, 370);
            this.selNameTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.selNameTxtbx.Name = "selNameTxtbx";
            this.selNameTxtbx.ReadOnly = true;
            this.selNameTxtbx.Size = new System.Drawing.Size(249, 30);
            this.selNameTxtbx.TabIndex = 16;
            // 
            // btnGiveReview
            // 
            this.btnGiveReview.BackColor = System.Drawing.Color.SeaShell;
            this.btnGiveReview.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiveReview.ForeColor = System.Drawing.Color.Sienna;
            this.btnGiveReview.Location = new System.Drawing.Point(21, 216);
            this.btnGiveReview.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiveReview.Name = "btnGiveReview";
            this.btnGiveReview.Size = new System.Drawing.Size(108, 41);
            this.btnGiveReview.TabIndex = 18;
            this.btnGiveReview.Text = "Give Review";
            this.btnGiveReview.UseVisualStyleBackColor = false;
            this.btnGiveReview.Click += new System.EventHandler(this.btnGiveReview_Click);
            // 
            // btnBrowseProduct
            // 
            this.btnBrowseProduct.BackColor = System.Drawing.Color.SeaShell;
            this.btnBrowseProduct.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseProduct.ForeColor = System.Drawing.Color.Sienna;
            this.btnBrowseProduct.Location = new System.Drawing.Point(21, 157);
            this.btnBrowseProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseProduct.Name = "btnBrowseProduct";
            this.btnBrowseProduct.Size = new System.Drawing.Size(108, 51);
            this.btnBrowseProduct.TabIndex = 19;
            this.btnBrowseProduct.Text = "Browse Product";
            this.btnBrowseProduct.UseVisualStyleBackColor = false;
            this.btnBrowseProduct.Click += new System.EventHandler(this.btnBrowseProduct_Click);
            // 
            // btnMyAccount
            // 
            this.btnMyAccount.BackColor = System.Drawing.Color.SeaShell;
            this.btnMyAccount.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyAccount.ForeColor = System.Drawing.Color.Sienna;
            this.btnMyAccount.Location = new System.Drawing.Point(21, 34);
            this.btnMyAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnMyAccount.Name = "btnMyAccount";
            this.btnMyAccount.Size = new System.Drawing.Size(108, 43);
            this.btnMyAccount.TabIndex = 20;
            this.btnMyAccount.Text = "My Account";
            this.btnMyAccount.UseVisualStyleBackColor = false;
            this.btnMyAccount.Click += new System.EventHandler(this.btnMyAccount_Click);
            // 
            // btnReadReview
            // 
            this.btnReadReview.BackColor = System.Drawing.Color.SeaShell;
            this.btnReadReview.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadReview.ForeColor = System.Drawing.Color.Sienna;
            this.btnReadReview.Location = new System.Drawing.Point(21, 269);
            this.btnReadReview.Margin = new System.Windows.Forms.Padding(4);
            this.btnReadReview.Name = "btnReadReview";
            this.btnReadReview.Size = new System.Drawing.Size(108, 44);
            this.btnReadReview.TabIndex = 21;
            this.btnReadReview.Text = "Read Review";
            this.btnReadReview.UseVisualStyleBackColor = false;
            this.btnReadReview.Click += new System.EventHandler(this.btnReadReview_Click);
            // 
            // categoryCmbbx
            // 
            this.categoryCmbbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryCmbbx.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryCmbbx.FormattingEnabled = true;
            this.categoryCmbbx.Items.AddRange(new object[] {
            "Electronics",
            "Clothing",
            "Books"});
            this.categoryCmbbx.Location = new System.Drawing.Point(629, 48);
            this.categoryCmbbx.Margin = new System.Windows.Forms.Padding(4);
            this.categoryCmbbx.Name = "categoryCmbbx";
            this.categoryCmbbx.Size = new System.Drawing.Size(204, 25);
            this.categoryCmbbx.TabIndex = 27;
            this.categoryCmbbx.SelectedIndexChanged += new System.EventHandler(this.categoryCmbbx_SelectedIndexChanged);
            // 
            // selectedNameLBl
            // 
            this.selectedNameLBl.AutoSize = true;
            this.selectedNameLBl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedNameLBl.ForeColor = System.Drawing.Color.Sienna;
            this.selectedNameLBl.Location = new System.Drawing.Point(516, 377);
            this.selectedNameLBl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedNameLBl.Name = "selectedNameLBl";
            this.selectedNameLBl.Size = new System.Drawing.Size(60, 23);
            this.selectedNameLBl.TabIndex = 22;
            this.selectedNameLBl.Text = "Name:";
            // 
            // browseLbl
            // 
            this.browseLbl.AutoSize = true;
            this.browseLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseLbl.ForeColor = System.Drawing.Color.Sienna;
            this.browseLbl.Location = new System.Drawing.Point(169, 49);
            this.browseLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.browseLbl.Name = "browseLbl";
            this.browseLbl.Size = new System.Drawing.Size(0, 23);
            this.browseLbl.TabIndex = 28;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.Sienna;
            this.titleLbl.Location = new System.Drawing.Point(440, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(116, 28);
            this.titleLbl.TabIndex = 29;
            this.titleLbl.Text = "User Home";
            // 
            // RegularUserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(980, 445);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.browseLbl);
            this.Controls.Add(this.categoryCmbbx);
            this.Controls.Add(this.selectedNameLBl);
            this.Controls.Add(this.btnReadReview);
            this.Controls.Add(this.btnMyAccount);
            this.Controls.Add(this.btnBrowseProduct);
            this.Controls.Add(this.btnGiveReview);
            this.Controls.Add(this.selNameTxtbx);
            this.Controls.Add(this.selIdTextbx);
            this.Controls.Add(this.selectedIdLbl);
            this.Controls.Add(this.btnBrowseShop);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.sbcLbl);
            this.Controls.Add(this.dgvShopProduct);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegularUserHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegularUserHome";
            this.Load += new System.EventHandler(this.RegularUserHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShopProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvShopProduct;
        private System.Windows.Forms.Label sbcLbl;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnBrowseShop;
        private System.Windows.Forms.Label selectedIdLbl;
        private System.Windows.Forms.TextBox selIdTextbx;
        private System.Windows.Forms.TextBox selNameTxtbx;
        private System.Windows.Forms.Button btnGiveReview;
        private System.Windows.Forms.Button btnBrowseProduct;
        private System.Windows.Forms.Button btnMyAccount;
        private System.Windows.Forms.Button btnReadReview;
        private System.Windows.Forms.ComboBox categoryCmbbx;
        private System.Windows.Forms.Label selectedNameLBl;
        private System.Windows.Forms.Label browseLbl;
        private System.Windows.Forms.Label titleLbl;
    }
}