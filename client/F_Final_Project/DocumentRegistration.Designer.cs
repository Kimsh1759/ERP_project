namespace F_Final_Project
{
    partial class DocumentRegistration
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
            panel1 = new System.Windows.Forms.Panel();
            txttitle = new System.Windows.Forms.TextBox();
            btnsend = new System.Windows.Forms.Button();
            btncancle = new System.Windows.Forms.Button();
            SelectMenu = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new System.Drawing.Point(12, 105);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(841, 594);
            panel1.TabIndex = 0;
            // 
            // txttitle
            // 
            txttitle.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txttitle.Location = new System.Drawing.Point(153, 60);
            txttitle.Name = "txttitle";
            txttitle.Size = new System.Drawing.Size(700, 29);
            txttitle.TabIndex = 2;
            // 
            // btnsend
            // 
            btnsend.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnsend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnsend.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnsend.Location = new System.Drawing.Point(885, 60);
            btnsend.Name = "btnsend";
            btnsend.Size = new System.Drawing.Size(92, 29);
            btnsend.TabIndex = 3;
            btnsend.Text = "완료";
            btnsend.UseVisualStyleBackColor = false;
            btnsend.Click += btnsend_Click;
            // 
            // btncancle
            // 
            btncancle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btncancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btncancle.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btncancle.Location = new System.Drawing.Point(885, 106);
            btncancle.Name = "btncancle";
            btncancle.Size = new System.Drawing.Size(92, 29);
            btncancle.TabIndex = 3;
            btncancle.Text = "취소";
            btncancle.UseVisualStyleBackColor = false;
            // 
            // SelectMenu
            // 
            SelectMenu.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            SelectMenu.FormattingEnabled = true;
            SelectMenu.Items.AddRange(new object[] { "휴가신청서", "일일업무보고서", "기안서" });
            SelectMenu.Location = new System.Drawing.Point(12, 60);
            SelectMenu.Name = "SelectMenu";
            SelectMenu.Size = new System.Drawing.Size(121, 29);
            SelectMenu.TabIndex = 5;
            SelectMenu.Text = "결재 종류";
            SelectMenu.SelectedIndexChanged += SelectMenu_SelectedIndexChanged;
            // 
            // DocumentRegistration
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Window;
            ClientSize = new System.Drawing.Size(1024, 711);
            Controls.Add(SelectMenu);
            Controls.Add(btncancle);
            Controls.Add(btnsend);
            Controls.Add(txttitle);
            Controls.Add(panel1);
            Name = "DocumentRegistration";
            Text = "DocumentRegistration";
            Load += DocumentRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.ComboBox SelectMenu;
    }
}