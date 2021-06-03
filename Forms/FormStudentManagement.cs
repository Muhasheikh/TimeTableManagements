using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;



namespace StudentsAndTagsManagement.Forms
{
    public partial class FormStudentManagement : Form
    {
        /* Making the connection with the SQL server*/

        SqlConnection con = new SqlConnection(@"Server=tcp:abcinstitute.database.windows.net,1433;Initial Catalog=time-table;Persist Security Info=False;User ID=biyoni;Password=itpm12345@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int Record_ID;

        public FormStudentManagement()
        {
            InitializeComponent();
            Showdata();
            state();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            con.Open();

            /* Generating the GroupID and the SubGroupID*/

            string GroupID = academicyrcmbx.Text + "." + programmecmbox.Text + "." + gpNumbertxbx.Text;
            string SubGroupID = academicyrcmbx.Text + "." + programmecmbox.Text + "." + gpNumbertxbx.Text + "." + SbgpNumbertxbx.Text;

            if (ValidateChildren(ValidationConstraints.Enabled) &&
                academicyrcmbx.Text == "" || programmecmbox.Text == "" || gpNumbertxbx.Text == "" || SbgpNumbertxbx.Text == "")
            {
                MessageBox.Show("Please fill out the Empty Field(s)",
                "Unable to Submit", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
            }
            else
            {
                /* Inserting data into the database*/
                cmd = new SqlCommand("insert into Student_Management (AcademicYearSemester,Programme,GroupNumber,SubGroupNumber,GroupID,SubGroupID)values('" + academicyrcmbx.Text + "','" + programmecmbox.Text + "','" + gpNumbertxbx.Text + "','" + SbgpNumbertxbx.Text + "','" + GroupID + "','" + SubGroupID + "')",con);
                cmd.ExecuteNonQuery();
                gpNumbertxbx.Clear();
                SbgpNumbertxbx.Clear();
                con.Close();
                Showdata();
            }
            con.Close();
        }

        public void Showdata()
        {
            /* retrieving the data into the grid view*/
            adpt = new SqlDataAdapter("select * from Student_Management",con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            /* clearing the fields*/
            state();
            gpNumbertxbx.Clear();
            SbgpNumbertxbx.Clear();

        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            /* deleting a specific record*/

            con.Open();
            string GroupID = academicyrcmbx.Text + "." + programmecmbox.Text + "." + gpNumbertxbx.Text;
            string SubGroupID = academicyrcmbx.Text + "." + programmecmbox.Text + "." + gpNumbertxbx.Text + "." + SbgpNumbertxbx.Text;

            cmd = new SqlCommand("delete from Student_Management where StID='" + Record_ID +  "'", con);
            cmd.ExecuteNonQuery();
            state();
            MessageBox.Show("Your data will be deleted successfully");
            con.Close();
            Showdata();

        }

        private void FormStudentManagement_Load(object sender, EventArgs e)
        {

        }

        private void LabelGroupNo_Click(object sender, EventArgs e)
        {

        }

        /* converting the table values again into the text boxes in the form*/
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            state1();
            Record_ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            academicyrcmbx.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            programmecmbox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            gpNumbertxbx.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            SbgpNumbertxbx.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            /* updating the records*/

            con.Open();
            string GroupID = academicyrcmbx.Text + "." + programmecmbox.Text + "." + gpNumbertxbx.Text;
            string SubGroupID = academicyrcmbx.Text + "." + programmecmbox.Text + "." + gpNumbertxbx.Text + "." + SbgpNumbertxbx.Text;

            cmd = new SqlCommand("update Student_Management set AcademicYearSemester = '" + academicyrcmbx.Text + "', Programme = '" + programmecmbox.Text + "', GroupNumber = '" + gpNumbertxbx.Text + "', SubGroupNumber = '" + SbgpNumbertxbx.Text + "', GroupID = '" + GroupID + "', SubGroupID = '" + SubGroupID + "'" +
               "where StID='" + Record_ID + "'",con);
            cmd.ExecuteNonQuery();
            state();
            MessageBox.Show("Your data will be successfully updated");
            con.Close();
            Showdata();
        }

        private void state()
        {

            btnSubmit.Enabled = true;
            btnManage.Enabled = false;
            BtnEdit.Enabled = false;



        }

        private void state1()
        {

            btnSubmit.Enabled = false;
            btnManage.Enabled = true;
            BtnEdit.Enabled = true;



        }
    }
}
