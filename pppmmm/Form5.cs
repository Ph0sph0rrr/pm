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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();



            string connectionString = "Data Source=C:\\Users\\user\\Documents\\Sharaga\\pppmmm\\pm.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString)) ;
        }
        //private SQLiteConnection connection;


        private void InitializeDatabaseConnection()
        {
            string connectionString = "Data Source=C:\\Users\\user\\Documents\\Sharaga\\pppmmm\\pm.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString)) ;
           //     connection = new SQLiteConnection(connectionString);


        }



        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idt.Text);
            string name = namet.Text;
            string optt = opt.Text;
            string status = stt.Text;
            string cena = cenat.Text;
            string namemaster = mastert.Text;




            string connectionString = "Data Source=C:\\Users\\user\\Documents\\Sharaga\\pppmmm\\pm.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE obor SET name = CASE WHEN @name IS NOT NULL THEN @name ELSE name END, opis = CASE WHEN @opis IS NOT NULL THEN @opis ELSE opis END," +
                    "cena = CASE WHEN @cena IS NOT NULL THEN @cena ELSE cena END, namemaster = CASE WHEN @namemaster IS NOT NULL THEN @namemaster ELSE namemaster END," +
                    " status = CASE WHEN @status IS NOT NULL THEN @status ELSE status END WHERE id = @id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@opis", optt);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@id", id);

                    //

                    command.Parameters.AddWithValue("@cena", cena);
                    command.Parameters.AddWithValue("@namemaster", namemaster);

                    //


                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Запись обновлена. Affected rows: " + rowsAffected);
                }
            }






            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            add MainPage = new add();
            MainPage.Show();
        }
    }
    
}
