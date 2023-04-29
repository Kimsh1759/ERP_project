using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace F_Final_Project
{
    public partial class Notice : Form
    {
        public Notice()
        {
            InitializeComponent();
        }
        List<JObject> list = new List<JObject>();
        List<string> notice_id = new List<string>();
        List<Label> label_page = new List<Label>();
        string mode = "";
        int index = 1;
        int doc = 0;

        void restart_form()
        {
            NoticeList.Items.Clear();
            notice_id.Clear();
            List<JObject> list2 = new List<JObject>();
            list2 = LoginApp.RDs.Readdic_database("NoticeBoard");
            list = list2.OrderByDescending(item => item["wdate"]).ToList();
            int i = 0;
            doc = 0;
            if (LoginApp.user.authority == 0)
                Btnregistration.Visible = true;
            else
                Btnregistration.Visible = false;

            ListViewItem listItem = new ListViewItem();
            List<JObject> list3 = new List<JObject>();
            foreach (JObject item in list)
            {
                if (mode == "title")
                {
                    if (item["title"].ToString().Contains(SearchTextbox.Text))
                    {
                        doc++;
                        list3.Add(item);
                    }
                }
                else if (mode == "division")
                {
                    if (item["division"].ToString() == SearchTextbox.Text)
                    {
                        doc++;
                        list3.Add(item);
                    }
                }
                else
                {
                    doc++;
                    list3.Add(item);
                }
            }

            foreach (JObject item in list3)
            {
                i++;
                notice_id.Add(item["id"].ToString()); // 문서 id 리스트 추가
                if (i <= (index - 1) * 20)
                {
                    continue;
                }

                listItem = new ListViewItem(item["id"].ToString());
                listItem.SubItems.Add(item["title"].ToString());
                listItem.SubItems.Add(item["name"].ToString());
                listItem.SubItems.Add(item["wdate"].ToString());
                listItem.SubItems.Add(item["division"].ToString());
                NoticeList.Items.Add(listItem);
                
                if (i % (index * 20) == 0)
                    break;
            }

            label_doctext.Text = "총 " + doc.ToString() + "개의 게시물";
        }

        private void Btnregistration_Click(object sender, EventArgs e)
        {
            NoticeCreate registration = new NoticeCreate(notice_id);
            registration.ShowDialog();
            restart_form();
        }

        private void Notice_Load(object sender, EventArgs e)
        {
            label_page.Add(Page1);
            label_page.Add(Page2);
            label_page.Add(Page3);
            label_page.Add(Page4);
            label_page.Add(Page5);
            label_page[0].ForeColor = Color.Blue;
            restart_form();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            index = 1;
            for (int i = 0; i < label_page.Count; i++)
            {
                label_page[i].ForeColor = Color.Black;
                label_page[i].Text = (index + i).ToString();
            }
            Page1.ForeColor = Color.Blue;

            if (search_option.SelectedItem.ToString() == "제목")
            {
                mode = "title";
            }
            else if (search_option.SelectedItem.ToString() == "구분" )
            {
                mode = "division";
            }
            restart_form();
        }

        private void NoticeList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string id = NoticeList.SelectedItems[0].Text;
           
            NoticeBrowse browse = new NoticeBrowse(id);
            browse.ShowDialog();
            restart_form();
        }
        
        private void PreviousPage_Click(object sender, EventArgs e)
        {
            if(index != 1 && (index-1)%5 == 0 )
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
                if (index == 0)
                    index++;
                label_page[(index - 1) % 5 + 1].ForeColor = Color.Black;
                label_page[(index - 1) % 5].ForeColor = Color.Blue;
            }
            restart_form();
        }

        private void NextPage_Click(object sender, EventArgs e)
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
                label_page[(index - 1) % 5 -1].ForeColor= Color.Black;
                label_page[(index-1)%5].ForeColor= Color.Blue;
            }
            restart_form();
        }

        private void PageClick(object sender, EventArgs e)
        {
            Label label = sender as Label;
            Page1.ForeColor = Color.Black;
            Page2.ForeColor = Color.Black;
            Page3.ForeColor = Color.Black;
            Page4.ForeColor = Color.Black;
            Page5.ForeColor = Color.Black;
            label.ForeColor = Color.Blue;
            
            index = Convert.ToInt32(label.Text);
            restart_form();
        }

        private void search_option_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (search_option.SelectedItem.ToString() == "전체")
            {
                SearchTextbox.Text = "";
                mode = "";
                restart_form();
            }
        }
    }
}
