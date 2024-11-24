using createAbargraph;
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
    public partial class FrontOfficerDashboard : Form
    {
        public FrontOfficerDashboard()
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
            sidebarTransition.Start();
        }

        bool sidebarExpand = true;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 47)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();


                    pnlAppointment.Width = sidebar.Width;
                    pnlSRequest.Width = sidebar.Width;
                    PanelCusDetails.Width = sidebar.Width;
                    panelCusFeedback.Width = sidebar.Width;
                    //pnlCusPayment.Width = sidebar.Width;
                    pnlCusInvoice.Width = sidebar.Width;
                    pnlLogout.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 316)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();


                    pnlAppointment.Width = sidebar.Width;
                    pnlSRequest.Width = sidebar.Width;
                    PanelCusDetails.Width = sidebar.Width;
                    panelCusFeedback.Width = sidebar.Width;
                    //pnlCusPayment.Width = sidebar.Width;
                    pnlCusInvoice.Width = sidebar.Width;
                    pnlLogout.Width = sidebar.Width;
                }
            }
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            openChildForm(new Appointment());
        }

        private void btnSRequest_Click(object sender, EventArgs e)
        {
            openChildForm(new ServiceRequest());
        }

        private void btnCusDetails_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerDetails());
        }

        private void btnCusFeedback_Click(object sender, EventArgs e)
        {
            openChildForm(new customerFeedback());
        }

        /*private void btnCusPayment_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerPayment());
        } */

        private void btnCusInvoice_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerInvoice());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Dispose();
        }
    }
}

