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
    public partial class Home : Form
    {
        MySqlConnection connect = new MySqlConnection("host=localhost;user=root;password=;database=project;");
        public static string date = "";
        public static string origins = "";
        public static string destinations = "";
        public Home()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (login.Text == "เข้าสู่ระบบ")
            {
                logins login = new logins();
                login.Show();
                this.Hide();
            }
            else if (login.Text == "เข้าสู่ระบบแล้ว")
            {
                
            }

        }

        private void member_Click(object sender, EventArgs e)
        { 
            if (member.Text == "สมัครสมาชิก")
            {
                members member = new members();
                member.Show();
                this.Hide();
            }
            else if (member.Text == "ออกจากระบบ")
            {
                DialogResult r = MessageBox.Show("คุณต้องการออกจากระบบใช่หรือไม่", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    member.BackColor = Color.LightBlue;
                    member.ForeColor = Color.MidnightBlue;
                    member.Text = "สมัครสมาชิก";

                    login.BackColor = Color.LightPink;
                    login.ForeColor = Color.Crimson;
                    login.Text = "เข้าสู่ระบบ";
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            cancelticket can = new cancelticket();
            can.Show();
            this.Hide();

        }

        private void Home_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Value = DateTime.Today;
            destination();
            if (logins.loginstatus == true)
            {
                member.BackColor = Color.Red;
                member.ForeColor = Color.White;
                member.Text = "ออกจากระบบ";

                login.BackColor = Color.Green;
                login.ForeColor = Color.YellowGreen;
                login.Text = "เข้าสู่ระบบแล้ว";


            }
        }
        private void destination()
        {
            connect.Open();

            List<String> origin = new List<String>();
            List<String> destination = new List<String>();

            String sql = "SELECT * FROM station ";
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                origin.Add(dr.GetString("origin"));
                destination.Add(dr.GetString("destination"));
            }

            foreach (string i in origin)
            {
                from.Items.Add(i);
            }

            foreach (string i in destination)
            {
                to.Items.Add(i);
            }

            connect.Close();
           
        }

        private void search_Click(object sender, EventArgs e)
        {
            DateTime idate;
            idate = dateTimePicker1.Value;
            date = idate.ToString("yyyy-MM-dd");
            //MessageBox.Show(date);
            //Console.WriteLine(date + " | " + Convert.ToDateTime(dateTimePicker1.Value).ToString("dd MMMM yyyy"));
            origins = from.Text;
            destinations = to.Text;

            if (logins.loginstatus == true)
            {
                if (origins != "ต้นทาง" && destinations != "ปลายทาง")
                {
                    choosest st = new choosest();
                    st.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("กรุณาเลือกจุดเริ่มต้นและจุดหมายปลายทาง", "ERROR");
                }

            }
            else
            {
                MessageBox.Show("กรุณาเข้าสู่ระบบ", "เข้าสู่ระบบก่อนจ้า");
            }
        }

        private void change_click(object sender, EventArgs e)
        {
            edittickets edit = new edittickets();
            edit.Show();
            this.Hide();
        }

        private void adminpage_Click(object sender, EventArgs e)
        {
            admin ad = new admin();
            ad.Show();
            this.Hide();
           
        }
    }
}
