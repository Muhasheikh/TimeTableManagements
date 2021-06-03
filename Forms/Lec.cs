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
    public partial class Lec : Form
    {
        public Lec()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Server=tcp:abcinstitute.database.windows.net,1433;Initial Catalog=time-table;Persist Security Info=False;User ID=biyoni;Password=itpm12345@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;
        String sql;
        bool Mode = true;



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            


            if (ValidateChildren(ValidationConstraints.Enabled) &&
               Lname.Text == "" || level.Text == "" || LecID.Text == "" || center.Text == "" || faculty.Text == "" || department.Text == "" || building.Text == "")
            {
                MessageBox.Show("Please fill out the Empty Field(s)",
                "Unable to Submit", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
            }
            else
            {

                if (Mode == true)

                {

                    String name = Lname.Text;
                    String lvl = level.SelectedItem.ToString();
                    String id = LecID.Text;
                    String cntr = center.SelectedItem.ToString();
                    String fclty = faculty.SelectedItem.ToString();
                    String dep = department.SelectedItem.ToString();
                    String bldn = building.SelectedItem.ToString();
                    String rank = level.Text + "." + LecID.Text;


                    sql = "insert into Lec_details(Lecturer_Name,Level,LecturerID,Center,Faculty,Department,Building,Rank)values(@Lecturer_Name,@Level,@LecturerID,@Center,@Faculty,@Department,@Building,@Rank)";
                    con.Open();
                    cmd = new SqlCommand(sql, con);


                    cmd.Parameters.AddWithValue("@Lecturer_Name", name);
                    cmd.Parameters.AddWithValue("@Level", lvl);
                    cmd.Parameters.AddWithValue("@LecturerID", id);
                    cmd.Parameters.AddWithValue("@Center", cntr);
                    cmd.Parameters.AddWithValue("@Faculty", fclty);
                    cmd.Parameters.AddWithValue("@Department", dep);
                    cmd.Parameters.AddWithValue("@Building", bldn);
                    cmd.Parameters.AddWithValue("@Rank", rank);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Insert Successfully!!");


                    con.Close();

                    LecID.Clear();
                    Lname.Clear();
                    level.SelectedIndex = -1;
                    center.SelectedIndex = -1;
                    faculty.SelectedIndex = -1;
                    department.SelectedIndex = -1;
                    building.SelectedIndex = -1;
                }

            }


            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        


        private void button16_Click_1(object sender, EventArgs e)
        {
            ManageLec manage = new ManageLec();
           
            manage.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
