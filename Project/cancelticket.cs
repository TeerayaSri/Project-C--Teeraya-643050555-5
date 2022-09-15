using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class cancelticket : Form
    {

        MySqlConnection connect = new MySqlConnection("host=localhost;user=root;password=;database=project;");
        public cancelticket()
        {
            InitializeComponent();
        }


        private void backhome_click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        public void dataticket(DataGridView dgv, string phone)
        {
            DataSet ds = new DataSet();
            connect.Open();
            MySqlCommand cmd;
            cmd = connect.CreateCommand();
         
            cmd.CommandText = "SELECT id,date,origin,destination FROM history WHERE phone = '" + phone + "'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            connect.Close();

            dgv.DataSource = ds.Tables[0].DefaultView;
        }
        private void cancelticket_Load(object sender, EventArgs e)
        {
            dataticket(dataticketmember, logins.phone2);
        }


        public string[] getdata(int historyid)
        {
            string sql = "SELECT id_status, seat FROM history WHERE id = '" + historyid + "'";
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string id_status = reader.GetString("id_status");
            string seat = reader.GetString("seat");

            connect.Close();

            string[] data = new string[] { id_status, seat };

            return data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedRow = dataticketmember.CurrentCell.RowIndex;
            int deleteId = Convert.ToInt32(dataticketmember.Rows[selectedRow].Cells["id"].Value);
            int bogie = Convert.ToInt32(getdata(deleteId)[0]);
            int seat = Convert.ToInt32(getdata(deleteId)[1]);

            String sql = "DELETE FROM history WHERE id = '" + deleteId + "'";

            MySqlCommand cmd = new MySqlCommand(sql, connect);

            connect.Open();

            cmd.ExecuteNonQuery();

            connect.Close();

            sql = "UPDATE checkseatstatus SET status = '1' WHERE bogie = '" + bogie + "' AND seat = '" + seat + "'";
            cmd = new MySqlCommand(sql, connect);
            connect.Open();
            int rows = cmd.ExecuteNonQuery();
            connect.Close();
            
            DialogResult r = MessageBox.Show("คุณต้องแการยกเลิกการจองตั๋วใช่หรือไม่", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                MessageBox.Show("ยกเลิกตั๋วเรียบร้อยแล้ว");

                dataticket(dataticketmember, logins.phone2);
            }
        }

        private void ticketnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataticketmember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataticketmember.CurrentRow.Selected = true;
            int selected = dataticketmember.CurrentCell.RowIndex;
            ticketnumber.Text = dataticketmember.Rows[selected].Cells["id"].FormattedValue.ToString();
        }
    }
}
