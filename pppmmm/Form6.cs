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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Runtime.Remoting.Messaging;

namespace pppmmm
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
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







        }






                
    }
    
}


