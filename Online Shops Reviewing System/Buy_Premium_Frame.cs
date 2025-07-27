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
    public partial class Buy_Premium_Frame : Form
    {
        int myId;
        int shopId;
        public Buy_Premium_Frame(int shopId, int myId)
        {
            this.myId = myId;
            this.shopId = shopId;
            InitializeComponent();
        }

        string subPlan;
        private void btnBuy_Click(object sender, EventArgs e)
        {
            if(cmbSub.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a subscription plan.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                subPlan = cmbSub.SelectedItem.ToString();
            }
            if (dtpStart.Value.Date >= dtpEnd.Value.Date)
            {
                MessageBox.Show("End date must be after start date.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpStart.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Start date cannot be in the past.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string paymentStatus = "Pending";
            int subscriptionId = 1;
            string subStart, subEnd;   
            if (previousLbl.Visible == false)
            {
                paymentStatus = "Paid";
                string query = "SELECT MAX(Subscription_Id) FROM [Subscription];";
                DataTable dt = DataAccess.LoadData(query);
                if (dt != null && dt.Rows.Count > 0)
                {
                    subscriptionId = Convert.ToInt32(dt.Rows[0][0]);
                }
                subscriptionId++;
                subStart = dtpStart.Value.ToString("yyyy-MM-dd");
                subEnd = dtpEnd.Value.ToString("yyyy-MM-dd");
                query = $"INSERT INTO [Subscription] (Subscription_Id, Payment_Status, Sub_Plan, Sub_Start_Date, Sub_End_Date, Shop_Id) VALUES ({subscriptionId}, '{paymentStatus}', '{subPlan}', '{subStart}', '{subEnd}', {shopId});";
                DataAccess.AddData(query);
                DialogResult res = MessageBox.Show("Subscription purchased successfully!Would you like to purchase another one?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    this.Hide();
                    Buy_Premium_Frame bpf = new Buy_Premium_Frame(shopId, myId);
                    bpf.Show();
                }
                else
                {
                    this.Hide();
                    ManageShopDetails mg = new ManageShopDetails(shopId, myId);
                    mg.Show();
                }
            }
            else
            {
                MessageBox.Show("Error: Purchase Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageShopDetails mg = new ManageShopDetails(shopId, myId);
            mg.Show();
        }

        private void cmbSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSub.SelectedItem != null)
            {
                if (cmbSub.SelectedItem.ToString() == "Basic")
                {
                    txtCost.Text = "1$";
                }
                else if (cmbSub.SelectedItem.ToString() == "Premium")
                {
                    txtCost.Text = "2$";
                }
                else
                {
                    txtCost.Text = "";
                }
                txtTotalCost.Text = "";
            }
            calcTimer.Start();
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            calcTimer.Start();

        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            calcTimer.Start();
        }

        private void calcTimer_Tick(object sender, EventArgs e)
        {
            string query = $"SELECT MAX(Sub_End_Date) FROM [Subscription] WHERE Shop_Id = {shopId}";
            DataTable dt = DataAccess.LoadData(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                DateTime lastEndDate = Convert.ToDateTime(dt.Rows[0][0]);
                if (lastEndDate >= dtpStart.Value)
                {
                    previousLbl.Text = $"Previous Subscription End Date: {lastEndDate.ToString("yyyy-MM-dd")}";
                    previousLbl.Visible = true;
                    return;
                }
                else
                {
                    previousLbl.Visible = false;
                }
            }
            try
            {
                int totalDays = (dtpEnd.Value - dtpStart.Value).Days;
                double totalCost = 0;
                if (cmbSub.SelectedIndex == 0)
                {
                    totalCost = 1*totalDays;
                }
                else if (cmbSub.SelectedIndex == 1)
                {
                    totalCost = 2*totalDays;
                }
                else
                {
                    Console.WriteLine(totalDays);
                }
                txtTotalCost.Text = totalCost.ToString("F2") + "$";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error calculating total cost: " + ex.Message);
            }
        }
    }
}
