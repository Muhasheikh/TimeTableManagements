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
    public partial class RoomControl : UserControl
    {
        SqlConnection con = new SqlConnection(@"Server=tcp:abcinstitute.database.windows.net,1433;Initial Catalog=time-table;Persist Security Info=False;User ID=biyoni;Password=itpm12345@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataReader rd;
        int ID = 0;
        public RoomControl()
        {
            InitializeComponent();
            DisplayData();
            displayBuilding();
        }

        private void displayBuilding()
        {
            cmbBuilding.Items.Clear();
            cmbType.Items.Clear();
            cmbRoom.Items.Clear();
            String sql = "SELECT * FROM loca";
            con.Open();
            cmd = new SqlCommand(sql, con);
            rd = cmd.ExecuteReader();

            while (rd.Read())
            {

                cmbBuilding.Items.Add(rd["building"].ToString());
                cmbRoom.Items.Add(rd["room"].ToString());
                cmbType.Items.Add(rd["type"].ToString());


            }
            con.Close();
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            String timeDuration = txtTIme.Text;
            String[] times = timeDuration.Split('-');
            DateTime temp;

            if (cmbBuilding.SelectedIndex < 0 || cmbRoom.SelectedIndex < 0 || cmbType.SelectedIndex < 0 ||  txtTIme.Text == "" || times.Length != 2 || !DateTime.TryParse(times[0].Trim(), out temp) || !DateTime.TryParse(times[1].Trim(), out temp))
            {

                if (cmbBuilding.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Select Building ", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cmbRoom.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Select Room ", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cmbType.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Select Type !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                
                else if (txtTIme.Text == "")
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

            ///insert

            else
            {

                String texttime = DateTime.Parse(times[0].Trim()).ToString("HH:mm") + " - " + DateTime.Parse(times[1].Trim()).ToString("HH:mm");
                cmd = new SqlCommand("insert into tbl_RmAvailability(Building,Room,Type,Time) values(@building,@room,@type,@time)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@building", cmbBuilding.Text);
                cmd.Parameters.AddWithValue("@room", cmbRoom.Text);
                cmd.Parameters.AddWithValue("@type", cmbType.Text);
               
                cmd.Parameters.AddWithValue("@time", texttime);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);




                DisplayData();
                ClearData();


            }
        }

        private void ClearData()
        {
            cmbBuilding.SelectedIndex = -1;
            cmbRoom.SelectedIndex = -1;
            cmbType.SelectedIndex = -1;
          
            txtTIme.Clear();

        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select ID,Building,Room, Type,Time from tbl_RmAvailability", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {

                String timeDuration = txtTIme.Text;
                String[] times = timeDuration.Split('-');
                DateTime temp;

                if (cmbBuilding.SelectedIndex < 0 || cmbRoom.SelectedIndex < 0 || cmbType.SelectedIndex < 0 || txtTIme.Text == "" || times.Length != 2 || !DateTime.TryParse(times[0].Trim(), out temp) || !DateTime.TryParse(times[1].Trim(), out temp))
                {

                    if (cmbBuilding.SelectedIndex < 0)
                    {
                        MessageBox.Show("Please Select Building !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else if (cmbRoom.SelectedIndex < 0)
                    {
                        MessageBox.Show("Please Select Room !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else if (cmbType.SelectedIndex < 0)
                    {
                        MessageBox.Show("Please Select Type !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    
                    else if (txtTIme.Text == "")
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
                    cmd = new SqlCommand("update tbl_RmAvailability set Building=@building,Room=@room,Type=@type,Time=@time where ID=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@building", cmbBuilding.Text);
                    cmd.Parameters.AddWithValue("@room", cmbRoom.Text);
                    cmd.Parameters.AddWithValue("@type", cmbType.Text);
                 
                    cmd.Parameters.AddWithValue("@time", texttime);

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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete tbl_RmAvailability where ID=@id", con);
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
         


            cmbBuilding.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
             cmbRoom.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
             cmbType.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTIme.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();


            cmd = new SqlCommand("select ID,Building,Type,Room,Time from tbl_RmAvailability where ID=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
