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
    public partial class ServiceRequest : Form
    {
        public ServiceRequest()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Validate input
            if (string.IsNullOrEmpty(this.txtRequestID.Text))
            {
                MessageBox.Show("Please fill service request ID.");
                return;
            }
            if (string.IsNullOrEmpty(this.Date.Text))
            {
                MessageBox.Show("Please fill service request date.");
                return;
            }
            if (string.IsNullOrEmpty(this.txtDescription.Text))
            {
                MessageBox.Show("Please fill description.");
                return;
            }
            if (string.IsNullOrEmpty(this.txtCustomerID.Text))
            {
                MessageBox.Show("Please fill customer ID.");
                return;
            }

            //Create a connection 
            string cs = "Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);

            try
            {
                con.Open();

                // Define SQL Command
                string sql = "INSERT INTO Service_Request(Request_ID, Date, Description, Customer_ID) " +
                             "VALUES(@Request_ID, @Date, @Description, @Customer_ID)";

                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    // Convert and validate Date
                    DateTime requestDate;
                    if (!DateTime.TryParse(Date.Text, out requestDate))
                    {
                        MessageBox.Show("Invalid date format. Please enter a valid date.");
                        return;
                    }

                    // Add parameters
                    com.Parameters.AddWithValue("@Request_ID", txtRequestID.Text);
                    com.Parameters.AddWithValue("@Date", requestDate);
                    com.Parameters.AddWithValue("@Description", txtDescription.Text);
                    com.Parameters.AddWithValue("@Customer_ID", txtCustomerID.Text);

                    int ret = com.ExecuteNonQuery();
                    MessageBox.Show("Number of records inserted: " + ret);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrEmpty(this.txtRequestID.Text))
            {
                MessageBox.Show("Please fill in the request ID.");
                return;
            }
            if (string.IsNullOrEmpty(this.Date.Text))
            {
                MessageBox.Show("Please fill in the date.");
                return;
            }
            if (string.IsNullOrEmpty(this.txtDescription.Text))
            {
                MessageBox.Show("Please fill in the description.");
                return;
            }
            if (string.IsNullOrEmpty(this.txtCustomerID.Text))
            {
                MessageBox.Show("Please fill in the customer ID.");
                return;
            }

            // Create a connection 
            string cs = "Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();

                    // Define SQL Command with the fixed comma
                    string sql = "UPDATE Service_Request SET Description=@Description, Date=@Date, Customer_ID=@Customer_ID WHERE Request_ID=@Request_ID";

                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        // Convert and validate Date
                        DateTime requestDate;
                        if (!DateTime.TryParse(Date.Text, out requestDate))
                        {
                            MessageBox.Show("Invalid date format. Please enter a valid date.");
                            return;
                        }

                        // Add parameters
                        com.Parameters.AddWithValue("@Request_ID", txtRequestID.Text);
                        com.Parameters.AddWithValue("@Date", requestDate);
                        com.Parameters.AddWithValue("@Description", txtDescription.Text);
                        com.Parameters.AddWithValue("@Customer_ID", txtCustomerID.Text);

                        int ret = com.ExecuteNonQuery();
                        MessageBox.Show("Number of records updated: " + ret);
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
            // Create a connection 
            string cs = "Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            // Define SQL Command passing parameters
            string sql = "DELETE FROM Service_Request WHERE Request_ID=@Request_ID";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@Request_ID", this.txtRequestID.Text);

            // Execute Delete Command
            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("Number of records deleted: " + ret, "Information");
            }

            // Close the connection
            con.Close();
        }
    }
}
