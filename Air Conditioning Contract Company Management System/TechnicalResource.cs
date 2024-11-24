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
    public partial class TechnicalResource : Form
    {
        public TechnicalResource()
        {
            InitializeComponent();
        }

        //Add Button
        private void button1_Click(object sender, EventArgs e)
        {
            //Validate input
            if (string.IsNullOrEmpty(this.txtResourceID.Text))
            {
                MessageBox.Show("Please fill technical resource id");
                return;
            }
            if (String.IsNullOrEmpty(this.txtName.Text))
            {
                MessageBox.Show("Please fill technical resource name");
                return;
            }
            if (String.IsNullOrEmpty(this.txtDescription.Text))
            {
                MessageBox.Show("Please fill technical resource description");
                return;
            }



            //Create a connection 
            String cs = "Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);

            try
            {
                con.Open();

                //Define SQL Command
                string sql = "INSERT INTO Technical_Resources(Resource_ID,Name,Description)" +
                    "VALUES(@Resource_ID,@Name,@Description)";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    //Add parameter
                    com.Parameters.AddWithValue("@Resource_ID", txtResourceID.Text);
                    com.Parameters.AddWithValue("@Name", txtName.Text);
                    com.Parameters.AddWithValue("@Description", txtDescription.Text);

                    int ret = com.ExecuteNonQuery();
                    MessageBox.Show("NO of record inserted:" + ret);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //Update Button
        private void button2_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrEmpty(this.txtResourceID.Text))
            {
                MessageBox.Show("Please fill in the technical resource ID.");
                return;
            }
            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                MessageBox.Show("Please fill in the technical resource Name.");
                return;
            }
            if (string.IsNullOrEmpty(this.txtDescription.Text))
            {
                MessageBox.Show("Please fill in the technical resource description.");
                return;
            }


            // Create a connection 
            string cs = "Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    // Define SQL Command
                    string sql = "UPDATE Technical_Resources SET Name=@Name, Description=@Description WHERE Resource_ID=@Resource_ID";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        // Add parameters
                        com.Parameters.AddWithValue("@Resource_ID", txtResourceID.Text);
                        com.Parameters.AddWithValue("@Name", txtName.Text);
                        com.Parameters.AddWithValue("@Description", txtDescription.Text);

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

        //Delete Button
        private void button3_Click(object sender, EventArgs e)
        {
            //Create a connection 
            string cs = "Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //Define SQL Command pasing parameters
            string sql = "DELETE FROM Technical_Resources  WHERE Resource_ID=@Resource_ID";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@Resource_ID", this.txtResourceID.Text);

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

        private void TechnicalResource_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_Dashboard dashBoard = new Admin_Dashboard();
            dashBoard.Show();
            this.Dispose();
        }
    }
}

