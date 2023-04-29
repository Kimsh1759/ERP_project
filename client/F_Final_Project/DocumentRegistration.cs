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
    public partial class DocumentRegistration : Form
    {
        public DocumentRegistration()
        {
            InitializeComponent();
        }

        private void DocumentRegistration_Load(object sender, EventArgs e)
        {

        }

        private void SelectMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectMenu.SelectedIndex == 0)
            {
                ApplicationForLeave applicationForLeave = new ApplicationForLeave();

                panel1.Controls.Clear();
                applicationForLeave.TopLevel = false;
                panel1.Controls.Add(applicationForLeave);
                applicationForLeave.Text = null;
                applicationForLeave.ControlBox = false;
                applicationForLeave.Parent = panel1;
                applicationForLeave.Show();
            }

            else if (SelectMenu.SelectedIndex == 1)
            {
                BusinessWorkReport businessWorkReport = new BusinessWorkReport();

                panel1.Controls.Clear();
                businessWorkReport.TopLevel = false;
                panel1.Controls.Add(businessWorkReport);
                businessWorkReport.Text = null;
                businessWorkReport.ControlBox = false;
                businessWorkReport.Parent = panel1;
                businessWorkReport.Show();
            }

            else if (SelectMenu.SelectedIndex == 2)
            {
                Draft draft = new Draft();

                panel1.Controls.Clear();
                draft.TopLevel = false;
                panel1.Controls.Add(draft);
                draft.Text = null;
                draft.ControlBox = false;
                draft.Parent = panel1;
                draft.Show();
            }
        }
    }
}
