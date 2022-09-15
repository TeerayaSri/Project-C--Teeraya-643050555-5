using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class datauser : Form
    {
        public datauser()
        {
            InitializeComponent();
        }

        MySqlConnection connect = new MySqlConnection("host=localhost;user=root;password=;database=project;");

        private string[] showname()
        {
            string sql = "SELECT * FROM user ";
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            connect.Open();

            MySqlDataReader reder = cmd.ExecuteReader();

            List<string> list = new List<string>();


            while (reder.Read())
            {
                list.Add(reder.GetString("name") + " " + reder.GetString("lastname") /* + " " + reder.GetString("phone") */);
            }

            connect.Close();

            return list.ToArray();
        }

        private string[] data()
        {
            string[] name = comboBox1.Text.Split(' ');
            string sql = $"SELECT * FROM user WHERE name = '{name[0]}' AND lastname = '{name[1]}'";
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            connect.Open();

            MySqlDataReader reder = cmd.ExecuteReader();

            string tel = "";
            string passport = "";


            if (reder.Read())
            {
                tel = reder.GetString("phone");
                passport = reder.GetString("passport");
                
            }

            connect.Close();
            string[] data = new string[] { tel, passport };
            return data;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            new cancelticket().dataticket(dataGridView1, data()[0]);
            if (dataGridView1.Rows.Count <= 1)
            {
                new cancelticket().dataticket(dataGridView1, data()[1]);
            }
            tel.Text = data()[0];
            passport.Text = data()[1];
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void datauser_Load(object sender, EventArgs e)
        {
            string[] dataname = showname();
            comboBox1.Items.Clear();
            foreach(string s in dataname)
            {
                comboBox1.Items.Add(s);
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.CurrentCell.RowIndex;
            int deleteId = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells["id"].Value);
            int bogie = Convert.ToInt32(new cancelticket().getdata(deleteId)[0]);
            int seat = Convert.ToInt32(new cancelticket().getdata(deleteId)[1]);

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

                new cancelticket().dataticket(dataGridView1, data()[0]);
                if (dataGridView1.Rows.Count <= 1)
                {
                    new cancelticket().dataticket(dataGridView1, data()[1]);
                }
            }
        }
    }
}
