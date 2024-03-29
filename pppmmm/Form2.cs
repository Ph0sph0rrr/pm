using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pppmmm
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
        }
        //private string connectionString = "Data Source=pm.db;Version=3;";
        private void label2_Click(object sender, EventArgs e)
        {

        }

        string connectionString = "Data Source=C:\\Users\\user\\Documents\\Sharaga\\pppmmm\\pm.db;Version=3;";

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=C:\\Users\\user\\Documents\\Sharaga\\pppmmm\\pm.db;Version=3;";
            


            string Obor = obor.Text;
            string Polom = polom.Text;
            string Namek = namek.Text;


            if (!string.IsNullOrEmpty(Obor) && !string.IsNullOrEmpty(Polom) && !string.IsNullOrEmpty(Namek))
            {
                try
                {
                    using(SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO obor (id, name, opis, status, nameklient) VALUES (@id, @name, @opis, @status, @nameklient)";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", GetNextId());
                            command.Parameters.AddWithValue("@name", Obor);
                            command.Parameters.AddWithValue("@opis", Polom);
                            command.Parameters.AddWithValue("@status", 0);
                            command.Parameters.AddWithValue("@nameklient", Namek);
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                        MessageBox.Show("Запись создана.", "Создание записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetNextId()
        {
            int maxId = 0;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MAX(id) FROM obor";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            maxId = reader.GetInt32(0);
                        }
                    }
                }
                connection.Close();
            }
            return maxId + 1;
        }
    }
}
