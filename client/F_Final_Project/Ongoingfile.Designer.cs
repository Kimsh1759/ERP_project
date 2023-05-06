namespace F_Final_Project
{
    partial class Ongoingfile
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "q", "w", "w", "w", "w" }, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
            DocumentList = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            Page5 = new System.Windows.Forms.Label();
            Page4 = new System.Windows.Forms.Label();
            Page3 = new System.Windows.Forms.Label();
            Page2 = new System.Windows.Forms.Label();
            Page1 = new System.Windows.Forms.Label();
            NextPage = new System.Windows.Forms.Button();
            PreviousPage = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // DocumentList
            // 
            DocumentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            DocumentList.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            DocumentList.GridLines = true;
            DocumentList.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1 });
            DocumentList.Location = new System.Drawing.Point(1, 1);
            DocumentList.Name = "DocumentList";
            DocumentList.Scrollable = false;
            DocumentList.Size = new System.Drawing.Size(1024, 529);
            DocumentList.TabIndex = 2;
            DocumentList.UseCompatibleStateImageBehavior = false;
            DocumentList.View = System.Windows.Forms.View.Details;
            DocumentList.MouseDoubleClick += DocumentList_MouseDoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "번호";
            columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "작성자";
            columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "제목";
            columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader3.Width = 500;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "날짜";
            columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "종류";
            columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader5.Width = 190;
            // 
            // Page5
            // 
            Page5.AutoSize = true;
            Page5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Page5.Location = new System.Drawing.Point(418, 609);
            Page5.Name = "Page5";
            Page5.Size = new System.Drawing.Size(22, 25);
            Page5.TabIndex = 37;
            Page5.Text = "5";
            // 
            // Page4
            // 
            Page4.AutoSize = true;
            Page4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Page4.Location = new System.Drawing.Point(356, 609);
            Page4.Name = "Page4";
            Page4.Size = new System.Drawing.Size(22, 25);
            Page4.TabIndex = 38;
            Page4.Text = "4";
            // 
            // Page3
            // 
            Page3.AutoSize = true;
            Page3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Page3.Location = new System.Drawing.Point(296, 609);
            Page3.Name = "Page3";
            Page3.Size = new System.Drawing.Size(22, 25);
            Page3.TabIndex = 39;
            Page3.Text = "3";
            // 
            // Page2
            // 
            Page2.AutoSize = true;
            Page2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Page2.Location = new System.Drawing.Point(236, 609);
            Page2.Name = "Page2";
            Page2.Size = new System.Drawing.Size(22, 25);
            Page2.TabIndex = 40;
            Page2.Text = "2";
            // 
            // Page1
            // 
            Page1.AutoSize = true;
            Page1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Page1.Location = new System.Drawing.Point(181, 609);
            Page1.Name = "Page1";
            Page1.Size = new System.Drawing.Size(22, 25);
            Page1.TabIndex = 41;
            Page1.Text = "1";
            // 
            // NextPage
            // 
            NextPage.BackColor = System.Drawing.Color.AliceBlue;
            NextPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            NextPage.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NextPage.Location = new System.Drawing.Point(461, 597);
            NextPage.Name = "NextPage";
            NextPage.Size = new System.Drawing.Size(149, 50);
            NextPage.TabIndex = 35;
            NextPage.Text = "다음 페이지";
            NextPage.UseVisualStyleBackColor = false;
            NextPage.Click += NextPage_Click;
            // 
            // PreviousPage
            // 
            PreviousPage.BackColor = System.Drawing.Color.AliceBlue;
            PreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            PreviousPage.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PreviousPage.Location = new System.Drawing.Point(11, 597);
            PreviousPage.Name = "PreviousPage";
            PreviousPage.Size = new System.Drawing.Size(149, 50);
            PreviousPage.TabIndex = 36;
            PreviousPage.Text = "이전 페이지";
            PreviousPage.UseVisualStyleBackColor = false;
            PreviousPage.Click += PreviousPage_Click;
            // 
            // Ongoingfile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Window;
            ClientSize = new System.Drawing.Size(1024, 711);
            Controls.Add(Page5);
            Controls.Add(Page4);
            Controls.Add(Page3);
            Controls.Add(Page2);
            Controls.Add(Page1);
            Controls.Add(NextPage);
            Controls.Add(PreviousPage);
            Controls.Add(DocumentList);
            Name = "Ongoingfile";
            Text = "Ongoingfile";
            Load += Ongoingfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ListView DocumentList;
        private System.Windows.Forms.Label Page5;
        private System.Windows.Forms.Label Page4;
        private System.Windows.Forms.Label Page3;
        private System.Windows.Forms.Label Page2;
        private System.Windows.Forms.Label Page1;
        private System.Windows.Forms.Button NextPage;
        private System.Windows.Forms.Button PreviousPage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}