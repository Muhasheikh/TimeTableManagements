using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace StudentsAndTagsManagement.Forms
{
    public partial class FormParallelSessions : Form
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

       
        public FormParallelSessions()
        {
            InitializeComponent();
            Showdata();
            state();
            loadSessionData();
            FillSubjectNameComboParallel();
            FillSubGroupIDComboParallel();
            FillSessionID2ComboParallel();
            FillSessionID1ComboParallel();
            FillGroupIDComboParallel();
            FillSubGroupID2ComboParallel();

        }

        public void Showdata()
        {
            /* retrieving the data into the grid view*/
            adpt = new SqlDataAdapter("select * from Parallel_Management", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewPSMData.DataSource = dt;
        }

        public void loadSessionData()
        {
            /* retrieving the data into the grid view*/
            adpt = new SqlDataAdapter("select * from Session_Management", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewSearchPSM.DataSource = dt;
        }

        //Retrieve subject names from the Subjects_Management table
        public void FillSubjectNameComboParallel()
        {
            cmd = new SqlCommand("Select subject_name,id from Subject_Management", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbSbNamePSM.DataSource = ds.Tables[0];
                cmbSbNamePSM.ValueMember = "id";
                cmbSbNamePSM.DisplayMember = "subject_name";

            }


        }
        //Retrieve subgroupIDs' from the Student_Management table
        public void FillGroupIDComboParallel()
        {
            cmd = new SqlCommand("Select GroupID,stID from Student_Management", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbGrpNoPSM.DataSource = ds.Tables[0];
                cmbGrpNoPSM.ValueMember = "stID";
                cmbGrpNoPSM.DisplayMember = "GroupID";

            }
        }

        //Retrieve subgroupIDs' from the Student_Management table
        public void FillSubGroupIDComboParallel()
        {
            cmd = new SqlCommand("Select SubGroupNumber,stID from Student_Management", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbSubGrpNoPSM.DataSource = ds.Tables[0];
                cmbSubGrpNoPSM.ValueMember = "stID";
                cmbSubGrpNoPSM.DisplayMember = "SubGroupNumber";

            }
        }

        //Retrieve subgroupID2s' from the Student_Management table
        public void FillSubGroupID2ComboParallel()
        {
            cmd = new SqlCommand("Select SubGroupNumber,stID from Student_Management", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbSubGrpNo2PSM.DataSource = ds.Tables[0];
                cmbSubGrpNo2PSM.ValueMember = "stID";
                cmbSubGrpNo2PSM.DisplayMember = "SubGroupNumber";

            }
        }

        //Retrieve sessions from the Session_Management table
        public void FillSessionID1ComboParallel()
        {
            cmd = new SqlCommand("Select SessionID,SessionID from Session_Management", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmboBoxS1PSM.DataSource = ds.Tables[0];
                cmboBoxS1PSM.ValueMember = "SessionID";
                cmboBoxS1PSM.DisplayMember = "SessionID";

            }
        }

        //Retrieve sessions from the Session_Management table
        public void FillSessionID2ComboParallel()
        {
            cmd = new SqlCommand("Select SessionID,SessionID from Session_Management", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmboBoxS2PSM.DataSource = ds.Tables[0];
                cmboBoxS2PSM.ValueMember = "SessionID"; 
                cmboBoxS2PSM.DisplayMember = "SessionID";

            }
        }

        /* inserting into the parallel_management table */
        private void btnSubmitPSM_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = new SqlCommand("insert into Parallel_Management (subject_name,GroupID,SubGroupID_1,SubGroupID_2,Session_1,Session_2)values('" + cmbSbNamePSM.Text + "','" + cmbGrpNoPSM.Text + "','" + cmbSubGrpNoPSM.Text + "','" + cmbSubGrpNo2PSM.Text + "','" + cmboBoxS1PSM.Text + "','" + cmboBoxS2PSM.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Showdata();



        }

        private void btnDeletePSM_Click(object sender, EventArgs e)
        {
            /* deleting a specific record*/

            con.Open();

            cmd = new SqlCommand("delete from Parallel_Management where ParallelID='" + Record_ID + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your data will be deleted successfully");
            state();
            con.Close();
            Showdata();
        }

        private void BtnEditPSM_Click(object sender, EventArgs e)
        {
            /* updating the records*/

            con.Open();

            cmd = new SqlCommand("update Parallel_Management set subject_name = '" + cmbSbNamePSM.Text + "',GroupID = '" + cmbGrpNoPSM.Text + "',SubGroupID_1 = '" + cmbSubGrpNoPSM.Text + "',SubGroupID_2 = '" + cmbSubGrpNo2PSM.Text + "', Session_1 = '" + cmboBoxS1PSM.Text + "', Session_2 = '" + cmboBoxS2PSM.Text + "'" +
           "where ParallelID='" + Record_ID + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your data will be successfully updated");
            state();
            con.Close();
            Showdata();
        }

        /* converting the table values again into the text boxes in the form*/
        private void dataGridViewPSMData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            state1();
            Record_ID = Convert.ToInt32(dataGridViewPSMData.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmbSbNamePSM.Text = dataGridViewPSMData.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbGrpNoPSM.Text = dataGridViewPSMData.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbSubGrpNoPSM.Text = dataGridViewPSMData.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbSubGrpNo2PSM.Text = dataGridViewPSMData.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmboBoxS1PSM.Text = dataGridViewPSMData.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmboBoxS2PSM.Text = dataGridViewPSMData.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void buttonSearchPSM_Click(object sender, EventArgs e)
        {
            loadSessionData();
        }

        private void cmboBoxS2PSM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void state() {

            btnSubmitPSM.Enabled = true;
            btnDeletePSM.Enabled = false;
            BtnEditPSM.Enabled = false;



        }

        private void state1()
        {

            btnSubmitPSM.Enabled = false;
            btnDeletePSM.Enabled = true;
            BtnEditPSM.Enabled = true;



        }
        private void FormParallelSessions_Load(object sender, EventArgs e)
        {

        }

        private void BtnClearCSM_Click(object sender, EventArgs e)
        {
            state();
        }
    }
    
}
