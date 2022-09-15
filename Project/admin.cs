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
    public partial class admin : Form
    {
        MySqlConnection connect = new MySqlConnection("host=localhost;user=root;password=;database=project;");

        private string log = "admin";
        private string passw = "12345";
        public static bool nn = false;
        private bool logg = false;

        public admin()
        {
            InitializeComponent();
        }

        private void admins_Click(object sender, EventArgs e)
        {
            string login = user.Text;
            string pass = pw.Text;

            if (log == login)
            {
                if (passw == pass)
                {
                    nn = true;
                    logg = true;
                    admins.BackColor = Color.Yellow;
                    MessageBox.Show("เข้าสู่ระบบพนักงานเรียบร้อยแล้ว");

                }
                else
                {
                    MessageBox.Show("รหัสผ่านไม่ถูกต้อง");
                    user.Text = "";
                    pw.Text = "";
                }
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้ Admin ไม่ถูกต้อง");
                user.Text = "";
                pw.Text = "";

            }
        }

        private void resetall(int bogie)
        {
            if (logg == true)
            {
                string sql = "UPDATE checkseatstatus SET status = '1' WHERE bogie = '" + bogie + "'";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                connect.Open();
                int rows = cmd.ExecuteNonQuery();
                connect.Close();
                if (rows > 0)
                {
                    MessageBox.Show("รีเซ็ตที่นั่งสำเร็จแล้ว");
                }
            }
            else
            {
                MessageBox.Show("กรุณาเข้าสู่ระบบพนักงานก่อน");
            }
        }
        private void reset_Click(object sender, EventArgs e)
        {
            int bogies = Convert.ToInt32(bg.Text);

            resetall(bogies);
        }

        string[] classlist = { "ชั้นพัดลม", "ชั้นแอร์", "ตู้นอน" };

        private void Add_Click(object sender, EventArgs e)
        {
            if (logg == true)
            {
                for (int i = 0; i < classlist.Length; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        string sql = $"INSERT INTO checkseatstatus (bogie,seat,status,date,class) VALUES ('{bg.Text}','{j}','{1}','{dateTime.Value.ToString("yyyy-MM-dd")}','{classlist[i]}')";
                        MySqlCommand cmd = new MySqlCommand(sql, connect);
                        connect.Open();

                        int rows = cmd.ExecuteNonQuery();
                        connect.Close();
                    }
                }
                MessageBox.Show("เพิ่มขบวนที่นั่งเรียบร้อยแล้ว");
            }
            else
            {
                MessageBox.Show("กรุณาเข้าสู่ระบบพนักงานก่อน");
            }
            

        }

        private void ยอนกลบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void showdata_Click(object sender, EventArgs e)
        {
            datauser data = new datauser();
            data.Show();
            this.Hide();
        }
    }
}
