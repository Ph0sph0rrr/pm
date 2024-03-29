using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace pppmmm
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();

            saveFileDialog1.Filter = "Text File(*.txt)|*.txt";

            label1.Text = Class1.iddd;

            if (Class1.iddd == "1")
            {
                label4.Text = ("Егор Плей");
            }

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idt.Text);



            string connectionString = "Data Source=C:\\Users\\user\\Documents\\Sharaga\\pppmmm\\pm.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * from obor where id = @id;";
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



            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string Filename = saveFileDialog1.FileName;

            File.WriteAllText(Filename, richTextBox1.Text);

            MessageBox.Show("Файл сохранен");




        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            




        }
    }
}
