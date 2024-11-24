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
    public partial class Equipments : Form
    {
        public Equipments()
        {
            InitializeComponent();
        }

        //Add Button 
        private void button1_Click(object sender, EventArgs e)
        {
            //Validate input
            if (string.IsNullOrEmpty(this.txtEqpID.Text))
            {
                MessageBox.Show("Please fill equipment id");
                return;
            }
            if (String.IsNullOrEmpty(this.txtName.Text))
            {
                MessageBox.Show("Please fill equipment name");
                return;
            }
            if (String.IsNullOrEmpty(this.Qty.Text))
            {
                MessageBox.Show("Please fill equipment quantity");
                return;
            }



            //Create a connection 
            String cs = "Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);

            try
            {
                con.Open();

                //Define SQL Command
                string sql = "INSERT INTO Equipment(Equipment_ID,Name,Quantity)" +
                    "VALUES(@Equipment_ID,@Name,@Quantity)";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    //Add parameter
                    com.Parameters.AddWithValue("@Equipment_ID", txtEqpID.Text);
                    com.Parameters.AddWithValue("@Name", txtName.Text);
                    com.Parameters.AddWithValue("@Quantity", Qty.Text);

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrEmpty(this.txtEqpID.Text))
            {
                MessageBox.Show("Please fill in the equipment ID.");
                return;
            }
            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                MessageBox.Show("Please fill in the equipment name.");
                return;
            }
            if (string.IsNullOrEmpty(this.Qty.Text))
            {
                MessageBox.Show("Please fill in the equipment quantity.");
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
                    string sql = "UPDATE Equipment SET Name=@Name, Quantity=@Quantity WHERE Equipment_ID=@Equipment_ID";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        // Add parameters
                        com.Parameters.AddWithValue("@Equipment_ID", txtEqpID.Text);
                        com.Parameters.AddWithValue("@Name", txtName.Text);
                        com.Parameters.AddWithValue("@Quantity", Qty.Text);

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
            string sql = "DELETE FROM Equipment WHERE Eqp_ID=@Eqp_ID";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@Eqp_ID", this.txtEqpID.Text);

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_Dashboard dashBoard = new Admin_Dashboard();
            dashBoard.Show();
            this.Dispose();
        }
    }
}

