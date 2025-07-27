using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Shops_Reviewing_System
{
    public partial class MakeReport : Form
    {
        int myId, reviewId, reportId;
        public MakeReport(int myId, int reviewId)
        {
            this.myId = myId;
            this.reviewId = reviewId;
            InitializeComponent();
        }

        private void MakeReport_Load(object sender, EventArgs e)
        {
            string query = $"SELECT MAX([Report_Id]) FROM [Report];";
            DataTable dt = DataAccess.LoadData(query);
            reportId = dt.Rows[0][0] == DBNull.Value ? 1 : Convert.ToInt32(dt.Rows[0][0]) + 1;
            txtReportId.Text = reportId.ToString();
            txtReviewId.Text = reviewId.ToString();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM [User] WHERE [User_Id] = {myId}";
            DataTable userData = DataAccess.LoadData(query);
            string userType = userData.Rows[0]["Type"].ToString();
            if (userType == "ShopAdmin")
            {
                ShopAdminHomeFrame shm = new ShopAdminHomeFrame(myId);
                shm.Show();
                this.Hide();
            }
            else
            {
                RegularUserHome regularUserHome = new RegularUserHome(myId);
                regularUserHome.Show();
                this.Hide();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string desc = descTxtbx.Text;
            if (desc == "")
            {
                MessageBox.Show("Please enter report details.");
                descTxtbx.Focus();
                return;
            }
            string reason = txtReason.Text;
            if(reason == "")
            {
                MessageBox.Show("Please enter a reason for the report.");
                txtReason.Focus();
                return;
            }
            string status = "Pending";
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string query = $"INSERT INTO [Report] ([Report_Id], [Reason], [Report_Date], [Report_Desc], [Status], [Review_Id], [User_Id]) VALUES ({reportId}, '{reason}', '{date}', '{desc}', '{status}', {reviewId}, {myId});";
            DataAccess.AddData(query);
            DialogResult res = MessageBox.Show("Report submitted successfully. Do you want to make another report?", "Report Submitted", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                this.MakeReport_Load(sender, e);
            }
            else
            {
                this.backBtn_Click(sender, e);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtReason.Clear();
            descTxtbx.Clear();
        }
    }
}

