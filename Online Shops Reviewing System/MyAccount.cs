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
    public partial class MyAccount : Form
    {
        int Id;
        string type;
        public MyAccount(int Id)
        {
            InitializeComponent();
            this.Id = Id;
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {
            idTxtbx.Text = Id.ToString();
            string query = $"SELECT * FROM [User] WHERE [User_Id] = '{Id}'";
            DataTable dt = DataAccess.LoadData(query);
            nameTxtbx.Text = dt.Rows[0]["Name"].ToString();
            emailTxtbx.Text = dt.Rows[0]["Email"].ToString();
            passTxtbx.Text = dt.Rows[0]["Password"].ToString();
            typeTxtbx.Text = dt.Rows[0]["Type"].ToString();
            type = dt.Rows[0]["Type"].ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxtbx.Text;
            if (name == "")
            {
                MessageBox.Show("Please enter a valid name.");
                nameTxtbx.Focus();
                return;
            }

            string email = emailTxtbx.Text;
            if (email == "" || email.Contains("@") == false || email.Contains(".") == false)
            {
                MessageBox.Show("Please enter a valid email.");
                emailTxtbx.Focus();
                return;
            }

            string password = passTxtbx.Text;
            if (password == "")
            {
                MessageBox.Show("Please enter a valid password.");
                passTxtbx.Focus();
                return;
            }
            string query = $"UPDATE [User] SET [Name] = '{name}', [Email] = '{email}', [Password] = '{password}' WHERE [User_Id] = '{Id}'";
            DataAccess.AddData(query);
            this.Refresh();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (type == "Admin")
            {
                Admin_Home_Frame adminDashboard = new Admin_Home_Frame(Id);
                adminDashboard.Show();
                this.Hide();
            }
            else if (type == "Moderator")
            {
                PlatformModerator moderatorDashboard = new PlatformModerator(Id);
                moderatorDashboard.Show();
                this.Hide();
            }
            else if (type == "ShopAdmin")
            {
                ShopAdminHomeFrame shopAdminDashboard = new ShopAdminHomeFrame(Id);
                shopAdminDashboard.Show();
                this.Hide();
            }
            else
            {
                RegularUserHome ru = new RegularUserHome(Id);
                ru.Show();
                this.Hide();
            }
        }
    }
}
