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
    public partial class ManageShopDetails : Form
    {
        int shopId;
        int shopAdmin_id;
        public ManageShopDetails(int shopId, int shopAdmin_id)
        {
            InitializeComponent();
            this.shopId = shopId;
            this.shopAdmin_id = shopAdmin_id;
        }

        private void ManageShopDetails_Load(object sender, EventArgs e)
        {
            txtShop_ID.Text = shopId.ToString();
            txtShop_AdminId.Text = shopAdmin_id.ToString();

            string query = $"SELECT * FROM [shop] WHERE [Shop_Id]={shopId}";
            DataTable dt = DataAccess.LoadData(query);


            query = $"SELECT * FROM [shop] WHERE [Shop_Id]={shopId}";
            dt = DataAccess.LoadData(query);

            if (dt.Rows.Count > 0)
            {
                txtShop_Name.Text = dt.Rows[0]["Shop_Name"].ToString();
                string DeliveryOption = dt.Rows[0]["Delivery_Option"].ToString();

                chkExpress.Checked = DeliveryOption.Contains("Express");
                chkStandard.Checked = DeliveryOption.Contains("Standard");

                txtService_Hour.Text = dt.Rows[0]["Service_Hour"].ToString();
                cmbCity.SelectedItem = dt.Rows[0]["City"].ToString();
                cmbArea.SelectedItem = dt.Rows[0]["Area"].ToString();
                txtRoad.Text = dt.Rows[0]["Road"].ToString();
                txtHouse.Text = dt.Rows[0]["House_No"].ToString();
                txtCategory.Text = dt.Rows[0]["Category"].ToString();
                txtPremiumStatus.Text = dt.Rows[0]["Premium_Status"].ToString();
                txtVerifiedStatus.Text = dt.Rows[0]["Verified_Status"].ToString();
                txtShop_Rating.Text = dt.Rows[0]["Shop_Rating"].ToString();
                txtReviewCount.Text = dt.Rows[0]["ReviewCount"].ToString();
            }
            else
            {
                MessageBox.Show("No shop data found for the given Shop ID.", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            DateTime now = DateTime.Now;
            query = $"SELECT * FROM [Subscription] WHERE [Shop_Id] = {shopId} AND '{now:yyyy-MM-dd}' BETWEEN [Sub_Start_Date] AND [Sub_End_Date]";
            dt = DataAccess.LoadData(query);
            if (dt.Rows.Count > 0)
            {
                txtPremiumStatus.Text = "True";
                query = $"UPDATE [Shop] SET [Premium_Status] = 1 WHERE [Shop_Id] = {shopId}";
                DataAccess.UpdateData(query);
            }
            else
            {
                txtPremiumStatus.Text = "False";
                query = $"UPDATE [Shop] SET [Premium_Status] = 0 WHERE [Shop_Id] = {shopId}";
                DataAccess.UpdateData(query);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            string shopName = txtShop_Name.Text;
            if (txtShop_Name.Text == "")
            {
                MessageBox.Show("Please enter a Shop Name");
                return;
            }

            string DeliveryOption = "";
            if (chkExpress.Checked == true && chkStandard.Checked == true)
            {
                DeliveryOption = "Express, Standard";
            }
            else if (chkExpress.Checked == true && chkStandard.Checked==false)
            {
                DeliveryOption = "Express";
            }
            else if (chkStandard.Checked == false && chkStandard.Checked==true)
            {
                DeliveryOption = "Standard";
            }
            else
            {
                MessageBox.Show("Please select a delivery option.");
                return;
            }


            string serviceHour = txtService_Hour.Text;
            if (txtService_Hour.Text == "")
            {
                MessageBox.Show("Please enter a Service Hour");
                return;
            }

            

            string cities= cmbCity.SelectedItem.ToString();
            if (cmbCity.SelectedItem == null)
            {
                MessageBox.Show("Please select a city.");
                return;
            }

            string area = cmbArea.SelectedItem.ToString();

            if(cmbArea.SelectedItem==null)
            {
                MessageBox.Show("Please select area");
                return;
            }



            string road = txtRoad.Text;
            if (txtRoad.Text == "")
            {
                MessageBox.Show("Please enter Road Name or Number");
                return;
            }

            string house = txtHouse.Text;
            if (txtHouse.Text == "")
            {
                MessageBox.Show("Please enter House Name or Number");
                return;
            }

            string query = $"UPDATE [Shop] SET [Shop_Name]='{shopName}',[Delivery_Option]='{DeliveryOption}',[Service_Hour]='{serviceHour}',[City]='{cities}',[Area]='{area},[Road]='{road},[House_No]='{house}'";
            DataAccess.UpdateData(query);
            this.Refresh();


        }

       
        private void cmbCity_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbCity.SelectedItem == null)
            {
                MessageBox.Show("Please select a city.");
                return;
            }
            var city = cmbCity.SelectedItem.ToString();
            string[] area;
            if (city == "Dhaka")
            {
                area = new string[] { "Dhanmondi", "Gulshan", "Bashundhara", "Uttara", "Mirpur" };
            }
            else if (city == "Chittagong")
            {
                area = new string[] { "Agrabad", "Halishahar", "Pahartali", "Bashundhara" };
            }
            else if (city == "Sylhet")
            {
                area = new string[] { "Zindabazar", "Ambarkhana", "Subidbazar" };
            }
            else if (city == "Rajshahi")
            {
                area = new string[] { "Shaheb Bazar", "Chhoto Bogura", "Shah Makhdum" };
            }
            else if (city == "Khulna")
            {
                area = new string[] { "Sonadanga", "Bashundhara" };
            }
            else
            {
                MessageBox.Show("Please select a valid city.");
                return;
            }
            cmbArea.DataSource = area;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopAdminHomeFrame shopAdminHomeFrame = new ShopAdminHomeFrame(shopAdmin_id);
            shopAdminHomeFrame.Show();
        }

        private void btnBuySubscription_Click(object sender, EventArgs e)
        {
            this.Hide();
            Buy_Premium_Frame buyPremiumFrame = new Buy_Premium_Frame(shopId, shopAdmin_id);
            buyPremiumFrame.Show();
        }
    }
}