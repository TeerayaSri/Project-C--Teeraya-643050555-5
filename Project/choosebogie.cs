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
    public partial class choosebogie : Form
    {
        MySqlConnection connect = new MySqlConnection("host=localhost;user=root;password=;database=project;");
        private Button lastbutton = null;
        private string classes = "";

        public choosebogie()
        {
            InitializeComponent();
        }
        private void showStatus()
        {

            DataSet ds = new DataSet();

            connect.Open();

            MySqlCommand cmd;

            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT status,price FROM choosebogie ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            connect.Close();

            dataChoosebogie.DataSource = ds.Tables[0].DefaultView;
        }


        private void databogie(object sender, DataGridViewCellEventArgs e)
        {
            dataChoosebogie.CurrentRow.Selected = true;
            int selected = dataChoosebogie.CurrentCell.RowIndex;
            statusbokie.Text = dataChoosebogie.Rows[selected].Cells["status"].FormattedValue.ToString();
            price.Text = dataChoosebogie.Rows[selected].Cells["price"].FormattedValue.ToString();
            submit.Enabled = true;
        }

        private void choosebogie_Load(object sender, EventArgs e)
        {
            showStatus();           
        }

        private void backchoosestation_Click(object sender, EventArgs e)
        {
            choosest choosest = new choosest ();
            choosest.Show();
            this.Hide();
        }

        private bool[] checkseat(int bogie,string classes)
        {
            connect.Open();

            List<bool> status = new List<bool>();

            string date = Home.date;
            String sql = $"SELECT * FROM checkseatstatus WHERE bogie  = '{bogie}' AND date =  '{date}' AND class =  '{classes}'";
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                status.Add(dr.GetBoolean("status"));
            }
            for (int i = 0; i < 10; i++)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is Button)
                    {
                        Button button = c as Button;
                        if (button.Name.Contains("_"))
                        {
                            if (status[i] == false)
                            {
                                int num = Convert.ToInt32(button.Name.Split('_')[1]);
                                if ((num - 1) == i)
                                {
                                    button.BackColor = Color.Crimson;
                                    button.Enabled = false;
                                }
                            } 
                            else
                            {
                                int num = Convert.ToInt32(button.Name.Split('_')[1]);
                                if ((num - 1) == i)
                                {
                                    button.BackColor = Color.Gold;
                                }
                            }
                        }

                    }
                }
            }
            connect.Close();
            return status.ToArray();
        }

        private void changecolor(Button current)
        {
            if (lastbutton != null)
            {
                checkseat(choosest.idstation,classes);
            }
            lastbutton = current;
            current.BackColor = Color.MediumAquamarine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Name.Contains("_"))
            {
                for (int i = 1; i <= 10; i++)
                {
                    changecolor(button);
                    int num = Convert.ToInt32(button.Name.Split('_')[1]);
                    button.BackColor = Color.MediumAquamarine;
                    statusseat.Text = "ที่นั่งที่ " + num.ToString();
                    comfirm.Enabled = true;
                }
            }
        }

        private void Addticket(string phone, string status,string date, int id_status, string origin, string destination, int seat)
        {
            string sql = $"INSERT INTO history (phone,status,date,id_status,origin,destination,seat) VALUES ('{phone}','{status}','{date}','{id_status}','{origin}','{destination}','{seat}')";
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            connect.Open();

            int rows = cmd.ExecuteNonQuery();
            connect.Close();

            if (rows > 0)
            {
                MessageBox.Show("จองตั๋วเรียบร้อยแล้ว", "Succeed");
            }
            else
            {
                MessageBox.Show("ข้อมูลไม่ครบถ้วน", "ERROR");
            }
        }

        private void cutstock (int bogie , int seat)
        {
            string sql = $"UPDATE checkseatstatus SET status = '0' WHERE bogie = '{bogie}'AND seat = '{seat}'";

            MySqlCommand cmd = new MySqlCommand(sql, connect);
            connect.Open();

            cmd.ExecuteNonQuery();

            connect.Close();
        }


        private void choose_Click(object sender, EventArgs e)
        {
            classes = statusbokie.Text;
            checkseat(choosest.idstation,classes);
        }

        private void comfirm_Click(object sender, EventArgs e)
        {
            string phone = logins.phone2;
            string status = statusbokie.Text;
            string seatstr = statusseat.Text.Split(' ')[1];
            int seat = Convert.ToInt32(seatstr);
            string date = Home.date;
            string origins = Home.origins;
            string destinations = Home.destinations;
            Addticket(phone, status, date, choosest.idstation, origins, destinations, seat);
            cutstock(choosest.idstation, seat);
            tickets tt = new tickets();
            tt.Show();
            this.Hide();
        }

    }
}
