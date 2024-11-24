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
    public partial class EmpRegistration : Form
    {
        public EmpRegistration()
        {
            InitializeComponent();
        }

/*
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            sidebar.Controls.Add(childForm);
            sidebar.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
*/
        //Add Button
        private void button1_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtEmpID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPosition.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(DOB.Text) ||
                string.IsNullOrWhiteSpace(txtNICnumber.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }


            //Validate input
            if (string.IsNullOrEmpty(this.txtEmpID.Text))
            {
                MessageBox.Show("Please fill employee id");
                return;
            }
            if (String.IsNullOrEmpty(this.txtName.Text))
            {
                MessageBox.Show("Please fill employee name");
                return;
            }
            if (String.IsNullOrEmpty(this.txtPosition.Text))
            {
                MessageBox.Show("Please fill employee position");
                return;
            }
            if (String.IsNullOrEmpty(this.txtAddress.Text))
            {
                MessageBox.Show("Please fill employee address");
                return;
            }
            if (String.IsNullOrEmpty(this.txtPosition.Text))
            {
                MessageBox.Show("Please fill employee password");
                return;
            }
            if (String.IsNullOrEmpty(this.txtEmail.Text))
            {
                MessageBox.Show("Please fill employee email");
                return;
            }
            if (String.IsNullOrEmpty(this.DOB.Text))
            {
                MessageBox.Show("Please fill employee date of birth");
                return;
            }
            if (String.IsNullOrEmpty(this.txtNICnumber.Text))
            {
                MessageBox.Show("Please fill employee NIC number");
                return;
            }
            if (String.IsNullOrEmpty(this.txtPhone.Text))
            {
                MessageBox.Show("Please fill employee phone number");
                return;
            }



            //Create a connection 
            String cs = "Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);

            try
            {
                con.Open();

                //Define SQL Command
                string sql = "INSERT INTO Employee_Registration (Emp_ID, Name, Position, Address, Email, Date_Of_Birth, Phone) " +
                        "VALUES (@Emp_ID, @Name, @Position, @Address, @Email, @Date_Of_Birth, @Phone)";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    //Add parameter
                    com.Parameters.AddWithValue("@Emp_ID", txtEmpID.Text);
                    com.Parameters.AddWithValue("@Name", txtName.Text);
                    com.Parameters.AddWithValue("@Position", txtPosition.Text);
                    com.Parameters.AddWithValue("@Address", txtAddress.Text);
                    com.Parameters.AddWithValue("@Email", txtEmail.Text);
                    com.Parameters.AddWithValue("@Date_Of_Birth", DOB.Text);
                    com.Parameters.AddWithValue("@Phone", txtPhone.Text);

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            //openChildForm(new Admin_Dashboard());
            Admin_Dashboard dashBoard = new Admin_Dashboard();
            dashBoard.Show();
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrEmpty(this.txtEmpID.Text))
            {
                MessageBox.Show("Please fill in the employee ID.");
                return;
            }
            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                MessageBox.Show("Please fill in the employee name.");
                return;
            }
            if (string.IsNullOrEmpty(this.txtPosition.Text))
            {
                MessageBox.Show("Please fill in the employee position.");
                return;
            }
            if (string.IsNullOrEmpty(this.txtAddress.Text))
            {
                MessageBox.Show("Please fill in the employee address.");
                return;
            }
            if (string.IsNullOrEmpty(this.txtEmail.Text))
            {
                MessageBox.Show("Please fill in the employee email.");
                return;
            }
            if (string.IsNullOrEmpty(this.DOB.Text))
            {
                MessageBox.Show("Please fill in the employee date of birth.");
                return;
            }
            if (string.IsNullOrEmpty(this.txtPhone.Text))
            {
                MessageBox.Show("Please fill in the employee phone number.");
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
                    string sql = "UPDATE Employee_Registration SET Name=@Name, Position=@Position, Address=@Address, Email=@Email, Date_Of_Birth=@Date_Of_Birth, Phone=@Phone WHERE Emp_ID=@Emp_ID";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        // Add parameters
                        com.Parameters.AddWithValue("@Emp_ID", txtEmpID.Text);
                        com.Parameters.AddWithValue("@Name", txtName.Text);
                        com.Parameters.AddWithValue("@Position", txtPosition.Text);
                        com.Parameters.AddWithValue("@Address", txtAddress.Text);
                        com.Parameters.AddWithValue("@Email", txtEmail.Text);
                        com.Parameters.AddWithValue("@Date_Of_Birth", DOB.Text);
                        com.Parameters.AddWithValue("@Phone", txtPhone.Text);

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
            string cs = "Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //Define SQL Command pasing parameters
            string sql = "DELETE FROM Employee_Registration WHERE Emp_ID=@Emp_ID";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@Emp_ID", this.txtEmpID.Text);

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
