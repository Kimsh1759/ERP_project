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
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            if (LoginApp.user.authority == 2)
            {
                Attendance_Workers workers = new Attendance_Workers();
                workers.TopLevel = false;
                workers.ControlBox = false;
                workers.Text = null;
                workers.Parent = panel3;
                workers.Show();
            }
            else
            {
                Attendance_Manager manager = new Attendance_Manager();
                manager.TopLevel = false;
                manager.ControlBox = false;
                manager.Text = null;
                manager.Parent = panel3;
                manager.Show();
            }
        }
    }
}
