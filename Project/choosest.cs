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
    public partial class choosest : Form
    {
        MySqlConnection connect = new MySqlConnection("host=localhost;user=root;password=;database=project;");
        public static int idstation = 0;
        public static string origins = "";
        public static string destinations = "";


        public choosest()
        {
            InitializeComponent();
        }

        private void showStation()
        {

            DataSet ds = new DataSet();
           
            connect.Open();

            MySqlCommand cmd;

            cmd = connect.CreateCommand();
            cmd.CommandText = $"SELECT id_station,origins,destinations FROM choosest WHERE date = '{Home.date}' ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            connect.Close();

            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void choosest_Load(object sender, EventArgs e)
        {
            showStation();
        }


        private void dataChoose_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            int selected = dataGridView1.CurrentCell.RowIndex;
            departuretime.Text = dataGridView1.Rows[selected].Cells["origins"].FormattedValue.ToString();
            arrivaltime.Text = dataGridView1.Rows[selected].Cells["destinations"].FormattedValue.ToString();
            numberst.Text = dataGridView1.Rows[selected].Cells["id_station"].FormattedValue.ToString();
        }

        private void submit_Click(object sender, EventArgs e)
        {

            idstation = Convert.ToInt32(numberst.Text);
            origins = departuretime.Text;
            destinations = arrivaltime.Text;

            choosebogie bg = new choosebogie();
            bg.Show();
            this.Hide();

        }

        private void backhome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

    }
    
}
