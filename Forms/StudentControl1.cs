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
    public partial class StudentControl1 : UserControl
    {

        SqlConnection con = new SqlConnection(@"Server=tcp:abcinstitute.database.windows.net,1433;Initial Catalog=time-table;Persist Security Info=False;User ID=biyoni;Password=itpm12345@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataReader rd;
        int ID = 0;
        public StudentControl1()
        {
            InitializeComponent();
            displayYear();
            DisplayData();
            displaySession();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void StudentControl1_Load(object sender, EventArgs e)
        {
           
        }

        public void displaySession() {


            cmbSession.Items.Clear();
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

        public void displayYear()
        {


            cmbYear.Items.Clear();
            cmbGroup.Items.Clear();
            cmbSubGroup.Items.Clear();
            String sql = "SELECT * FROM Student_Management";
            con.Open();
            cmd = new SqlCommand(sql, con); 
             rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                cmbYear.Items.Add(rd["AcademicYearSemester"].ToString());
                cmbGroup.Items.Add(rd["GroupID"].ToString());
                cmbSubGroup.Items.Add(rd["SubGroupID"].ToString());

            }
            con.Close();


        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            String timeDuration = txtTIme.Text;
            String[] times = timeDuration.Split('-');
            DateTime temp;

            if (cmbYear.SelectedIndex < 0 || cmbSubGroup.SelectedIndex < 0 || cmbSubGroup.SelectedIndex < 0 || cmbSession.SelectedIndex < 0 || txtTIme.Text == "" || times.Length != 2 || !DateTime.TryParse(times[0].Trim(), out temp) || !DateTime.TryParse(times[1].Trim(), out temp))
            {

                if (cmbYear.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Select Year !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

            ///insert

            else
            {

                String texttime = DateTime.Parse(times[0].Trim()).ToString("HH:mm") + " - " + DateTime.Parse(times[1].Trim()).ToString("HH:mm");
                cmd = new SqlCommand("insert into tbl_StAvailability(Year,GroupNumber,SubGroupNumber,SessionID,Time) values(@year,@gNo,@sNO,@sessID,@time)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@year", cmbYear.Text);
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
            adapt = new SqlDataAdapter("select ID,Year,GroupNumber, SubGroupNumber,SessionID,Time from tbl_StAvailability", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void ClearData()
        {
            cmbYear.SelectedIndex = -1;
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

                if (cmbYear.SelectedIndex < 0 || cmbSubGroup.SelectedIndex < 0 || cmbSubGroup.SelectedIndex < 0 || cmbSession.SelectedIndex < 0 || txtTIme.Text == "" || times.Length != 2 || !DateTime.TryParse(times[0].Trim(), out temp) || !DateTime.TryParse(times[1].Trim(), out temp))
                {

                    if (cmbYear.SelectedIndex < 0)
                    {
                        MessageBox.Show("Please Select Year !", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
                    cmd = new SqlCommand("update tbl_StAvailability set year=@year,GroupNumber=@gNo,SubGroupNumber=@sNO,SessionID=@sessID,Time=@time where ID=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@year", cmbYear.Text);
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
                cmd = new SqlCommand("delete tbl_StAvailability where ID=@id", con);
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
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmbYear.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbGroup.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbSubGroup.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbSession.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTIme.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();


            cmd = new SqlCommand("select ID,Year,GroupNumber from tbl_StAvailability where ID=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
