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
using System.Data;

namespace ITPM
{
    public partial class manageSess : Form
    {
        SqlConnection con = new SqlConnection(@"Server=tcp:abcinstitute.database.windows.net,1433;Initial Catalog=time-table;Persist Security Info=False;User ID=biyoni;Password=itpm12345@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        DataSet ds = new DataSet();
        int Record_ID;
        SqlDataReader dr;




        public manageSess()
        {
            InitializeComponent();
            Showdata();
            LecName1ComboFill();
            LecName2ComboFill();
            subjectsComboFill();
            subjectCodesComboFill();
            TagComboFill();
            GroupIDComboFill();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void manageSess_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Record_ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            name1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            name2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            sub.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            code.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            tag.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            grpid.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            subid.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            numofstu.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            dura.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();


        }
        
        //method to call the data to the datagridview
        public void Showdata()
        {
            /* retrieving the data into the grid view*/
            adpt = new SqlDataAdapter("select * from Session_Management", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            /* updating the records*/

            if (ValidateChildren(ValidationConstraints.Enabled) &&
                name1.Text == ""  || sub.Text == "" || code.Text == "" || tag.Text == "" || grpid.Text == "" || subid.Text == "" || numofstu.Text == "" || dura.Text == "")
            {
                MessageBox.Show("Please fill out all the Empty Field(s)",
                "Unable to Submit", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
            }

            else {

                con.Open();

                cmd = new SqlCommand("update Session_Management set Lecturer_1 = '" + name1.Text + "', Lecturer_2 = '" + name2.Text + "', subject_name = '" + sub.Text + "', subject_code = '" + code.Text + "'," +
                    " Tags = '" + tag.Text + "', GroupID = '" + grpid.Text + "', SubGroupID = '" + subid.Text + "', NumberOfStudents = '" + numofstu.Text + "', Duration = '" + dura.Text + "' " +
                    "where SessionID ='" + Record_ID + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully!!!");
                con.Close();
                Showdata();

                name1.SelectedIndex = -1;
                name2.SelectedIndex = -1;
                sub.SelectedIndex = -1;
                code.SelectedIndex = -1;
                tag.SelectedIndex = -1;
                grpid.SelectedIndex = -1;
                subid.SelectedIndex = -1;
                numofstu.Clear();
                dura.SelectedIndex = -1;


            }
            

        }

        //load lecturers names to the combobox from the lectuters database
        public void LecName1ComboFill()
        {
            cmd = new SqlCommand("select Lecturer_Name,ID from Lec_details", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                name1.DataSource = ds.Tables[0];
                name1.ValueMember = "ID";
                name1.DisplayMember = "Lecturer_Name";

            }

        }

        //load lecturers names to the combobox from the lectuters database
        public void LecName2ComboFill()
        {
            cmd = new SqlCommand("select Lecturer_Name,ID from Lec_details", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                name2.DataSource = ds.Tables[0];
                name2.ValueMember = "ID";
                name2.DisplayMember = "Lecturer_Name";

            }
        }

        //load subjects to the combobox from the subject database
        public void subjectsComboFill()
        {
            cmd = new SqlCommand("select subject_name,ID from Subject_Management", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                sub.DataSource = ds.Tables[0];
                sub.ValueMember = "ID";
                sub.DisplayMember = "subject_name";

            }
        }

        public void subjectCodesComboFill()
        {
            cmd = new SqlCommand("select subject_code,ID from Subject_Management", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                code.DataSource = ds.Tables[0];
                code.ValueMember = "ID";
                code.DisplayMember = "subject_code";

            }
        }

        public void TagComboFill()
        {
            cmd = new SqlCommand("select TagID,TagName from Tags_Management", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                tag.DataSource = ds.Tables[0];
                tag.ValueMember = "TagID";
                tag.DisplayMember = "TagName";

            }
        }


        public void GroupIDComboFill()
        {
            cmd = new SqlCommand("select GroupID,StID from Student_Management", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                grpid.DataSource = ds.Tables[0];
                grpid.ValueMember = "StID";
                grpid.DisplayMember = "GroupID";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* deleting a record*/

            con.Open();

            cmd = new SqlCommand("delete from Session_Management where SessionID='" + Record_ID + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully!!!");
            con.Close();
            Showdata();

            name1.SelectedIndex = -1;
            name2.SelectedIndex = -1;
            sub.SelectedIndex = -1;
            code.SelectedIndex = -1;
            tag.SelectedIndex = -1;
            grpid.SelectedIndex = -1;
            subid.SelectedIndex = -1;
            numofstu.Clear();
            dura.SelectedIndex = -1;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            addSession session = new addSession();
            this.Hide();
            session.Show();
        }

        public void display()
        {
            dt = new DataTable();

            if (textBox1.Text.Length > 0)
            {
                adpt = new SqlDataAdapter("select * from Session_Management where Lecturer_1 like '" + textBox1.Text + " %'", con);

                adpt.Fill(dt);
            }
            else if (textBox2.Text.Length > 0)
            {
                adpt = new SqlDataAdapter("select * from Session_Management where subject_name like '" + textBox2.Text + " %'", con);

                adpt.Fill(dt);
            }
            dataGridView2.DataSource = dt;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
            display();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            display();
        }
    }
}
