namespace F_Final_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            TextL = new System.Windows.Forms.Label();
            Click_LogIN = new System.Windows.Forms.Button();
            InputPW = new System.Windows.Forms.TextBox();
            InputID = new System.Windows.Forms.TextBox();
            PW = new System.Windows.Forms.Label();
            ID = new System.Windows.Forms.Label();
            Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // TextL
            // 
            TextL.AutoSize = true;
            TextL.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TextL.Location = new System.Drawing.Point(732, 132);
            TextL.Name = "TextL";
            TextL.Size = new System.Drawing.Size(511, 87);
            TextL.TabIndex = 27;
            TextL.Text = "Login To Access";
            // 
            // Click_LogIN
            // 
            Click_LogIN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            Click_LogIN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Click_LogIN.Font = new System.Drawing.Font("휴먼둥근헤드라인", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Click_LogIN.Location = new System.Drawing.Point(836, 639);
            Click_LogIN.Name = "Click_LogIN";
            Click_LogIN.Size = new System.Drawing.Size(250, 50);
            Click_LogIN.TabIndex = 26;
            Click_LogIN.Text = "LogIn";
            Click_LogIN.UseVisualStyleBackColor = false;
            Click_LogIN.Click += Click_LogIN_Click;
            // 
            // InputPW
            // 
            InputPW.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            InputPW.Location = new System.Drawing.Point(749, 489);
            InputPW.Name = "InputPW";
            InputPW.Size = new System.Drawing.Size(494, 43);
            InputPW.TabIndex = 25;
            InputPW.UseSystemPasswordChar = true;
            // 
            // InputID
            // 
            InputID.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            InputID.Location = new System.Drawing.Point(749, 366);
            InputID.Name = "InputID";
            InputID.Size = new System.Drawing.Size(494, 43);
            InputID.TabIndex = 24;
            // 
            // PW
            // 
            PW.AutoSize = true;
            PW.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            PW.Location = new System.Drawing.Point(666, 489);
            PW.Name = "PW";
            PW.Size = new System.Drawing.Size(72, 45);
            PW.TabIndex = 23;
            PW.Text = "PW";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ID.Location = new System.Drawing.Point(671, 366);
            ID.Name = "ID";
            ID.Size = new System.Drawing.Size(54, 45);
            ID.TabIndex = 22;
            ID.Text = "ID";
            // 
            // Logo
            // 
            Logo.Image = (System.Drawing.Image)resources.GetObject("Logo.Image");
            Logo.Location = new System.Drawing.Point(22, 139);
            Logo.Name = "Logo";
            Logo.Size = new System.Drawing.Size(600, 550);
            Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 21;
            Logo.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1264, 921);
            Controls.Add(TextL);
            Controls.Add(Click_LogIN);
            Controls.Add(InputPW);
            Controls.Add(InputID);
            Controls.Add(PW);
            Controls.Add(ID);
            Controls.Add(Logo);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label TextL;
        private System.Windows.Forms.Button Click_LogIN;
        private System.Windows.Forms.TextBox InputPW;
        private System.Windows.Forms.TextBox InputID;
        private System.Windows.Forms.Label PW;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.PictureBox Logo;
    }
}