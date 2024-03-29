using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace pppmmm
{
    public partial class add : Form
    {
        private List<DAL.Users> _list;

        public add()
        {
            InitializeComponent();

            _list = new List<DAL.Users>();

            bsUser.DataSource = _list;



            dataGridView1.AutoGenerateColumns = true;


            string connectionString = "Data Source=C:\\Users\\user\\Documents\\Sharaga\\pppmmm\\pm.db;Version=3;";
            string query = "SELECT id, name, opis, status, nameklient, datanach, namemaster, datzokonch,cena from obor;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                }

                connection.Close();




            }

        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {



            string connectionString = "Data Source=C:\\Users\\user\\Documents\\Sharaga\\pppmmm\\pm.db;Version=3;";
            string query = "SELECT id, name, opis, status, nameklient, datanach, namemaster, datzokonch,cena from obor;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                }

                connection.Close();








            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 MainPage = new Form5();
            MainPage.Show();


        }

        private void bsUser_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 MainPage = new Form2();
            MainPage.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 MainPage = new Form6();
            MainPage.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 MainPage = new Form7();
            MainPage.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 MainPage = new Form8();
            MainPage.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 MainPage = new Form4();
            MainPage.Show();
        }
    }
}
