﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Net.Http.Headers;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using static System.Net.Mime.MediaTypeNames;
using Google.Protobuf.WellKnownTypes;
using System.IO;
using F_Final_Project;
using Microsoft.VisualBasic.Logging;
using MySqlX.XDevAPI;
using Mysqlx.Crud;
using Microsoft.VisualBasic.ApplicationServices;

namespace F_Final_Project
{

    public partial class MyPage : Form
    {
        List<object> list = new List<object>();
        List<string> memoList = new List<string>();
        string buttonNumber;
        string year;
        string month;

        public MyPage()
        {        
            InitializeComponent();
            list = LoginApp.RDs.Read_database("UserInfo", LoginApp.user.id); //로그인 정보를 불러온다.
            NameL.Text = LoginApp.user.name;
            TelNum.Text = LoginApp.user.tel;
            Assign.Text = LoginApp.user.team;
            JobGrade.Text = LoginApp.user.JG;
            Join.Text = Convert.ToString(LoginApp.user.DoE);
            LnkMail.Text = LoginApp.user.mail;
            Address.Text = LoginApp.user.addr;
            birthDay.Text = Convert.ToString(LoginApp.user.birth);

            LoginApp.user.img = LoginApp.RDs.ReadImage_database("UserInfo", LoginApp.user.id);
            if (LoginApp.user.img != null)
            {
                Profile.Image = new Bitmap(new MemoryStream(LoginApp.user.img));
            }

            YearC.SelectedItem = 2023;
            MonthC.SelectedItem = 1;
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

        private void Click_Memo(object sender, EventArgs e)
        {
            TxtMemo.Clear();
            string date;
            string month;
            string year = YearC.SelectedItem.ToString(); 

            if(Convert.ToInt32(MonthC.SelectedItem.ToString()) < 10)
                month = "0"+MonthC.SelectedItem.ToString();
            else
                month = YearC.SelectedItem.ToString();

            date = year + month;

            memoList.Clear();

            buttonNumber = date + ((Button)sender).Text;
            list= LoginApp.RDs.Read_database("MyPage", LoginApp.user.id, buttonNumber);
            foreach(var str in list)
            {
                TxtMemo.Text += str.ToString();
            }

            updateButton.Visible = true;
        }

        private void MonthC_SelectedIndexChanged(object sender, EventArgs e)
        {
            year = YearC.SelectedItem.ToString();
            month = MonthC.SelectedItem.ToString();
            DateTime datetime = new DateTime(Int32.Parse(year), Int32.Parse(month), 1, new GregorianCalendar());
            KoreanCalendar myCal = new KoreanCalendar();

            List<Button> days = new List<Button> { Day1, Day2, Day3, Day4, Day5, Day6, Day7,
                Day8, Day9, Day10, Day11, Day12, Day13, Day14, Day15, Day16,
                Day17, Day18, Day19, Day20, Day21, Day22, Day23, Day24, Day25, Day26,
                Day27, Day28, Day29, Day30, Day31, Day32, Day33, Day34, Day35, Day36,
                Day37, Day38, Day39, Day40, Day41, Day42
            };

            int DaysInMonth = myCal.GetDaysInMonth(myCal.GetYear(datetime), Int32.Parse(month));

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
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string year = YearC.SelectedItem.ToString();
            string month = MonthC.SelectedItem.ToString();
            LoginApp.RDs.Create_database(LoginApp.user.id, buttonNumber, TxtMemo.Text);
        }
    }
}
