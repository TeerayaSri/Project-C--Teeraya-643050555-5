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
    public partial class logins : Form
    {

        public static bool loginstatus = false;
        public static string phone2 = "0945199968";

        MySqlConnection connect = new MySqlConnection("host=localhost;user=root;password=;database=project;");

        public logins()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {

            string tel = textBox1.Text;
            phone2 = tel;
            string pw = password.Text;
        

            if (phone.Checked)
            {
                if (checkPhone(tel) == true)
                {
                    
                    if (checkPassword(tel, pw) == true)
                    {
                        loginstatus = true;
                        MessageBox.Show("เข้าสู่ระบบเรียบร้อยแล้ว","พร้อมเที่ยวจ้า");
                        this.Hide();

                        Home home = new Home();
                        home.Show();
                        Console.WriteLine(loginstatus);
                    } 
                    else
                    {
                        MessageBox.Show("รหัสผ่านไม่ถูกต้อง","ERROR");
                        textBox1.Text = "";
                        password.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("เบอร์โทรศัพท์ไม่ถูกต้อง", "ERROR");
                    textBox1.Text = "";
                    password.Text = "";
                }
            } 
            else if (passport.Checked)
            {
                if (checkPhone(tel) == true)
                {
                   
                    if (checkPassword(tel, pw) == true)
                    {
                        loginstatus = true;
                        MessageBox.Show("เข้าสู่ระบบเรียบร้อยแล้ว");
                        this.Hide();
                        Home cus = new Home();
                        cus.Show();
                        Console.WriteLine(loginstatus);

                    }
                    else
                    {
                        MessageBox.Show("รหัสผ่านไม่ถูกต้อง");
                        textBox1.Text = "";
                        password.Text = "";
                    }
              }
                else
                {
                    MessageBox.Show("เลขบัตรประจำตัวประชาชนไม่ถูกต้อง");
                    textBox1.Text = "";
                    password.Text = "";
                }
             }
        }

        private bool checkPhone(string text)
        {
            connect.Open();

            List<String> phonelist = new List<String>();
            List<String> passportlist = new List<String>();

            String sql = "SELECT * FROM user";
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                phonelist.Add(dr.GetString("phone"));
                passportlist.Add(dr.GetString("passport"));
            }

            bool boolean = false;

            if (phone.Checked)
            {
                foreach (string i in phonelist)
                {
                    if (i == text)
                    {
                        boolean = true;
                    }
                }
            } 
            else if (passport.Checked)
            {
                foreach (string i in passportlist)
                {
                    if (i == text)
                    {
                        boolean = true;
                    }
                }
            }
            connect.Close();

            return boolean;
        }

        private bool checkPassword(string text, string password)
        {
            connect.Open();

            string sql = "";
            if (phone.Checked)
            {
                sql = "SELECT password FROM user WHERE phone = '" + text + "'";
            } 
            else if (passport.Checked)
            {
                sql = "SELECT password FROM user WHERE passport = '" + text + "'";
            }
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            MySqlDataReader dr = cmd.ExecuteReader();

            string pw = "";

            while (dr.Read())
            {
                pw = dr.GetString("password");
            }

            bool boolean = false;

            if (pw == password)
            {
                boolean = true;
            }

            connect.Close();

            return boolean;
        }


        private void phone_CheckedChanged(object sender, EventArgs e)
        {
            if (phone.Checked == true)
            {
                textBox1.Text = "เบอร์โทรศัพท์";
            }
        }

        private void passport_CheckedChanged(object sender, EventArgs e)
        {
            if (passport.Checked == true)
            {
                textBox1.Text = "เลขบัตรประจำตัวประชาชน";
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "เบอร์โทรศัพท์")
            {
                textBox1.Clear();
            } else if (textBox1.Text == "เลขบัตรประจำตัวประชาชน")
            {
                textBox1.Clear();
            }
        }

        private void forgotpw_Click(object sender, EventArgs e)
        {
            forgetpw fgpw = new forgetpw();
            fgpw.Show();
            this.Hide();
        }
    }
}
