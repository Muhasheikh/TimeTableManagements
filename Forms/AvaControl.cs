using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace StudentsAndTagsManagement
{
    public partial class AvaControl : UserControl
    {
        

        public AvaControl()
        {
            InitializeComponent();
        }



     
       
        private void btnLecturer_Click(object sender, EventArgs e)
        {
           
            lecturerControl lc = new lecturerControl();
            MainControl.ShowControl(lc, panelLecturer);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentControl1 sc= new StudentControl1();
            MainControl.ShowControl(sc, panelLecturer);
        }

        private void AvaControl_Load(object sender, EventArgs e)
        {
          
           


        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            RoomControl sc = new RoomControl();
            MainControl.ShowControl(sc, panelLecturer);
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
