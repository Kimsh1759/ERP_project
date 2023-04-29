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
            this.DocumentList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.Page5 = new System.Windows.Forms.Label();
            this.Page4 = new System.Windows.Forms.Label();
            this.Page3 = new System.Windows.Forms.Label();
            this.Page2 = new System.Windows.Forms.Label();
            this.Page1 = new System.Windows.Forms.Label();
            this.NextPage = new System.Windows.Forms.Button();
            this.PreviousPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DocumentList
            // 
            this.DocumentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.DocumentList.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DocumentList.Location = new System.Drawing.Point(0, 0);
            this.DocumentList.Name = "DocumentList";
            this.DocumentList.Size = new System.Drawing.Size(1024, 635);
            this.DocumentList.TabIndex = 2;
            this.DocumentList.UseCompatibleStateImageBehavior = false;
            this.DocumentList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "번호";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "받는사람";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "제목";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 580;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "시간";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "날짜";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 110;
            // 
            // Page5
            // 
            this.Page5.AutoSize = true;
            this.Page5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Page5.Location = new System.Drawing.Point(419, 661);
            this.Page5.Name = "Page5";
            this.Page5.Size = new System.Drawing.Size(22, 25);
            this.Page5.TabIndex = 37;
            this.Page5.Text = "5";
            // 
            // Page4
            // 
            this.Page4.AutoSize = true;
            this.Page4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Page4.Location = new System.Drawing.Point(357, 661);
            this.Page4.Name = "Page4";
            this.Page4.Size = new System.Drawing.Size(22, 25);
            this.Page4.TabIndex = 38;
            this.Page4.Text = "4";
            // 
            // Page3
            // 
            this.Page3.AutoSize = true;
            this.Page3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Page3.Location = new System.Drawing.Point(297, 661);
            this.Page3.Name = "Page3";
            this.Page3.Size = new System.Drawing.Size(22, 25);
            this.Page3.TabIndex = 39;
            this.Page3.Text = "3";
            // 
            // Page2
            // 
            this.Page2.AutoSize = true;
            this.Page2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Page2.Location = new System.Drawing.Point(237, 661);
            this.Page2.Name = "Page2";
            this.Page2.Size = new System.Drawing.Size(22, 25);
            this.Page2.TabIndex = 40;
            this.Page2.Text = "2";
            // 
            // Page1
            // 
            this.Page1.AutoSize = true;
            this.Page1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Page1.Location = new System.Drawing.Point(182, 661);
            this.Page1.Name = "Page1";
            this.Page1.Size = new System.Drawing.Size(22, 25);
            this.Page1.TabIndex = 41;
            this.Page1.Text = "1";
            // 
            // NextPage
            // 
            this.NextPage.BackColor = System.Drawing.Color.AliceBlue;
            this.NextPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextPage.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextPage.Location = new System.Drawing.Point(462, 649);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(149, 50);
            this.NextPage.TabIndex = 35;
            this.NextPage.Text = "다음 페이지";
            this.NextPage.UseVisualStyleBackColor = false;
            // 
            // PreviousPage
            // 
            this.PreviousPage.BackColor = System.Drawing.Color.AliceBlue;
            this.PreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousPage.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PreviousPage.Location = new System.Drawing.Point(12, 649);
            this.PreviousPage.Name = "PreviousPage";
            this.PreviousPage.Size = new System.Drawing.Size(149, 50);
            this.PreviousPage.TabIndex = 36;
            this.PreviousPage.Text = "이전 페이지";
            this.PreviousPage.UseVisualStyleBackColor = false;
            // 
            // Ongoingfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1024, 711);
            this.Controls.Add(this.Page5);
            this.Controls.Add(this.Page4);
            this.Controls.Add(this.Page3);
            this.Controls.Add(this.Page2);
            this.Controls.Add(this.Page1);
            this.Controls.Add(this.NextPage);
            this.Controls.Add(this.PreviousPage);
            this.Controls.Add(this.DocumentList);
            this.Name = "Ongoingfile";
            this.Text = "Ongoingfile";
            this.Load += new System.EventHandler(this.Ongoingfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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