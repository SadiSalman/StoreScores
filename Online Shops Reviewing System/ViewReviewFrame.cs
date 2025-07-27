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
    public partial class ViewReviewFrame : Form
    {
        int myId, selectedId;
        string type;
        public ViewReviewFrame(int userId, int selId, string type)
        {
            myId = userId;
            selectedId = selId;
            this.type = type;
            InitializeComponent();
        }
        private void ClearFields()
        {
            txtReviewId.Text = "";
            txtReviewDate.Text = "";
            txtRating.Text = "";
            descriptionTxtbx.Text = "";
            reviewerNameTxtbx.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.ViewReviewFrame_Load(null, null);
        }

        private void revDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && revDgv.Rows[e.RowIndex] != null)
            {
                txtReviewId.Text = revDgv.Rows[e.RowIndex].Cells["Review_Id"].Value.ToString();
                txtReviewDate.Text = revDgv.Rows[e.RowIndex].Cells["Review_Date"].Value.ToString().Substring(0, 10);
                txtRating.Text = revDgv.Rows[e.RowIndex].Cells["Rating"].Value.ToString();
                descriptionTxtbx.Text = revDgv.Rows[e.RowIndex].Cells["Review_Desc"].Value.ToString();

                int reviewerId = Convert.ToInt32(revDgv.Rows[e.RowIndex].Cells["RegularUser_Id"].Value);
                string query = $"SELECT * FROM [User] WHERE [User_Id] = {reviewerId}";
                DataTable userData = DataAccess.LoadData(query);
                reviewerNameTxtbx.Text = userData.Rows[0]["Name"].ToString();
            }
            else
            {
                return;
            }
            

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

        private void reportBtn_Click(object sender, EventArgs e)
        {
            int reviewId = int.Parse(txtReviewId.Text);
            if (reviewId <= 0)
            {
                MessageBox.Show("Please select a valid review to report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MakeReport makeReport = new MakeReport(myId, reviewId);
            makeReport.Show();
            this.Hide();
        }

        private void ViewReviewFrame_Load(object sender, EventArgs e)
        {
            if (type == "Product")
            {
                string query = $"SELECT * FROM [Product] WHERE [Product_Id] = {selectedId}";
                DataTable dt = DataAccess.LoadData(query);
                selectedNameLbl.Text = "Product Name";
                selectedNameTxtbx.Text = dt.Rows[0]["Product_Name"].ToString();
                query = $"SELECT * FROM [Review] WHERE [Review_Id] IN (SELECT [Review_Id] FROM [Review_Product] WHERE [Product_Id] = {selectedId});";
                dt = DataAccess.LoadData(query);
                revDgv.DataSource = dt;
                revDgv.Refresh();
            }
            else if (type == "Shop")
            {

                string query = $"SELECT * FROM [Shop] WHERE [Shop_Id] = {selectedId}";
                DataTable dt = DataAccess.LoadData(query);
                selectedNameLbl.Text = "Shop Name";
                selectedNameTxtbx.Text = dt.Rows[0]["Shop_Name"].ToString();
                query = $"SELECT * FROM [Review] WHERE [Review_Id] IN (SELECT [Review_Id] FROM [Review_Shop] WHERE [Shop_Id] = {selectedId});";
                dt = DataAccess.LoadData(query);
                revDgv.DataSource = dt;
                revDgv.Refresh();
            }
            else
            {
                MessageBox.Show("Invalid type specified.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.ClearFields();
        }
    }
}
