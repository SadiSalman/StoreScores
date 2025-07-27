namespace Online_Shops_Reviewing_System
{
    partial class ManageReview
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvManageReview = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.updateBtn = new System.Windows.Forms.Button();
            this.rtxtReviewDescription = new System.Windows.Forms.RichTextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtReviewDate = new System.Windows.Forms.TextBox();
            this.txtReviewId = new System.Windows.Forms.TextBox();
            this.reviewerIdLbl = new System.Windows.Forms.Label();
            this.descLbl = new System.Windows.Forms.Label();
            this.ratingLbl = new System.Windows.Forms.Label();
            this.revDateLbl = new System.Windows.Forms.Label();
            this.revIdLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageReview)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 833F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1115, 556);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dgvManageReview);
            this.panel8.Location = new System.Drawing.Point(4, 69);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(825, 483);
            this.panel8.TabIndex = 8;
            // 
            // dgvManageReview
            // 
            this.dgvManageReview.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvManageReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvManageReview.Location = new System.Drawing.Point(0, 0);
            this.dgvManageReview.Margin = new System.Windows.Forms.Padding(4);
            this.dgvManageReview.Name = "dgvManageReview";
            this.dgvManageReview.RowHeadersWidth = 51;
            this.dgvManageReview.Size = new System.Drawing.Size(825, 483);
            this.dgvManageReview.TabIndex = 0;
            this.dgvManageReview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageReview_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.updateBtn);
            this.panel3.Controls.Add(this.rtxtReviewDescription);
            this.panel3.Controls.Add(this.txtUserId);
            this.panel3.Controls.Add(this.txtRating);
            this.panel3.Controls.Add(this.txtReviewDate);
            this.panel3.Controls.Add(this.txtReviewId);
            this.panel3.Controls.Add(this.reviewerIdLbl);
            this.panel3.Controls.Add(this.descLbl);
            this.panel3.Controls.Add(this.ratingLbl);
            this.panel3.Controls.Add(this.revDateLbl);
            this.panel3.Controls.Add(this.revIdLbl);
            this.panel3.Location = new System.Drawing.Point(837, 69);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 483);
            this.panel3.TabIndex = 3;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.DimGray;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.updateBtn.Location = new System.Drawing.Point(20, 424);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(225, 33);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtxtReviewDescription
            // 
            this.rtxtReviewDescription.Location = new System.Drawing.Point(20, 248);
            this.rtxtReviewDescription.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtReviewDescription.Name = "rtxtReviewDescription";
            this.rtxtReviewDescription.Size = new System.Drawing.Size(225, 85);
            this.rtxtReviewDescription.TabIndex = 9;
            this.rtxtReviewDescription.Text = "";
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(20, 370);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(225, 29);
            this.txtUserId.TabIndex = 8;
            // 
            // txtRating
            // 
            this.txtRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRating.Location = new System.Drawing.Point(20, 179);
            this.txtRating.Margin = new System.Windows.Forms.Padding(4);
            this.txtRating.Name = "txtRating";
            this.txtRating.ReadOnly = true;
            this.txtRating.Size = new System.Drawing.Size(225, 29);
            this.txtRating.TabIndex = 7;
            // 
            // txtReviewDate
            // 
            this.txtReviewDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReviewDate.Location = new System.Drawing.Point(20, 114);
            this.txtReviewDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtReviewDate.Name = "txtReviewDate";
            this.txtReviewDate.ReadOnly = true;
            this.txtReviewDate.Size = new System.Drawing.Size(225, 29);
            this.txtReviewDate.TabIndex = 6;
            // 
            // txtReviewId
            // 
            this.txtReviewId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReviewId.Location = new System.Drawing.Point(20, 43);
            this.txtReviewId.Margin = new System.Windows.Forms.Padding(4);
            this.txtReviewId.Name = "txtReviewId";
            this.txtReviewId.ReadOnly = true;
            this.txtReviewId.Size = new System.Drawing.Size(225, 29);
            this.txtReviewId.TabIndex = 5;
            // 
            // reviewerIdLbl
            // 
            this.reviewerIdLbl.AutoSize = true;
            this.reviewerIdLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewerIdLbl.Location = new System.Drawing.Point(16, 341);
            this.reviewerIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reviewerIdLbl.Name = "reviewerIdLbl";
            this.reviewerIdLbl.Size = new System.Drawing.Size(66, 23);
            this.reviewerIdLbl.TabIndex = 4;
            this.reviewerIdLbl.Text = "User ID";
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLbl.Location = new System.Drawing.Point(16, 221);
            this.descLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(160, 23);
            this.descLbl.TabIndex = 3;
            this.descLbl.Text = "Review Description:";
            // 
            // ratingLbl
            // 
            this.ratingLbl.AutoSize = true;
            this.ratingLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLbl.Location = new System.Drawing.Point(16, 151);
            this.ratingLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ratingLbl.Name = "ratingLbl";
            this.ratingLbl.Size = new System.Drawing.Size(64, 23);
            this.ratingLbl.TabIndex = 2;
            this.ratingLbl.Text = "Rating:";
            // 
            // revDateLbl
            // 
            this.revDateLbl.AutoSize = true;
            this.revDateLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revDateLbl.Location = new System.Drawing.Point(16, 85);
            this.revDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.revDateLbl.Name = "revDateLbl";
            this.revDateLbl.Size = new System.Drawing.Size(110, 23);
            this.revDateLbl.TabIndex = 1;
            this.revDateLbl.Text = "Review Date:";
            // 
            // revIdLbl
            // 
            this.revIdLbl.AutoSize = true;
            this.revIdLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revIdLbl.Location = new System.Drawing.Point(16, 15);
            this.revIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.revIdLbl.Name = "revIdLbl";
            this.revIdLbl.Size = new System.Drawing.Size(91, 23);
            this.revIdLbl.TabIndex = 0;
            this.revIdLbl.Text = "Review ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(837, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 57);
            this.panel2.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DimGray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(20, 16);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(225, 33);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.txtSearchId);
            this.panel1.Controls.Add(this.searchLbl);
            this.panel1.Controls.Add(this.titleLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 57);
            this.panel1.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.DimGray;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.searchBtn.Location = new System.Drawing.Point(632, 13);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(55, 36);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Go";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DimGray;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLoad.Location = new System.Drawing.Point(722, 13);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(87, 36);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(419, 21);
            this.txtSearchId.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(185, 22);
            this.txtSearchId.TabIndex = 2;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.Location = new System.Drawing.Point(286, 19);
            this.searchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(111, 23);
            this.searchLbl.TabIndex = 1;
            this.searchLbl.Text = "Search By ID:";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(24, 12);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(162, 28);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Manage Review";
            // 
            // ManageReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1115, 556);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageReview";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageReview)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dgvManageReview;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.RichTextBox rtxtReviewDescription;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtReviewDate;
        private System.Windows.Forms.TextBox txtReviewId;
        private System.Windows.Forms.Label reviewerIdLbl;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.Label ratingLbl;
        private System.Windows.Forms.Label revDateLbl;
        private System.Windows.Forms.Label revIdLbl;
        private System.Windows.Forms.Button searchBtn;
    }
}