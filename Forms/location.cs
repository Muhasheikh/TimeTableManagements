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
    public partial class location : Form
    {
        public location()
        {
            InitializeComponent();
            Autonum();
        }
        SqlConnection con = new SqlConnection(@"Server=tcp:abcinstitute.database.windows.net,1433;Initial Catalog=time-table;Persist Security Info=False;User ID=biyoni;Password=itpm12345@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;
        SqlDataReader dr;
        String proid;
        string sql;
        

        public void Autonum()
        {
            sql = "select ID from loca order by ID desc";
            cmd = new SqlCommand(sql,con);
            con.Open();
            dr = cmd.ExecuteReader();
            
            /*
            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                proid = id.ToString("00000");
            }
            else if (Convert.IsDBNull(dr))
            {
                proid = ("00000");
            }
            else
            {
                proid = ("00000");

            }

            textid.Text = proid.ToString(); */
            con.Close();
           
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           
            //String tid = textid.Text;
            String floor = txtfloor.SelectedItem.ToString();
            String room = txtroom.SelectedItem.ToString();
            String capacity = tcap.Text;

            String type = txttype.SelectedItem.ToString();
            String build = txtbuild.SelectedItem.ToString();

            sql = "Insert into loca(floor,room,capacity,type,building)values(@floor,@room,@capacity,@type,@building)";
            con.Open();
            cmd = new SqlCommand(sql, con);
            
            cmd.Parameters.AddWithValue("@floor", floor);
            cmd.Parameters.AddWithValue("@room", room);
            cmd.Parameters.AddWithValue("@capacity", capacity);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@building", build);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Added Sucessfully");
            
            con.Close();



        

       

            //String build = txtbuild.Text;
            {  //twooo t = new twooo();
                //this.Hide();
                //t.Show();
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtfloor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbuild_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtcapacity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LocationMgt loc = new LocationMgt();
            loc.Show();
        }
    }
}
