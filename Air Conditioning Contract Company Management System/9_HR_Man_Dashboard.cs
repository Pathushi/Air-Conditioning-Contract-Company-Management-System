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
    public partial class HRManagerDashboard : Form
    {
        public HRManagerDashboard()
        {
            InitializeComponent();
        }


        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            openChildForm(new EmployeeDetails());
        }

        private void btnSRequest_Click(object sender, EventArgs e)
        {
            openChildForm(new Payroll());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new EmpPerformance());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Dispose();
        }
    }
}
