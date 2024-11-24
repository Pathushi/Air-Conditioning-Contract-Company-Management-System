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
    public partial class MarketingCampaign : Form
    {
        public MarketingCampaign()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtCampID.Text) ||
                string.IsNullOrWhiteSpace(txtMatId.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(StartDate.Text) ||
                string.IsNullOrWhiteSpace(EndDate.Text) ||
                string.IsNullOrWhiteSpace(txtDescrition.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string connectionString = "Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Marketing_Campaign (CampaignID, MaterialID, Name, StartDate, EndDate, Description) " +
                               "VALUES (@CampaignID, @MaterialID, @Name, @StartDate, @EndDate, @Description)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CampaignID", txtCampID.Text);
                    cmd.Parameters.AddWithValue("@MaterialID", txtMatId.Text);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@StartDate", StartDate.Value);
                    cmd.Parameters.AddWithValue("@EndDate", EndDate.Value);
                    cmd.Parameters.AddWithValue("@Description", txtDescrition.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Campaign added successfully!");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtCampID.Text) ||
                string.IsNullOrWhiteSpace(txtMatId.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(StartDate.Text) ||
                string.IsNullOrWhiteSpace(EndDate.Text) ||
                string.IsNullOrWhiteSpace(txtDescrition.Text))
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

                    string sql = "UPDATE Appointment SET Date=@Date, Time=@Time, Description=@Description, Customer_ID=@Customer_ID " +
                                 "WHERE Appointment_ID=@Appointment_ID";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        com.Parameters.AddWithValue("@CampaignID", txtCampID.Text);
                        com.Parameters.AddWithValue("@MaterialID", txtCampID.Text);
                        com.Parameters.AddWithValue("@Name", txtName.Text);
                        com.Parameters.AddWithValue("@StartDate", StartDate.Value);
                        com.Parameters.AddWithValue("@EndDate", EndDate.Value);
                        com.Parameters.AddWithValue("@Description", txtDescrition.Text);

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
    }
}
