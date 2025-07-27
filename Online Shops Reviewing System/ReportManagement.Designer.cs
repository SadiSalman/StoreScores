namespace Online_Shops_Reviewing_System
{
    partial class ReportManagement
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
            this.sortCmb = new System.Windows.Forms.ComboBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.repDgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResolved = new System.Windows.Forms.RadioButton();
            this.btnPending = new System.Windows.Forms.RadioButton();
            this.txtReason = new System.Windows.Forms.RichTextBox();
            this.userIdTxtbx = new System.Windows.Forms.TextBox();
            this.userIdLbl = new System.Windows.Forms.Label();
            this.goToRevBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.revIdLbl = new System.Windows.Forms.Label();
            this.revIdTxtbx = new System.Windows.Forms.TextBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.reasonLbl = new System.Windows.Forms.Label();
            this.repIdTxtbx = new System.Windows.Forms.TextBox();
            this.repIdLbl = new System.Windows.Forms.Label();
            this.sortLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repDgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sortCmb
            // 
            this.sortCmb.FormattingEnabled = true;
            this.sortCmb.Items.AddRange(new object[] {
            "None",
            "Pending",
            "Resolved"});
            this.sortCmb.Location = new System.Drawing.Point(490, 48);
            this.sortCmb.Margin = new System.Windows.Forms.Padding(4);
            this.sortCmb.Name = "sortCmb";
            this.sortCmb.Size = new System.Drawing.Size(188, 24);
            this.sortCmb.TabIndex = 17;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(13, 9);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(189, 31);
            this.titleLbl.TabIndex = 16;
            this.titleLbl.Text = "Manage Reports";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DimGray;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.backBtn.Location = new System.Drawing.Point(19, 44);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(156, 33);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.DimGray;
            this.loadBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.loadBtn.Location = new System.Drawing.Point(699, 44);
            this.loadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(112, 33);
            this.loadBtn.TabIndex = 13;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // repDgv
            // 
            this.repDgv.AllowUserToAddRows = false;
            this.repDgv.AllowUserToDeleteRows = false;
            this.repDgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.repDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.repDgv.Location = new System.Drawing.Point(19, 85);
            this.repDgv.Margin = new System.Windows.Forms.Padding(4);
            this.repDgv.Name = "repDgv";
            this.repDgv.ReadOnly = true;
            this.repDgv.RowHeadersWidth = 51;
            this.repDgv.Size = new System.Drawing.Size(792, 410);
            this.repDgv.TabIndex = 12;
            this.repDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.repDgv_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnResolved);
            this.panel1.Controls.Add(this.btnPending);
            this.panel1.Controls.Add(this.txtReason);
            this.panel1.Controls.Add(this.userIdTxtbx);
            this.panel1.Controls.Add(this.userIdLbl);
            this.panel1.Controls.Add(this.goToRevBtn);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.revIdLbl);
            this.panel1.Controls.Add(this.revIdTxtbx);
            this.panel1.Controls.Add(this.statusLbl);
            this.panel1.Controls.Add(this.reasonLbl);
            this.panel1.Controls.Add(this.repIdTxtbx);
            this.panel1.Controls.Add(this.repIdLbl);
            this.panel1.Location = new System.Drawing.Point(838, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 486);
            this.panel1.TabIndex = 11;
            // 
            // btnResolved
            // 
            this.btnResolved.AutoSize = true;
            this.btnResolved.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolved.Location = new System.Drawing.Point(159, 231);
            this.btnResolved.Margin = new System.Windows.Forms.Padding(4);
            this.btnResolved.Name = "btnResolved";
            this.btnResolved.Size = new System.Drawing.Size(78, 19);
            this.btnResolved.TabIndex = 17;
            this.btnResolved.TabStop = true;
            this.btnResolved.Text = "Resolved";
            this.btnResolved.UseVisualStyleBackColor = true;
            // 
            // btnPending
            // 
            this.btnPending.AutoSize = true;
            this.btnPending.Location = new System.Drawing.Point(27, 231);
            this.btnPending.Margin = new System.Windows.Forms.Padding(4);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(78, 20);
            this.btnPending.TabIndex = 16;
            this.btnPending.TabStop = true;
            this.btnPending.Text = "Pending";
            this.btnPending.UseVisualStyleBackColor = true;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(25, 105);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4);
            this.txtReason.Name = "txtReason";
            this.txtReason.ReadOnly = true;
            this.txtReason.Size = new System.Drawing.Size(221, 88);
            this.txtReason.TabIndex = 15;
            this.txtReason.Text = "";
            // 
            // userIdTxtbx
            // 
            this.userIdTxtbx.Location = new System.Drawing.Point(25, 353);
            this.userIdTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.userIdTxtbx.Name = "userIdTxtbx";
            this.userIdTxtbx.ReadOnly = true;
            this.userIdTxtbx.Size = new System.Drawing.Size(221, 22);
            this.userIdTxtbx.TabIndex = 14;
            // 
            // userIdLbl
            // 
            this.userIdLbl.AutoSize = true;
            this.userIdLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLbl.Location = new System.Drawing.Point(23, 323);
            this.userIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userIdLbl.Name = "userIdLbl";
            this.userIdLbl.Size = new System.Drawing.Size(83, 23);
            this.userIdLbl.TabIndex = 13;
            this.userIdLbl.Text = "User ID:";
            // 
            // goToRevBtn
            // 
            this.goToRevBtn.BackColor = System.Drawing.Color.DimGray;
            this.goToRevBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToRevBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.goToRevBtn.Location = new System.Drawing.Point(43, 443);
            this.goToRevBtn.Margin = new System.Windows.Forms.Padding(4);
            this.goToRevBtn.Name = "goToRevBtn";
            this.goToRevBtn.Size = new System.Drawing.Size(191, 28);
            this.goToRevBtn.TabIndex = 12;
            this.goToRevBtn.Text = "Go To Review Page";
            this.goToRevBtn.UseVisualStyleBackColor = false;
            this.goToRevBtn.Click += new System.EventHandler(this.goToRevBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.DimGray;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.saveBtn.Location = new System.Drawing.Point(43, 396);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(191, 30);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // revIdLbl
            // 
            this.revIdLbl.AutoSize = true;
            this.revIdLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revIdLbl.Location = new System.Drawing.Point(21, 258);
            this.revIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.revIdLbl.Name = "revIdLbl";
            this.revIdLbl.Size = new System.Drawing.Size(106, 23);
            this.revIdLbl.TabIndex = 9;
            this.revIdLbl.Text = "Review ID:";
            // 
            // revIdTxtbx
            // 
            this.revIdTxtbx.Location = new System.Drawing.Point(27, 292);
            this.revIdTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.revIdTxtbx.Name = "revIdTxtbx";
            this.revIdTxtbx.ReadOnly = true;
            this.revIdTxtbx.Size = new System.Drawing.Size(219, 22);
            this.revIdTxtbx.TabIndex = 8;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.Location = new System.Drawing.Point(21, 200);
            this.statusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(70, 23);
            this.statusLbl.TabIndex = 6;
            this.statusLbl.Text = "Status:";
            // 
            // reasonLbl
            // 
            this.reasonLbl.AutoSize = true;
            this.reasonLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonLbl.Location = new System.Drawing.Point(21, 75);
            this.reasonLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reasonLbl.Name = "reasonLbl";
            this.reasonLbl.Size = new System.Drawing.Size(79, 23);
            this.reasonLbl.TabIndex = 2;
            this.reasonLbl.Text = "Reason:";
            // 
            // repIdTxtbx
            // 
            this.repIdTxtbx.Location = new System.Drawing.Point(27, 43);
            this.repIdTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.repIdTxtbx.Name = "repIdTxtbx";
            this.repIdTxtbx.ReadOnly = true;
            this.repIdTxtbx.Size = new System.Drawing.Size(219, 22);
            this.repIdTxtbx.TabIndex = 1;
            // 
            // repIdLbl
            // 
            this.repIdLbl.AutoSize = true;
            this.repIdLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repIdLbl.Location = new System.Drawing.Point(21, 12);
            this.repIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.repIdLbl.Name = "repIdLbl";
            this.repIdLbl.Size = new System.Drawing.Size(102, 23);
            this.repIdLbl.TabIndex = 0;
            this.repIdLbl.Text = "Report ID:";
            // 
            // sortLbl
            // 
            this.sortLbl.AutoSize = true;
            this.sortLbl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortLbl.Location = new System.Drawing.Point(358, 51);
            this.sortLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sortLbl.Name = "sortLbl";
            this.sortLbl.Size = new System.Drawing.Size(114, 19);
            this.sortLbl.TabIndex = 18;
            this.sortLbl.Text = "Sort By Status";
            // 
            // ReportManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1113, 516);
            this.Controls.Add(this.sortLbl);
            this.Controls.Add(this.sortCmb);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.repDgv);
            this.Controls.Add(this.panel1);
            this.Name = "ReportManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportManagement";
            this.Load += new System.EventHandler(this.ReportManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repDgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sortCmb;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.DataGridView repDgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton btnResolved;
        private System.Windows.Forms.RadioButton btnPending;
        private System.Windows.Forms.RichTextBox txtReason;
        private System.Windows.Forms.TextBox userIdTxtbx;
        private System.Windows.Forms.Label userIdLbl;
        private System.Windows.Forms.Button goToRevBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label revIdLbl;
        private System.Windows.Forms.TextBox revIdTxtbx;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label reasonLbl;
        private System.Windows.Forms.TextBox repIdTxtbx;
        private System.Windows.Forms.Label repIdLbl;
        private System.Windows.Forms.Label sortLbl;
    }
}