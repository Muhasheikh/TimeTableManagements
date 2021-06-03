using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StudentsAndTagsManagement.Forms
{
    public partial class FormDashboard : Form
    {

        /* Making the connection with the SQL server*/


        SqlConnection con = new SqlConnection(@"Server=tcp:abcinstitute.database.windows.net,1433;Initial Catalog=time-table;Persist Security Info=False;User ID=biyoni;Password=itpm12345@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataReader rd;
        private SqlCommand command1;

        public FormDashboard()
        {
            InitializeComponent();
            LoadData();
            LoadData1();
            LoadData2();



        }

        //load data

        private void LoadData2()
        {

            try
            {

                String getLecturers = "select count(*) from Subject_Management";



                con.Open();




                command1 = new SqlCommand(getLecturers, con);


                SqlDataReader reader1 = command1.ExecuteReader();


                while (reader1.Read())
                {
                    int studentCount = reader1.GetInt32(0);
                    lableSub.Text = studentCount.ToString();


                    con.Close();
                }
            }


            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private void LoadData1()
        {

            try
            {

                String getLecturers = "select count(*) from Lec_Details";



                con.Open();




                command1 = new SqlCommand(getLecturers, con);


                SqlDataReader reader1 = command1.ExecuteReader();


                while (reader1.Read())
                {
                    int studentCount = reader1.GetInt32(0);
                    labelLecs.Text = studentCount.ToString();


                    con.Close();
                }
            }


            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
        private void LoadData()
        {
            try
            {

                String getStudents = "select count(*) from Student_Management";



                con.Open();




                command1 = new SqlCommand(getStudents, con);


                SqlDataReader reader1 = command1.ExecuteReader();


                while (reader1.Read())
                {
                    int studentCount = reader1.GetInt32(0);
                    lableSt.Text = studentCount.ToString();


                    con.Close();
                }
            }


            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }



        private void labelTTG_Click(object sender, EventArgs e)
        {

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("Select subject_name,COUNT(ID) as c from Subject_Management GROUP BY subject_name", con);
            adapt.Fill(ds, "subject_name");
            chart1.DataSource = ds.Tables["subject_name"];

            chart1.Series["Series1"].XValueMember = "subject_name";
            chart1.Series["Series1"].YValueMembers = "c";
            chart1.Series["Series1"].ChartType = SeriesChartType.Pie;


            //Roomchart.DataSource = dataBase1DataSet.mydb;
            chart1.DataBind();
            con.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
        }
    }
}
