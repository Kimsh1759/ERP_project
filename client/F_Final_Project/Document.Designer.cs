namespace F_Final_Project
{
    partial class Document
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Document));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DocumentL = new System.Windows.Forms.Label();
            this.SelectPanel = new System.Windows.Forms.Panel();
            this.btnfinishedfile = new System.Windows.Forms.Button();
            this.btnongoingfile = new System.Windows.Forms.Button();
            this.btnregistration = new System.Windows.Forms.Button();
            this.btnfinish = new System.Windows.Forms.Button();
            this.btnongoing = new System.Windows.Forms.Button();
            this.manegersmenu = new System.Windows.Forms.Label();
            this.workersmenu = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.SelectPanel.SuspendLayout();
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
            // DocumentL
            // 
            this.DocumentL.AutoSize = true;
            this.DocumentL.Font = new System.Drawing.Font("휴먼모음T", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DocumentL.ForeColor = System.Drawing.Color.Indigo;
            this.DocumentL.Location = new System.Drawing.Point(12, 23);
            this.DocumentL.Name = "DocumentL";
            this.DocumentL.Size = new System.Drawing.Size(179, 53);
            this.DocumentL.TabIndex = 11;
            this.DocumentL.Text = "전자결재";
            // 
            // SelectPanel
            // 
            this.SelectPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.SelectPanel.Controls.Add(this.btnfinishedfile);
            this.SelectPanel.Controls.Add(this.btnongoingfile);
            this.SelectPanel.Controls.Add(this.btnregistration);
            this.SelectPanel.Controls.Add(this.btnfinish);
            this.SelectPanel.Controls.Add(this.btnongoing);
            this.SelectPanel.Controls.Add(this.manegersmenu);
            this.SelectPanel.Controls.Add(this.workersmenu);
            this.SelectPanel.Location = new System.Drawing.Point(12, 89);
            this.SelectPanel.Name = "SelectPanel";
            this.SelectPanel.Size = new System.Drawing.Size(180, 750);
            this.SelectPanel.TabIndex = 12;
            // 
            // btnfinishedfile
            // 
            this.btnfinishedfile.BackColor = System.Drawing.Color.White;
            this.btnfinishedfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfinishedfile.Location = new System.Drawing.Point(28, 283);
            this.btnfinishedfile.Name = "btnfinishedfile";
            this.btnfinishedfile.Size = new System.Drawing.Size(120, 23);
            this.btnfinishedfile.TabIndex = 1;
            this.btnfinishedfile.Text = "완료된 문서";
            this.btnfinishedfile.UseVisualStyleBackColor = false;
            // 
            // btnongoingfile
            // 
            this.btnongoingfile.BackColor = System.Drawing.Color.White;
            this.btnongoingfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnongoingfile.Location = new System.Drawing.Point(28, 254);
            this.btnongoingfile.Name = "btnongoingfile";
            this.btnongoingfile.Size = new System.Drawing.Size(120, 23);
            this.btnongoingfile.TabIndex = 1;
            this.btnongoingfile.Text = "진행중인 문서";
            this.btnongoingfile.UseVisualStyleBackColor = false;
            // 
            // btnregistration
            // 
            this.btnregistration.BackColor = System.Drawing.Color.White;
            this.btnregistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistration.Location = new System.Drawing.Point(28, 113);
            this.btnregistration.Name = "btnregistration";
            this.btnregistration.Size = new System.Drawing.Size(120, 23);
            this.btnregistration.TabIndex = 1;
            this.btnregistration.Text = "작성";
            this.btnregistration.UseVisualStyleBackColor = false;
            this.btnregistration.Click += new System.EventHandler(this.btnregistration_Click);
            // 
            // btnfinish
            // 
            this.btnfinish.BackColor = System.Drawing.Color.White;
            this.btnfinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfinish.Location = new System.Drawing.Point(28, 84);
            this.btnfinish.Name = "btnfinish";
            this.btnfinish.Size = new System.Drawing.Size(120, 23);
            this.btnfinish.TabIndex = 1;
            this.btnfinish.Text = "완료";
            this.btnfinish.UseVisualStyleBackColor = false;
            this.btnfinish.Click += new System.EventHandler(this.btnfinish_Click);
            // 
            // btnongoing
            // 
            this.btnongoing.BackColor = System.Drawing.Color.White;
            this.btnongoing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnongoing.Location = new System.Drawing.Point(28, 55);
            this.btnongoing.Name = "btnongoing";
            this.btnongoing.Size = new System.Drawing.Size(120, 23);
            this.btnongoing.TabIndex = 1;
            this.btnongoing.Text = "진행중";
            this.btnongoing.UseVisualStyleBackColor = false;
            this.btnongoing.Click += new System.EventHandler(this.btnongoing_Click);
            // 
            // manegersmenu
            // 
            this.manegersmenu.AutoSize = true;
            this.manegersmenu.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manegersmenu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.manegersmenu.Location = new System.Drawing.Point(70, 217);
            this.manegersmenu.Name = "manegersmenu";
            this.manegersmenu.Size = new System.Drawing.Size(39, 20);
            this.manegersmenu.TabIndex = 0;
            this.manegersmenu.Text = "승인";
            // 
            // workersmenu
            // 
            this.workersmenu.AutoSize = true;
            this.workersmenu.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.workersmenu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.workersmenu.Location = new System.Drawing.Point(70, 20);
            this.workersmenu.Name = "workersmenu";
            this.workersmenu.Size = new System.Drawing.Size(39, 20);
            this.workersmenu.TabIndex = 0;
            this.workersmenu.Text = "결재";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(197, 89);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1040, 750);
            this.panel.TabIndex = 13;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(1102, 11);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(135, 65);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 6;
            this.Logo.TabStop = false;
            // 
            // Document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1244, 849);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.SelectPanel);
            this.Controls.Add(this.DocumentL);
            this.Controls.Add(this.panel1);
            this.Name = "Document";
            this.Text = "Document";
            this.SelectPanel.ResumeLayout(false);
            this.SelectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DocumentL;
        private System.Windows.Forms.Panel SelectPanel;
        private System.Windows.Forms.Label workersmenu;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnfinishedfile;
        private System.Windows.Forms.Button btnongoingfile;
        private System.Windows.Forms.Button btnregistration;
        private System.Windows.Forms.Button btnfinish;
        private System.Windows.Forms.Button btnongoing;
        private System.Windows.Forms.Label manegersmenu;
        private System.Windows.Forms.PictureBox Logo;
    }
}