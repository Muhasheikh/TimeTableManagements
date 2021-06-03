using ITPM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagement.Forms;
using dhara;
using finallllllllllllll;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace StudentsAndTagsManagement
{
    public partial class Form1 : Form
    {
        //declaring database connection
        SqlConnection con = new SqlConnection(@"Server=tcp:abcinstitute.database.windows.net,1433;Initial Catalog=time-table;Persist Security Info=False;User ID=biyoni;Password=itpm12345@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataReader rd;
        private SqlCommand command1;
        /*private SqlCommand command2;
        private SqlCommand command3;
        private SqlCommand command4;
        private SqlCommand command5;
        private SqlCommand command6;
        private SqlCommand command7;
        private SqlCommand command8;*/
        //fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
       
 

        //constructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
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

       

        private void LoadData1() {

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

        //methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColors.ColorList.Count);
            while(tempIndex == index)
            {
                index = random.Next(ThemeColors.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColors.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton( object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton!= (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);


                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelSide.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.White;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }

            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.panelForm.Controls.Add(childForm);
            this.panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void panelSide_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void DashBoard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDashboard(), sender);

        }

        private void buttonWorkingDays_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
           WorkControl wk = new WorkControl();
            MainControl.ShowControl(wk, panelForm);
        }

        private void buttonWorkingHours_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnLecturers_Click(object sender, EventArgs e)
        {
           
            ActivateButton(sender);
            Lec lc = new Lec();

            lc.Show();



        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
           OpenChildForm(new Forms.FormStudentManagement(), sender);
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            subject su = new subject();
            su.Show();
            
        }

        private void btnTags_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
           OpenChildForm(new Forms.FormTagManagement(), sender);
        }

        private void btnLocations_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            location loc = new location();
            loc.Show();
        }

        private void btnSessions_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.FormSessionManagement(), sender);
        }

        private void btnAvailability_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
   
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonLogo_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnAvailabilityM_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AvaControl wk = new AvaControl();
            MainControl.ShowControl(wk, panelForm);
        }

        private void BtnRoomM_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Room rm = new Room();
            rm.Show();
            
        }

        private void BtnStatM_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_TimeTable_Click(object sender, EventArgs e)
        {
            TimeTable wk = new TimeTable();
            MainControl.ShowControl(wk, panelForm);
        }

        private void Form1_Load(object sender, EventArgs e)
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
    }
}
