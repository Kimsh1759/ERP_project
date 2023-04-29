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
    public partial class NoticeCreate : Form
    {
        public NoticeCreate(List<string> list)
        {
            notice_id.Clear();
            notice_id = list;
            InitializeComponent();
        }

        List<string> notice_id = new List<string>();

        private void btncancle_Click(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls)
            {
                control.Text = "";
            }
            introduction.Text = "머리말";
            this.Dispose();
        }

        private void Btnregistration_Click(object sender, EventArgs e)
        {
            List<object> list = new List<object>();
            list.Add(LoginApp.user.id);
            list.Add(LoginApp.user.name);
            list.Add(txtTitle.Text);
            list.Add(Substance.Text);
            DateTime dateTime = DateTime.Now;
            string date = dateTime.ToString("yyyy") + dateTime.ToString("MM") + dateTime.ToString("dd");
            list.Add(Convert.ToInt32(date));
            list.Add(introduction.SelectedItem.ToString());
            Random random = new Random();
            string str = "";
            while(true)
            {
                if(introduction.SelectedItem.ToString() == "일반")
                {
                    str += "B"+Convert.ToString(random.Next()%1000000);
                }
                else if(introduction.SelectedItem.ToString() == "긴급")
                {
                    str += "A"+ Convert.ToString(random.Next() % 1000000);
                }
                else if(introduction.SelectedItem.ToString() == "안내")
                {
                    str += "C"+ Convert.ToString(random.Next() % 1000000);
                }
                if (notice_id.Contains(str))
                {
                    str = "";
                    continue;
                }
                else
                {
                    list.Add(str);
                    break;
                }
            }
            LoginApp.RDs.Create_database(list,"NoticeBoard");
            this.Dispose();
        }
    }
}
