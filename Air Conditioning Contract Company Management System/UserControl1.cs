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
    public partial class UserControl1 : UserControl
    {
        public static String static_day;
        public UserControl1()
        {
            InitializeComponent();
        }

        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            ClientMeeting events = new ClientMeeting();
            events.Show();
        }
    }
}
