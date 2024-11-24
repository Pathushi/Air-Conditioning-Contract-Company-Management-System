using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_Conditioning_Contract_Company_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;

            switch (Username)
            {
                case "1111":
                    if (Password == "1111")
                    {
                        MessageBox.Show("Login Success");
                        Admin_Dashboard dashBoard = new Admin_Dashboard();
                        dashBoard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password for Admin.");
                    }
                    break;

                case "2222":
                    if (Password == "2222")
                    {
                        MessageBox.Show("Login Success");
                        FrontOfficerDashboard dashBoard = new FrontOfficerDashboard();
                        dashBoard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password for Front Officer.");
                    }
                    break;

                case "3333":
                    if (Password == "3333")
                    {
                        MessageBox.Show("Login Success");
                        InstallationTechnicianDashboard dashBoard = new InstallationTechnicianDashboard();
                        dashBoard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password for Installation Technician.");
                    }
                    break;

                case "4444":
                    if (Password == "4444")
                    {
                        MessageBox.Show("Login Success");
                        QAManagerDashboard dashBoard = new QAManagerDashboard();
                        dashBoard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password for QA Manager.");
                    }
                    break;

                case "5555":
                    if (Password == "5555")
                    {
                        MessageBox.Show("Login Success");
                        MarketingManagerDashboard dashBoard = new MarketingManagerDashboard();
                        dashBoard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password for Marketing Manager.");
                    }
                    break;

                case "6666":
                    if (Password == "6666")
                    {
                        MessageBox.Show("Login Success");
                        ProjectSalesManagerDashboard dashBoard = new ProjectSalesManagerDashboard();
                        dashBoard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password for Project Sales Manager.");
                    }
                    break;

                case "7777":
                    if (Password == "7777")
                    {
                        MessageBox.Show("Login Success");
                        ProjectEngineerDashboard dashBoard = new ProjectEngineerDashboard();
                        dashBoard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password for Project Engineer.");
                    }
                    break;

                case "8888":
                    if (Password == "8888")
                    {
                        MessageBox.Show("Login Success");
                        ElectricalEngineerDashboard dashBoard = new ElectricalEngineerDashboard();
                        dashBoard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password for Electrical Engineer.");
                    }
                    break;

                case "9999":
                    if (Password == "9999")
                    {
                        MessageBox.Show("Login Success");
                        HRManagerDashboard dashBoard = new HRManagerDashboard();
                        dashBoard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password for HR Manager.");
                    }
                    break;

                case "11111":
                    if (Password == "11111")
                    {
                        MessageBox.Show("Login Success");
                        StockManagerDashboard dashBoard = new StockManagerDashboard();
                        dashBoard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password for Stock Manager.");
                    }
                    break;

                case "22222":
                    if (Password == "22222")
                    {
                        MessageBox.Show("Login Success");
                        AccountingManager dashBoard = new AccountingManager();
                        dashBoard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password for Accounting Manager.");
                    }
                    break;

                default:
                    MessageBox.Show("Login not successful. User not found.");
                    break;
            }
        }

            private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                
            }
        }
    }
}
