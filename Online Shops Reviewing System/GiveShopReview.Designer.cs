namespace Online_Shops_Reviewing_System
{
    partial class GiveShopReview
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
            this.shopIdTxtbx = new System.Windows.Forms.TextBox();
            this.shopNameTxtbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.ratingCmbbx.Location = new System.Drawing.Point(252, 316);
            this.ratingCmbbx.Name = "ratingCmbbx";
            this.ratingCmbbx.Size = new System.Drawing.Size(261, 24);
            this.ratingCmbbx.TabIndex = 72;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(163, 314);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 23);
            this.label13.TabIndex = 71;
            this.label13.Text = "Rating:";
            // 
            // revIdTxtbx
            // 
            this.revIdTxtbx.Location = new System.Drawing.Point(252, 139);
            this.revIdTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.revIdTxtbx.Name = "revIdTxtbx";
            this.revIdTxtbx.ReadOnly = true;
            this.revIdTxtbx.Size = new System.Drawing.Size(261, 22);
            this.revIdTxtbx.TabIndex = 70;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(130, 139);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 23);
            this.label12.TabIndex = 69;
            this.label12.Text = "Review ID:";
            // 
            // descTxtbx
            // 
            this.descTxtbx.Location = new System.Drawing.Point(252, 184);
            this.descTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.descTxtbx.Name = "descTxtbx";
            this.descTxtbx.Size = new System.Drawing.Size(261, 104);
            this.descTxtbx.TabIndex = 68;
            this.descTxtbx.Text = "";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.SlateGray;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.backBtn.Location = new System.Drawing.Point(252, 400);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(261, 28);
            this.backBtn.TabIndex = 67;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.SlateGray;
            this.submitBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.submitBtn.Location = new System.Drawing.Point(252, 358);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(261, 28);
            this.submitBtn.TabIndex = 66;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // shopIdTxtbx
            // 
            this.shopIdTxtbx.Location = new System.Drawing.Point(252, 60);
            this.shopIdTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.shopIdTxtbx.Name = "shopIdTxtbx";
            this.shopIdTxtbx.ReadOnly = true;
            this.shopIdTxtbx.Size = new System.Drawing.Size(261, 22);
            this.shopIdTxtbx.TabIndex = 65;
            // 
            // shopNameTxtbx
            // 
            this.shopNameTxtbx.Location = new System.Drawing.Point(252, 101);
            this.shopNameTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.shopNameTxtbx.Name = "shopNameTxtbx";
            this.shopNameTxtbx.ReadOnly = true;
            this.shopNameTxtbx.Size = new System.Drawing.Size(261, 22);
            this.shopNameTxtbx.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 63;
            this.label5.Text = "Shop ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 62;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 61;
            this.label2.Text = "Shop Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 26);
            this.label1.TabIndex = 60;
            this.label1.Text = "Give Shop Review";
            // 
            // GiveShopReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.ratingCmbbx);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.revIdTxtbx);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.descTxtbx);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.shopIdTxtbx);
            this.Controls.Add(this.shopNameTxtbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GiveShopReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiveShopReview";
            this.Load += new System.EventHandler(this.GiveShopReview_Load);
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
        private System.Windows.Forms.TextBox shopIdTxtbx;
        private System.Windows.Forms.TextBox shopNameTxtbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}