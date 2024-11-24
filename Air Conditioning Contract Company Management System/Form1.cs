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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlLoad.Width += 6;
            if (pnlLoad.Width >= 664)
            {
                timer1.Stop();

                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
