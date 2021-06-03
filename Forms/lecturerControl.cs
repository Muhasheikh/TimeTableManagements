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
    public partial class lecturerControl : UserControl
    {
        SqlConnection con = new SqlConnection(@"Server=tcp:abcinstitute.database.windows.net,1433;Initial Catalog=time-table;Persist Security Info=False;User ID=biyoni;Password=itpm12345@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataReader rd;
        int ID = 0;
        public lecturerControl()
        {
            InitializeComponent();
            DisplayData();

            displayLecturer();
            DisplayStudent();
            DisplaySession();
        }

        public void displayLecturer() {

            cmbSession.Items.Clear();
            cmbLecturer.Items.Clear();
            cmbGroup.Items.Clear();
            cmbSubGroup.Items.Clear();
          String sql = "SELECT * FROM Lec_details";
            con.Open();
            cmd = new SqlCommand(sql, con);
            rd = cmd.ExecuteReader();

            while (rd.Read()) {

                cmbLecturer.Items.Add(rd["Lecturer_Name"].ToString());
                

            }
            con.Close();


        }
        public void DisplaySession() {

            String sql = "SELECT * FROM Session_Management";
            con.Open();
            cmd = new SqlCommand(sql, con);
            rd = cmd.ExecuteReader();

            while (rd.Read())
            {

                cmbSession.Items.Add(rd["SessionID"].ToString());
              

            }
            con.Close();
        }
        public void DisplayStudent() {



           
          
            String sql = "SELECT * FROM Student_Management";
            con.Open();
            cmd = new SqlCommand(sql, con);
            rd = cmd.ExecuteReader();

            while (rd.Read())
            {

                cmbGroup.Items.Add(rd["GroupID"].ToString());
                cmbSubGroup.Items.Add(rd["SubGroupID"].ToString());

            }
            con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            String timeDuration = txtTIme.Text;
            String[] times = timeDuration.Split('-');
            DateTime temp;
           
            if (cmbLecturer.SelectedIndex < 0 || cmbSubGroup.SelectedIndex < 0 || cmbSubGroup.SelectedIndex < 0 || cmbSession.SelectedIndex < 0 || txtTIme.Text == "" || times.Length != 2 || !DateTime.TryParse(times[0].Trim(), out temp) || !DateTime.TryParse(times[1].Trim(), out temp))
            {

                if (cmbLecturer.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Select lecturer !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cmbSubGroup.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Select SubGroup !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cmbSubGroup.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Select Group !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cmbSession.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Select Session !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (txtTIme.Text == "")
                {
                    MessageBox.Show("Please input the Time !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (times.Length !=2 )
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

                //DateTime initialTime = DateTime.Parse(times[0].Trim());
                //DateTime endTime = DateTime.Parse(times[1].Trim());

                String texttime = DateTime.Parse(times[0].Trim()).ToString("HH:mm") + " - " + DateTime.Parse(times[1].Trim()).ToString("HH:mm");
                cmd = new SqlCommand("insert into tbl_Availability(lecturerName,GroupNumber,SubGroupNumber,SessionID,Time) values(@lecName,@gNo,@sNO,@sessID,@time)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@lecName", cmbLecturer.Text);
                cmd.Parameters.AddWithValue("@gNo", cmbGroup.Text);
                cmd.Parameters.AddWithValue("@sNO", cmbSubGroup.Text);
                cmd.Parameters.AddWithValue("@sessID", cmbSession.Text);
                cmd.Parameters.AddWithValue("@time", texttime);

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
            adapt = new SqlDataAdapter("select ID,lecturerName,GroupNumber, SubGroupNumber,SessionID,Time from tbl_Availability", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void ClearData()
        {
            cmbLecturer.SelectedIndex = -1;
            cmbGroup.SelectedIndex = -1;
            cmbSubGroup.SelectedIndex = -1;
            cmbSession.SelectedIndex = -1;
            txtTIme.Clear();






        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (ID != 0) 
            {
                String timeDuration = txtTIme.Text;
                String[] times = timeDuration.Split('-');
                DateTime temp;

                if (cmbLecturer.SelectedIndex < 0 || cmbSubGroup.SelectedIndex < 0 || cmbSubGroup.SelectedIndex < 0 || cmbSession.SelectedIndex < 0 || txtTIme.Text == "" || times.Length != 2 || !DateTime.TryParse(times[0].Trim(), out temp) || !DateTime.TryParse(times[1].Trim(), out temp))
                {

                    if (cmbLecturer.SelectedIndex < 0)
                    {
                        MessageBox.Show("Please Select lecturer !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else if (cmbSubGroup.SelectedIndex < 0)
                    {
                        MessageBox.Show("Please Select SubGroup !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else if (cmbSubGroup.SelectedIndex < 0)
                    {
                        MessageBox.Show("Please Select Group !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else if (cmbSession.SelectedIndex < 0)
                    {
                        MessageBox.Show("Please Select Session !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
                    cmd = new SqlCommand("update tbl_Availability set lecturerName=@lecName,GroupNumber=@gNo,SubGroupNumber=@sNO,SessionID=@sessID,Time=@time where ID=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@lecName", cmbLecturer.Text);
                    cmd.Parameters.AddWithValue("@gNo", cmbGroup.Text);
                    cmd.Parameters.AddWithValue("@sNO", cmbSubGroup.Text);
                    cmd.Parameters.AddWithValue("@sessID", cmbSession.Text);
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

       

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete tbl_Availability where ID=@id", con);
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmbLecturer.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbGroup.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbSubGroup.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbSession.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTIme.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();


            cmd = new SqlCommand("select ID,lecturerName,GroupNumber from tbl_Availability where ID=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
