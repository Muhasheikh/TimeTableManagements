using StudentsAndTagsManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TimeTableManagement.Forms
{
    public partial class TimeTable : UserControl
    {
        public TimeTable()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_Lecturer_Click(object sender, EventArgs e)
        {
            lecturerTime lc = new lecturerTime();
            MainControl.ShowControl(lc, panelTImetable);
        }
    }
}
