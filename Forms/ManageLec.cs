using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ITPM
{
    public partial class ManageLec : Form
    {
        public ManageLec()
        {
            InitializeComponent();
            state();
           // state1();
            Showdata();

        }

        SqlConnection con = new SqlConnection(@"Server=tcp:abcinstitute.database.windows.net,1433;Initial Catalog=time-table;Persist Security Info=False;User ID=biyoni;Password=itpm12345@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public int id;
        SqlCommand cmd;
        SqlDataReader dr;
        bool Mode = true;
        String sql;
        SqlDataAdapter adpt;
        DataSet ds = new DataSet();
        int Record_ID;
        DataTable dt;


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ManageLec_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lec lc = new Lec();
            lc.Show();
        }

        

      
            public void Showdata()
            {
                /* retrieving the data into the grid view*/
                adpt = new SqlDataAdapter("select * from Lec_details", con);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //id =Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);

            //  Record_ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            state1();
            lecName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            lvl.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            LID.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            center.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            faculty.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            depart.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            building.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (ValidateChildren(ValidationConstraints.Enabled) &&
               lecName.Text == "" || lvl.Text == "" || LID.Text == "" || center.Text == "" || faculty.Text == "" || depart.Text == "" || building.Text == "")
            {
                MessageBox.Show("Please fill out the Empty Field(s)",
                "Unable to Submit", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
            }
            else
            {

                sql = "update Lec_details set Lecturer_Name = @Lecturer_Name,Level = @Level,LecturerID = @LecturerID,Center = @Center,Faculty = @Faculty,Department = @Department,Building = @Building where LecturerID = @LecturerID ";
                con.Open();
                cmd = new SqlCommand(sql, con);
                state();

                cmd.Parameters.AddWithValue("@Lecturer_Name", lecName.Text);
                cmd.Parameters.AddWithValue("@Level", lvl.Text);
                cmd.Parameters.AddWithValue("@LecturerID", LID.Text);
                cmd.Parameters.AddWithValue("@Center", center.Text);
                cmd.Parameters.AddWithValue("@Faculty", faculty.Text);
                cmd.Parameters.AddWithValue("@Department", depart.Text);
                cmd.Parameters.AddWithValue("@Building", building.Text);


                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Data Update Successfully!!");

                Showdata();

                lecName.Clear();
                lvl.SelectedIndex = -1;
                LID.Clear();
                center.SelectedIndex = -1;
                faculty.SelectedIndex = -1;
                depart.SelectedIndex = -1;
                building.SelectedIndex = -1;


            }




        }

       /* private void GetRecords()
        {
            cmd = new SqlCommand("select * from Lec_details", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView1.DataSource = dt;
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            sql = "delete from Lec_details where LecturerID = @LecturerID ";
            con.Open();
            cmd = new SqlCommand(sql, con);
            state();

           
            cmd.Parameters.AddWithValue("@LecturerID", LID.Text);
            


            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Delete Successfully!!");


            Showdata();


            lvl.SelectedIndex = -1;
            center.SelectedIndex = -1;
            lecName.Clear();
            LID.Clear();
            faculty.SelectedIndex = -1;
            depart.SelectedIndex = -1;
            building.SelectedIndex = -1;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ManageHnD manage = new ManageHnD();
            //this.Hide();
            //manage.Show();
        }

        private void fclt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void state()
        {


            button2.Enabled = false;
            button1.Enabled = false;
          



        }

        private void state1()
        {

            
            button2.Enabled = true;
            button1.Enabled = true;



        }
    }

}
