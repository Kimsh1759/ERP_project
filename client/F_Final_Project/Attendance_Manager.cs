using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F_Final_Project
{
    public partial class Attendance_Manager : Form
    {
        public Attendance_Manager()
        {
            InitializeComponent();
        }

        private void Attendance_Manager_Load(object sender, EventArgs e)
        {
            if (LoginApp.user.authority == 0)
            {
                SelectTeam.Visible = true;
                btnSearch.Visible = true;
            }
            else
            {
                SelectTeam.Visible = false;
                btnSearch.Visible = false;
            }
            foreach(var item in LoginApp.RDs.team_dic.Values)
            {
                SelectTeam.Items.Add(item);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
