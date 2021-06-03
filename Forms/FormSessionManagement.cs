using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TimeTableManagement.Forms;
using ITPM;


namespace StudentsAndTagsManagement.Forms
{
    public partial class FormSessionManagement : Form
    {

        //fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public FormSessionManagement()
        {
            InitializeComponent();
            random = new Random();

        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColors.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColors.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColors.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void FormSessionManagement_Load(object sender, EventArgs e)
        {

        }




        private void FormSessionManagement_Load_1(object sender, EventArgs e)
        {

        }

        private void BtnNormalSessions_Click(object sender, EventArgs e)
        {
            addSession mg = new addSession();
            mg.Show();
        }

        private void buttonConsecutiveSessions_Click(object sender, EventArgs e)
        {
            FormConsecutiveSessions fm = new FormConsecutiveSessions();
            fm.ShowDialog();
        }

        private void BtnParallelSessionsM_Click(object sender, EventArgs e)
        {
            FormParallelSessions fm = new FormParallelSessions();
            fm.ShowDialog();
        }

        private void BtnNonOverlappingSessM_Click(object sender, EventArgs e)
        {
            FormNonOverlappingSessions fm = new FormNonOverlappingSessions();
            fm.ShowDialog();
        }

        private void BtnNotAvailableTimes_Click(object sender, EventArgs e)
        {
            var form = new FormNonAvailability();
            form.Show();
        }
    }
}
