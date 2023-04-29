namespace F_Final_Project
{
    partial class TeamManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamManagement));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("0");
            this.panel1 = new System.Windows.Forms.Panel();
            this.TeamManagementL = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.TeamList = new System.Windows.Forms.ListBox();
            this.TeamListL = new System.Windows.Forms.Label();
            this.TeamML = new System.Windows.Forms.Label();
            this.TextTeam = new System.Windows.Forms.TextBox();
            this.btnDeleteTeam = new System.Windows.Forms.Button();
            this.btnConfirmTeam = new System.Windows.Forms.Button();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.TeamWorkerList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.teamName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 1);
            this.panel1.TabIndex = 9;
            // 
            // TeamManagementL
            // 
            this.TeamManagementL.AutoSize = true;
            this.TeamManagementL.Font = new System.Drawing.Font("휴먼모음T", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamManagementL.ForeColor = System.Drawing.Color.MediumPurple;
            this.TeamManagementL.Location = new System.Drawing.Point(12, 23);
            this.TeamManagementL.Name = "TeamManagementL";
            this.TeamManagementL.Size = new System.Drawing.Size(179, 53);
            this.TeamManagementL.TabIndex = 13;
            this.TeamManagementL.Text = "부서관리";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(1102, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(135, 65);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 38;
            this.Logo.TabStop = false;
            // 
            // TeamList
            // 
            this.TeamList.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamList.FormattingEnabled = true;
            this.TeamList.ItemHeight = 21;
            this.TeamList.Location = new System.Drawing.Point(12, 130);
            this.TeamList.Name = "TeamList";
            this.TeamList.Size = new System.Drawing.Size(550, 550);
            this.TeamList.TabIndex = 39;
            // 
            // TeamListL
            // 
            this.TeamListL.AutoSize = true;
            this.TeamListL.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamListL.Location = new System.Drawing.Point(15, 106);
            this.TeamListL.Name = "TeamListL";
            this.TeamListL.Size = new System.Drawing.Size(118, 21);
            this.TeamListL.TabIndex = 40;
            this.TeamListL.Text = "현재 부서 목록";
            // 
            // TeamML
            // 
            this.TeamML.AutoSize = true;
            this.TeamML.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamML.Location = new System.Drawing.Point(15, 706);
            this.TeamML.Name = "TeamML";
            this.TeamML.Size = new System.Drawing.Size(130, 21);
            this.TeamML.TabIndex = 41;
            this.TeamML.Text = "부서 추가 / 삭제";
            // 
            // TextTeam
            // 
            this.TextTeam.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextTeam.Location = new System.Drawing.Point(12, 730);
            this.TextTeam.Name = "TextTeam";
            this.TextTeam.Size = new System.Drawing.Size(550, 29);
            this.TextTeam.TabIndex = 42;
            // 
            // btnDeleteTeam
            // 
            this.btnDeleteTeam.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnDeleteTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTeam.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteTeam.Location = new System.Drawing.Point(477, 765);
            this.btnDeleteTeam.Name = "btnDeleteTeam";
            this.btnDeleteTeam.Size = new System.Drawing.Size(85, 35);
            this.btnDeleteTeam.TabIndex = 43;
            this.btnDeleteTeam.Text = "삭제";
            this.btnDeleteTeam.UseVisualStyleBackColor = false;
            // 
            // btnConfirmTeam
            // 
            this.btnConfirmTeam.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnConfirmTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmTeam.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmTeam.Location = new System.Drawing.Point(386, 765);
            this.btnConfirmTeam.Name = "btnConfirmTeam";
            this.btnConfirmTeam.Size = new System.Drawing.Size(85, 35);
            this.btnConfirmTeam.TabIndex = 43;
            this.btnConfirmTeam.Text = "수정";
            this.btnConfirmTeam.UseVisualStyleBackColor = false;
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeam.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddTeam.Location = new System.Drawing.Point(295, 765);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(85, 35);
            this.btnAddTeam.TabIndex = 43;
            this.btnAddTeam.Text = "추가";
            this.btnAddTeam.UseVisualStyleBackColor = false;
            // 
            // TeamWorkerList
            // 
            this.TeamWorkerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.TeamWorkerList.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TeamWorkerList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.TeamWorkerList.Location = new System.Drawing.Point(580, 192);
            this.TeamWorkerList.Name = "TeamWorkerList";
            this.TeamWorkerList.Size = new System.Drawing.Size(650, 567);
            this.TeamWorkerList.TabIndex = 44;
            this.TeamWorkerList.UseCompatibleStateImageBehavior = false;
            this.TeamWorkerList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "사원번호";
            this.columnHeader1.Width = 215;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "성명";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 215;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "직급";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 215;
            // 
            // teamName
            // 
            this.teamName.AutoSize = true;
            this.teamName.Font = new System.Drawing.Font("휴먼모음T", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamName.Location = new System.Drawing.Point(580, 140);
            this.teamName.Name = "teamName";
            this.teamName.Size = new System.Drawing.Size(104, 39);
            this.teamName.TabIndex = 45;
            this.teamName.Text = "부서명";
            // 
            // TeamManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1244, 849);
            this.Controls.Add(this.teamName);
            this.Controls.Add(this.TeamWorkerList);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.btnConfirmTeam);
            this.Controls.Add(this.btnDeleteTeam);
            this.Controls.Add(this.TextTeam);
            this.Controls.Add(this.TeamML);
            this.Controls.Add(this.TeamListL);
            this.Controls.Add(this.TeamList);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.TeamManagementL);
            this.Controls.Add(this.panel1);
            this.Name = "TeamManagement";
            this.Text = "TeamManagement";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TeamManagementL;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.ListBox TeamList;
        private System.Windows.Forms.Label TeamListL;
        private System.Windows.Forms.Label TeamML;
        private System.Windows.Forms.TextBox TextTeam;
        private System.Windows.Forms.Button btnDeleteTeam;
        private System.Windows.Forms.Button btnConfirmTeam;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.ListView TeamWorkerList;
        private System.Windows.Forms.Label teamName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}