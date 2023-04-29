using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;

namespace F_Final_Project
{
    public partial class EmployeeManagement : Form
    {
        public EmployeeManagement()
        {
            InitializeComponent();

            if(LoginApp.user.authority != 0)
            {
                ManagementL.Text = "사원조회";
                btnregistration.Visible = false;
            }
        }

        public static RDSserver RDs = new RDSserver();

        public static User user = new User();

        private void btnregistration_Click(object sender, EventArgs e)
        {
            EmployeeRegistration registration = new EmployeeRegistration();
            
            panel2.Controls.Clear();
            registration.TopLevel = false;
            panel2.Controls.Add(registration);
            registration.Text = null;
            registration.ControlBox = false;
            registration.Parent = panel2;
            registration.Show();
            restart();
        }

        void restart()
        {
            WorkerList.Items.Clear();
            ListViewItem listItem;
            List<JObject> list = LoginApp.RDs.Readdic_database("UserInfo");
            foreach (JObject obj in list)
            {
                listItem = new ListViewItem(obj["employeeNumber"].ToString());
                listItem.SubItems.Add(obj["name"].ToString());
                listItem.SubItems.Add(LoginApp.RDs.team_dic[Convert.ToInt32(obj["team"])]);
                listItem.SubItems.Add(LoginApp.RDs.JG_dic[Convert.ToInt32(obj["JG"])]);
                listItem.SubItems.Add(obj["DoE"].ToString());
                WorkerList.Items.Add(listItem); 
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if(WorkersMenu.SelectedIndex == 0)
            {
                List<object> list = new List<object>();
                
                if(SearchTextbox.Text != "")
                {
                    list = RDs.Read_database("UserInfo", SearchTextbox.Text);

                    if(list.Count != 0 && list[1] == SearchTextbox.Text)
                    {
                        user.id = Convert.ToInt32(list[0]);
                        user.name = Convert.ToString(list[1]);
                        user.pw = Convert.ToString(list[2]);
                        user.authority = Convert.ToInt32(list[3]);
                        user.team = Convert.ToString(list[4]);
                        user.JG = Convert.ToString(list[5]);
                        user.birth = Convert.ToInt32(list[6]);
                        user.addr = Convert.ToString(list[7]);
                        user.tel = Convert.ToString(list[8]);
                        user.mail = Convert.ToString(list[9]);
                        user.DoE = Convert.ToInt32(list[10]);
                    }

                    else
                    {
                        MessageBox.Show("입력한 사원의 정보가 없습니다.");
                        SearchTextbox.Text = null;
                    }
                }
            }
            else if(WorkersMenu.SelectedIndex == 1)
            {
                List<object> list = new List<object>();
                if(SearchTextbox.Text != null)
                {

                }
            }
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            restart();
        }

        private void WorkerList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(user.authority==0)
            {
                string id = WorkerList.SelectedItems[0].Text;

                ShowWorker showWorker = new ShowWorker(Convert.ToInt32(id));
                panel2.Controls.Clear();
                showWorker.TopLevel = false;
                panel2.Controls.Add(showWorker);
                showWorker.Text = null;
                showWorker.ControlBox = false;
                showWorker.Parent = panel2;
                showWorker.Show();
                restart();
            }
        }
    }

}
