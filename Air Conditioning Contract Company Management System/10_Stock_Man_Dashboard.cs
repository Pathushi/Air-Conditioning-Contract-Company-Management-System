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
    public partial class StockManagerDashboard : Form
    {
        public StockManagerDashboard()
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

        private void btnInventory_Click(object sender, EventArgs e)
        {
            openChildForm(new Inventory());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            openChildForm(new Order());
        }

        private void btnSupplierReport_Click(object sender, EventArgs e)
        {
            openChildForm(new SupplierReport());
        }

        private void btnSupPayment_Click(object sender, EventArgs e)
        {
            openChildForm(new SupplierPayment());
        }

        private void btnGRN_Click(object sender, EventArgs e)
        {
            openChildForm(new GRN());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Dispose();
        }
    }
}
