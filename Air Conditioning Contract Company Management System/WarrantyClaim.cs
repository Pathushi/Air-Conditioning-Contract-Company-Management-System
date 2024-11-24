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

namespace Air_Conditioning_Contract_Company_Management_System
{
    public partial class WarrantyClaim : Form
    {
        public WarrantyClaim()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtWarrantyID.Text) ||
                string.IsNullOrWhiteSpace(txtCusID.Text) ||
                string.IsNullOrWhiteSpace(txtCusName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtProjectID.Text) ||
                string.IsNullOrWhiteSpace(txtProjectName.Text) ||
                string.IsNullOrWhiteSpace(txtStatus.Text))
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
                    string sql = "INSERT INTO Warranty_Claim(Warranty_ID, Customer_ID, Customer_Name, Phone, Project_ID, Project_Name, Purchase_Date, Due_Date, Status) " +
                                 "VALUES(@Warranty_ID, @Customer_ID, @Customer_Name, @Phone, @Project_ID, @Project_Name, @Purchase_Date, @Due_Date, @Status)";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@Warranty_ID", txtWarrantyID.Text);
                        cmd.Parameters.AddWithValue("@Customer_ID", txtCusID.Text);
                        cmd.Parameters.AddWithValue("@Customer_Name", txtCusName.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@Project_ID", txtProjectID.Text);
                        cmd.Parameters.AddWithValue("@Project_Name", txtProjectName.Text);
                        cmd.Parameters.AddWithValue("@Purchase_Date", Date.Value.Date);
                        cmd.Parameters.AddWithValue("@Due_Date", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@Status", txtStatus.Text);

                        int ret = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{ret} Warranty added successfully.", "Success");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtWarrantyID.Text) ||
                string.IsNullOrWhiteSpace(txtCusID.Text) ||
                string.IsNullOrWhiteSpace(txtCusName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtProjectID.Text) ||
                string.IsNullOrWhiteSpace(txtProjectName.Text) ||
                string.IsNullOrWhiteSpace(txtStatus.Text))
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
                    string sql = "UPDATE Warranty_Claim SET Customer_ID=@Customer_ID, Customer_Name=@Customer_Name, Phone=@Phone, Project_ID=@Project_ID, " +
                                 "Project_Name=@Project_Name, Purchase_Date=@Purchase_Date, Due_Date=@Due_Date, Status=@Status WHERE Warranty_ID=@Warranty_ID";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@Warranty_ID", txtWarrantyID.Text);
                        cmd.Parameters.AddWithValue("@Customer_ID", txtCusID.Text);
                        cmd.Parameters.AddWithValue("@Customer_Name", txtCusName.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@Project_ID", txtProjectID.Text);
                        cmd.Parameters.AddWithValue("@Project_Name", txtProjectName.Text);
                        cmd.Parameters.AddWithValue("@Purchase_Date", Date.Value.Date);
                        cmd.Parameters.AddWithValue("@Due_Date", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@Status", txtStatus.Text);

                        int ret = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{ret} Warranty updated successfully.", "Success");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get Warranty ID
            string warrantyId = txtWarrantyID.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(warrantyId))
            {
                MessageBox.Show("Warranty ID cannot be blank.");
                return;
            }

            string connectionString = "Data Source=YourServer;Initial Catalog=YourDatabase;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string sql = "DELETE FROM WarrantyClaim WHERE Warranty_ID=@Warranty_ID";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Warranty_ID", warrantyId);

                        DialogResult result = MessageBox.Show("Are you sure you want to delete this warranty?",
                                                              "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            int ret = cmd.ExecuteNonQuery();
                            MessageBox.Show($"{ret} Warranty deleted successfully.", "Success");
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
