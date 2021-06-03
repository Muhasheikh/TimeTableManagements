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

namespace dhara
{
    public partial class LocationMgt : Form
    {
        public LocationMgt()
        {
            InitializeComponent();
            Autonum();
        }
        SqlConnection con = new SqlConnection(@"Server=tcp:abcinstitute.database.windows.net,1433;Initial Catalog=time-table;Persist Security Info=False;User ID=biyoni;Password=itpm12345@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;
        SqlDataReader dr;
        bool Mode = true;
        string sql;
        String pid;


        public void Autonum()
        {
            sql = "select ID from loca order by ID desc";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            con.Close();
        }


        public void load()
        {
            sql = "select * from loca";
            cmd = new SqlCommand(sql, con);
            con.Open();

            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);

            }

            con.Close();

        }

        public void twooo_Load(object sender, EventArgs e)
        {
            sql = "select * from loca";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();

            sql = "select from loca";
            cmd = new SqlCommand(sql, con);




            while (dr.Read()) {

                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);


            }


            con.Close();
        }

        public void getid(String id)
        {
            sql = "select * from loca where ID = '" + id + "'";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txid.Text = dr[0].ToString();
                tbuild.Text = dr[1].ToString();
                tfloor.Text = dr[2].ToString();
                troom.Text = dr[3].ToString();
                cap.Text = dr[4].ToString();
                ttype.Text = dr[5].ToString();

            }
            con.Close();
        }






        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                txtid.Enabled = false;
                pid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                getid(pid);

            }
            else if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
            {

                Mode = false;

                pid = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                sql = "delete from loca where ID = @ID";
                con.Open();
                cmd = new SqlCommand(sql, con);



                cmd.Parameters.AddWithValue("@ID", pid);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Deleteeeeee");
                con.Close();
            }
        }
            
               /* sql = "update loca set floor=@floor,room=@room,capacity=@capacity,type=@type building= @building where ID = @ID";
                con.Open();
                cmd = new SqlCommand(sql, con);
                
                cmd.Parameters.AddWithValue("@floor", tfloor);
                cmd.Parameters.AddWithValue("@room", troom);
                cmd.Parameters.AddWithValue("@capacity", tcapacity);
                cmd.Parameters.AddWithValue("@type", ttype);
                cmd.Parameters.AddWithValue("@building", tbuild);
                cmd.Parameters.AddWithValue("@ID", pid);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Sucessfully");
                txtid.Enabled = true;
                Mode = true;*/



            
        

        private void troom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {





            sql = "update loca set building= @building, floor=@floor,room=@room,capacity=@capacity,type=@type where ID=@ID ";

            con.Open();

            cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@ID", txid.Text);

            cmd.Parameters.AddWithValue("@building", tbuild.Text);

            cmd.Parameters.AddWithValue("@floor", tfloor.Text);

            cmd.Parameters.AddWithValue("@room", troom.Text);

            cmd.Parameters.AddWithValue("@capacity", cap.Text);

            cmd.Parameters.AddWithValue("@type", ttype.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated!!!");
            txtid.Enabled = true;
           // txid.Clear();
           // tbuild.Items.Clear();
            //tfloor.Items.Clear();
           // troom.Items.Clear();

           // ttype.Items.Clear();



            /*sql = "update loca set ID= @ID, floor=@floor,room=@room,capacity=@capacity,type=@type building= @building ";
            con.Open();
            cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@ID", txid);
            cmd.Parameters.AddWithValue("@floor", tfloor);
            cmd.Parameters.AddWithValue("@room", troom);
            cmd.Parameters.AddWithValue("@capacity", tcapacity);
            cmd.Parameters.AddWithValue("@type", ttype);
            cmd.Parameters.AddWithValue("@building", tbuild);


            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Sucessfully");*/

            con.Close();
            load();
            //txtid.Enabled = true;
            // Mode = true;
        }
            
       

        private void button3_Click(object sender, EventArgs e)
        {
            load();
            Autonum();
            txid.Clear();
            tbuild.Items.Clear();
            tfloor.Items.Clear();
            troom.Items.Clear();
           
            ttype.Items.Clear();




        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}