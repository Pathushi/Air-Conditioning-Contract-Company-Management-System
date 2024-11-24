﻿using System;
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
    public partial class UserControlDays : UserControl
    {
        public static String static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is ClientMeeting)
                {
                    return; // Form is already open, exit method
                }
            }

            // Create and show new instance of Events form
            static_day = lbdays.Text;
            ClientMeeting meeting = new ClientMeeting();
            meeting.Show();

         
        }
    }
}