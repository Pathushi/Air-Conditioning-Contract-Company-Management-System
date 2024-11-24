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
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtAppointID.Text) ||
                string.IsNullOrWhiteSpace(datePicker.Text) ||
                string.IsNullOrWhiteSpace(Time.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtCusID.Text))
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

                    string sql = "INSERT INTO Appointment(Appointment_ID, Date, Time, Description, Customer_ID) " +
                                 "VALUES(@Appointment_ID, @Date, @Time, @Description, @Customer_ID)";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        // Add parameters
                        com.Parameters.AddWithValue("@Appointment_ID", txtAppointID.Text);
                        com.Parameters.AddWithValue("@Date", datePicker.Value.Date);  // Assuming datePicker is DateTimePicker
                        com.Parameters.AddWithValue("@Time", Time.Text); // Time in string format
                        com.Parameters.AddWithValue("@Description", txtDescription.Text);
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
            if (string.IsNullOrWhiteSpace(txtAppointID.Text) ||
                string.IsNullOrWhiteSpace(datePicker.Text) ||
                string.IsNullOrWhiteSpace(Time.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtCusID.Text))
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
                        // Add parameters
                        com.Parameters.AddWithValue("@Appointment_ID", txtAppointID.Text);
                        com.Parameters.AddWithValue("@Date", datePicker.Value.Date); // Assuming DateTimePicker for Date
                        com.Parameters.AddWithValue("@Time", Time.Text); // Time as string
                        com.Parameters.AddWithValue("@Description", txtDescription.Text);
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
            string itemId = txtAppointID.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(itemId))
            {
                MessageBox.Show("Appointment ID cannot be blank.");
                return;
            }

            string connectionString = "Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string sql = "DELETE FROM Appointment WHERE Appointment_ID=@Appointment_ID";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        com.Parameters.AddWithValue("@Appointment_ID", txtAppointID.Text);

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_Dashboard dashBoard = new Admin_Dashboard();
            dashBoard.Show();
            this.Dispose();
            this.Hide();
        }


        private void LoadOrderDetails()
        {
            string connectionString = "Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string sql = "SELECT Appointment_ID, Date, Time FROM Appointment WHERE Customer_ID = @Customer_ID";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.AddWithValue("@Customer_ID", txtCusID.Text);

                    SqlDataAdapter dap = new SqlDataAdapter(com);
                    DataSet ds = new DataSet();
                    dap.Fill(ds);

                    dataGridView.DataSource = ds.Tables[0];
                }
            }
        }



        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = @"Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string sql = "SELECT Appointment_ID, Date, Time, Description, Customer_ID FROM Appointment WHERE Appointment_ID=@Appointment_ID";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.AddWithValue("@Appointment_ID", txtAppointID.Text);

                    SqlDataAdapter dap = new SqlDataAdapter(com);
                    DataSet ds = new DataSet();
                    dap.Fill(ds);

                    dataGridView.DataSource = ds.Tables[0];
                }
            }
        }

        private void Appointment_Load(object sender, EventArgs e)
        {

        }
    }
}