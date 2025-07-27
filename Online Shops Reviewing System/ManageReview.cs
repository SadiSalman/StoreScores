using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Shops_Reviewing_System
{
    public partial class ManageReview : Form
       
    {
        int myId, reviewId;
        public ManageReview(int userId, int revId)
        {
            myId = userId;
            reviewId = revId;
            if (revId != 0)
            {
                InitializeComponent();
                txtSearchId.Text = revId.ToString();
                this.searchBtn_Click(null, null);
            }
            else
            {
                InitializeComponent();
            }
        }

        private void clearFields()
        {
            txtReviewId.Text = "";
            txtReviewDate.Text = "";
            rtxtReviewDescription.Text = "";
            txtUserId.Text = "";
            txtRating.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string description = rtxtReviewDescription.Text;
            if(rtxtReviewDescription.Text=="")
            {
                MessageBox.Show("Please enter review description");
                return;
            }
            int reviewId = Int32.Parse(txtReviewId.Text);
            string query = $"UPDATE [Review] SET [Review_Desc]='{description}' WHERE [Review_Id]='{reviewId}' ";
            DataAccess.UpdateData(query);

            MessageBox.Show("Review updated successfully");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM [Review];";
            DataTable dt = DataAccess.LoadData(query);
            dgvManageReview.DataSource = dt;
            dgvManageReview.Refresh();

            this.clearFields();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            reviewId = Int32.Parse(txtSearchId.Text);
            if (reviewId <= 0)
            {
                MessageBox.Show("Please enter a valid Review ID");
                return;
            }
            string query = $"SELECT * FROM [Review] WHERE [Review_Id]='{reviewId}'";
            DataTable dt = DataAccess.LoadData(query);
            dgvManageReview.DataSource = dt;
            dgvManageReview.Refresh();

            txtReviewId.Text = dt.Rows[0]["Review_Id"].ToString();
            txtReviewDate.Text = dt.Rows[0]["Review_Date"].ToString();
            txtRating.Text = dt.Rows[0]["Rating"].ToString();
            rtxtReviewDescription.Text = dt.Rows[0]["Review_Desc"].ToString();
            txtUserId.Text = dt.Rows[0]["RegularUser_Id"].ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PlatformModerator pm = new PlatformModerator(myId);
            pm.Show();
            this.Hide();
        }

        private void dgvManageReview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvManageReview.Rows.Count)
            {
                return;
            }
            txtReviewId.Text = dgvManageReview.Rows[e.RowIndex].Cells["Review_Id"].Value.ToString();
            txtReviewDate.Text = dgvManageReview.Rows[e.RowIndex].Cells["Review_Date"].Value.ToString();
            txtRating.Text = dgvManageReview.Rows[e.RowIndex].Cells["Rating"].Value.ToString();
            rtxtReviewDescription.Text = dgvManageReview.Rows[e.RowIndex].Cells["Review_Desc"].Value.ToString();
            txtUserId.Text = dgvManageReview.Rows[e.RowIndex].Cells["RegularUser_Id"].Value.ToString();
        }
    }
}
