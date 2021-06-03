using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace StudentsAndTagsManagement.Forms
{
    public partial class FormNonOverlappingSessions : Form
    {

        /* Making the connection with the SQL server*/

        SqlConnection con = new SqlConnection(@"Server=tcp:abcinstitute.database.windows.net,1433;Initial Catalog=time-table;Persist Security Info=False;User ID=biyoni;Password=itpm12345@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        DataSet ds = new DataSet();
        int Record_ID;


        public static DataTable DataSource { get; private set; }
        public static string ValueMember { get; private set; }
        public static string DisplayMember { get; private set; }


        public FormNonOverlappingSessions()
        {
            InitializeComponent();
            Showdata();
            state();
            FillSubjectCode1ComboNonOverlapping();
            FillSubjectCode2ComboNonOverlapping();
            FillGroupIDComboNonOverlapping();
            FillSubGroupIDComboConsecutive();
            FillSessionID1ComboNonOverlapping();
            FillSessionID2ComboNonOverlapping();
            FillSessionID3ComboNonOverlapping();

        }

        public void Showdata()
        {
            /* retrieving the data into the grid view*/
            adpt = new SqlDataAdapter("select * from NonOverlapping_Management", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewNOSM.DataSource = dt;
        }

        public void loadSessionData()
        {
            /* retrieving the data into the grid view*/
            adpt = new SqlDataAdapter("select * from Session_Management", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewSessionDetails.DataSource = dt;
        }

        //Retrieve subject codes from the Subjects_Management table
        public void FillSubjectCode1ComboNonOverlapping()
        {
            cmd = new SqlCommand("Select subject_code,id from Subject_Management", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbSbCodeNOSM.DataSource = ds.Tables[0];
                cmbSbCodeNOSM.ValueMember = "id";
                cmbSbCodeNOSM.DisplayMember = "subject_code";

            }


        }

        //Retrieve subject codes from the Subjects_Management table
        public void FillSubjectCode2ComboNonOverlapping()
        {
            cmd = new SqlCommand("Select subject_code,id from Subject_Management", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbSbCode2NOSM.DataSource = ds.Tables[0];
                cmbSbCode2NOSM.ValueMember = "id";
                cmbSbCode2NOSM.DisplayMember = "subject_code";

            }


        }


        //Retrieve GroupIDs' from the Student_Management table
        public void FillGroupIDComboNonOverlapping()
        {
            cmd = new SqlCommand("Select GroupID,StID from Student_Management", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbGrpNoNOSM.DataSource = ds.Tables[0];
                cmbGrpNoNOSM.ValueMember = "StID";
                cmbGrpNoNOSM.DisplayMember = "GroupID";


            }


        }

        //Retrieve SubGroupIDs' from the Student_Management table
        public void FillSubGroupIDComboConsecutive()
        {
            cmd = new SqlCommand("Select SubGroupNumber,StID from Student_Management", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbSubGrpNoNOSM.DataSource = ds.Tables[0];
                cmbSubGrpNoNOSM.ValueMember = "StID";
                cmbSubGrpNoNOSM.DisplayMember = "SubGroupNumber";


            }


        }

        //Retrieve sessions from the Session_Management table
        public void FillSessionID1ComboNonOverlapping()
        {
            cmd = new SqlCommand("Select SessionID,SessionID from Session_Management", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbNOSM1.DataSource = ds.Tables[0];
                cmbNOSM1.ValueMember = "SessionID";
                cmbNOSM1.DisplayMember = "SessionID";

            }
        }

        //Retrieve sessions from the Session_Management table
        public void FillSessionID2ComboNonOverlapping()
        {
            cmd = new SqlCommand("Select SessionID,SessionID from Session_Management", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbNOSM2.DataSource = ds.Tables[0];
                cmbNOSM2.ValueMember = "SessionID";
                cmbNOSM2.DisplayMember = "SessionID";

            }
        }

        //Retrieve sessions from the Session_Management table
        public void FillSessionID3ComboNonOverlapping()
        {
            cmd = new SqlCommand("Select SessionID,SessionID from Session_Management", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbNOSM3.DataSource = ds.Tables[0];
                cmbNOSM3.ValueMember = "SessionID";
                cmbNOSM3.DisplayMember = "SessionID";

            }
        }

        private void btnSubmitNOSM_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = new SqlCommand("insert into NonOverlapping_Management (subject_code1,subject_code2,GroupID,SubGroupNumber,Session_1,Session_2,Session_3)values('" + cmbSbCodeNOSM.Text + "','" + cmbSbCode2NOSM.Text + "','" + cmbGrpNoNOSM.Text + "','" + cmbSubGrpNoNOSM.Text + "','" + cmbNOSM1.Text + "','" + cmbNOSM2.Text + "','" + cmbNOSM3.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Showdata();
        }

        private void BtnEditNOSM_Click(object sender, EventArgs e)
        {
            /* updating the records*/

            con.Open();

            cmd = new SqlCommand("update NonOverlapping_Management set subject_code1 = '" + cmbSbCodeNOSM.Text + "',subject_code2 = '" + cmbSbCode2NOSM.Text + "',GroupID = '" + cmbGrpNoNOSM.Text + "',SubGroupID = '" + cmbSubGrpNoNOSM.Text + "', Session_1 = '" + cmbNOSM1.Text + "',, Session_2 = '" + cmbNOSM2.Text + "' Session_3 = '" + cmbNOSM3.Text + "'" +
           "where NonOverlappingID='" + Record_ID + "'", con);
            cmd.ExecuteNonQuery();
            state();
            MessageBox.Show("Your data will be successfully updated");
            con.Close();
            Showdata();
        }

        private void btnDeleteNOSM_Click(object sender, EventArgs e)
        {
            /* deleting a specific record*/

            con.Open();

            cmd = new SqlCommand("delete from NonOverlapping_Management where NonOverlappingID='" + Record_ID + "'", con);
            cmd.ExecuteNonQuery();
            state();
            MessageBox.Show("Your data will be deleted successfully");
            con.Close();
            Showdata();
        }

        private void BtnShowSessionDetails_Click(object sender, EventArgs e)
        {
            loadSessionData();
        }

        private void state()
        {

            btnSubmitNOSM.Enabled = true;
            btnDeleteNOSM.Enabled = false;
            BtnEditNOSM.Enabled = false;



        }

        private void state1()
        {

            btnSubmitNOSM.Enabled = false;
            btnDeleteNOSM.Enabled = true;
            BtnEditNOSM.Enabled = true;



        }

        private void dataGridViewNOSM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            state1();
            Record_ID = Convert.ToInt32(dataGridViewNOSM.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmbSbCodeNOSM.Text = dataGridViewNOSM.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbSbCode2NOSM.Text = dataGridViewNOSM.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbGrpNoNOSM.Text = dataGridViewNOSM.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbSubGrpNoNOSM.Text = dataGridViewNOSM.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbNOSM1.Text = dataGridViewNOSM.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbNOSM2.Text = dataGridViewNOSM.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbNOSM3.Text = dataGridViewNOSM.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void BtnClearCSM_Click(object sender, EventArgs e)
        {
            state();
        }
    }

}
