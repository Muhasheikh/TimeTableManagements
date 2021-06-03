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
    public partial class ManageSub : Form
    {

        SqlConnection con = new SqlConnection(@"Server=tcp:abcinstitute.database.windows.net,1433;Initial Catalog=time-table;Persist Security Info=False;User ID=biyoni;Password=itpm12345@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public int id;
        SqlCommand cmd;
        SqlDataReader dr;
       // bool Mode = true;
        String sql;
        SqlDataAdapter adpt;
        DataSet ds = new DataSet();
        int Record_ID;
        DataTable dt;


        public ManageSub()
        {
            InitializeComponent();
            Loaddata();
            state();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = new SqlCommand("update Subject_Management set Offered_year = '" + comboBox1.Text + "', Offered_semester = '" + comboBox2.Text + "', subject_code = '" + textBox1.Text + "', subject_name = '" + textBox2.Text + "'," +
                " lec_hours = '" + comboBox3.Text + "', tute_hours = '" + comboBox4.Text + "', lab_hours = '" + comboBox5.Text + "', ev_hours = '" + comboBox6.Text + "'" +
                "where subject_code='" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Update Successfully!!");
            con.Close();
            Loaddata();
            state();

            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            textBox2.Clear();
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;

        }

        private void ManageSub_Load(object sender, EventArgs e)
        {

        }

        public void Loaddata()
        {
            /* retrieving the data into the grid view*/
            adpt = new SqlDataAdapter("select * from Subject_Management", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            state1();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            comboBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            comboBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = new SqlCommand("delete from Subject_Management where subject_code='" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data deleted successfully");
            con.Close();
            Loaddata();
            state();

            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            textBox2.Clear();
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            subject sub = new subject();
            this.Hide();
            sub.Show();
        }

        private void state()
        {


            button2.Enabled = false;
            button1.Enabled = false;




        }

        private void state1()
        {


            button1.Enabled = true;
            button2.Enabled = true;



        }
    }

}
