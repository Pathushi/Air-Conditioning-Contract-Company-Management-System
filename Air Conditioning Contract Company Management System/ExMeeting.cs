using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_Conditioning_Contract_Company_Management_System
{
    public partial class ExMeeting : Form
    {
        int month, year;
        public static int static_month, static_year;
        public ExMeeting()
        {
            InitializeComponent();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

            month--;

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = monthname + " " + year;

            //get the first day of month
            DateTime startofthemonth = new DateTime(year, month, 1);

            //get the count of days in the month
            int Date = DateTime.DaysInMonth(year, month);

            //convert the start of the month to integer
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d") + 1);

            /*create a blank user control
            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControl1blank ucblank = new UserControl1blank();
                dayContainer.Controls.Add(ucblank);
            }*/

            // create new usercontrol

            for (int i = 1; i <= Date; i++)
            {
                UserControl1 ucdays = new UserControl1();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

            month++;

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = monthname + " " + year;

            //get the first day of month
            DateTime startofthemonth = new DateTime(year, month, 1);

            //get the count of days in the month
            int Date = DateTime.DaysInMonth(year, month);

            //convert the start of the month to integer
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d") + 1);

            /*create a blank user control
            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControl1blank ucblank = new UserControl1blank();
                dayContainer.Controls.Add(ucblank);
            }*/

            // create new usercontrol

            for (int i = 1; i <= Date; i++)
            {
                UserControl1 ucdays = new UserControl1();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);

            }
        }

        private void ExMeeting_Load(object sender, EventArgs e)
        {
            displaydays();
        }

        private void displaydays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = monthname + " " + year;

            static_month = month;
            static_year = year;

            //get the first day of month
            DateTime startofthemonth = new DateTime(year, month, 1);

            //get the count of days in the month
            int Date = DateTime.DaysInMonth(year, month);

            //convert the start of the month to integer
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d") + 1);

            /*create a blank user control
            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControl1blank ucblank = new UserControl1blank();
                dayContainer.Controls.Add(ucblank);
            }*/

            // create new usercontrol

            for (int i = 1; i <= Date; i++)
            {
                UserControl1 ucdays = new UserControl1();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);

            }

        }
    }
}
