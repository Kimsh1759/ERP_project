﻿namespace F_Final_Project
{
    partial class PostCreate
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
            this.Substance = new System.Windows.Forms.RichTextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.introduction = new System.Windows.Forms.ComboBox();
            this.Btnregistration = new System.Windows.Forms.Button();
            this.btncancle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Substance
            // 
            this.Substance.Location = new System.Drawing.Point(12, 87);
            this.Substance.Name = "Substance";
            this.Substance.Size = new System.Drawing.Size(510, 471);
            this.Substance.TabIndex = 3;
            this.Substance.Text = "";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(505, 87);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 471);
            this.vScrollBar1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.introduction);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 40);
            this.panel1.TabIndex = 28;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(109, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(398, 25);
            this.txtTitle.TabIndex = 4;
            // 
            // introduction
            // 
            this.introduction.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.introduction.FormattingEnabled = true;
            this.introduction.Location = new System.Drawing.Point(3, 3);
            this.introduction.Name = "introduction";
            this.introduction.Size = new System.Drawing.Size(100, 25);
            this.introduction.TabIndex = 3;
            this.introduction.Tag = "";
            this.introduction.Text = "머리말";
            // 
            // Btnregistration
            // 
            this.Btnregistration.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btnregistration.Location = new System.Drawing.Point(12, 12);
            this.Btnregistration.Name = "Btnregistration";
            this.Btnregistration.Size = new System.Drawing.Size(48, 23);
            this.Btnregistration.TabIndex = 30;
            this.Btnregistration.Text = "완료";
            this.Btnregistration.UseVisualStyleBackColor = true;
            this.Btnregistration.Click += new System.EventHandler(this.Btnregistration_Click);
            // 
            // btncancle
            // 
            this.btncancle.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncancle.Location = new System.Drawing.Point(66, 12);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(48, 23);
            this.btncancle.TabIndex = 31;
            this.btncancle.Text = "취소";
            this.btncancle.UseVisualStyleBackColor = true;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // PostCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(534, 576);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.Btnregistration);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.Substance);
            this.Name = "PostCreate";
            this.Text = "PostCreate";
            this.Load += new System.EventHandler(this.PostCreate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox Substance;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox introduction;
        private System.Windows.Forms.Button Btnregistration;
        private System.Windows.Forms.Button btncancle;
    }
}