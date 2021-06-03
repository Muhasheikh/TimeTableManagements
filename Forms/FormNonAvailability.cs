using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TimeTableManagement.Forms
{
    public partial class FormNonAvailability : Form
    {
        SqlConnection con = new SqlConnection(@"Server=tcp:abcinstitute.database.windows.net,1433;Initial Catalog=time-table;Persist Security Info=False;User ID=biyoni;Password=itpm12345@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataReader rd;
        int ID = 0;
        public FormNonAvailability()
        {
            InitializeComponent();
            displayBuilding();
            DisplayData();
        }




        private void displayBuilding()
        {
            cmbRoom.Items.Clear();
            
            String sql = "SELECT * FROM loca";
            con.Open();
            cmd = new SqlCommand(sql, con);
            rd = cmd.ExecuteReader();

            while (rd.Read())
            {

                cmbRoom.Items.Add(rd["room"].ToString());
               


            }
            con.Close();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            String timeDuration =txtStartTime.Text;
            String[] times = timeDuration.Split('-');
            DateTime temp;

            if (cmbRoom.SelectedIndex < 0 || cmbDay.SelectedIndex < 0 || txtStartTime.Text == "" || times.Length != 2 || !DateTime.TryParse(times[0].Trim(), out temp) || !DateTime.TryParse(times[1].Trim(), out temp))
            {

                if (cmbRoom.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Select Room !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cmbDay.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Select Day !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (txtStartTime.Text == "")
                {
                    MessageBox.Show("Please input the Time !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (times.Length != 2)
                {
                    MessageBox.Show("Please input Valid Time Duration (08:25 - 10:15) !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (!DateTime.TryParse(times[0].Trim(), out temp))
                {
                    MessageBox.Show("Please input Valid Time Duration (08:25 - 10:15) !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (!DateTime.TryParse(times[1].Trim(), out temp))
                {
                    MessageBox.Show("Please input Valid Time Duration (08:25 - 10:15) !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }




            }
            else
            {
                String texttime = DateTime.Parse(times[0].Trim()).ToString("HH:mm") + " - " + DateTime.Parse(times[1].Trim()).ToString("HH:mm");
                cmd = new SqlCommand("insert into tbl_SessRoom(Room,Day,Time) values(@room,@day,@Stime)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@room", cmbRoom.Text);
                cmd.Parameters.AddWithValue("@day", cmbDay.Text);
                cmd.Parameters.AddWithValue("@Stime", texttime);

               

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
            adapt = new SqlDataAdapter("select ID,Room,Day, Time from tbl_SessRoom", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void ClearData()
        {

            cmbRoom.SelectedIndex = -1;
            cmbDay.SelectedIndex = -1;


          
            txtStartTime.Clear();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {

                String timeDuration = txtStartTime.Text;
                String[] times = timeDuration.Split('-');
                DateTime temp;

                if (cmbRoom.SelectedIndex < 0 || cmbDay.SelectedIndex < 0 || txtStartTime.Text == ""|| times.Length != 2 || !DateTime.TryParse(times[0].Trim(), out temp) || !DateTime.TryParse(times[1].Trim(), out temp))
                {

                    if (cmbRoom.SelectedIndex < 0)
                    {
                        MessageBox.Show("Please Select Room", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else if (cmbDay.SelectedIndex < 0)
                    {
                        MessageBox.Show("Please Select Day ", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else if (txtStartTime.Text == "")
                    {
                        MessageBox.Show("Please input the Time ", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else if (times.Length != 2)
                    {
                        MessageBox.Show("Please input Valid Time Duration (08:25 - 10:15) !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else if (!DateTime.TryParse(times[0].Trim(), out temp))
                    {
                        MessageBox.Show("Please input Valid Time Duration (08:25 - 10:15) !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else if (!DateTime.TryParse(times[1].Trim(), out temp))
                    {
                        MessageBox.Show("Please input Valid Time Duration (08:25 - 10:15) !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                }
                else
                {
                    String texttime = DateTime.Parse(times[0].Trim()).ToString("HH:mm") + " - " + DateTime.Parse(times[1].Trim()).ToString("HH:mm");
                    cmd = new SqlCommand("update tbl_SessRoom set Room=@room,Day=@day,Time=@Stime where ID=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@room", cmbRoom.Text);
                    cmd.Parameters.AddWithValue("@day", cmbDay.Text);
                    cmd.Parameters.AddWithValue("@Stime", texttime);

               

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    DisplayData();
                    ClearData();
                }
            }
            else
            {
                MessageBox.Show("Select a Record to Update", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete tbl_SessRoom where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value.ToString());




            cmbRoom.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbDay.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtStartTime.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
          


            cmd = new SqlCommand("select ID,Room,Time from tbl_SessRoom where ID=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
