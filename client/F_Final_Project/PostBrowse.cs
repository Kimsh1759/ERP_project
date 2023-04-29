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
    public partial class PostBrowse : Form
    {
        List<object> board_data;
        string Free_id;

        public PostBrowse(string id)
        {
            this.Free_id= id;
            InitializeComponent();
        }

        void save_Board_Data()
        {
            board_data[2] = label_title.Text;
            board_data[3] = Substance.Text;
            DateTime dateTime = DateTime.Now;
            string str = dateTime.ToString("yyyy") + dateTime.ToString("MM") + dateTime.ToString("dd");
            board_data[4] = Convert.ToInt32(str);
            board_data[5] = label_division.Text;
        }

        private void PostBrowse_Load(object sender, EventArgs e)
        {
            Substance.BackColor = SystemColors.Window;
            board_data = LoginApp.RDs.Read_database("FreeBoard", Free_id);
            label_name.Text = board_data[1].ToString();
            label_title.Text = board_data[2].ToString();
            Substance.Text = board_data[3].ToString();
            label_wdate.Text = board_data[4].ToString();
            label_division.Text = board_data[5].ToString();
            label_id.Text = board_data[6].ToString();

            if (LoginApp.user.id == Convert.ToInt32(board_data[0]) || LoginApp.user.authority == 0)
            {
                btndelete.Visible = true;
                btnmodify.Visible = true;
            }
            else
            {
                btndelete.Visible = false;
                btnmodify.Visible = false;
            }
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            LoginApp.RDs.Delete_database(label_id.Text, "FreeBoard");
            MessageBox.Show("삭제 완료");
            this.Dispose();
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            if (btnmodify.Text == "수정")
            {
                btnmodify.Text = "저장";
                Substance.ReadOnly = false;
                Substance.BackColor = SystemColors.Window;
                introduction.Visible = true;
                txt_title.Visible = true;
                label_title.Visible = false;
                label_division.Visible = false;
                introduction.Text = label_division.Text;
                tableLayoutPanel1.Controls.Add(introduction, 1, 1);
                tableLayoutPanel2.Controls.Add(txt_title, 1, 0);
                introduction.Items.Add("자유");
                introduction.Items.Add(LoginApp.user.team);

            }
            else
            {
                btnmodify.Text = "수정";
                Substance.ReadOnly = true;
                Substance.BackColor = SystemColors.Window;
                introduction.Visible = false;
                txt_title.Visible = false;
                label_title.Visible = true;
                label_division.Visible = true;
                label_division.Text = introduction.Text;
                label_title.Text = txt_title.Text;
                DateTime dateTime = DateTime.Now;
                string str = dateTime.ToString("yyyy") + dateTime.ToString("MM") + dateTime.ToString("dd");
                label_wdate.Text = str;
                save_Board_Data();
                LoginApp.RDs.UpdateBoard_database(board_data, "FreeBoard");
                MessageBox.Show("수정 완료");
                tableLayoutPanel1.Controls.Add(label_division, 1, 1);
                tableLayoutPanel2.Controls.Add(label_title, 1, 0);
                introduction.Items.Clear();
            }
        }
    }
}
