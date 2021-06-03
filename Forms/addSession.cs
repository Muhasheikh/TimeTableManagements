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
    public partial class addSession : Form
    {
        public addSession()
        {
            InitializeComponent();
            LecName1ComboFill();
            LecName2ComboFill();
            subjectsComboFill();
            subjectCodesComboFill();
            TagComboFill();
            GroupIDComboFill();
          //  Showdata();

        }

        SqlConnection con = new SqlConnection(@"Server=tcp:abcinstitute.database.windows.net,1433;Initial Catalog=time-table;Persist Security Info=False;User ID=biyoni;Password=itpm12345@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;
        SqlDataReader dr;
        bool Mode = true;
        String sql;
        SqlDataAdapter adpt;
        DataSet ds = new DataSet();


        public static DataTable DataSource { get; private set; }
        public static string ValueMember { get; private set; }
        public static string DisplayMember { get; private set; }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addSession_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            manageSess session = new manageSess();
            this.Hide();
            session.Show();
        }

        internal void show()
        {
            throw new NotImplementedException();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled) &&
                lec1.Text == ""  || sub.Text == "" || code.Text == "" || tag.Text == "" || grpID.Text == "" || subgrp.Text == "" || numOfStu.Text == "" || dur.Text == "")
            {
                MessageBox.Show("Please fill out all the Field(s)",
                "Unable to Submit", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
            }
            else
            {

                con.Open();

                cmd = new SqlCommand("insert into Session_Management ( Lecturer_1 , Lecturer_2 , subject_name , subject_code , Tags , GroupID , SubGroupID, NumberOfStudents, Duration)" +
                    "values('" + lec1.Text + "','" + lec2.Text + "','" + sub.Text + "','" + code.Text + "'" +
                    ",'" + tag.Text + "','" + grpID.Text + "','" + subgrp.Text + "','" + numOfStu.Text + "','" + dur.Text + "')", con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Insert Successfully!!");
                con.Close();

                lec1.SelectedIndex = -1;
                lec2.SelectedIndex = -1;
                sub.SelectedIndex = -1;
                code.SelectedIndex = -1;
                tag.SelectedIndex = -1;
                grpID.SelectedIndex = -1;
                subgrp.SelectedIndex = -1;
                numOfStu.Clear();
                dur.SelectedIndex = -1;
                // Lname.Clear();
            }
        }



        //load lecturers names to the combobox from the lectuters database
        public void LecName1ComboFill()
        {
            cmd = new SqlCommand("select Lecturer_Name,ID from Lec_details", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                lec1.DataSource = ds.Tables[0];
                lec1.ValueMember = "ID";
                lec1.DisplayMember = "Lecturer_Name";

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
                lec2.DataSource = ds.Tables[0];
                lec2.ValueMember = "ID";
                lec2.DisplayMember = "Lecturer_Name";

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
            cmd = new SqlCommand("select TagName,TagID from Tags_Management", con);
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
                grpID.DataSource = ds.Tables[0];
                grpID.ValueMember = "StID";
                grpID.DisplayMember = "GroupID";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 main = new Form1();
            //this.Hide();
            //main.Show();
        }
    }
}
