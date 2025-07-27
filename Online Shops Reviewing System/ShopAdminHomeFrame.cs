using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace Online_Shops_Reviewing_System
{
    public partial class ShopAdminHomeFrame : Form
    {
        int shopAdminId;
        int shopId;
        string btn = "";
        public ShopAdminHomeFrame(int shopAdmin)
        {
            this.shopAdminId = shopAdmin;
            InitializeComponent();
        }

        private void ClearProductFields()
        {
            txtProductId.Text = "";
            txtProductName.Text = "";
            txtProductPrice.Text = "";
            txtProductDescription.Text = "";
        }

        private void btnManP_Click(object sender, EventArgs e)
        {
            this.btnRefresh_Click(sender, e);
            btn = "ManageProduct";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int pId = txtProductId.Text == "" ? 0 : Int32.Parse(txtProductId.Text);

            string pName = txtProductName.Text;
            if (pName == "")
            {
                MessageBox.Show("Please enter a valid product name.");
                txtProductName.Focus();
                return;
            }
            double price;
            try
            {
                price = Double.Parse(txtProductPrice.Text);
                if (price < 0)
                {
                    MessageBox.Show("Please enter a valid price greater than or equal to 0.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid price.");
                txtProductPrice.Focus();
                return;
            }

            string description = txtProductDescription.Text;
            if (description == "")
            {
                MessageBox.Show("Please enter a valid product description.");
                txtProductDescription.Focus();
                return;
            }

            string query = $"INSERT INTO [Product] (Product_Id, Product_Name, Price, Product_Desc, Product_Rating, ReviewCount) VALUES ({pId}, '{pName}', {price}, '{description}', 0, 0); INSERT INTO [Product_Shop] (Product_Id, Product_Name, Price, Product_Desc, Product_Rating, Shop_Id, ReviewCount) VALUES ({pId}, '{pName}', {price}, '{description}', 0, {shopId}, 0);";
            DataAccess.AddData(query);
            MessageBox.Show("Product added successfully.");
            this.ClearProductFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int pId;
            pId = Int32.Parse(txtProductId.Text);

            string pName = txtProductName.Text;
            if (pName == "")
            {
                MessageBox.Show("Please enter a valid product name.");
                txtProductName.Focus();
                return;
            }

            double price;
            try
            {
                price = Double.Parse(txtProductPrice.Text);
                if (price < 0)
                {
                    MessageBox.Show("Please enter a valid price greater than or equal to 0.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid price.");
                txtProductPrice.Focus();
                return;
            }

            string description = txtProductDescription.Text;
            if (description == "")
            {
                MessageBox.Show("Please enter a valid product description.");
                txtProductDescription.Focus();
                return;
            }

            string query = $"UPDATE [Product] SET [Product_Name] = '{pName}', [Price] = {price}, [Product_Description] = '{description}' WHERE [Product_Id] = {pId}; UPDATE [Product_Shop] SET [Product_Name] = '{pName}', [Price] = {price}, [Product_Description] = '{description}' WHERE [Product_Id] = {pId};";
            DataAccess.UpdateData(query);
            MessageBox.Show("Product updated successfully.");
            this.ClearProductFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int pId;
            pId = Int32.Parse(txtProductId.Text);

            string query = $"DELETE FROM [Product] WHERE [Product_Id] = {pId}; DELETE FROM [Product_Shop] WHERE [Product_Id] = {pId};";
            DataAccess.DeleteData(query);
            this.ClearProductFields();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (btn != "ShopReview" && btn != "ProductReview")
            {
                string query = $"SELECT * FROM [Product_Shop] WHERE [Shop_Id] = {shopId};";
                shmDgv.DataSource = DataAccess.LoadData(query);
                shmDgv.Refresh();
                this.ClearProductFields();
            }
            else
            {
                return;
            }
            
        }

        private void btnGo_Click_1(object sender, EventArgs e)
        {
            int pId;
            try
            {
                pId = Int32.Parse(searchTxtbx.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid Product ID.");
                searchTxtbx.Focus();
                return;
            }
            string query = $"SELECT * FROM [Product] WHERE [Product_Id] = {pId} AND [Product_Id] IN (SELECT [Product_Id] FROM [Product_Shop] WHERE [Shop_Id] = {shopId});";
            DataTable dt = DataAccess.LoadData(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                shmDgv.Columns.Clear();
                shmDgv.DataSource = dt; 
                shmDgv.Refresh();
                txtProductId.Text = dt.Rows[0]["Product_Id"].ToString();
                txtProductId.Enabled = false;
                txtProductName.Text = dt.Rows[0]["Product_Name"].ToString();
                txtProductPrice.Text = dt.Rows[0]["Price"].ToString();
                txtProductDescription.Text = dt.Rows[0]["Product_Desc"].ToString();
            }
            else
            {
                MessageBox.Show("No product found from this shop with the given ID.");
                return;
            }
        }

        private void btnShopReview_Click(object sender, EventArgs e)
        {
            ViewReviewFrame viewReviewFrame = new ViewReviewFrame(shopAdminId, shopId, "Shop");
            viewReviewFrame.Show();
            this.Hide();
        }

        private void btnProView_Click(object sender, EventArgs e)
        {
            try
            {
                int pId = Int32.Parse(txtProductId.Text);
                ViewReviewFrame viewReviewFrame = new ViewReviewFrame(shopAdminId, pId, "Product");
                viewReviewFrame.Show();
                this.Hide();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please select a product first.");
                txtProductId.Focus();
            }
        }

        private void myAccBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyAccount myAccount = new MyAccount(shopAdminId);
            myAccount.Show();
        }

        private void shopBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageShopDetails manageShopDetails = new ManageShopDetails(shopId, shopAdminId);
            manageShopDetails.Show();
        }

        private void shmDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && btn == "ManageProduct")
            {
                txtProductId.Text = shmDgv.Rows[e.RowIndex].Cells["Product_Id"].Value.ToString();
                txtProductId.Enabled = false;
                txtProductName.Text = shmDgv.Rows[e.RowIndex].Cells["Product_Name"].Value.ToString();
                txtProductPrice.Text = shmDgv.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                txtProductDescription.Text = shmDgv.Rows[e.RowIndex].Cells["Product_Desc"].Value.ToString();
            }
        }

        private void ShopAdminHomeFrame_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM [Shop] WHERE [ShopAdmin_Id] = {shopAdminId}";
            DataTable dt = DataAccess.LoadData(query);
            shopId = Int32.Parse(dt.Rows[0]["Shop_Id"].ToString());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFrame loginForm = new LoginFrame();
            loginForm.Show();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            this.ClearProductFields();
            int pId;
            string query = $"SELECT MAX([Product_Id]) FROM [Product];";
            DataTable dt = DataAccess.LoadData(query);
            pId = dt.Rows[0][0] == DBNull.Value ? 1 : Convert.ToInt32(dt.Rows[0][0]) + 1;
            txtProductId.Text = pId.ToString();
        }
    }
}
