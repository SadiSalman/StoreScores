using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Online_Shops_Reviewing_System
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            passTxtbx.PasswordChar = '\0';
            cnPassTxtBx.PasswordChar = '\0';
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          passTxtbx.PasswordChar = '•';
            timer1.Stop();
        }

        private void txtConPass_TextChanged(object sender, EventArgs e)
        {
            if (passTxtbx.Text == "" || cnPassTxtBx.Text == "")
                return;
            if (cnPassTxtBx.Text != passTxtbx.Text)
            {
                errorLbl.Visible = true;
            }

            else
            {
                errorLbl.Visible = false;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            int id = int.TryParse(IdTxtbx.Text, out int parsedId) ? parsedId : 0;
            string query = $"SELECT * FROM [User] WHERE [User_Id] = '{id}'";
            DataTable dt = DataAccess.LoadData(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show("This ID already exists. Please choose a different ID.");
                IdTxtbx.Focus();
                return;
            }

            string name = nameTxtbx.Text;
            if (name == "")
            {
                MessageBox.Show("Please enter your name");
                nameTxtbx.Focus();

                return;
            }

            string email = txtEmail.Text;
            if (email == "" || email.Contains("@") == false || email.Contains(".") == false)
            {
                MessageBox.Show("Please enter a valid email address");
                txtEmail.Focus();
                return;
            }

            String pass = passTxtbx.Text;
            if (pass == "" || pass.Length < 4)
            {
                MessageBox.Show("Please enter a valid password with at least 4 characters");
                passTxtbx.Focus();
                return;
            }

            if (cnPassTxtBx.Text == "" || cnPassTxtBx.Text != passTxtbx.Text)
            {
                MessageBox.Show("Your passwords does not match!");
                cnPassTxtBx.Focus();
                return;
            }

            if (errorLbl.Visible == true)
            {
                MessageBox.Show(errorLbl.Text);
                cnPassTxtBx.Focus();
                return;
            }

            string type = "";
            if (rbtnRegularUser.Checked == true)
            {
                type = "RegularUser";
            }
            else if (rbtnShopAdmin.Checked == true)
            {
                type = "ShopAdmin";
            }
            if (type == "")
            {
                MessageBox.Show("Please select your account type");
            }

            query = $"INSERT INTO [User] ([User_Id], [Name], [Email], [Photo], [Type], [Password]) VALUES ({id}, '{name}', '{email}',Null, '{type}', '{pass}')";
            DataAccess.AddData(query);

            MessageBox.Show("Sign up successful! You can now log in.");
            this.Hide();
            LoginFrame loginFrame = new LoginFrame();
            loginFrame.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFrame loginFrame = new LoginFrame();
            loginFrame.Show();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            int uId;
            string query = $"SELECT MAX([User_Id]) FROM [User];";
            DataTable dt = DataAccess.LoadData(query);
            uId = dt.Rows[0][0] == DBNull.Value ? 1 : Convert.ToInt32(dt.Rows[0][0]) + 1;
            IdTxtbx.Text = uId.ToString();
        }
    }
}
