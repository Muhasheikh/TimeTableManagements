using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace finallllllllllllll
{
    public partial class Room : Form
    {

        SqlConnection con = new SqlConnection(@"Server=tcp:abcinstitute.database.windows.net,1433;Initial Catalog=time-table;Persist Security Info=False;User ID=biyoni;Password=itpm12345@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        DataSet ds = new DataSet();
        int Record_ID;

        public Room()
        {
            InitializeComponent();

            Showdata();
        }

        public void Showdata()
        {
            /* retrieving the data into the grid view*/
            adpt = new SqlDataAdapter("select * from Session_Management", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roomDataSet1.Session_Management' table. You can move, or remove it, as needed.
            //this.session_ManagementTableAdapter1.Fill(this.roomDataSet1.Session_Management);
            // TODO: This line of code loads data into the 'roomDataSet.Session_Management' table. You can move, or remove it, as needed.
           // this.session_ManagementTableAdapter.Fill(this.roomDataSet.Session_Management);

        }

        private void button4_Click(object sender, EventArgs e)
        {
           

        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = new SqlCommand("insert into room_management (Lecture_1,Lecture_2,subject_name,subject_code,Tags,GroupID,SubGroupID,NumberOfStudents,Duration,Room)" +
                "values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox8.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox5.Text + "','" + textBox4.Text + "','" + textBox2.Text + "','" + textBox10.Text + "','" + comboBox1.Text + "')", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Inserted Successfully");
            con.Close();
            // Showdata();


            textBox1.Clear();
            textBox3.Clear();
            textBox8.Clear();
            textBox7.Clear();
            textBox6.Clear();
          
               textBox5.Clear();
            textBox4.Clear();
            textBox2.Clear();
            textBox10.Clear();
            comboBox1.SelectedIndex = -1;



        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // Record_ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox2.Text= dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBox10.Text= dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomManage manage = new RoomManage();
            this.Hide();
            manage.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RoomManage rm = new RoomManage();
            rm.Show();
        }
    }
}
