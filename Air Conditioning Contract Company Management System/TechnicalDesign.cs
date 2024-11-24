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
    public partial class TechnicalDesign : Form
    {
        public TechnicalDesign()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtDesignID.Text) ||
                string.IsNullOrWhiteSpace(txtprojrct.Text) ||
                string.IsNullOrWhiteSpace(txtEmpId.Text) ||
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

                    string sql = "INSERT INTO Technical_Design(Design_ID, Project_ID, Employee_ID, Name, Date) " +
                                 "VALUES(Design_ID, Project_ID, Employee_ID, Name, Date)";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        // Add parameters
                        com.Parameters.AddWithValue("@Design_ID", txtDesignID.Text);
                        com.Parameters.AddWithValue("@Project_ID", txtprojrct.Text);
                        com.Parameters.AddWithValue("@Employee_ID", txtEmpId.Text);
                        com.Parameters.AddWithValue("@Name", txtName.Text);
                        com.Parameters.AddWithValue("@Date", Date.Value.Date);  // Assuming datePicker is DateTimePicker



                        int ret = com.ExecuteNonQuery();
                        MessageBox.Show($"{ret} Design added successfully.", "Success");
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
            if (string.IsNullOrWhiteSpace(txtDesignID.Text) ||
                string.IsNullOrWhiteSpace(txtprojrct.Text) ||
                string.IsNullOrWhiteSpace(txtEmpId.Text) ||
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

                    string sql = "UPDATE Technical_Design SET Project_ID = @Project_ID, Employee_ID = @Employee_ID, " +
                                    "Name = @Name, Date = @Date WHERE Design_ID = @Design_ID";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        // Add parameters
                        com.Parameters.AddWithValue("@Design_ID", txtDesignID.Text);
                        com.Parameters.AddWithValue("@Project_ID", txtprojrct.Text);
                        com.Parameters.AddWithValue("@Employee_ID", txtEmpId.Text);
                        com.Parameters.AddWithValue("@Name", txtName.Text);
                        com.Parameters.AddWithValue("@Date", Date.Value.Date);  // Assuming datePicker is DateTimePicker

                        int ret = com.ExecuteNonQuery();
                        MessageBox.Show($"{ret} Design updated successfully.", "Success");
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
            string itemId = txtDesignID.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(itemId))
            {
                MessageBox.Show("Design ID cannot be blank.");
                return;
            }

            string connectionString = "Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string sql = "DELETE FROM Design WHERE Design_ID=@Design_ID";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        com.Parameters.AddWithValue("@Design_ID", txtDesignID.Text);

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
