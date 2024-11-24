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
    public partial class CustomerInvoice : Form
    {
        public CustomerInvoice()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtInvoiceNo.Text) ||
                string.IsNullOrWhiteSpace(dateTimePicker.Text) ||
                string.IsNullOrWhiteSpace(cmbItem.Text) ||
                string.IsNullOrWhiteSpace(Quantity.Text) ||
                string.IsNullOrWhiteSpace(txtAmount.Text) ||
                string.IsNullOrWhiteSpace(txtServiceCharge.Text) ||
                string.IsNullOrWhiteSpace(txtDiscount.Text) ||
                string.IsNullOrWhiteSpace(txtTotal.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtcusId.Text))
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

                    string sql = "INSERT INTO Customer_Invoice(Invoice_No, Item, Quantity, Amount, Service_Charge, Discount, Total, Description, Customer_ID) " +
                                 "VALUES(@Invoice_No, @Item, @Quantity, @Amount, @Service_Charge, @Discount, @Total, @Description, @Customer_ID)";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        // Add parameters
                        com.Parameters.AddWithValue("@Invoice_No", txtInvoiceNo.Text);
                        com.Parameters.AddWithValue("@Date", dateTimePicker.Value.Date);  // Assuming datePicker is DateTimePicker
                        com.Parameters.AddWithValue("@Item", cmbItem.Text); // Time in string format
                        com.Parameters.AddWithValue("@Quantity", Quantity.Text);
                        com.Parameters.AddWithValue("@Amount", txtAmount.Text);
                        com.Parameters.AddWithValue("@Service_Charge", txtServiceCharge.Text);
                        com.Parameters.AddWithValue("@Discount", txtDiscount.Text);
                        com.Parameters.AddWithValue("@Total", txtTotal.Text);
                        com.Parameters.AddWithValue("@Description", txtDescription.Text);
                        com.Parameters.AddWithValue("@Customer_ID", txtcusId.Text);

                        int ret = com.ExecuteNonQuery();
                        MessageBox.Show($"{ret} record(s) added successfully.", "Success");
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
            if (string.IsNullOrWhiteSpace(txtInvoiceNo.Text) ||
                string.IsNullOrWhiteSpace(dateTimePicker.Text) ||
                string.IsNullOrWhiteSpace(cmbItem.Text) ||
                string.IsNullOrWhiteSpace(Quantity.Text) ||
                string.IsNullOrWhiteSpace(txtAmount.Text) ||
                string.IsNullOrWhiteSpace(txtServiceCharge.Text) ||
                string.IsNullOrWhiteSpace(txtDiscount.Text) ||
                string.IsNullOrWhiteSpace(txtTotal.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtcusId.Text))
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

                    string sql = "UPDATE Customer_Invoice SET Item = @Item, Quantity = @Quantity, Amount = @Amount, Service_Charge = @Service_Charge, Discount = @Discount, Total = @Total, Description = @Description, Customer_ID = @Customer_ID WHERE Invoice_No = @Invoice_No";

                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        // Add parameters
                        com.Parameters.AddWithValue("@Invoice_No", txtInvoiceNo.Text);
                        com.Parameters.AddWithValue("@Date", dateTimePicker.Value.Date);  // Assuming datePicker is DateTimePicker
                        com.Parameters.AddWithValue("@Item", cmbItem.Text); // Time in string format
                        com.Parameters.AddWithValue("@Quantity", Quantity.Text);
                        com.Parameters.AddWithValue("@Amount", txtAmount.Text);
                        com.Parameters.AddWithValue("@Service_Charge", txtServiceCharge.Text);
                        com.Parameters.AddWithValue("@Discount", txtDiscount.Text);
                        com.Parameters.AddWithValue("@Total", txtTotal.Text);
                        com.Parameters.AddWithValue("@Description", txtDescription.Text);
                        com.Parameters.AddWithValue("@Customer_ID", txtcusId.Text);

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
            string itemId = txtInvoiceNo.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(itemId))
            {
                MessageBox.Show("invoice No cannot be blank.");
                return;
            }

            string connectionString = "Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string sql = "DELETE FROM Customer_Invoice WHERE Invoice_No=@Invoice_No";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        com.Parameters.AddWithValue("@Invoice_No", txtInvoiceNo.Text);

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
