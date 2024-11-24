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
    public partial class ProjectProposals : Form
    {
        public ProjectProposals()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtProposalID.Text) ||
                string.IsNullOrWhiteSpace(txtCusID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(Date.Text))
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

                    string sql = "INSERT INTO ProjectProposal(Proposal_ID, Name, Date, Customer_ID) " +
                                 "VALUES(@Proposal_ID, @Name, @Date, @Customer_ID)";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        // Add parameters
                        com.Parameters.AddWithValue("@Proposal_ID", txtProposalID.Text);
                        com.Parameters.AddWithValue("@Date", Date.Value.Date);  // Assuming datePicker is DateTimePicker
                        com.Parameters.AddWithValue("@Name", txtName.Text);
                        com.Parameters.AddWithValue("@Customer_ID", txtCusID.Text);



                        int ret = com.ExecuteNonQuery();
                        MessageBox.Show($"{ret} appointment(s) added successfully.", "Success");
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
            if (string.IsNullOrWhiteSpace(txtProposalID.Text) ||
                string.IsNullOrWhiteSpace(txtCusID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(Date.Text))
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

                    string sql = "UPDATE Project_Proposal SET Proposal_ID=@Proposal_ID, Name=@Name, Date=@Date, Customer_ID=@Customer_ID " +
                                 "WHERE Proposal_ID=@Proposal_ID";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        // Add parameters
                        com.Parameters.AddWithValue("@Proposal_ID", txtProposalID.Text);
                        com.Parameters.AddWithValue("@Date", Date.Value.Date);  // Assuming datePicker is DateTimePicker
                        com.Parameters.AddWithValue("@Name", txtName.Text);
                        com.Parameters.AddWithValue("@Customer_ID", txtCusID.Text);

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
            string itemId = txtProposalID.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(itemId))
            {
                MessageBox.Show("Proposal ID cannot be blank.");
                return;
            }

            string connectionString = "Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string sql = "DELETE FROM Project_Proposal WHERE Proposal_ID=@Proposal_ID";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        com.Parameters.AddWithValue("@Proposal_ID", txtProposalID.Text);

                        DialogResult mret = MessageBox.Show("Are you sure you want to delete this record?",
                            "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (mret == DialogResult.Yes)
                        {
                            int ret = com.ExecuteNonQuery();
                            MessageBox.Show($"{ret} proposal deleted successfully.", "Success");
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
