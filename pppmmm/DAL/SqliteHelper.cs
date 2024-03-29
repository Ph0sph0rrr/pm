using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pppmmm.DAL
{
    class SqliteHelper
    {
        internal static List<Users> GetUsers()
        {
            try

            {

                List<Users> users = new List<Users>();

                using (var connection = new SQLiteConnection("Data Source=C:\\Users\\user\\Documents\\Sharaga\\pppmmm\\pm.db;Version=3;"))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(@"SELECT id, name, opis, status, nameklient, datanach from obor;", connection))
                    {
                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                //List<Users> users = new List<Users>();
                                while (rdr.Read())
                                {
                                    users.Add(new Users
                                    {
                                        id = rdr.GetInt32(0),
                                        name = rdr.GetString(1),
                                        opis = rdr.GetString(2),
                                        status = rdr.GetInt32(3),
                                        nameklient = rdr.GetString(4),

                                        //
                                        datanach = rdr.GetString(5),



                                        //
                                    });
                                }

                                return users;

                            }
                        }

                    }
                }
                return users;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }


    }    

}

