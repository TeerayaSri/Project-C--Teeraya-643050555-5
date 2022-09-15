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
    public partial class tickets : Form
    {
        MySqlConnection connect = new MySqlConnection("host=localhost;user=root;password=;database=project;");
        public tickets()
        {
            InitializeComponent();
        }


        private string showname()
        {
            string sql = "";
            if (logins.phone2.Length == 10)
            {
                sql = "SELECT * FROM user WHERE phone = '" + logins.phone2 + "' ";
            } 
            else
            {
                sql = "SELECT * FROM user WHERE passport = '" + logins.phone2 + "' ";
            }
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            connect.Open();

            MySqlDataReader reder = cmd.ExecuteReader();

            string name = "";
            string lname = "";


            while (reder.Read())
            {
                name = reder.GetString("name");
                lname = reder.GetString("lastname");
            }

            connect.Close();
            return name + " " + lname;
        }
        private int latestid()
        {
            string sql = "SELECT id FROM history";

            MySqlCommand cmd = new MySqlCommand(sql, connect);

            List<int> allid = new List<int>();
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {  
                allid.Add(reader.GetInt32("id"));
            }

            connect.Close();
            return allid[allid.Count - 1] ;
        }
        private string[] showdata()
        {
            string sql = "SELECT * FROM history WHERE id = '" + latestid() + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            connect.Open();

            MySqlDataReader reder = cmd.ExecuteReader();
            
            string id_status = "";
            string status = "";
            string date = "";
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

             sql = "SELECT price FROM choosebogie WHERE status = '"+status+"'";
             cmd = new MySqlCommand(sql, connect);
             connect.Open();

             reder = cmd.ExecuteReader();
            
            int price = 0;

            while (reder.Read())
            {
                price = reder.GetInt32("price");
            }   
            connect.Close();
            //เก็บข้อมูลทั้งหมดไว้ในarrayนี้
            string[] x = {id_status, status, date, origin, destination, seat, price.ToString()};
            return x;
        }
        
        private void tickets_Load(object sender, EventArgs e)
        {
            int idstation = choosest.idstation;
            string departmenttime = choosest.origins;
            string arrivementtime = choosest.destinations;

            station.Text = idstation.ToString();
            form.Text = departmenttime.ToString();
            to.Text = arrivementtime.ToString();
            flname.Text = showname();
            numberticket.Text = latestid().ToString();
            status.Text = showdata()[1];
            date.Text = (showdata()[2]);
            origin.Text = (showdata()[3]);
            destination.Text = showdata()[4];
            seat.Text = showdata()[5];
            price.Text = showdata()[6];
        }


        private void back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
