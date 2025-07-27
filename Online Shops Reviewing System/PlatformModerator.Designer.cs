namespace Online_Shops_Reviewing_System
{
    partial class PlatformModerator
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
            this.helloLbl = new System.Windows.Forms.Label();
            this.mhmDgv = new System.Windows.Forms.DataGridView();
            this.myAccBtn = new System.Windows.Forms.Button();
            this.mngRevBtn = new System.Windows.Forms.Button();
            this.mngRepBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.mngUserBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.searchBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.typeTxtbx = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.passTxtbx = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTxtbx = new System.Windows.Forms.TextBox();
            this.mailTxtbx = new System.Windows.Forms.TextBox();
            this.idTxtBx = new System.Windows.Forms.TextBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.searchTxtbx = new System.Windows.Forms.TextBox();
            this.manageLbl = new System.Windows.Forms.Label();
            this.searchLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mhmDgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // helloLbl
            // 
            this.helloLbl.AutoSize = true;
            this.helloLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloLbl.Location = new System.Drawing.Point(13, 13);
            this.helloLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.helloLbl.Name = "helloLbl";
            this.helloLbl.Size = new System.Drawing.Size(115, 28);
            this.helloLbl.TabIndex = 0;
            this.helloLbl.Text = "Hello, User";
            // 
            // mhmDgv
            // 
            this.mhmDgv.AllowUserToAddRows = false;
            this.mhmDgv.AllowUserToDeleteRows = false;
            this.mhmDgv.BackgroundColor = System.Drawing.Color.White;
            this.mhmDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mhmDgv.Location = new System.Drawing.Point(181, 83);
            this.mhmDgv.Margin = new System.Windows.Forms.Padding(4);
            this.mhmDgv.Name = "mhmDgv";
            this.mhmDgv.ReadOnly = true;
            this.mhmDgv.RowHeadersWidth = 51;
            this.mhmDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mhmDgv.Size = new System.Drawing.Size(786, 366);
            this.mhmDgv.TabIndex = 1;
            this.mhmDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mhmDgv_CellClick);
            // 
            // myAccBtn
            // 
            this.myAccBtn.BackColor = System.Drawing.Color.SeaShell;
            this.myAccBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myAccBtn.ForeColor = System.Drawing.Color.Sienna;
            this.myAccBtn.Location = new System.Drawing.Point(13, 62);
            this.myAccBtn.Margin = new System.Windows.Forms.Padding(4);
            this.myAccBtn.Name = "myAccBtn";
            this.myAccBtn.Size = new System.Drawing.Size(123, 47);
            this.myAccBtn.TabIndex = 2;
            this.myAccBtn.Text = "My Account";
            this.myAccBtn.UseVisualStyleBackColor = false;
            this.myAccBtn.Click += new System.EventHandler(this.myAccBtn_Click);
            // 
            // mngRevBtn
            // 
            this.mngRevBtn.BackColor = System.Drawing.Color.SeaShell;
            this.mngRevBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngRevBtn.ForeColor = System.Drawing.Color.Sienna;
            this.mngRevBtn.Location = new System.Drawing.Point(13, 183);
            this.mngRevBtn.Margin = new System.Windows.Forms.Padding(4);
            this.mngRevBtn.Name = "mngRevBtn";
            this.mngRevBtn.Size = new System.Drawing.Size(123, 56);
            this.mngRevBtn.TabIndex = 20;
            this.mngRevBtn.Text = "Manage Review";
            this.mngRevBtn.UseVisualStyleBackColor = false;
            this.mngRevBtn.Click += new System.EventHandler(this.mngRevBtn_Click);
            // 
            // mngRepBtn
            // 
            this.mngRepBtn.BackColor = System.Drawing.Color.SeaShell;
            this.mngRepBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngRepBtn.ForeColor = System.Drawing.Color.Sienna;
            this.mngRepBtn.Location = new System.Drawing.Point(13, 247);
            this.mngRepBtn.Margin = new System.Windows.Forms.Padding(4);
            this.mngRepBtn.Name = "mngRepBtn";
            this.mngRepBtn.Size = new System.Drawing.Size(123, 59);
            this.mngRepBtn.TabIndex = 21;
            this.mngRepBtn.Text = "Manage Reports";
            this.mngRepBtn.UseVisualStyleBackColor = false;
            this.mngRepBtn.Click += new System.EventHandler(this.mngRepBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.SeaShell;
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.Sienna;
            this.logOutBtn.Location = new System.Drawing.Point(13, 375);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(123, 40);
            this.logOutBtn.TabIndex = 22;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // mngUserBtn
            // 
            this.mngUserBtn.BackColor = System.Drawing.Color.SeaShell;
            this.mngUserBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngUserBtn.ForeColor = System.Drawing.Color.Sienna;
            this.mngUserBtn.Location = new System.Drawing.Point(13, 117);
            this.mngUserBtn.Margin = new System.Windows.Forms.Padding(4);
            this.mngUserBtn.Name = "mngUserBtn";
            this.mngUserBtn.Size = new System.Drawing.Size(123, 58);
            this.mngUserBtn.TabIndex = 23;
            this.mngUserBtn.Text = "Manage Regular User";
            this.mngUserBtn.UseVisualStyleBackColor = false;
            this.mngUserBtn.Click += new System.EventHandler(this.mngUserBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(757, 47);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(42, 28);
            this.searchBtn.TabIndex = 16;
            this.searchBtn.Text = "Go";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.typeTxtbx);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.passTxtbx);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nameTxtbx);
            this.panel1.Controls.Add(this.mailTxtbx);
            this.panel1.Controls.Add(this.idTxtBx);
            this.panel1.Location = new System.Drawing.Point(990, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 436);
            this.panel1.TabIndex = 24;
            // 
            // newBtn
            // 
            this.newBtn.BackColor = System.Drawing.Color.SeaShell;
            this.newBtn.ForeColor = System.Drawing.Color.Sienna;
            this.newBtn.Location = new System.Drawing.Point(21, 275);
            this.newBtn.Margin = new System.Windows.Forms.Padding(4);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(196, 28);
            this.newBtn.TabIndex = 29;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = false;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Type:";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.SeaShell;
            this.saveBtn.ForeColor = System.Drawing.Color.Sienna;
            this.saveBtn.Location = new System.Drawing.Point(21, 349);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(196, 28);
            this.saveBtn.TabIndex = 28;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // typeTxtbx
            // 
            this.typeTxtbx.Enabled = false;
            this.typeTxtbx.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTxtbx.Location = new System.Drawing.Point(21, 238);
            this.typeTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.typeTxtbx.Name = "typeTxtbx";
            this.typeTxtbx.Size = new System.Drawing.Size(196, 25);
            this.typeTxtbx.TabIndex = 26;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.SeaShell;
            this.deleteBtn.ForeColor = System.Drawing.Color.Sienna;
            this.deleteBtn.Location = new System.Drawing.Point(21, 387);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(196, 28);
            this.deleteBtn.TabIndex = 27;
            this.deleteBtn.Text = "Delete User";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // passTxtbx
            // 
            this.passTxtbx.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTxtbx.Location = new System.Drawing.Point(21, 185);
            this.passTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.passTxtbx.Name = "passTxtbx";
            this.passTxtbx.Size = new System.Drawing.Size(196, 25);
            this.passTxtbx.TabIndex = 22;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.SeaShell;
            this.addBtn.ForeColor = System.Drawing.Color.Sienna;
            this.addBtn.Location = new System.Drawing.Point(21, 311);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(196, 28);
            this.addBtn.TabIndex = 25;
            this.addBtn.Text = "Add User";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "User ID:";
            // 
            // nameTxtbx
            // 
            this.nameTxtbx.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtbx.Location = new System.Drawing.Point(21, 83);
            this.nameTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.nameTxtbx.Name = "nameTxtbx";
            this.nameTxtbx.Size = new System.Drawing.Size(196, 25);
            this.nameTxtbx.TabIndex = 20;
            // 
            // mailTxtbx
            // 
            this.mailTxtbx.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTxtbx.Location = new System.Drawing.Point(21, 132);
            this.mailTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.mailTxtbx.Name = "mailTxtbx";
            this.mailTxtbx.Size = new System.Drawing.Size(196, 25);
            this.mailTxtbx.TabIndex = 21;
            // 
            // idTxtBx
            // 
            this.idTxtBx.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtBx.Location = new System.Drawing.Point(21, 32);
            this.idTxtBx.Margin = new System.Windows.Forms.Padding(4);
            this.idTxtBx.Name = "idTxtBx";
            this.idTxtBx.ReadOnly = true;
            this.idTxtBx.Size = new System.Drawing.Size(196, 25);
            this.idTxtBx.TabIndex = 23;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(819, 46);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(4);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(148, 28);
            this.refreshBtn.TabIndex = 29;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // searchTxtbx
            // 
            this.searchTxtbx.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtbx.Location = new System.Drawing.Point(536, 49);
            this.searchTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.searchTxtbx.Name = "searchTxtbx";
            this.searchTxtbx.Size = new System.Drawing.Size(196, 25);
            this.searchTxtbx.TabIndex = 30;
            // 
            // manageLbl
            // 
            this.manageLbl.AutoSize = true;
            this.manageLbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageLbl.Location = new System.Drawing.Point(177, 50);
            this.manageLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.manageLbl.Name = "manageLbl";
            this.manageLbl.Size = new System.Drawing.Size(74, 23);
            this.manageLbl.TabIndex = 31;
            this.manageLbl.Text = "Manage";
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.Location = new System.Drawing.Point(418, 51);
            this.searchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(94, 20);
            this.searchLbl.TabIndex = 32;
            this.searchLbl.Text = "Search by Id";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(476, 9);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(264, 28);
            this.titleLbl.TabIndex = 33;
            this.titleLbl.Text = "Platform Moderator Home";
            // 
            // PlatformModerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 471);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.manageLbl);
            this.Controls.Add(this.searchTxtbx);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.mngUserBtn);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.mngRepBtn);
            this.Controls.Add(this.mngRevBtn);
            this.Controls.Add(this.myAccBtn);
            this.Controls.Add(this.mhmDgv);
            this.Controls.Add(this.helloLbl);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PlatformModerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlatformModerator";
            this.Load += new System.EventHandler(this.PlatformModerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mhmDgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloLbl;
        private System.Windows.Forms.DataGridView mhmDgv;
        private System.Windows.Forms.Button myAccBtn;
        private System.Windows.Forms.Button mngRevBtn;
        private System.Windows.Forms.Button mngRepBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button mngUserBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox typeTxtbx;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox passTxtbx;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTxtbx;
        private System.Windows.Forms.TextBox mailTxtbx;
        private System.Windows.Forms.TextBox idTxtBx;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.TextBox searchTxtbx;
        private System.Windows.Forms.Label manageLbl;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button newBtn;
    }
}