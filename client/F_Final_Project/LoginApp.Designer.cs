namespace F_Final_Project
{
    partial class LoginApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginApp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextL = new System.Windows.Forms.Label();
            this.Click_LogIN = new System.Windows.Forms.Button();
            this.InputPW = new System.Windows.Forms.TextBox();
            this.InputID = new System.Windows.Forms.TextBox();
            this.PW = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.TextL);
            this.panel1.Controls.Add(this.Click_LogIN);
            this.panel1.Controls.Add(this.InputPW);
            this.panel1.Controls.Add(this.InputID);
            this.panel1.Controls.Add(this.PW);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 960);
            this.panel1.TabIndex = 0;
            // 
            // TextL
            // 
            this.TextL.AutoSize = true;
            this.TextL.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextL.Location = new System.Drawing.Point(737, 202);
            this.TextL.Name = "TextL";
            this.TextL.Size = new System.Drawing.Size(511, 87);
            this.TextL.TabIndex = 20;
            this.TextL.Text = "Login To Access";
            // 
            // Click_LogIN
            // 
            this.Click_LogIN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Click_LogIN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Click_LogIN.Font = new System.Drawing.Font("휴먼둥근헤드라인", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Click_LogIN.Location = new System.Drawing.Point(841, 709);
            this.Click_LogIN.Name = "Click_LogIN";
            this.Click_LogIN.Size = new System.Drawing.Size(250, 50);
            this.Click_LogIN.TabIndex = 19;
            this.Click_LogIN.Text = "LogIn";
            this.Click_LogIN.UseVisualStyleBackColor = false;
            this.Click_LogIN.Click += new System.EventHandler(this.Click_LogIN_Click);
            // 
            // InputPW
            // 
            this.InputPW.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputPW.Location = new System.Drawing.Point(754, 559);
            this.InputPW.Name = "InputPW";
            this.InputPW.Size = new System.Drawing.Size(494, 43);
            this.InputPW.TabIndex = 18;
            this.InputPW.UseSystemPasswordChar = true;
            // 
            // InputID
            // 
            this.InputID.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputID.Location = new System.Drawing.Point(754, 436);
            this.InputID.Name = "InputID";
            this.InputID.Size = new System.Drawing.Size(494, 43);
            this.InputID.TabIndex = 17;
            // 
            // PW
            // 
            this.PW.AutoSize = true;
            this.PW.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PW.Location = new System.Drawing.Point(671, 559);
            this.PW.Name = "PW";
            this.PW.Size = new System.Drawing.Size(72, 45);
            this.PW.TabIndex = 16;
            this.PW.Text = "PW";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ID.Location = new System.Drawing.Point(676, 436);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(54, 45);
            this.ID.TabIndex = 15;
            this.ID.Text = "ID";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(27, 209);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(600, 550);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 14;
            this.Logo.TabStop = false;
            // 
            // LoginApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 961);
            this.Controls.Add(this.panel1);
            this.Name = "LoginApp";
            this.Text = "사내업무관리시스템";
            this.Load += new System.EventHandler(this.LoginApp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TextL;
        private System.Windows.Forms.Button Click_LogIN;
        private System.Windows.Forms.TextBox InputPW;
        private System.Windows.Forms.TextBox InputID;
        private System.Windows.Forms.Label PW;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.PictureBox Logo;
    }
}
