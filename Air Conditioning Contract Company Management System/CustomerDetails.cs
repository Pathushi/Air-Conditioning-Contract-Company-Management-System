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
    public partial class CustomerDetails : Form
    {
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            /*
             //Validate input
            if (String.IsNullOrEmpty(this.txtCusID.Text))
            {
                MessageBox.Show("Please fill customer ID");
                return;
            }
            if (String.IsNullOrEmpty(this.txtName.Text))
            {
                MessageBox.Show("Please fill customer name");
                return;
            }
            if (String.IsNullOrEmpty(this.txtAddress.Text))
            {
                MessageBox.Show("Please fill customer address");
                return;
            }
            if (String.IsNullOrEmpty(this.txtPhone.Text))
            {
                MessageBox.Show("Please fill customer phone");
                return;
            }
            if (String.IsNullOrEmpty(this.txtEmail.Text))
            {
                MessageBox.Show("Please fill customer email");
                return;
            }



            //Create a connection 
            String cs = "Data Source=hp\\mssqlserver01;Initial Catalog=Final Project;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);

            try
            {
                con.Open();

                //Define SQL Command
                string sql = "INSERT INTO Admin_Customer_Registration(Customer_ID,Name,Address,Phone,Email)" +
                    "VALUES(@Customer_ID,@Name,@Address,@Phone,@Email)";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    //Add parameter
                    com.Parameters.AddWithValue("@Customer_ID", txtCusID.Text);
                    com.Parameters.AddWithValue("@Name", txtName.Text);
                    com.Parameters.AddWithValue("@Address", txtAddress.Text);
                    com.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    com.Parameters.AddWithValue("@Email", txtEmail.Text);


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
        
            */
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrEmpty(this.txtCusID.Text))
            {
                MessageBox.Show("Please fill in the customer id.");
                return;
            }
            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                MessageBox.Show("Please fill in the customer name.");
                return;
            }
            if (string.IsNullOrEmpty(this.txtAddress.Text))
            {
                MessageBox.Show("Please fill in the customer address.");
                return;
            }
            if (string.IsNullOrEmpty(this.txtPhone.Text))
            {
                MessageBox.Show("Please fill in the customer phone number.");
                return;
            }
            if (string.IsNullOrEmpty(this.txtEmail.Text))
            {
                MessageBox.Show("Please fill in the customer email.");
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
                    string sql = "UPDATE Customer_Registration SET Name=@Name, Address=@Address, Phone=@Phone, Email=@Email WHERE Customer_ID=@Customer_ID";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        // Add parameters
                        com.Parameters.AddWithValue("@Customer_ID", txtCusID.Text);
                        com.Parameters.AddWithValue("@Name", txtName.Text);
                        com.Parameters.AddWithValue("@Address", txtAddress.Text);
                        com.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        com.Parameters.AddWithValue("@Email", txtEmail.Text);

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

        /*private void btnDelete_Click(object sender, EventArgs e)
        {
            //Create a connection 
            string cs = "Data Source=hp\\mssqlserver01;Initial Catalog=Final Project;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //Define SQL Command pasing parameters
            string sql = "DELETE FROM Admin_Customer_Registration WHERE Customer_ID=@Customer_ID";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@Customer_ID", this.txtCusID.Text);

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
        }*/

        private void CustomerDetails_Load(object sender, EventArgs e)
        {

        }
    }
    }
