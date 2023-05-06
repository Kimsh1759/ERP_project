using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F_Final_Project
{
    public partial class Ongoingfile : Form
    {
        string ip = "http://localhost:8080";
        public static RDSserver rds = new RDSserver();
        int state;
        public int page = 0;
        int btn_num;
        bool approval;
        int lastPage;
        int lastitem;
        public Ongoingfile(int state, int btn_num, bool approval)
        {
            InitializeComponent();
            this.state = state;
            this.btn_num = btn_num;
            this.approval = approval;
        }

        private void Ongoingfile_Load(object sender, EventArgs e)
        {
            readFile(state);
        }

        private void PreviousPage_Click(object sender, EventArgs e)
        {
            --page;
            readFile(state);
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            ++page;
            readFile(state);
        }
        public void readFile(int state)
        {
            DocumentList.Items.Clear();
            List<JObject> listA = new List<JObject>();
            List<JObject> listJ = new List<JObject>();
            List<JObject> listD = new List<JObject>();
            List<JObject> list = new List<JObject>();
            ListViewItem listViewItem;
            if (LoginApp.user.athority == 0)
            {
                if (btn_num == 1)
                {
                    // 다불러와
                    listA = rds.Readdic_database("ApplicationForLeave", LoginApp.user.name, state, "writer");
                    listJ = rds.Readdic_database("journal", LoginApp.user.name, state, "writer");
                    listD = rds.Readdic_database("Draft", LoginApp.user.name, state, "writer");
                }
                else if (btn_num == 2)
                {
                    // 다불러와
                    listA = rds.Readdic_database("ApplicationForLeave", state);
                    listJ = rds.Readdic_database("journal", state);
                    listD = rds.Readdic_database("Draft", state);
                }
            }
            else if (LoginApp.user.athority == 1)
            {
                if (btn_num == 1)
                {
                    // 권한 1 부장 -> 자기가 쓴것만 보면 됨 state 통해서 승인 미승인 바꾸면 됨
                    listA = rds.Readdic_database("ApplicationForLeave", LoginApp.user.name, state, "writer"); 
                    listJ = rds.Readdic_database("journal", LoginApp.user.name, state, "writer");
                    listD = rds.Readdic_database("Draft", LoginApp.user.name, state, "writer");
                    if (state == 1)
                    {
                        listA.AddRange(rds.Readdic_database("ApplicationForLeave", LoginApp.user.team, state + 1, "writer"));
                        listJ.AddRange(rds.Readdic_database("journal", LoginApp.user.team, state + 1, "writer"));
                        listD.AddRange(rds.Readdic_database("Draft", LoginApp.user.team, state + 1, "writer"));
                    }
                }
                else if (btn_num == 2)
                {
                    listA = rds.Readdic_database("ApplicationForLeave", LoginApp.user.team, state, "team");
                    listJ = rds.Readdic_database("journal", LoginApp.user.team, state, "team");
                    listD = rds.Readdic_database("Draft", LoginApp.user.team, state, "team");
                    if (state == 1)
                    {
                        listA.AddRange(rds.Readdic_database("ApplicationForLeave", LoginApp.user.team, state + 1, "team"));
                        listJ.AddRange(rds.Readdic_database("journal", LoginApp.user.team, state + 1, "team"));
                        listD.AddRange(rds.Readdic_database("Draft", LoginApp.user.team, state + 1, "team"));
                    }
                    // 권한 1 부장 -> 자기팀꺼 불러오기 state 통해서 승인 미승인 바꾸면 됨
                    
                }
            }
            else
            {
                if (btn_num == 1)
                {
                    // 권한 2 일반 사원 -> 자기가 쓴것만 보면 됨
                    listA = rds.Readdic_database("ApplicationForLeave", LoginApp.user.name, state, "writer");
                    listJ = rds.Readdic_database("journal", LoginApp.user.name, state, "writer");
                    listD = rds.Readdic_database("Draft", LoginApp.user.name, state, "writer");
                    if (state == 1)
                    {
                        listA.AddRange(rds.Readdic_database("ApplicationForLeave", LoginApp.user.team, state + 1, "writer"));
                        listJ.AddRange(rds.Readdic_database("journal", LoginApp.user.team, state + 1, "writer"));
                        listD.AddRange(rds.Readdic_database("Draft", LoginApp.user.team, state + 1, "writer"));
                    }
                }
            }
            list.AddRange(listA);
            list.AddRange(listJ);
            list.AddRange(listD);
            lastitem = list.Count % 20;
            lastPage = list.Count / 20;
            if (page == lastPage)
            {
                if (page == 0)
                {
                    PreviousPage.Visible = false;
                    NextPage.Visible = false;
                }    
                else
                {
                    NextPage.Visible = false;
                    PreviousPage.Visible = true;
                }               
                for (int i = page * 20; i < page * 20+ lastitem; i++)
                {
                    JObject obj = list[i];
                    listViewItem = new ListViewItem(obj["id"].ToString());
                    listViewItem.SubItems.Add(obj["writer"].ToString());
                    listViewItem.SubItems.Add(obj["title"].ToString());
                    listViewItem.SubItems.Add(Convert.ToInt32(obj["date"]).ToString());
                    listViewItem.SubItems.Add(typeReturn(Convert.ToInt32(obj["type"])));
                    DocumentList.Items.Add(listViewItem);
                }
           
            }
            else if(page < lastPage)
            {
                if(page == 0)
                    PreviousPage.Visible = false;
                else
                    PreviousPage.Visible = true;

                for (int i = page * 20; i < page * 20 + 20; i++)
                {
                    JObject obj = list[i];
                    listViewItem = new ListViewItem(obj["id"].ToString());
                    listViewItem.SubItems.Add(obj["writer"].ToString());
                    listViewItem.SubItems.Add(obj["title"].ToString());
                    listViewItem.SubItems.Add(Convert.ToInt32(obj["date"]).ToString());
                    listViewItem.SubItems.Add(typeReturn(Convert.ToInt32(obj["type"])));
                    DocumentList.Items.Add(listViewItem);
                }
                
                NextPage.Visible = true;
            }
        }

        public string typeReturn(int type)
        {
            string result = "";
            if (type == 1)
                result = "휴가신청서";
            else if (type == 2)
                result = "일일 업무 보고서";
            else if (type == 3)
                result = "기안서";
            return result;
        }

        private void DocumentList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BusinessWorkReport report = new BusinessWorkReport(true, DocumentList.FocusedItem.SubItems[0].Text, approval) ;
            Draft draft = new Draft(true, DocumentList.FocusedItem.SubItems[0].Text, approval);
            ApplicationForLeave applicationForLeave = new ApplicationForLeave(true, DocumentList.FocusedItem.SubItems[0].Text, approval);
            char type = DocumentList.FocusedItem.SubItems[0].Text[0];
            JObject obj = new JObject();
            if (type == 'X')
            {
                applicationForLeave.ShowDialog();
            }
            else if (type == 'Y')
            {
                report.ShowDialog();
            }
            else
            {
                draft.ShowDialog();
            }
        }
    }
}
