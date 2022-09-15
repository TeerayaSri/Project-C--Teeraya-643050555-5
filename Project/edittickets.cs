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
    public partial class edittickets : Form
    {
        MySqlConnection connect = new MySqlConnection("host=localhost;user=root;password=;database=project;");
        public edittickets()
        {
            InitializeComponent();
        }

        private string[] getAllticketID(string phone)
        {
            List<string> ticketID = new List<string>();
            
            string sql = "SELECT id FROM history WHERE phone = '" + phone + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            connect.Open();

            MySqlDataReader reder = cmd.ExecuteReader();

            while (reder.Read())
            {
                ticketID.Add(reder.GetString("id"));
            }

            connect.Close();

            return ticketID.ToArray();
        }

        private string[] dataticketID(int id)
        {
            string sql = "SELECT * FROM history WHERE id = '" + id + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            connect.Open();

            MySqlDataReader reder = cmd.ExecuteReader();

            string status = "";
            string date = "";
            string id_status = "";
            string origin = "";
            string destination = "";
            string seat = "";


            while (reder.Read())
            {
                status = reder.GetString("status");
                date = reder.GetString("date");
                id_status = reder.GetString("id_status");
                origin = reder.GetString("origin");
                destination = reder.GetString("destination");
                seat = reder.GetString("seat");
            }

            connect.Close();

            sql = "SELECT * FROM user WHERE phone = '" + logins.phone2 + "' OR passport = '" + logins.phone2 + "' ";
            cmd = new MySqlCommand(sql, connect);
            connect.Open();

            reder = cmd.ExecuteReader();

            string name = "";
            string lname = "";


            while (reder.Read())
            {
                name = reder.GetString("name");
                lname = reder.GetString("lastname");
            }

            connect.Close();

            sql = "SELECT * FROM choosest WHERE id_station = '" + id_status + "' AND date = '" + date + "'  ";
            cmd = new MySqlCommand(sql,connect);
            connect.Open();

            reder = cmd.ExecuteReader();

            string origins = "";
            string destinations = "";


            while (reder.Read())
            {
                origins = reder.GetString("origins");
                destinations = reder.GetString("destinations");
            }

            connect.Close();

            string[] data = { name, lname, origin, destination, id_status, seat, date, origins, destinations, status };

            return data;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void historyticket_Load(object sender, EventArgs e)
        {
            string[] id = getAllticketID(logins.phone2);
            foreach (string item in id)
            {
                ticketnumber.Items.Add(item);
            }
        }

        private void ticketnumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = dataticketID(Convert.ToInt32(ticketnumber.Text))[0] + " " + dataticketID(Convert.ToInt32(ticketnumber.Text))[1];
            flname.Text = name;

            string travel = dataticketID(Convert.ToInt32(ticketnumber.Text))[2] + " >>> " + dataticketID(Convert.ToInt32(ticketnumber.Text))[3];
            tofrom.Text = travel;

            string id_status = dataticketID(Convert.ToInt32(ticketnumber.Text))[4];
            idstatus.Text = id_status;

            string Seat = dataticketID(Convert.ToInt32(ticketnumber.Text))[5];
            seat.Text = Seat;

            string Date = dataticketID(Convert.ToInt32(ticketnumber.Text))[6];
            date.Text = Convert.ToDateTime(Date).ToString("dd-MM-yyyy");

            string Time = dataticketID(Convert.ToInt32(ticketnumber.Text))[7] + " >>> " + dataticketID(Convert.ToInt32(ticketnumber.Text))[8];
            times.Text = Time;

            string Status = dataticketID(Convert.ToInt32(ticketnumber.Text))[9];
            status.Text = Status;

        }

        private void backhome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tickets tk = new tickets();
            tk.Show();
            this.Hide();
        }
    }
}
