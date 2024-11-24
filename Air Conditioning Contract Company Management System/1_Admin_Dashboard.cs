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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            SidebarTransition.Start();
        }

        bool sidebarExpand = true;
        private void SidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panelMain.Width -= 10;
                if (panelMain.Width <= 47)
                {
                    sidebarExpand = false;
                    SidebarTransition.Stop();

                    
                    pnlEmpRegistration.Width = panelMain.Width;
                    pnlCusRegistration.Width = panelMain.Width;
                    pnlTechResources.Width = panelMain.Width;
                    pnlMonitorSystem.Width = panelMain.Width;
                    pnlEquipment.Width = panelMain.Width;
                }
            }
            else
            {
                panelMain.Width += 10;
                if (panelMain.Width >= 317)
                {
                    sidebarExpand = true;
                    SidebarTransition.Stop();

                    
                    pnlEmpRegistration.Width = panelMain.Width;

                    pnlCusRegistration.Width = panelMain.Width;
                    pnlTechResources.Width = panelMain.Width;
                    pnlMonitorSystem.Width = panelMain.Width;
                    pnlEquipment.Width = panelMain.Width;
                }
            }
        }

        private void btnMonitorSystem_Click(object sender, EventArgs e)
        {
            openChildForm(new MonitorSystem());
        }

        private void btnEmpRegistration_Click(object sender, EventArgs e)
        {
            openChildForm(new EmpRegistration());
        }

        private void lbllogout_Click(object sender, EventArgs e)
        {
                Login login = new Login();
                login.ShowDialog();
                this.Dispose();
        }

        private void btnItemRegistration_Click(object sender, EventArgs e)
        {
            openChildForm(new ItemRegistration());
        }

        private void btnCusRegistration_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerRegistration());
        }


        private void btnTechResources_Click(object sender, EventArgs e)
        {
            openChildForm(new TechnicalResource());
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            openChildForm(new Equipments());
        }
    }
}
