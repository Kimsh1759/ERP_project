namespace F_Final_Project
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MyPageHome = new System.Windows.Forms.ToolStripMenuItem();
            this.NoticeHome = new System.Windows.Forms.ToolStripMenuItem();
            this.PostHome = new System.Windows.Forms.ToolStripMenuItem();
            this.DocumentHome = new System.Windows.Forms.ToolStripMenuItem();
            this.AttendanceHome = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeHome = new System.Windows.Forms.ToolStripMenuItem();
            this.teamhome = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MyPageHome,
            this.NoticeHome,
            this.PostHome,
            this.DocumentHome,
            this.AttendanceHome,
            this.EmployeeHome,
            this.teamhome});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1264, 29);
            this.MainMenu.TabIndex = 3;
            this.MainMenu.Text = "menuStrip1";
            // 
            // MyPageHome
            // 
            this.MyPageHome.BackColor = System.Drawing.Color.DarkBlue;
            this.MyPageHome.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MyPageHome.ForeColor = System.Drawing.SystemColors.Window;
            this.MyPageHome.Name = "MyPageHome";
            this.MyPageHome.Size = new System.Drawing.Size(102, 25);
            this.MyPageHome.Text = "마이페이지";
            this.MyPageHome.Click += new System.EventHandler(this.MyPageHome_Click);
            // 
            // NoticeHome
            // 
            this.NoticeHome.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NoticeHome.ForeColor = System.Drawing.SystemColors.Window;
            this.NoticeHome.Name = "NoticeHome";
            this.NoticeHome.Size = new System.Drawing.Size(86, 25);
            this.NoticeHome.Text = "공지사항";
            this.NoticeHome.Click += new System.EventHandler(this.NoticeHome_Click);
            // 
            // PostHome
            // 
            this.PostHome.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PostHome.ForeColor = System.Drawing.SystemColors.Window;
            this.PostHome.Name = "PostHome";
            this.PostHome.Size = new System.Drawing.Size(102, 25);
            this.PostHome.Text = "자유게시판";
            this.PostHome.Click += new System.EventHandler(this.PostHome_Click);
            // 
            // DocumentHome
            // 
            this.DocumentHome.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DocumentHome.ForeColor = System.Drawing.SystemColors.Window;
            this.DocumentHome.Name = "DocumentHome";
            this.DocumentHome.Size = new System.Drawing.Size(86, 25);
            this.DocumentHome.Text = "전자결재";
            this.DocumentHome.Click += new System.EventHandler(this.DocumentHome_Click);
            // 
            // AttendanceHome
            // 
            this.AttendanceHome.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AttendanceHome.ForeColor = System.Drawing.SystemColors.Window;
            this.AttendanceHome.Name = "AttendanceHome";
            this.AttendanceHome.Size = new System.Drawing.Size(86, 25);
            this.AttendanceHome.Text = "근태관리";
            this.AttendanceHome.Click += new System.EventHandler(this.AttendanceHome_Click);
            // 
            // EmployeeHome
            // 
            this.EmployeeHome.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeHome.ForeColor = System.Drawing.SystemColors.Window;
            this.EmployeeHome.Name = "EmployeeHome";
            this.EmployeeHome.Size = new System.Drawing.Size(86, 25);
            this.EmployeeHome.Text = "사원관리";
            this.EmployeeHome.Click += new System.EventHandler(this.EmployeeHome_Click);
            // 
            // teamhome
            // 
            this.teamhome.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamhome.ForeColor = System.Drawing.SystemColors.Window;
            this.teamhome.Name = "teamhome";
            this.teamhome.Size = new System.Drawing.Size(86, 25);
            this.teamhome.Text = "부서관리";
            this.teamhome.Visible = false;
            this.teamhome.Click += new System.EventHandler(this.teamhome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 888);
            this.panel1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 921);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainMenu);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MyPageHome;
        private System.Windows.Forms.ToolStripMenuItem NoticeHome;
        private System.Windows.Forms.ToolStripMenuItem PostHome;
        private System.Windows.Forms.ToolStripMenuItem DocumentHome;
        private System.Windows.Forms.ToolStripMenuItem AttendanceHome;
        private System.Windows.Forms.ToolStripMenuItem EmployeeHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem teamhome;
    }
}