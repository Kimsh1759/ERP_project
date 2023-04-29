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

namespace F_Final_Project
{
    public partial class Attendance_Workers : Form
    {
        public Attendance_Workers()
        {
            InitializeComponent();
        }

        private int dayToInt(string day)
        {
            int num;
            if (day.Equals("Sunday"))
                num = 1;
            else if (day.Equals("Monday"))
                num = 2;
            else if (day.Equals("Tuesday"))
                num = 3;
            else if (day.Equals("Wednesday"))
                num = 4;
            else if (day.Equals("Thursday"))
                num = 5;
            else if (day.Equals("Friday"))
                num = 6;
            else
                num = 7;
            return num;
        }

        private void Attendance_Workers_Load(object sender, EventArgs e)
        {
            DateTime date= DateTime.Now;
            DateTime datetime = new DateTime(date.Year, date.Month, 1, new GregorianCalendar());
            KoreanCalendar myCal = new KoreanCalendar();

            List<Button> days = new List<Button> { Day1, Day2, Day3, Day4, Day5, Day6, Day7,
                Day8, Day9, Day10, Day11, Day12, Day13, Day14, Day15, Day16,
                Day17, Day18, Day19, Day20, Day21, Day22, Day23, Day24, Day25, Day26,
                Day27, Day28, Day29, Day30, Day31, Day32, Day33, Day34, Day35, Day36,
                Day37, Day38, Day39, Day40, Day41, Day42
            };

            int DaysInMonth = myCal.GetDaysInMonth(myCal.GetYear(datetime), datetime.Month);

            int num = dayToInt(myCal.GetDayOfWeek(datetime).ToString());
            for (int i = 0; i < 42; i++)
            {
                days[i].Visible = false;
            }

            int day_num = 1;
            for (int i = num - 1; i < DaysInMonth + num - 1; i++)
            {
                days[i].Visible = true;

                if (day_num < 10)
                    days[i].Text = " " + day_num.ToString();
                else
                    days[i].Text = day_num.ToString();
                day_num++;
            }

            label_name.Text = LoginApp.user.name;
            label_goodday.Text = "0";
        }
    }
}
