using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace Air_Conditioning_Contract_Company_Management_System
{
    public partial class ClientMeeting : Form
    {

        


        public ClientMeeting()
        {
            InitializeComponent();
        }

        private void ClientMeeting_Load(object sender, EventArgs e)
        {
            txtDate.Text = NewCalendar.static_month + "/" + UserControlDays.static_day + "/" + NewCalendar.static_year;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (
                string.IsNullOrWhiteSpace(txtName.Text) ||
                 string.IsNullOrWhiteSpace(txtTime.Text) ||
                string.IsNullOrWhiteSpace(txtDate.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string connectionString = "Data Source=hp\\mssqlserver01;Initial Catalog=iDAC;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string sql = "INSERT INTO Meeting(Name, Date, Time) VALUES( @Name, @Date, @Time)";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        // Add parameters
                        com.Parameters.AddWithValue("@Event", txtName.Text);
                        com.Parameters.AddWithValue("@Date", txtDate.Text);
                        com.Parameters.AddWithValue("@Date", txtTime.Text);

                        int ret = com.ExecuteNonQuery();
                        MessageBox.Show("Saved:" + ret);
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
            // Validate input
            if (string.IsNullOrEmpty(this.txtMeetingID.Text))
            {
                MessageBox.Show("Please fill in the meeting id.");
                return;
            }
           


            // Create a connection 
            string cs = "Data Source=hp\\mssqlserver01;Initial Catalog=iDAC;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    // Define SQL Command
                    string sql = "UPDATE Meeting SET Name=@Name, Date=@Date, Time=@Time WHERE MeetingID=@MeetingID";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        // Add parameters
                        com.Parameters.AddWithValue("@MeetingID", txtMeetingID.Text);
                        com.Parameters.AddWithValue("@Name", txtName.Text);
                        com.Parameters.AddWithValue("@Date", txtDate.Text);
                        com.Parameters.AddWithValue("@Time", txtTime.Text);
                        

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

            //Create a connection 
            string cs = "Data Source=hp\\mssqlserver01;Initial Catalog=iDAC;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //Define SQL Command pasing parameters
            string sql = "DELETE FROM Meeting WHERE MeetingID=@MeetingID";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@MeetingID", this.txtMeetingID.Text);

            //Execute Delete Command
            string mret = MessageBox.Show("Are you sure to delete this record? ",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
            if (mret == "Yes")
            {
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records deleted: " + ret, "Information");
            }


            //Close the connection
            con.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            ProjectSalesManagerDashboard dashBoard = new ProjectSalesManagerDashboard();
            dashBoard.Show();
            this.Dispose();
            this.Hide();
        }

        private void txtMeetingID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
