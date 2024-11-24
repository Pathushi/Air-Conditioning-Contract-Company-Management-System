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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Air_Conditioning_Contract_Company_Management_System
{
    public partial class SocailMediaAccount : Form
    {
        public SocailMediaAccount()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtAccountID.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string connectionString = "Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string sql = "INSERT INTO Shocial_Media(Account_ID, Username, Password) " +
                                 "VALUES(@Account_ID, @Username, @Password)";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        // Add parameters
                        com.Parameters.AddWithValue("@Account_ID", txtPassword.Text);
                        com.Parameters.AddWithValue("@Username", txtUsername.Text);
                        com.Parameters.AddWithValue("@Password", txtPassword.Text);



                        int ret = com.ExecuteNonQuery();
                        MessageBox.Show($"{ret} Social media account added successfully.", "Success");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtAccountID.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string connectionString = "Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string sql = "UPDATE Social_Media SET Account_ID=@Account_ID, Username=@Username, Password=@Password" +
                                 "WHERE Account_ID=@Account_ID";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        // Add parameters
                        com.Parameters.AddWithValue("@Account_ID", txtPassword.Text);
                        com.Parameters.AddWithValue("@Username", txtUsername.Text);
                        com.Parameters.AddWithValue("@Password", txtPassword.Text);

                        int ret = com.ExecuteNonQuery();
                        MessageBox.Show($"{ret} appointments updated successfully.", "Success");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get value 
            string accid = txtAccountID.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(accid))
            {
                MessageBox.Show("Account ID cannot be blank.");
                return;
            }

            string connectionString = "Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string sql = "DELETE FROM Social_Media WHERE Account_ID=@Account_ID";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        com.Parameters.AddWithValue("@Account_ID", txtAccountID.Text);

                        DialogResult mret = MessageBox.Show("Are you sure you want to delete this record?",
                            "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (mret == DialogResult.Yes)
                        {
                            int ret = com.ExecuteNonQuery();
                            MessageBox.Show($"{ret} appointment(s) deleted successfully.", "Success");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
