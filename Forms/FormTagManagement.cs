using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace StudentsAndTagsManagement.Forms
{
    public partial class FormTagManagement : Form
    {
        /* Making the connection with the SQL server*/

        SqlConnection con = new SqlConnection(@"Server=tcp:abcinstitute.database.windows.net,1433;Initial Catalog=time-table;Persist Security Info=False;User ID=biyoni;Password=itpm12345@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int Record_ID;

        public FormTagManagement()
        {
            InitializeComponent();
            Showdata();
            state();
            
        }
        public void Showdata()
        {
            /* retrieving the data into the grid view*/
            adpt = new SqlDataAdapter("select * from Tags_Management", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            con.Open();

            if (ValidateChildren(ValidationConstraints.Enabled) &&
                tgNametxt.Text == "" || tagcodebx.Text == "" || rltedtagtxt.Text == "")
            {
                MessageBox.Show("Please fill out the Empty Field(s)",
                "Unable to Submit", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
            }
            else
            {
                /* Inserting data into the database*/
                cmd = new SqlCommand("insert into Tags_Management (TagName,TagCode,RelatedTag)values('" + tgNametxt.Text + "','" + tagcodebx.Text + "','" + rltedtagtxt.Text + "')", con);
                cmd.ExecuteNonQuery();
                tgNametxt.Clear();
                rltedtagtxt.Clear();
                con.Close();
                Showdata();
            }

            con.Close();
        }

        private void FormTagManagement_Load(object sender, EventArgs e)
        {

        }

        private void BTNclearData_Click(object sender, EventArgs e)
        {
            /* clearing the fields*/
            state();
            tgNametxt.Clear();
            rltedtagtxt.Clear();
        }

        private void BTNEditData_Click(object sender, EventArgs e)
        {
            /* updating the records*/

            con.Open();

            cmd = new SqlCommand("update Tags_Management set TagName = '" + tgNametxt.Text + "', TagCode = '" + tagcodebx.Text + "', RelatedTag = '" + rltedtagtxt.Text + "'" +
               "where tagID='" + Record_ID + "'", con);
            cmd.ExecuteNonQuery();
            state();
            MessageBox.Show("Your data will be successfully updated");
            con.Close();
            Showdata();
        }

        private void BTNdelete_Click(object sender, EventArgs e)
        {
            /* deleting a specific record*/

            con.Open();
     

            cmd = new SqlCommand("delete from Tags_Management where TagID='" + Record_ID + "'", con);
            cmd.ExecuteNonQuery();
            state();
            MessageBox.Show("Your data will be deleted successfully");
            con.Close();
            Showdata();
        }

        /* converting the table values again into the text boxes in the form*/
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            state1();
            Record_ID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            tgNametxt.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            tagcodebx.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            rltedtagtxt.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }

        private void state()
        {

            btnSubmitData.Enabled = true;
            BTNdelete.Enabled = false;
            BTNEditData.Enabled = false;



        }

        private void state1()
        {

            btnSubmitData.Enabled = false;
            BTNdelete.Enabled = true;
            BTNEditData.Enabled = true;



        }

    }
}
