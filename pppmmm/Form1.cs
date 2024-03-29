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
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Net.NetworkInformation;

namespace pppmmm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


            Login.Text = "Логин";
            Parol.Text = "Пароль";




        }

        private void CheckLoginCredentials()
        {
            string connectionString = "Data Source=pm.db;Version=3;";
            string login = Login.Text;
            string parol = Parol.Text;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM users WHERE login = @login AND parol = @parol";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@parol", parol);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Вход успешно выполнен!");
                            // Добавьте здесь код для перехода к следующему экрану или выполнения других действий
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль!");
                        }
                    }
                }

                connection.Close();
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=C:\\Users\\user\\Documents\\Sharaga\\pppmmm\\pm.db;Version=3;";
            string login = Login.Text;
            string parol = Parol.Text;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM users WHERE login = @login AND parol = @parol";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@parol", parol);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int roll = reader.GetInt32(reader.GetOrdinal("rol"));
                            string rol = roll == 1 ? "Пользователь" : "Сотрудник";

                            int id = reader.GetInt32(reader.GetOrdinal("id"));
                            string id2 = Convert.ToString(id);
                            Class1.iddd = id2;
                            //MessageBox.Show($"Вход успешно выполнен! Вы входите как {rol}.");

                            // 0 - сотрудник
                            // 1 - клиент
                            // 2 - админ




                            if (roll == 1)
                            {
                                // Open red window for admin
                                this.Hide();
                                Form2 MainPage = new Form2();
                                MainPage.Show();
                                MessageBox.Show("Вы зашли как клиент");
                            }
                            if (roll == 0)
                            {
                                // Open green window for user
                                this.Hide();
                                add MainPage = new add();
                                MainPage.Show();
                                MessageBox.Show("Вы зашли как администратор");
                            }
                            if (roll == 2)
                            {
                                // Open green window for user
                                this.Hide();
                                Form4 MainPage = new Form4();
                                MainPage.Show();
                                MessageBox.Show("Вы зашли как сотрудник");

                                if (id == 3)
                                {
                                    MessageBox.Show("Привет, Андрей");

                                    Class1.iddd= id2;

                                    


                                }
                            
                                


                            }

                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль!");
                        }
                    }
                }

                connection.Close();
            }

        }

        private void reg_Click(object sender, EventArgs e)
        {
            string login = Login.Text;
            string password = Parol.Text;


            string connectionString = "Data Source=C:\\Users\\user\\Documents\\Sharaga\\pppmmm\\pm.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string checkLoginQuery = "SELECT COUNT(*) FROM users WHERE login = @login";
                using (SQLiteCommand checkLoginCommand = new SQLiteCommand(checkLoginQuery, connection))
                {
                    checkLoginCommand.Parameters.AddWithValue("@login", login);
                   // int loginCount = (int)checkLoginCommand.ExecuteScalar();
                    int loginCount = Convert.ToInt32(checkLoginCommand.ExecuteScalar());
                    if (loginCount > 0)
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует.");
                        return;
                    }
                }

                string insertQuery = "INSERT INTO users (id, login, parol, rol) VALUES (NULL, @login, @password, 1)";
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);

                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Пользователь добавлен. Affected rows: " + rowsAffected);
                }
            }
        }
    }
    
}
