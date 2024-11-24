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
    public partial class ItemRegistration : Form
    {
        public ItemRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validate input
            if (string.IsNullOrEmpty(this.txtItemID.Text))
            {
                MessageBox.Show("Please fill item id");
                return;
            }
            if (String.IsNullOrEmpty(this.txtName.Text))
            {
                MessageBox.Show("Please fill item name");
                return;
            }
            if (String.IsNullOrEmpty(this.txtPrice.Text))
            {
                MessageBox.Show("Please fill item price");
                return;
            }
            if (String.IsNullOrEmpty(this.txtDescription.Text))
            {
                MessageBox.Show("Please fill item description");
                return;
            }



            //Create a connection 
            String cs = "Data Source=hp\\mssqlserver01;Initial Catalog=Final Project;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);

            try
            {
                con.Open();

                //Define SQL Command
                string sql = "INSERT INTO Admin_Item_Registration(Item_ID,Name,Price,Description)" +
                    "VALUES(@Item_ID,@Name,@Price,@Description)";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    //Add parameter
                    com.Parameters.AddWithValue("@Item_ID", txtItemID.Text);
                    com.Parameters.AddWithValue("@Name", txtName.Text);
                    com.Parameters.AddWithValue("@Price", txtPrice.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrEmpty(this.txtItemID.Text))
            {
                MessageBox.Show("Please fill in the item ID.");
                return;
            }
            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                MessageBox.Show("Please fill in the item name.");
                return;
            }
            if (string.IsNullOrEmpty(this.txtPrice.Text))
            {
                MessageBox.Show("Please fill in the item price.");
                return;
            }
            if (string.IsNullOrEmpty(this.txtDescription.Text))
            {
                MessageBox.Show("Please fill in the service description.");
                return;
            }


            // Create a connection 
            string cs = "Data Source=hp\\mssqlserver01;Initial Catalog=Final Project;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    // Define SQL Command
                    string sql = "UPDATE Admin_Item_Registration SET Name=@Name, Price=@Price, Description=@Description WHERE Item_ID=@Item_ID";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        // Add parameters
                        com.Parameters.AddWithValue("@Item_ID", txtItemID.Text);
                        com.Parameters.AddWithValue("@Name", txtName.Text);
                        com.Parameters.AddWithValue("@Price", txtPrice.Text);
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

        private void button3_Click(object sender, EventArgs e)
        {
            //Create a connection 
            string cs = "Data Source=hp\\mssqlserver01;Initial Catalog=Final Project;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //Define SQL Command pasing parameters
            string sql = "DELETE FROM Admin_Item_Registration WHERE Item_ID=@Item_ID";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@Item_ID", this.txtItemID.Text);

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
    }
}
