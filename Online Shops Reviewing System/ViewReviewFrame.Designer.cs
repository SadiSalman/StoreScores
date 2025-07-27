namespace Online_Shops_Reviewing_System
{
    partial class ViewReviewFrame
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
            this.selectedNameLbl = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.revDgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReviewId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionTxtbx = new System.Windows.Forms.RichTextBox();
            this.reportBtn = new System.Windows.Forms.Button();
            this.selectedNameTxtbx = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReviewDate = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.reviewerNameTxtbx = new System.Windows.Forms.TextBox();
            this.reviewerNameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.revDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedNameLbl
            // 
            this.selectedNameLbl.AutoSize = true;
            this.selectedNameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedNameLbl.Location = new System.Drawing.Point(12, 25);
            this.selectedNameLbl.Name = "selectedNameLbl";
            this.selectedNameLbl.Size = new System.Drawing.Size(126, 23);
            this.selectedNameLbl.TabIndex = 1;
            this.selectedNameLbl.Text = "Selected name:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Gray;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Location = new System.Drawing.Point(643, 174);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(201, 26);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // revDgv
            // 
            this.revDgv.AllowUserToAddRows = false;
            this.revDgv.AllowUserToDeleteRows = false;
            this.revDgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.revDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.revDgv.Location = new System.Drawing.Point(15, 215);
            this.revDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.revDgv.Name = "revDgv";
            this.revDgv.ReadOnly = true;
            this.revDgv.RowHeadersWidth = 62;
            this.revDgv.RowTemplate.Height = 28;
            this.revDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.revDgv.Size = new System.Drawing.Size(829, 238);
            this.revDgv.TabIndex = 5;
            this.revDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.revDgv_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Review Id:";
            // 
            // txtReviewId
            // 
            this.txtReviewId.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReviewId.Location = new System.Drawing.Point(15, 117);
            this.txtReviewId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReviewId.Name = "txtReviewId";
            this.txtReviewId.ReadOnly = true;
            this.txtReviewId.Size = new System.Drawing.Size(262, 25);
            this.txtReviewId.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(615, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Review Description:";
            // 
            // descriptionTxtbx
            // 
            this.descriptionTxtbx.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTxtbx.Location = new System.Drawing.Point(618, 86);
            this.descriptionTxtbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionTxtbx.Name = "descriptionTxtbx";
            this.descriptionTxtbx.ReadOnly = true;
            this.descriptionTxtbx.Size = new System.Drawing.Size(226, 78);
            this.descriptionTxtbx.TabIndex = 11;
            this.descriptionTxtbx.Text = "";
            // 
            // reportBtn
            // 
            this.reportBtn.BackColor = System.Drawing.Color.Gray;
            this.reportBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.reportBtn.Location = new System.Drawing.Point(28, 469);
            this.reportBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(201, 35);
            this.reportBtn.TabIndex = 12;
            this.reportBtn.Text = "Submit Report";
            this.reportBtn.UseVisualStyleBackColor = false;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // selectedNameTxtbx
            // 
            this.selectedNameTxtbx.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedNameTxtbx.Location = new System.Drawing.Point(15, 54);
            this.selectedNameTxtbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectedNameTxtbx.Name = "selectedNameTxtbx";
            this.selectedNameTxtbx.ReadOnly = true;
            this.selectedNameTxtbx.Size = new System.Drawing.Size(262, 25);
            this.selectedNameTxtbx.TabIndex = 13;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DimGray;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.backBtn.Location = new System.Drawing.Point(643, 470);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(201, 35);
            this.backBtn.TabIndex = 14;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Review Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Rating:";
            // 
            // txtReviewDate
            // 
            this.txtReviewDate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReviewDate.Location = new System.Drawing.Point(15, 178);
            this.txtReviewDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReviewDate.Name = "txtReviewDate";
            this.txtReviewDate.ReadOnly = true;
            this.txtReviewDate.Size = new System.Drawing.Size(262, 25);
            this.txtReviewDate.TabIndex = 17;
            // 
            // txtRating
            // 
            this.txtRating.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRating.Location = new System.Drawing.Point(313, 79);
            this.txtRating.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRating.Name = "txtRating";
            this.txtRating.ReadOnly = true;
            this.txtRating.Size = new System.Drawing.Size(242, 25);
            this.txtRating.TabIndex = 18;
            // 
            // reviewerNameTxtbx
            // 
            this.reviewerNameTxtbx.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewerNameTxtbx.Location = new System.Drawing.Point(313, 139);
            this.reviewerNameTxtbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reviewerNameTxtbx.Name = "reviewerNameTxtbx";
            this.reviewerNameTxtbx.ReadOnly = true;
            this.reviewerNameTxtbx.Size = new System.Drawing.Size(242, 25);
            this.reviewerNameTxtbx.TabIndex = 22;
            // 
            // reviewerNameLbl
            // 
            this.reviewerNameLbl.AutoSize = true;
            this.reviewerNameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewerNameLbl.Location = new System.Drawing.Point(310, 113);
            this.reviewerNameLbl.Name = "reviewerNameLbl";
            this.reviewerNameLbl.Size = new System.Drawing.Size(85, 23);
            this.reviewerNameLbl.TabIndex = 21;
            this.reviewerNameLbl.Text = "Reviewer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "View Reviews";
            // 
            // ViewReviewFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(868, 515);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reviewerNameTxtbx);
            this.Controls.Add(this.reviewerNameLbl);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtReviewDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.selectedNameTxtbx);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.descriptionTxtbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtReviewId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.revDgv);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.selectedNameLbl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewReviewFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReviewFrame";
            this.Load += new System.EventHandler(this.ViewReviewFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.revDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label selectedNameLbl;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView revDgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReviewId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox descriptionTxtbx;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.TextBox selectedNameTxtbx;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReviewDate;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox reviewerNameTxtbx;
        private System.Windows.Forms.Label reviewerNameLbl;
        private System.Windows.Forms.Label label2;
    }
}