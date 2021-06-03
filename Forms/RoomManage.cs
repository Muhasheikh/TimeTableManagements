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






namespace finallllllllllllll
{
    public partial class RoomManage : Form
    {
        public RoomManage()
        {
            InitializeComponent();
            Showdata();
        }
        SqlConnection con = new SqlConnection(@"Server=tcp:abcinstitute.database.windows.net,1433;Initial Catalog=time-table;Persist Security Info=False;User ID=biyoni;Password=itpm12345@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        DataSet ds = new DataSet();
        int Record_ID;


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    cboState.Text = cboState.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Record_ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        public void Showdata()
        {
            /* retrieving the data into the grid view*/
            adpt = new SqlDataAdapter("select * from room_management", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /* updating the records*/

            con.Open();

            cmd = new SqlCommand("update room_management set Room = '" + comboBox1.Text + "'"+
           "where roomID ='" + Record_ID + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("successfully updated");
            con.Close();
            comboBox1.SelectedIndex = -1;
            Showdata();

        }
    }
}
