using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Online_Shops_Reviewing_System
{
    public partial class Admin_Home_Frame : Form
    {
        int myId;
        public Admin_Home_Frame(int Id)
        {
            InitializeComponent();
            myId = Id;
        }

        

        private void ClearFields()
        {
            idTxtbx.Text = "";
            nameTxtbx.Text = "";
            emailTxtbx.Text = "";
            passTxtbx.Text = "";
        }

        private void mngShpAdminBtn_Click(object sender, EventArgs e)
        {
            manageLbl.Text = "Manage ShopAdmins";
            this.refreshBtn_Click(sender, e);
        }

        private void mngMdrtrBtn_Click(object sender, EventArgs e)
        {
            manageLbl.Text = "Manage Moderators";
            this.refreshBtn_Click(sender, e);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int id = idTxtbx.Text == "" ? 0 : Int32.Parse(idTxtbx.Text);

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

            string type = "";
            if (manageLbl.Text == "Manage ShopAdmins")
            {
                type = "ShopAdmin";
            }
            else if (manageLbl.Text == "Manage Moderators")
            {
                type = "Moderator";
            }
            else
            {
                MessageBox.Show("Please select a valid management option.");
                return;
            }

            string query = $"INSERT INTO [User] ([User_Id], [Name], [Email], [Photo], [Type], [Password]) VALUES ({id}, '{name}', '{email}',Null, '{type}', '{password}')";
            DataAccess.AddData(query);
            MessageBox.Show("User added successfully.");
            this.ClearFields();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = Int32.Parse(idTxtbx.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid ID.");
                idTxtbx.Focus();
                return;
            }

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

            string type = "";
            if (manageLbl.Text == "Manage ShopAdmins")
            {
                type = "ShopAdmin";
            }
            else if (manageLbl.Text == "Manage Moderators")
            {
                type = "Moderator";
            }
            else
            {
                MessageBox.Show("Please select a valid management option.");
                return;
            }
            string query = $"UPDATE [User] SET [Name] = '{name}', [Email] = '{email}', [Type] = '{type}', [Password] = '{password}' WHERE [User_Id] = '{id}'";
            DataAccess.UpdateData(query);
            MessageBox.Show("User updated successfully.");
            this.ClearFields();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idTxtbx.Text);
            if (id <= 0)
            {
                MessageBox.Show("Please enter a valid ID.");
                idTxtbx.Focus();
                return;
            }
            string query = $"DELETE FROM [User] WHERE [User_Id] = {id}";
            DataAccess.DeleteData(query);
            this.ClearFields();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            string query = "";
            if (manageLbl.Text == "Manage ShopAdmins")
            {
                query = "SELECT * FROM [User] WHERE Type = 'ShopAdmin'";
            }
            else if (manageLbl.Text == "Manage Moderators")
            {
                query = "SELECT * FROM [User] WHERE Type = 'Moderator'";
            }
            else
            {
                MessageBox.Show("Please select a valid management option.");
            }
            ahmDgv.DataSource = DataAccess.LoadData(query);
            ahmDgv.Refresh();
            this.ClearFields();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            int id;
            try
            {
                id = Int32.Parse(searchIdTxtbx.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid ID.");
                searchIdTxtbx.Focus();
                return;
            }
            string query = $"SELECT * FROM [User] WHERE [User_Id] = {id}";
            DataTable dt = DataAccess.LoadData(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["Type"].ToString() == "ShopAdmin" || dt.Rows[0]["Type"].ToString() == "Moderator")
                {
                    ahmDgv.Columns.Clear();
                    ahmDgv.DataSource = dt;
                    ahmDgv.Refresh();
                    idTxtbx.Text = dt.Rows[0]["User_Id"].ToString();
                    idTxtbx.Enabled = false;
                    nameTxtbx.Text = dt.Rows[0]["Name"].ToString();
                    emailTxtbx.Text = dt.Rows[0]["Email"].ToString();
                    passTxtbx.Text = dt.Rows[0]["Password"].ToString();
                }
            }
            else
            {
                MessageBox.Show("No Moderator or ShopAdmin found with the given ID.");
                return;
            }
        }

        private void ahmDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idTxtbx.Text = ahmDgv.Rows[e.RowIndex].Cells["User_Id"].Value.ToString();
                idTxtbx.Enabled = false;
                nameTxtbx.Text = ahmDgv.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                emailTxtbx.Text = ahmDgv.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                passTxtbx.Text = ahmDgv.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            }

        }

        private void lgoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Are you sure?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.No )
            {
                return;
            }
            this.Hide();
            LoginFrame lf = new LoginFrame();
            lf.Show();
        }
        private void accBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyAccount ma = new MyAccount(myId);
            ma.Show();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            this.ClearFields();
            int uId;
            string query = $"SELECT MAX([User_Id]) FROM [User];";
            DataTable dt = DataAccess.LoadData(query);
            uId = dt.Rows[0][0] == DBNull.Value ? 1 : Convert.ToInt32(dt.Rows[0][0]) + 1;
            idTxtbx.Text = uId.ToString();
        }
    }
}
