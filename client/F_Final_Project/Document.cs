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
    public partial class Document : Form
    {
        public Document()
        {
            InitializeComponent();
        }

        private void btnongoing_Click(object sender, EventArgs e)
        {
            Ongoingfile ongoingfile = new Ongoingfile();

            panel.Controls.Clear();
            ongoingfile.TopLevel = false;
            Controls.Add(ongoingfile);
            ongoingfile.Text = null;
            ongoingfile.ControlBox = false;
            ongoingfile.Parent = panel;
            ongoingfile.Show();
        }

        private void btnregistration_Click(object sender, EventArgs e)
        {
            DocumentRegistration registration = new DocumentRegistration();

            panel.Controls.Clear();
            registration.TopLevel = false;
            panel.Controls.Add(registration);
            registration.Text = null;
            registration.ControlBox = false;
            registration.Parent = panel;
            registration.Show();

        }

        private void btnfinish_Click(object sender, EventArgs e)
        {
            Ongoingfile ongoingfile = new Ongoingfile();

            panel.Controls.Clear();
            ongoingfile.TopLevel = false;
            Controls.Add(ongoingfile);
            ongoingfile.Text = null;
            ongoingfile.ControlBox = false;
            ongoingfile.Parent = panel;
            ongoingfile.Show();
        }
    }
}
