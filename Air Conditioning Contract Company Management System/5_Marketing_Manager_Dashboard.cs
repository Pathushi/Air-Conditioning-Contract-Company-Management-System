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
    public partial class MarketingManagerDashboard : Form
    {
        public MarketingManagerDashboard()
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

        private void btnMarCampaign_Click(object sender, EventArgs e)
        {
            openChildForm(new MarketingCampaign());
        }

        private void btnMarkMeterial_Click(object sender, EventArgs e)
        {
            openChildForm(new MarketingMeterial());
        }

        private void btnSocialMediaAcc_Click(object sender, EventArgs e)
        {
            openChildForm(new SocailMediaAccount());
        }

        private void btnMarPerformance_Click(object sender, EventArgs e)
        {
            openChildForm(new MarketingPerformance());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Dispose();
        }
    }
}
