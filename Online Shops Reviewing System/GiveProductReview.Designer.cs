namespace Online_Shops_Reviewing_System
{
    partial class GiveProductReview
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
            this.ratingCmbbx = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.revIdTxtbx = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.descTxtbx = new System.Windows.Forms.RichTextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.productNameTxtbx = new System.Windows.Forms.TextBox();
            this.shopNameTxtbx = new System.Windows.Forms.TextBox();
            this.productNameLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shopNameLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.productIdTextbx = new System.Windows.Forms.TextBox();
            this.productIdLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ratingCmbbx
            // 
            this.ratingCmbbx.FormattingEnabled = true;
            this.ratingCmbbx.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5"});
            this.ratingCmbbx.Location = new System.Drawing.Point(304, 382);
            this.ratingCmbbx.Name = "ratingCmbbx";
            this.ratingCmbbx.Size = new System.Drawing.Size(261, 24);
            this.ratingCmbbx.TabIndex = 85;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(215, 380);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 23);
            this.label13.TabIndex = 84;
            this.label13.Text = "Rating:";
            // 
            // revIdTxtbx
            // 
            this.revIdTxtbx.Location = new System.Drawing.Point(304, 205);
            this.revIdTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.revIdTxtbx.Name = "revIdTxtbx";
            this.revIdTxtbx.ReadOnly = true;
            this.revIdTxtbx.Size = new System.Drawing.Size(261, 22);
            this.revIdTxtbx.TabIndex = 83;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(182, 205);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 23);
            this.label12.TabIndex = 82;
            this.label12.Text = "Review ID:";
            // 
            // descTxtbx
            // 
            this.descTxtbx.Location = new System.Drawing.Point(304, 250);
            this.descTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.descTxtbx.Name = "descTxtbx";
            this.descTxtbx.Size = new System.Drawing.Size(261, 104);
            this.descTxtbx.TabIndex = 81;
            this.descTxtbx.Text = "";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.SlateGray;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.backBtn.Location = new System.Drawing.Point(304, 466);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(261, 28);
            this.backBtn.TabIndex = 80;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.SlateGray;
            this.submitBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.submitBtn.Location = new System.Drawing.Point(304, 424);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(261, 28);
            this.submitBtn.TabIndex = 79;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // productNameTxtbx
            // 
            this.productNameTxtbx.Location = new System.Drawing.Point(304, 119);
            this.productNameTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.productNameTxtbx.Name = "productNameTxtbx";
            this.productNameTxtbx.ReadOnly = true;
            this.productNameTxtbx.Size = new System.Drawing.Size(261, 22);
            this.productNameTxtbx.TabIndex = 78;
            // 
            // shopNameTxtbx
            // 
            this.shopNameTxtbx.Location = new System.Drawing.Point(304, 166);
            this.shopNameTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.shopNameTxtbx.Name = "shopNameTxtbx";
            this.shopNameTxtbx.ReadOnly = true;
            this.shopNameTxtbx.Size = new System.Drawing.Size(261, 22);
            this.shopNameTxtbx.TabIndex = 77;
            // 
            // productNameLbl
            // 
            this.productNameLbl.AutoSize = true;
            this.productNameLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLbl.Location = new System.Drawing.Point(151, 117);
            this.productNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productNameLbl.Name = "productNameLbl";
            this.productNameLbl.Size = new System.Drawing.Size(137, 23);
            this.productNameLbl.TabIndex = 76;
            this.productNameLbl.Text = "Product Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 75;
            this.label3.Text = "Description:";
            // 
            // shopNameLbl
            // 
            this.shopNameLbl.AutoSize = true;
            this.shopNameLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopNameLbl.Location = new System.Drawing.Point(176, 166);
            this.shopNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shopNameLbl.Name = "shopNameLbl";
            this.shopNameLbl.Size = new System.Drawing.Size(112, 23);
            this.shopNameLbl.TabIndex = 74;
            this.shopNameLbl.Text = "Shop Name:";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(266, 26);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(283, 26);
            this.titleLbl.TabIndex = 73;
            this.titleLbl.Text = "Give Your Product Review";
            // 
            // productIdTextbx
            // 
            this.productIdTextbx.Location = new System.Drawing.Point(304, 78);
            this.productIdTextbx.Margin = new System.Windows.Forms.Padding(4);
            this.productIdTextbx.Name = "productIdTextbx";
            this.productIdTextbx.ReadOnly = true;
            this.productIdTextbx.Size = new System.Drawing.Size(261, 22);
            this.productIdTextbx.TabIndex = 87;
            // 
            // productIdLbl
            // 
            this.productIdLbl.AutoSize = true;
            this.productIdLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdLbl.Location = new System.Drawing.Point(179, 77);
            this.productIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productIdLbl.Name = "productIdLbl";
            this.productIdLbl.Size = new System.Drawing.Size(109, 23);
            this.productIdLbl.TabIndex = 86;
            this.productIdLbl.Text = "Product ID:";
            // 
            // GiveProductReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.productIdTextbx);
            this.Controls.Add(this.productIdLbl);
            this.Controls.Add(this.ratingCmbbx);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.revIdTxtbx);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.descTxtbx);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.productNameTxtbx);
            this.Controls.Add(this.shopNameTxtbx);
            this.Controls.Add(this.productNameLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shopNameLbl);
            this.Controls.Add(this.titleLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GiveProductReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiveProductReview";
            this.Load += new System.EventHandler(this.GiveProductReview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ratingCmbbx;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox revIdTxtbx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox descTxtbx;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox productNameTxtbx;
        private System.Windows.Forms.TextBox shopNameTxtbx;
        private System.Windows.Forms.Label productNameLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label shopNameLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TextBox productIdTextbx;
        private System.Windows.Forms.Label productIdLbl;
    }
}