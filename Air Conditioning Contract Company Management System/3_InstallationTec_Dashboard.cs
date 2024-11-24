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
    public partial class InstallationTechnicianDashboard : Form
    {
        public InstallationTechnicianDashboard()
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
            openChildForm(new InstallAppointment());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Dispose();
        }

        private void btnTechResources_Click(object sender, EventArgs e)
        {
            openChildForm(new InstallTechResource());
        }

        private void btnRequestItems_Click(object sender, EventArgs e)
        {
            openChildForm(new RequestItem());
        }

        private void btnInsReport_Click(object sender, EventArgs e)
        {
            openChildForm(new InstallationReport());
        }
    }
}
