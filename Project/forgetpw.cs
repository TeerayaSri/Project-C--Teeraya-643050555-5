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
    public partial class forgetpw : Form
    {
        MySqlConnection connect = new MySqlConnection("host=localhost;user=root;password=;database=project;");
        public forgetpw()
        {
            InitializeComponent();
        }

        private string showpw(string passport)
        {
            string sql = "SELECT password FROM user WHERE passport = '"+passport+"'";
            MySqlCommand cmd = new MySqlCommand(sql, connect);

            string allid = "";
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                allid = (reader.GetString("password"));
            }

            connect.Close();
            return allid;
        }

        private void pptext_TextChanged(object sender, EventArgs e)
        {
            if (pptext.Text.Length == 13)
            {
                pwtxt.Text = showpw(pptext.Text);
            }
        }

        private void pwtxt_Click(object sender, EventArgs e)
        {
            pwtxt.PasswordChar = '\0';
        }

        private void backlogin_Click(object sender, EventArgs e)
        {
            logins lg = new logins();
            lg.Show();
            this.Hide();
        }

    }
}

