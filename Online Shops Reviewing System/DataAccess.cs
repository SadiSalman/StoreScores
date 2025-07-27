using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Shops_Reviewing_System
{
    internal static class DataAccess
    {
        public static DataTable LoadData(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=SADI-S;Initial Catalog=OSRSdb;Integrated Security=True;Encrypt=False";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                System.Data.DataSet ds = new System.Data.DataSet();
                adp.Fill(ds);

                DataTable dataTable = ds.Tables[0];
                con.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
        public static void AddData(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=SADI-S;Initial Catalog=OSRSdb;Integrated Security=True;Encrypt=False";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Data Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public static void UpdateData(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=SADI-S;Initial Catalog=OSRSdb;Integrated Security=True;Encrypt=False";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Data update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public static void DeleteData(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=SADI-S;Initial Catalog=OSRSdb;Integrated Security=True;Encrypt=False";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
                DialogResult result = MessageBox.Show("Are You Sure?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Data deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Data delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error: " + ex.Message);
            }
        }

    }
}
