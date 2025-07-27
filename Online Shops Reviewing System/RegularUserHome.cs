using Microsoft.SqlServer.Server;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Online_Shops_Reviewing_System
{
    public partial class RegularUserHome : Form
    {
        int myId;
        string category = "";
        DataTable dt = new DataTable();
        public RegularUserHome(int id)
        {
            myId = id;
            InitializeComponent();
        }
        private void ClearFields()
        {
            selIdTextbx.Text = "";
            selNameTxtbx.Text = "";
        }

        private void btnBrowseShop_Click(object sender, EventArgs e)
        {
            browseLbl.Text = "Browse Shops";
            string query = "SELECT * FROM [Shop]";
            dt = DataAccess.LoadData(query);
            if (dt != null)
            {
                dgvShopProduct.DataSource = dt;
                dgvShopProduct.Refresh();
            }
            else
            {
                MessageBox.Show("No shops found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            category = "";
            categoryCmbbx.SelectedIndex= -1;
        }

        private void btnBrowseProduct_Click(object sender, EventArgs e)
        {
            browseLbl.Text = "Browse Products";
            string query = "SELECT * FROM [Product]";
            dt = DataAccess.LoadData(query);
            if (dt != null)
            {
                dgvShopProduct.DataSource = dt;
                dgvShopProduct.Refresh();
            }
            else
            {
                MessageBox.Show("No products found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            category = "";
            categoryCmbbx.SelectedIndex= -1;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (browseLbl.Text == "Browse Shops")
            {
                if (category != "")
                {
                    string query = $"SELECT * FROM [Shop] WHERE [Category] = '{category}'";
                    dt = DataAccess.LoadData(query);
                    dgvShopProduct.DataSource = dt;
                    dgvShopProduct.Refresh();
                }
                else
                {
                    string query = "SELECT * FROM [Shop]";
                    dt = DataAccess.LoadData(query);
                    dgvShopProduct.DataSource = dt;
                    dgvShopProduct.Refresh();
                }
            }
            else if (browseLbl.Text == "Browse Products")
            {
                if (category != "")
                {
                    string query = $"SELECT * FROM[Product_Shop] WHERE [Shop_Id] IN (SELECT[Shop_Id] FROM[Shop] WHERE[Category] = '{category}')";
                    dt = DataAccess.LoadData(query);
                    dgvShopProduct.DataSource = dt;
                    dgvShopProduct.Refresh();
                }
                else
                {
                    string query = "SELECT * FROM [Product]";
                    dt = DataAccess.LoadData(query);
                    dgvShopProduct.DataSource = dt;
                    dgvShopProduct.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please select a browse option to refresh.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.ClearFields();
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyAccount ma = new MyAccount(myId);
            ma.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.No)
            {
                return;
            }
            this.Hide();
            LoginFrame lf = new LoginFrame();
            lf.Show();
        }

        private void dgvShopProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selIdTextbx.Text = dgvShopProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                selNameTxtbx.Text = dgvShopProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void categoryCmbbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryCmbbx.SelectedIndex == -1)
            {
                category = "";
            }
            else
            {
                category = categoryCmbbx.SelectedItem.ToString();
            }
        }

        private void btnGiveReview_Click(object sender, EventArgs e)
        {
            if (selIdTextbx.Text == "" || selNameTxtbx.Text == "")
            {
                MessageBox.Show("Please select a shop or product to review.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = Convert.ToInt32(selIdTextbx.Text);
            if (browseLbl.Text == "Browse Shops")
            {
                GiveShopReview reviewShop = new GiveShopReview(myId, id);
                reviewShop.Show();
                this.Hide();
            }
            else if (browseLbl.Text == "Browse Products")
            {
                GiveProductReview gpr = new GiveProductReview(myId, id);
                gpr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a shop or product to review.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadReview_Click(object sender, EventArgs e)
        { 
            string type = browseLbl.Text == "Browse Shops" ? "Shop" : "Product";
            if (selIdTextbx.Text == "")
            {
                MessageBox.Show("Please select a shop or product to read reviews.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int selectedId = int.Parse(selIdTextbx.Text);
            ViewReviewFrame vrf = new ViewReviewFrame(myId, selectedId, type);
            vrf.Show();
            this.Hide();
        }

        private void RegularUserHome_Load(object sender, EventArgs e)
        {

        }
    }

}

