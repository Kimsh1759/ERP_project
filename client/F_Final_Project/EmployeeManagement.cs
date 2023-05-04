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
using Microsoft.VisualBasic.FileIO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.CodeDom.Compiler;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;
using Newtonsoft.Json.Linq;

namespace F_Final_Project
{
    public partial class EmployeeManagement : Form
    {
        public EmployeeManagement()
        {
            InitializeComponent();
        }

        int index = 1;

        List<string> workers_id = new List<string>();
        List<Label> label_page = new List<Label>();

        void restart_form()
        {
            List<JObject> obj = new List<JObject>();
            obj = LoginApp.RDs.Readdic_database("UserInfo");

            WorkerList.Items.Clear();

            for(int i = 0; i < obj.Count; i++)
            {
                if (i < 20 * (index - 1))
                    continue;

                ListViewItem listItem = new ListViewItem(obj[i]["employeeNumber"].ToString());
                listItem.SubItems.Add(obj[i]["name"].ToString());
                listItem.SubItems.Add(LoginApp.RDs.team_dic[Convert.ToInt32(obj[i]["team"])]);
                listItem.SubItems.Add(LoginApp.RDs.JG_dic[Convert.ToInt32(obj[i]["JG"])]);
                listItem.SubItems.Add(obj[i]["mail"].ToString());
                WorkerList.Items.Add(listItem);

                if (i == 20 * (index))                
                    continue;
            }
            
        }

        private void btnregistration_Click(object sender, EventArgs e)
        {

            EmployeeRegistration registration = new EmployeeRegistration();
            panel2.Controls.Clear();
            registration.TopLevel = false;
            panel2.Controls.Add(registration);
            registration.ControlBox = false;
            registration.Parent= panel2;
            registration.Show();
            restart_form();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
             WorkerList.Items.Clear();
             List<JObject> list = new List<JObject>();

             list = LoginApp.RDs.Readdic_database("UserInfo");

             ListViewItem listItem = new ListViewItem();

            if (WorkersMenu.SelectedItem.ToString() == "이름")
            {
                foreach(JObject workers in list)
                {
                    if (workers["name"].ToString().Contains(SearchTextbox.Text))
                    {
                        listItem = new ListViewItem(workers["employeeNumber"].ToString());
                        listItem.SubItems.Add(workers["name"].ToString());
                        listItem.SubItems.Add(LoginApp.RDs.team_dic[Convert.ToInt32(workers["team"])]);
                        listItem.SubItems.Add(LoginApp.RDs.JG_dic[Convert.ToInt32(workers["JG"])]);
                        listItem.SubItems.Add(workers["mail"].ToString());
                        WorkerList.Items.Add(listItem);
                    }
                }
            }

            else if (WorkersMenu.SelectedItem.ToString() == "사원번호")
            {
                foreach (JObject workers in list)
                {
                    if (workers["employeeNumber"].ToString().Contains(SearchTextbox.Text))
                    {
                        listItem = new ListViewItem(workers["employeeNumber"].ToString());
                        listItem.SubItems.Add(workers["name"].ToString());
                        listItem.SubItems.Add(LoginApp.RDs.team_dic[Convert.ToInt32(workers["team"])]);
                        listItem.SubItems.Add(LoginApp.RDs.JG_dic[Convert.ToInt32(workers["JG"])]);
                        listItem.SubItems.Add(workers["mail"].ToString());
                        WorkerList.Items.Add(listItem);
                    }
                }
            }

            else if (WorkersMenu.SelectedItem.ToString() == "부서")
            {
                foreach (JObject workers in list)
                {
                    if (LoginApp.RDs.team_dic[Convert.ToInt32(workers["team"])].Contains(SearchTextbox.Text))
                    {
                        listItem = new ListViewItem(workers["employeeNumber"].ToString());
                        listItem.SubItems.Add(workers["name"].ToString());
                        listItem.SubItems.Add(LoginApp.RDs.team_dic[Convert.ToInt32(workers["team"])]);
                        listItem.SubItems.Add(LoginApp.RDs.JG_dic[Convert.ToInt32(workers["JG"])]);
                        listItem.SubItems.Add(workers["mail"].ToString());
                        WorkerList.Items.Add(listItem);
                    }
                }
            }
        }


        private void WorkerList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            label_page.Add(page1);
            label_page.Add(page2);
            label_page.Add(page3);
            label_page.Add(page4);
            label_page.Add(page5);
            label_page[0].ForeColor = Color.Blue;
            restart_form();
        }

        private void WorkerList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(LoginApp.user.authority==0)
            {
                string id = WorkerList.SelectedItems[0].Text;
                ShowWorker showworker = new ShowWorker(Convert.ToInt32(id));
                panel2.Controls.Clear();
                showworker.TopLevel = false; 
                panel2.Controls.Add(showworker);
                showworker.Text = null;
                showworker.ControlBox = false;
                showworker.Parent = panel2;
                showworker.Show();
            }
        }

        private void btnprevPage_Click(object sender, EventArgs e)
        {

            if (index != 1 && (index - 1) % 5 == 0)
            {
                index--;
                label_page[0].ForeColor = Color.Black;
                label_page[0].Text = Convert.ToString(Convert.ToInt32(label_page[0].Text) - 5);
                label_page[1].ForeColor = Color.Black;
                label_page[1].Text = Convert.ToString(Convert.ToInt32(label_page[1].Text) - 5);
                label_page[2].ForeColor = Color.Black;
                label_page[2].Text = Convert.ToString(Convert.ToInt32(label_page[2].Text) - 5);
                label_page[3].ForeColor = Color.Black;
                label_page[3].Text = Convert.ToString(Convert.ToInt32(label_page[3].Text) - 5);
                label_page[4].ForeColor = Color.Blue;
                label_page[4].Text = Convert.ToString(Convert.ToInt32(label_page[4].Text) - 5);
            }

            else
            {
                index--;
                if(index == 0)
                {
                    index++;
                }
                label_page[(index - 1) % 5 + 1].ForeColor = Color.Black;
                label_page[(index - 1) % 5].ForeColor = Color.Blue;
            }

            restart_form();

        }

        private void btnnextPage_Click(object sender, EventArgs e)
        {
            if ((index + 1) % 5 == 1)
            {
                index++;
                label_page[0].ForeColor = Color.Blue;
                label_page[0].Text = Convert.ToString(Convert.ToInt32(label_page[0].Text) + 5);
                label_page[1].ForeColor = Color.Black;
                label_page[1].Text = Convert.ToString(Convert.ToInt32(label_page[1].Text) + 5);
                label_page[2].ForeColor = Color.Black;
                label_page[2].Text = Convert.ToString(Convert.ToInt32(label_page[2].Text) + 5);
                label_page[3].ForeColor = Color.Black;
                label_page[3].Text = Convert.ToString(Convert.ToInt32(label_page[3].Text) + 5);
                label_page[4].ForeColor = Color.Black;
                label_page[4].Text = Convert.ToString(Convert.ToInt32(label_page[4].Text) + 5);
            }

            else
            {
                index++;
                label_page[(index - 1) % 5 - 1].ForeColor = Color.Black;
                label_page[(index - 1) % 5].ForeColor = Color.Blue;
            }

            restart_form();
        }

        private void Page_Click(object sender, EventArgs e)
        {
            Label page = sender as Label;

            index = Convert.ToInt32(page.Text);
            restart_form();

            page1.ForeColor = Color.Black;
            page2.ForeColor = Color.Black;
            page3.ForeColor = Color.Black;
            page4.ForeColor = Color.Black;
            page5.ForeColor = Color.Black;
            page.ForeColor = Color.Blue;
        }
    }

}
