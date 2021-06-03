using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITPM
{
    public partial class subject : Form
    {
        public subject()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Server=tcp:abcinstitute.database.windows.net,1433;Initial Catalog=time-table;Persist Security Info=False;User ID=biyoni;Password=itpm12345@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
      
        SqlCommand cmd;
        String sql;
        bool Mode = true;


        private void subject_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {


            if (ValidateChildren(ValidationConstraints.Enabled) &&
                off_y.Text == "" || off_s.Text == "" || s_code.Text == "" || s_name.Text == "" || lH.Text == "" || tH.Text == "" || labH.Text == "" || eH.Text == "")
            {
                MessageBox.Show("Please fill out all the Field(s)",
                "Unable to Submit", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
            }
            else
            {

                String year = off_y.SelectedItem.ToString();
                String sem = off_s.SelectedItem.ToString();
                String code = s_code.Text;
                String name = s_name.Text;
                String Lec = lH.SelectedItem.ToString();
                String tute = tH.SelectedItem.ToString();
                String lab = labH.SelectedItem.ToString();
                String ev = eH.SelectedItem.ToString();

                if (Mode == true)
                {
                    sql = "insert into Subject_Management(Offered_year,Offered_semester,subject_code,subject_name,lec_hours,tute_hours,lab_hours,ev_hours)values(@Offered_year,@Offered_semester,@subject_code,@subject_name,@lec_hours,@tute_hours,@lab_hours,@ev_hours)";
                    con.Open();
                    cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@Offered_year", year);
                    cmd.Parameters.AddWithValue("@Offered_semester", sem);
                    cmd.Parameters.AddWithValue("@subject_code", code);
                    cmd.Parameters.AddWithValue("@subject_name", name);
                    cmd.Parameters.AddWithValue("@lec_hours", Lec);
                    cmd.Parameters.AddWithValue("@tute_hours", tute);
                    cmd.Parameters.AddWithValue("@lab_hours", lab);
                    cmd.Parameters.AddWithValue("@ev_hours", ev);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Insert Successfully!!");
                }

                else
                {

                }
                con.Close();

                off_y.SelectedIndex = -1;
                off_s.SelectedIndex = -1;
                s_code.Clear();
                s_name.Clear();
                lH.SelectedIndex = -1;
                tH.SelectedIndex = -1;
                labH.SelectedIndex = -1;
                eH.SelectedIndex = -1;

            }


           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Form1 form = new Form1();
           // this.Hide();
           // form.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ManageSub m = new ManageSub();
           this.Hide();
            m.Show();
        }
    }
}
