using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Shops_Reviewing_System
{
    public partial class GiveProductReview : Form
    {
        double currentRating;
        int totalReviews;
        int myId;
        int pId, shopId;
        public GiveProductReview(int reviewerId, int productId)
        {
            myId = reviewerId;
            pId = productId;
            InitializeComponent();
        }

        private void GiveProductReview_Load(object sender, EventArgs e)
        {
            productIdTextbx.Text = pId.ToString();
            string query = $"SELECT * FROM [Product_Shop] WHERE [Product_Id] = '{pId}'";
            DataTable dt = DataAccess.LoadData(query);
            productNameTxtbx.Text = dt.Rows[0]["Product_Name"].ToString();
            totalReviews = Convert.ToInt32(dt.Rows[0]["ReviewCount"]);
            currentRating = (Convert.ToDouble(dt.Rows[0]["Product_Rating"])) * totalReviews;
            shopId = Convert.ToInt32(dt.Rows[0]["Shop_Id"]);
            query = $"SELECT * FROM [Shop] WHERE [Shop_Id] = {shopId}";
            dt = DataAccess.LoadData(query);
            shopNameTxtbx.Text = dt.Rows[0]["Shop_Name"].ToString();
            query = $"SELECT MAX([Review_Id]) FROM [Review];";
            dt = DataAccess.LoadData(query);
            int reviewId = dt.Rows[0][0] == DBNull.Value ? 1 : Convert.ToInt32(dt.Rows[0][0]) + 1;
            revIdTxtbx.Text = reviewId.ToString();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            int reviewId = Convert.ToInt32(revIdTxtbx.Text);
            string description = descTxtbx.Text;
            if (description == "")
            {
                MessageBox.Show("Please enter a review description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                descTxtbx.Focus();
                return;
            }
            double rating, newRating;
            DateTime reviewDate = DateTime.Now;
            string formattedDate = reviewDate.ToString("yyyy-MM-dd");
            if (ratingCmbbx.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a rating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                rating = Convert.ToDouble(ratingCmbbx.SelectedItem.ToString());
                newRating = (currentRating + rating) / (totalReviews + 1);
            }
            string query = $"INSERT INTO [Review] ([Review_Id], [Review_Date], [Rating], [Review_Desc], [Upvotes], [Downvotes], [RegularUser_Id]) VALUES ({reviewId}, '{formattedDate}', {rating}, '{description}', 0, 0, {myId}); INSERT INTO [Review_Product] ([Review_Id], [Product_Id], [Shop_Id]) VALUES({reviewId},{pId}, {shopId});";
            DataAccess.AddData(query);
            DialogResult res = MessageBox.Show("Do you want to leave another review?", "Review Submitted", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                descTxtbx.Clear();
                ratingCmbbx.SelectedIndex = -1;
            }
            else
            {
                this.backBtn_Click(sender, e);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegularUserHome rh = new RegularUserHome(myId);
            rh.Show();
        }
    }
}
