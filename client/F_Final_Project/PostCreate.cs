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
    public partial class PostCreate : Form
    {
        public PostCreate(List<string> list)
        {
            Free_id.Clear();
            Free_id = list;
            InitializeComponent();
        }

        List<string> Free_id = new List<string>();

        private void btncancle_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
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
            while (true)
            {
                if (introduction.SelectedItem.ToString() == "자유")
                {
                    str += "F" + Convert.ToString(random.Next() % 1000000);
                }
                else  
                {
                    str += LoginApp.RDs.teamDoc_dic[introduction.SelectedItem.ToString()]+ Convert.ToString(random.Next() % 1000000);
                }

                if (Free_id.Contains(str))
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
            LoginApp.RDs.Create_database(list, "FreeBoard");
            introduction.Items.Clear();
            this.Dispose();
        }

        

        private void PostCreate_Load(object sender, EventArgs e)
        {
            introduction.Items.Add("자유");
            if(LoginApp.user.authority == 0)
            {
                foreach(string item in LoginApp.RDs.team_dic.Values)
                {
                    introduction.Items.Add(item);
                }
            }
            else
                introduction.Items.Add(LoginApp.user.team);
        }
    }
}
