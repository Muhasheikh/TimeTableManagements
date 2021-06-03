using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentsAndTagsManagement
{
    public partial class WorkControl : UserControl
    {
        SqlConnection con = new SqlConnection(@"Server=tcp:abcinstitute.database.windows.net,1433;Initial Catalog=time-table;Persist Security Info=False;User ID=biyoni;Password=itpm12345@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public WorkControl()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select ID,NumberDays,(cast(WorkingTimes as VARCHAR(2)) +' h '+cast(Minutes as VARCHAR(2)) +' min') as WorkingTime, WorkingDays from tbl_Records", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }

        private void btnview_Click(object sender, EventArgs e)
        {
            Add_WorkingDays w2 = new Add_WorkingDays();
            w2.ShowDialog();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }
    }

        
    }

