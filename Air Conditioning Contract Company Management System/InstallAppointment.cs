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
    public partial class InstallAppointment : Form
    {
        public InstallAppointment()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             btnAdd.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
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
    }
}
