using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace StudentsAndTagsManagement
{
    class MainControl
    {



        public static void ShowControl(System.Windows.Forms.Control control, System.Windows.Forms.Control Content)
        {

            Content.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            Content.Controls.Add(control);
        }

        
    }
}
