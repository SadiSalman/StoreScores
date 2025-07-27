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
    public partial class ReportManagement : Form
    {
        int myId;
        public ReportManagement(int id)
        {
            myId = id;
            InitializeComponent();
        }
        private void ClearFields()
        {
            repIdTxtbx.Text = "";
            txtReason.Text = "";
            btnPending.Checked = false;
            btnResolved.Checked = false;
            revIdTxtbx.Text = "";
            userIdTxtbx.Text = "";
        }
        private void ReportManagement_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM [Report];";
            DataTable dt = DataAccess.LoadData(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                repDgv.DataSource = dt;
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (sortCmb.SelectedIndex == 1)
            {
                string query = "SELECT * FROM [Report] WHERE [Status] = 'Pending'";
                DataTable dt = DataAccess.LoadData(query);
                repDgv.DataSource = dt;
                repDgv.Refresh();
            }
            else if (sortCmb.SelectedIndex == 2)
            {
                string query = "SELECT * FROM [Report] WHERE [Status] = 'Resolved'";
                DataTable dt = DataAccess.LoadData(query);
                repDgv.DataSource = dt;
                repDgv.Refresh();
            }
            else
            {
                string query = "SELECT * FROM [Report];";
                DataTable dt = DataAccess.LoadData(query);
                repDgv.DataSource = dt;
                repDgv.Refresh();
            }
            this.ClearFields();
        }

        private void repDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= repDgv.Rows.Count)
            {
                return;
            }
            repIdTxtbx.Text = repDgv.Rows[e.RowIndex].Cells["Report_Id"].Value.ToString();
            txtReason.Text = repDgv.Rows[e.RowIndex].Cells["Reason"].Value.ToString();
            if (repDgv.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "Pending")
            {
                btnPending.Checked = true;
            }
            else
            {
                btnResolved.Checked = true;
            }
            revIdTxtbx.Text = repDgv.Rows[e.RowIndex].Cells["Review_Id"].Value.ToString();
            userIdTxtbx.Text = repDgv.Rows[e.RowIndex].Cells["User_Id"].Value.ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string status;
            int repId = int.Parse(repIdTxtbx.Text);
            if (btnPending.Checked)
            {
                status = "Pending";
            }
            else if (btnResolved.Checked)
            {
                status = "Resolved";
            }
            else
            {
                MessageBox.Show("Please select a status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $"UPDATE [Report] SET [Status] = '{status}' WHERE [Report_Id] = {repId};";
            DataAccess.UpdateData(query);
            MessageBox.Show("Report updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void goToRevBtn_Click(object sender, EventArgs e)
        {
            int revId = int.Parse(revIdTxtbx.Text);
            this.Hide();
            ManageReview revMan = new ManageReview(myId, revId);
            revMan.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            PlatformModerator pmh = new PlatformModerator(myId);
            pmh.Show();
            this.Hide();
        }
    }
}
