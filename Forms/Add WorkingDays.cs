using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace StudentsAndTagsManagement
{
    public partial class Add_WorkingDays : Form
    {

        SqlConnection con = new SqlConnection(@"Server=tcp:abcinstitute.database.windows.net,1433;Initial Catalog=time-table;Persist Security Info=False;User ID=biyoni;Password=itpm12345@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        int ID = 0;

        public Add_WorkingDays()

        {
           

            InitializeComponent();
            DisplayData();


        }





        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void Add_WorkingDays_Load(object sender, EventArgs e)
        {
            
        }

       

        private void Addbtn_Click(object sender, EventArgs e)
        {
            //WorkingDays.WorkingDetails w = new WorkingDays.WorkingDetails(liWD.Items(),);
           


            if (listdays.SelectedIndex < 0 || chkdays.CheckedItems.Count < 1 || listhours.SelectedIndex < 0)
            {
                
                if (listdays.SelectedIndex < 0) {
                    MessageBox.Show("Number of days Required !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  
                }
                else if(chkdays.CheckedItems.Count < 1){
                    MessageBox.Show("Days not Selected !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   
                }
                else if(listhours.SelectedIndex < 0){
                    MessageBox.Show("Working Hours Required !","Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
               

            }
            


            else
            {
                string Days = "";

                foreach (var checkedItem in this.chkdays.CheckedItems)
                {
                    Days += checkedItem.ToString() + ",";
                }
                Days = Days.TrimEnd(',');

                string min = (chk_minutes.Checked) ? "30" : "00";

                cmd = new SqlCommand("insert into tbl_Records(NumberDays,WorkingTimes,WorkingDays,Minutes) values(@numberdays,@hours,@days,@min)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@numberdays", listdays.Text);
                cmd.Parameters.AddWithValue("@hours", listhours.Text);
                cmd.Parameters.AddWithValue("@days", Days);
                cmd.Parameters.AddWithValue("@min", min);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();
                ClearData();


            }

            
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete tbl_Records where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!","Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearData()
        {
            listhours.SelectedIndex = -1;
            listdays.SelectedIndex = -1;
            while (chkdays.CheckedIndices.Count > 0)
            {
                chkdays.SetItemChecked(chkdays.CheckedIndices[0],false);
            }
            chkdays.CheckedItems.Equals(false);
            chk_minutes.Checked = false;
           

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string Days = "";

            foreach (var checkedItem in this.chkdays.CheckedItems)
            {
                Days += checkedItem.ToString() + ",";
            }
            Days = Days.TrimEnd(',');


           



            string min = (chk_minutes.Checked) ? "30" : "00";
            if (ID != 0)
            {
                if (listdays.SelectedIndex < 0 || chkdays.CheckedItems.Count < 1 || listhours.SelectedIndex < 0)
                {

                    if (listdays.SelectedIndex < 0)
                    {
                        MessageBox.Show("Number of days Required !", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else if (chkdays.CheckedItems.Count < 1)
                    {
                        MessageBox.Show("Days not Selected !", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else if (listhours.SelectedIndex < 0)
                    {
                        MessageBox.Show("Working Hours Required !", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                }

                else {

                    cmd = new SqlCommand("update tbl_Records set NumberDays=@name,WorkingDays=@WDays,WorkingTimes=@WTimes,Minutes=@min where ID=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@name", listdays.Text);
                    cmd.Parameters.AddWithValue("@WDays", Days);
                    cmd.Parameters.AddWithValue("@WTimes", listhours.Text);
                    cmd.Parameters.AddWithValue("@min", min);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully","Status",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    con.Close();
                    DisplayData();
                    ClearData();
                }

               

            }
            else {
                MessageBox.Show("Select a Record to Update", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int count = 0; count < chkdays.Items.Count; count++)
            {
                chkdays.SetItemChecked(count, false);
            }
            


            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            listhours.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            listdays.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            cmd = new SqlCommand("select WorkingTimes,Minutes from tbl_Records where ID=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.ExecuteNonQuery();
            con.Close();
            try
            {
                con.Open();

                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        listhours.Text = (read["WorkingTimes"].ToString());

                        if (read["Minutes"].ToString().Trim().Equals("00")) {
                            chk_minutes.CheckState = CheckState.Unchecked;
                        }else {
                            chk_minutes.CheckState = CheckState.Checked;
                        }
                       

                    }
                }
            }
            finally
            {
                con.Close();
            }

            String[] x = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Split();
            foreach (string xs in x)
            {
                for (int count = 0; count < chkdays.Items.Count; count++)
                {
                    if (xs.Contains(chkdays.Items[count].ToString()))
                    {
                        chkdays.SetItemChecked(count, true);
                    }
                }

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
