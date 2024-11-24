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
    public partial class Projects : Form
    {
        public Projects()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtProjectID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmpID.Text) ||
                string.IsNullOrWhiteSpace(StartDate.Text) ||
                string.IsNullOrWhiteSpace(cmbStatus.Text) ||
                string.IsNullOrWhiteSpace(EndDate.Text))
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

                    string sql = "INSERT INTO Project(Project_ID, Name, Employee_ID, Start_Date, Status, End_Date) " +
                                 "VALUES(@Project_ID, @Name, @Employee_ID, @Start_Date, @Status, @End_Date)";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        // Add parameters
                        com.Parameters.AddWithValue("@Project_ID", txtProjectID.Text);
                        com.Parameters.AddWithValue("@Name", txtName.Text);
                        com.Parameters.AddWithValue("@Start_Date", StartDate.Value.Date);  // Assuming datePicker is DateTimePicker
                        com.Parameters.AddWithValue("@End_Date", EndDate.Value.Date);  // Assuming datePicker is DateTimePicker
                        com.Parameters.AddWithValue("@Status", cmbStatus.Text);
                        com.Parameters.AddWithValue("@Employee_ID", txtEmpID.Text);



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
            if (string.IsNullOrWhiteSpace(txtProjectID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmpID.Text) ||
                string.IsNullOrWhiteSpace(StartDate.Text) ||
                string.IsNullOrWhiteSpace(cmbStatus.Text) ||
                string.IsNullOrWhiteSpace(EndDate.Text))
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

                    string sql = "UPDATE Project SET Project_ID=@Project_ID, Name=@Name, Employee_ID=@Employee_ID, Start_Date=@Start_Date, End_Date=@End_Date, Status= " +
                                 "WHERE Appointment_ID=@Appointment_ID";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        // Add parameters
                        com.Parameters.AddWithValue("@Project_ID", txtProjectID.Text);
                        com.Parameters.AddWithValue("@Name", txtName.Text);
                        com.Parameters.AddWithValue("@Start_Date", StartDate.Value.Date);  // Assuming datePicker is DateTimePicker
                        com.Parameters.AddWithValue("@End_Date", EndDate.Value.Date);  // Assuming datePicker is DateTimePicker
                        com.Parameters.AddWithValue("@Status", cmbStatus.Text);
                        com.Parameters.AddWithValue("@Employee_ID", txtEmpID.Text);

                        int ret = com.ExecuteNonQuery();
                        MessageBox.Show($"{ret} Project updated successfully.", "Success");
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
            string itemId = txtProjectID.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(itemId))
            {
                MessageBox.Show("Project ID cannot be blank.");
                return;
            }

            string connectionString = "Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string sql = "DELETE FROM Project WHERE Project_ID=@Project_ID";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        com.Parameters.AddWithValue("@Project_ID", txtProjectID.Text);

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

