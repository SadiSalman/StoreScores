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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Online_Shops_Reviewing_System
{
    public partial class PlatformModerator : Form
    {
        int myId;
        public PlatformModerator(int Id)
        {
            InitializeComponent();
            myId = Id;
        }
        private void ClearFields()
        {
            idTxtBx.Text = "";
            idTxtBx.Enabled = true;
            nameTxtbx.Text = "";
            mailTxtbx.Text = "";
            passTxtbx.Text = "";
            typeTxtbx.Text = "";
            searchTxtbx.Text = "";
        }
        private void myAccBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyAccount ma = new MyAccount(myId);
            ma.Show();
        }

        private void mngUserBtn_Click(object sender, EventArgs e)
        {
            manageLbl.Text = "Manage Users";
            this.refreshBtn_Click(sender, e);
        }

        private void mngRevBtn_Click(object sender, EventArgs e)
        {
            ManageReview mr = new ManageReview(myId, 0);
            mr.Show();
            this.Hide();
        }

        private void mngRepBtn_Click(object sender, EventArgs e)
        {
            ReportManagement repm = new ReportManagement(myId);
            repm.Show();
            this.Hide();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            string query = "";
            if (manageLbl.Text == "Manage Users")
            {
                query = "SELECT * FROM [User] WHERE Type = 'Regular'";
            }
            else
            {
                MessageBox.Show("Please press the manage regular user button to enable this feature.");
                return;
            }
            mhmDgv.DataSource = DataAccess.LoadData(query);
            mhmDgv.Refresh();
            idTxtBx.Enabled = true;
            this.ClearFields();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int id = idTxtBx.Text == "" ? 0 : Int32.Parse(idTxtBx.Text);

            string name = nameTxtbx.Text;
            if (name == "")
            {
                MessageBox.Show("Please enter a valid name.");
                nameTxtbx.Focus();
                return;
            }

            string email = mailTxtbx.Text;
            if (email == "" || email.Contains("@") == false || email.Contains(".") == false)
            {
                MessageBox.Show("Please enter a valid email.");
                mailTxtbx.Focus();
                return;
            }

            string password = passTxtbx.Text;
            if (password == "")
            {
                MessageBox.Show("Please enter a valid password.");
                passTxtbx.Focus();
                return;
            }

            string type = "Regular";

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
                id = Int32.Parse(idTxtBx.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid ID.");
                idTxtBx.Focus();
                return;
            }

            string name = nameTxtbx.Text;
            if (name == "")
            {
                MessageBox.Show("Please enter a valid name.");
                nameTxtbx.Focus();
                return;
            }

            string email = mailTxtbx.Text;
            if (email == "" || email.Contains("@") == false || email.Contains(".") == false)
            {
                MessageBox.Show("Please enter a valid email.");
                mailTxtbx.Focus();
                return;
            }

            string password = passTxtbx.Text;
            if (password == "")
            {
                MessageBox.Show("Please enter a valid password.");
                passTxtbx.Focus();
                return;
            }

            string type = "Regular";

            string query = $"UPDATE [User] SET [Name] = '{name}', [Email] = '{email}', [Type] = '{type}', [Password] = '{password}' WHERE [User_Id] = '{id}'";
            DataAccess.UpdateData(query);
            MessageBox.Show("User updated successfully.");
            this.ClearFields();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idTxtBx.Text);
            if (id <= 0)
            {
                MessageBox.Show("Please enter a valid ID.");
                idTxtBx.Focus();
                return;
            }
            string query = $"DELETE FROM [User] WHERE [User_Id] = {id}";
            DataAccess.DeleteData(query);
            MessageBox.Show("User deleted successfully.");
            this.refreshBtn_Click(sender, e);
            this.ClearFields();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = Int32.Parse(searchTxtbx.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid ID.");
                searchTxtbx.Focus();
                return;
            }
            string query = $"SELECT * FROM [User] WHERE [User_Id] = {id}";
            DataTable dt = DataAccess.LoadData(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["Type"].ToString() == "Regular")
                {
                    mhmDgv.Columns.Clear();
                    mhmDgv.DataSource = dt;
                    mhmDgv.Refresh();
                    idTxtBx.Text = dt.Rows[0]["User_Id"].ToString();
                    idTxtBx.Enabled = false;
                    nameTxtbx.Text = dt.Rows[0]["Name"].ToString();
                    mailTxtbx.Text = dt.Rows[0]["Email"].ToString();
                    passTxtbx.Text = dt.Rows[0]["Password"].ToString();
                    typeTxtbx.Text = dt.Rows[0]["Type"].ToString();
                }
            }
            else
            {
                MessageBox.Show("No User found with the given ID.");
                return;
            }
        }

        private void mhmDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idTxtBx.Text = mhmDgv.Rows[e.RowIndex].Cells["User_Id"].Value.ToString();
                idTxtBx.Enabled = false;
                nameTxtbx.Text = mhmDgv.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                mailTxtbx.Text = mhmDgv.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                passTxtbx.Text = mhmDgv.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                typeTxtbx.Text = mhmDgv.Rows[e.RowIndex].Cells["Type"].Value.ToString();
            }

        }

        private void logOutBtn_Click(object sender, EventArgs e)
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

        private void PlatformModerator_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM [User] WHERE [User_Id] = {myId};";
            DataTable dt = DataAccess.LoadData(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                helloLbl.Text = "Hello, " + dt.Rows[0]["Name"].ToString() + "!";
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            this.ClearFields();
            int uId;
            string query = $"SELECT MAX([User_Id]) FROM [User];";
            DataTable dt = DataAccess.LoadData(query);
            uId = dt.Rows[0][0] == DBNull.Value ? 1 : Convert.ToInt32(dt.Rows[0][0]) + 1;
            idTxtBx.Text = uId.ToString();
        }
    }
}
