using System;
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
    public partial class CreateShopFrame : Form
    {
        int ShopAdmin_Id;
        public CreateShopFrame(int adminId)
        {
            ShopAdmin_Id = adminId;
            InitializeComponent();
        }

        private void CityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CityComboBox.SelectedItem == null)
                return;
            var City = CityComboBox.SelectedItem.ToString();

            string[] Area;
            if (City == "Dhaka")
            {
                Area = new string[] { "Dhaka", "Khilkhet", "Gulshan" };
            }

            else if (City == "Chittagong")
            {
                Area = new string[] { "Agrabad", "Cox Bazar", "Feni" };
            }

            else
            {
                Area = new string[] { "Natore", "Janina", "Unknown" };
            }

            AreaComboBox.DataSource = Area;

        }

        private void btnShopSignUP_Click(object sender, EventArgs e)
        {
            string Shop_Name = txtName.Text;
            if(Shop_Name == "")
            {
                MessageBox.Show("Invalid Shop Name");
                txtName.Focus();
                return;
            }


            int shop_id;
            try
            {
                shop_id = Int32.Parse(txtID.Text);
            }
            catch
            {
                MessageBox.Show("Please enter an integer as ID.");
                txtID.Focus();
                return;
            }
            string query = $"SELECT * FROM [User] WHERE [User_Id] = '{shop_id}'";
            DataTable dt = DataAccess.LoadData(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show("This ID already exists. Please choose a different ID.");
                txtID.Focus();
                return;
            }

            string Category;
            if (catCmbbx.SelectedIndex == -1)
            {
                MessageBox.Show("Choose a Shop Category");
                catCmbbx.Focus();
                return;
            }
            else
            {
                Category = catCmbbx.SelectedItem.ToString();
            }

            string Delivery_Option = "";
            if (expCkbx.Checked == true && stndCkBx.Checked == true)
            {
                Delivery_Option = "Express,Standard";
            }
            else if (expCkbx.Checked == true && stndCkBx.Checked == false)
            {
                Delivery_Option = "Express";
            }
            else if(expCkbx.Checked == false && stndCkBx.Checked == true)
            {
                Delivery_Option = "Standard";
            }
            else
            {
                MessageBox.Show("Please select a delivery option");
                return;
            }

                string Service_Hour = txtServiceHour.Text;
            if (string.IsNullOrWhiteSpace(Service_Hour))
            {
                MessageBox.Show("Invalid Service Hour");
                txtServiceHour.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtShopAdminId.Text))
            {
                MessageBox.Show("Invalid Shop Admin ID");
                txtShopAdminId.Focus();
                return;
            }
            txtShopAdminId.Text = ShopAdmin_Id.ToString();


            if (CityComboBox.SelectedItem == null)
            {
                MessageBox.Show("Invalid City");
                CityComboBox.Focus();
                return;
            }
            string City = CityComboBox.SelectedItem.ToString();


            if (AreaComboBox.SelectedItem == null)
            {
                MessageBox.Show("Invalid City");
                AreaComboBox.Focus();
                return;
            }
            string Area = AreaComboBox.SelectedItem.ToString();

            string Road = txtBoxRoad.Text;

            string House_No = txtHouse.Text;


            MessageBox.Show(
            "Shop ID: " + shop_id + "\n" +
            "Shop Name: " + Shop_Name + "\n" +
            "Category: " + Category + "\n" +
            "Delivery Option: " + Delivery_Option + "\n" +
            "Service Hour: " + Service_Hour + "\n" +
            "Shop Admin ID: " + ShopAdmin_Id + "\n" +
            "Verified Status: False" + "\n" +
            "Premium Status: False" + "\n" +
            "Review Count: " + 0 + "\n" +
            "Shop Rating: " + 0 + "\n" +
            "City: " + City + "\n" +
            "Area: " + Area + "\n" +
            "Road: " + Road + "\n" +
            "House No: " + House_No,
            "Shop Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            query = $"INSERT INTO [dbo].[Shop] VALUES ({shop_id}, '{Shop_Name}', '{Category}', 0 , 0, '{Delivery_Option}', '{Service_Hour}', 0, {ShopAdmin_Id}, '{City}', '{Area}', '{Road}', '{House_No}', 0)";
            DataAccess.AddData(query);
            MessageBox.Show("You can now Access your shop from your profile. Go back to login page and log into your account");
        }

        private void CreateShopFrame_Load(object sender, EventArgs e)
        {
            txtShopAdminId.Text = ShopAdmin_Id.ToString();
            txtShopAdminId.Enabled = false;
            int shopId;
            string query = $"SELECT MAX([Shop_Id]) FROM [SHop];";
            DataTable dt = DataAccess.LoadData(query);
            shopId = dt.Rows[0][0] == DBNull.Value ? 1 : Convert.ToInt32(dt.Rows[0][0]) + 1;
            txtID.Text = shopId.ToString();
        }

        private void btnBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFrame lf = new LoginFrame();
            lf.Show();
        }
    }
}
