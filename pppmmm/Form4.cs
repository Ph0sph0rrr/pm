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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            label1.Text = Class1.iddd;

            

            if (Class1.iddd == "3")
            {
                label4.Text=("Андрей Чистенин");
            }
            if (Class1.iddd == "1")
            {
                label4.Text = ("Егор Плей");
            }
            if (Class1.iddd == "2")
            {
                label4.Text = ("Славик Геньба");
            }





            string namerab = label4.Text;

            string idr = label1.Text;



        }

        private void button1_Click(object sender, EventArgs e)
        {


            int id = int.Parse(idt.Text);






            string connectionString = "Data Source=C:\\Users\\user\\Documents\\Sharaga\\pppmmm\\pm.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * from rab where id = @id;";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@id", id);




                    int rowsAffected = command.ExecuteNonQuery();


                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {

                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                        command.Parameters.AddWithValue("@id", id);
                    }


                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idt.Text);
            string status = "В работе";
            string namemaster = label4.Text;
            string cena = "500";

            






            




            string connectionString = "Data Source=C:\\Users\\user\\Documents\\Sharaga\\pppmmm\\pm.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE obor SET cena = CASE WHEN @cena IS NOT NULL THEN @cena ELSE cena END, namemaster = CASE WHEN @namemaster IS NOT NULL THEN @namemaster ELSE namemaster END," +
                    " status = CASE WHEN @status IS NOT NULL THEN @status ELSE status END WHERE id = @id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    
                    
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@id", id);

                    //

                    command.Parameters.AddWithValue("@cena", cena);
                    command.Parameters.AddWithValue("@namemaster", namemaster);

                    //


                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Запись обновлена. Affected rows: ");
                }
            }

            string idr = label1.Text;


            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE rab SET  status = CASE WHEN @status IS NOT NULL THEN @status ELSE status END, obor = CASE WHEN @obor IS NOT NULL THEN @obor ELSE obor END WHERE id = @id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@obor", id);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@id", idr);

                    //
                    


                    //


                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Запись обновлена. Affected rows: " );
                }
            }












        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 MainPage = new Form5();
            MainPage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idt.Text);
            string status = "Выполнено";
            string namemaster = label4.Text;
            

            string statuss = "Завершен";











            string connectionString = "Data Source=C:\\Users\\user\\Documents\\Sharaga\\pppmmm\\pm.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE obor SET  status = CASE WHEN @status IS NOT NULL THEN @status ELSE status END WHERE id = @id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {


                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@id", id);

                    //

                    
                    command.Parameters.AddWithValue("@namemaster", namemaster);

                    //


                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Запись обновлена. Affected rows: " );
                }
            }
            string no = "Без заказа";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE rab SET  status = CASE WHEN @status IS NOT NULL THEN @status ELSE status END , obor = CASE WHEN @obor IS NOT NULL THEN @obor ELSE obor END WHERE id = @id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    string idr = label1.Text;

                    command.Parameters.AddWithValue("@status", statuss);
                    command.Parameters.AddWithValue("@id", idr);
                    command.Parameters.AddWithValue("@obor", no);

                    //



                    //


                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Запись обновлена. Affected rows: " );
                }
            }







        }
    }
}
