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
    public partial class LoginFrame : Form
    {
        public LoginFrame()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxtbx.Text;
            if (email == ""|| email.Contains("@")==false || email.Contains(".")==false)
            {
                MessageBox.Show("Please input a valid email!");
                emailTxtbx.Focus();
                return;
            }
            string pass = passTxtbx.Text;
            if(pass == "")
            {
                MessageBox.Show("Please input a valid password!");
                passTxtbx.Focus();
                return;
            }

            string query = $"SELECT * FROM [User] WHERE [Email] = '{email}'";
            DataTable dt = DataAccess.LoadData(query);
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("User not found. Please check your email.");
                emailTxtbx.Focus();
                return;
            }
            if (dt.Rows[0]["Password"].ToString() != pass)
            {
                MessageBox.Show("Incorrect password. Please try again.");
                passTxtbx.Focus();
                return;
            }
            int userId = Convert.ToInt32(dt.Rows[0]["User_Id"]);
            if (dt.Rows[0]["Type"].ToString() == "Admin")
            {
                Admin_Home_Frame adminFrame = new Admin_Home_Frame(userId);
                adminFrame.Show();
                this.Hide();
            }
            else if (dt.Rows[0]["Type"].ToString() == "Moderator")
            {
                PlatformModerator platformModerator = new PlatformModerator(userId);
                platformModerator.Show();
                this.Hide();
            }
            else if (dt.Rows[0]["Type"].ToString() == "Regular")
            {
                RegularUserHome regularUserHome = new RegularUserHome(userId);
                regularUserHome.Show();
                this.Hide();
            }
            else if(dt.Rows[0]["Type"].ToString() == "ShopAdmin")
            {
                query = $"SELECT * FROM [Shop] WHERE [ShopAdmin_Id] = '{userId}'";
                DataTable dtShop = DataAccess.LoadData(query);
                if (dtShop == null || dtShop.Rows.Count == 0)
                {
                    DialogResult dRes = MessageBox.Show("Would you like to create a shop profile?", "Shop not found", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dRes == DialogResult.Yes)
                    {
                        CreateShopFrame createShopFrame = new CreateShopFrame(userId);
                        createShopFrame.Show();
                        this.Hide();
                    }
                    else
                    {
                        return;
                    }
                }
                else 
                {
                    
                    ShopAdminHomeFrame saf = new ShopAdminHomeFrame(userId);
                    saf.Show();
                    this.Hide();
                }
            }
            else
            {
                emailTxtbx.Focus();
                return;
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp su = new SignUp();
            su.Show();
        }
    }
}
