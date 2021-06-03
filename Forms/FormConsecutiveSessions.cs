using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentsAndTagsManagement.Forms
{
    public partial class FormConsecutiveSessions : Form
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

        public FormConsecutiveSessions()
        {
            InitializeComponent();
            
            FillSubjectCodeComboConsecutive();
            FillGroupIDComboConsecutive();
            state();
            FillSessionID1ComboConsecutive();
            FillSessionID2ComboConsecutive();
            FillSubGroupIDComboConsecutive();
            Showdata();
        }


        public void Showdata()
        {
            /* retrieving the data into the grid view*/
            adpt = new SqlDataAdapter("select * from Consecutive_Management", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewCSMData.DataSource = dt;
        }
        public void loadSessionData()
        {
            /* retrieving the data into the grid view*/
            adpt = new SqlDataAdapter("select * from Session_Management", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewSearch.DataSource = dt;
        }

        private void btnClearCSM_Click(object sender, EventArgs e)
        {

        }

    
        //Retrieve subject codes from the Subjects_Management table
        public void FillSubjectCodeComboConsecutive()
        {
            cmd = new SqlCommand("Select subject_code,id from Subject_Management", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbSbCodeCSM.DataSource = ds.Tables[0];
                cmbSbCodeCSM.ValueMember = "id";
                cmbSbCodeCSM.DisplayMember = "subject_code";

            }


        }

        //Retrieve GroupIDs' from the Student_Management table
        public void FillGroupIDComboConsecutive()
        {
            cmd = new SqlCommand("Select GroupID,StID from Student_Management", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbGrpNoCSM.DataSource = ds.Tables[0];
                cmbGrpNoCSM.ValueMember = "StID";
                cmbGrpNoCSM.DisplayMember = "GroupID";
                

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
                cmbSubGrpNoCSM.DataSource = ds.Tables[0];
                cmbSubGrpNoCSM.ValueMember = "StID";
                cmbSubGrpNoCSM.DisplayMember = "SubGroupNumber";


            }


        }

        internal void show()
        {
            throw new NotImplementedException();
        }

        //Retrieve sessions from the Session_Management table
        public void FillSessionID1ComboConsecutive()
        {
            cmd = new SqlCommand("Select SessionID,SessionID from Session_Management", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbSID1.DataSource = ds.Tables[0];
                cmbSID1.ValueMember = "SessionID";
                cmbSID1.DisplayMember = "SessionID";

            }
        }

        //Retrieve sessions from the Session_Management table
        public void FillSessionID2ComboConsecutive()
        {
            cmd = new SqlCommand("Select SessionID,SessionID from Session_Management", con);
            adpt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adpt.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbSID2.DataSource = ds.Tables[0];
                cmbSID2.ValueMember = "SessionID";
                cmbSID2.DisplayMember = "SessionID";

            }
        }

        private void FormConsecutiveSessions_Load(object sender, EventArgs e)
        {

        }

        //inserting records into the database
        private void btnSubmitCSM_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = new SqlCommand("insert into Consecutive_Management (subject_code,GroupID,SubGroupID,Session_1,Session_2)values('" + cmbSbCodeCSM.Text + "','" + cmbGrpNoCSM.Text + "','" + cmbSubGrpNoCSM.Text + "','" + cmbSID1.Text + "','" + cmbSID2.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Showdata();



        }

        private void btnDeleteCSM_Click(object sender, EventArgs e)
        {
            /* deleting a specific record*/

            con.Open();
      
            cmd = new SqlCommand("delete from Consecutive_Management where ConsecutiveID='" + Record_ID + "'", con);
            cmd.ExecuteNonQuery();
            state();
            MessageBox.Show("Your data will be deleted successfully");
            con.Close();
            Showdata();
        }



        private void BtnEditCSM_Click(object sender, EventArgs e)
        {
            /* updating the records*/

            con.Open(); 

            cmd = new SqlCommand("update Consecutive_Management set subject_code = '" + cmbSbCodeCSM.Text + "',GroupID = '" + cmbGrpNoCSM.Text + "',SubGroupID = '" + cmbSubGrpNoCSM.Text + "', Session_1 = '" + cmbSID1.Text + "', Session_2 = '" + cmbSID2.Text + "'" +
           "where ConsecutiveID='" + Record_ID + "'", con);
            cmd.ExecuteNonQuery();
            state();
            MessageBox.Show("Your data will be successfully updated");
            con.Close();
            Showdata();
        
        }
       /* converting the table values again into the text boxes in the form*/
        private void dataGridViewCSMData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            state1();
            Record_ID = Convert.ToInt32(dataGridViewCSMData.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmbSbCodeCSM.Text = dataGridViewCSMData.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbGrpNoCSM.Text = dataGridViewCSMData.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbSubGrpNoCSM.Text = dataGridViewCSMData.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbSID1.Text = dataGridViewCSMData.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbSID2.Text = dataGridViewCSMData.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            loadSessionData();


        }

        private void state()
        {

            btnSubmitCSM.Enabled = true;
            btnDeleteCSM.Enabled = false;
            BtnEditCSM.Enabled = false;



        }

        private void state1()
        {

            btnSubmitCSM.Enabled = false;
            btnDeleteCSM.Enabled = true;
            BtnEditCSM.Enabled = true;



        }

        private void BtnClearCSM_Click_1(object sender, EventArgs e)
        {
            state();


        }
    }
}
