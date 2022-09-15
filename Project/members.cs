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
    public partial class members : Form
    {
        MySqlConnection connect = new MySqlConnection("host=localhost;user=root;password=;database=project;");

        public members()
        {
            InitializeComponent();
        }

        private bool checkcharacter(string str)
        {
            string word = "กขฃคฅฆงจฉชซฌญฎฏฐฑฒณดตถทธนบปผฝพฟภมยรลวศษสหฬอฮะาิีึืุูเแโัๆใไๅฤฦ่้๊๋์็ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < str.Length; i++)
            {
                if (!(word.Contains(str[i])))
                {
                    return false;
                }
            }
            return true;
        }

        private bool checkNum(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            for (int i = 0; i < str.Length; i++)
            {
                if ((char.IsNumber(str[i])))
                {
                    return true;
                }
            }
            
            return false;
        }

        private void signup(string fname, string lname, string passport, string phone, string password)
        {
            string sql = $"INSERT INTO user (name,lastname,phone,passport,password) VALUES ('{fname}','{lname}','{phone}','{passport}','{password}')";
            MySqlCommand cmd = new MySqlCommand(sql,connect);
            connect.Open();

            int rows = cmd.ExecuteNonQuery();
            connect.Close();

            if (rows > 0)
            {
                MessageBox.Show("เพิ่มข้อมูลสมาชิกเรียบร้อยแล้ว", "Succeed");
            }
            else
            {
                MessageBox.Show("เพิ่มข้อมูลไม่สำเร็จ", "ERROR");
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string fname = firstname.Text;
            string lname = lastname.Text;
            string pp = passport2.Text;
            string ph = phone2.Text;
            string pw2 = password2.Text;
            string pw3 = password3.Text;

            if (checkfull(ph) && checkfull(pp))
            {
                if (checkcharacter(fname))
                {
                    if (checkcharacter(lname))
                    {
                        if (checkNum(pp) && pp.Length == 13)
                        {
                            if (checkNum(ph) && ph.Length == 10)
                            {
                                if (pw2 == pw3)
                                {
                                    MessageBox.Show("เพิ่มข้อมูลสมาชิกเรียบร้อยแล้ว", "Succeed");
                                    signup(fname, lname, pp, ph, pw2);

                                    logins login = new logins();
                                    login.Show();
                                    this.Hide();

                                }
                                else
                                {
                                    MessageBox.Show("รหัสยืนยันไม่ตรงกับรหัสผ่าน", "ERROR");
                                }
                            }
                            else
                            {
                                MessageBox.Show("เบอร์โทรศัพท์ไม่ถูกต้อง", "ERROR");
                            }
                        }
                        else
                        {
                            MessageBox.Show("เลขบัตรประจำตัวประชาชนไม่ถูกต้อง", "ERROR");
                        }
                    }
                    else
                    {
                        MessageBox.Show("นามสกุลต้องเป็นตัวอักษรเท่านั้น", "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("ชื่อจริงต้องเป็นตัวอักษรเท่านั้น", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("พบผู้ใช้นี้ในระบบ", "มีบัญชีอยู่แล้วจ้า");
            }
          
        }

        private bool checkfull (string phone)
        {
            connect.Close();
            string sql = "SELECT phone,passport FROM user";
            MySqlCommand cmd = new MySqlCommand(sql,connect);
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            List<string> allphone = new List<string>();

            while (reader.Read())
            {
                allphone.Add(reader.GetString("phone"));
                allphone.Add(reader.GetString("passport"));
            }
            foreach (string i in allphone)
            {
                if(i == phone)
                {
                    return false;
                }
            }

            connect.Close();
            return true;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }

}

