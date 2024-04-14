
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _7days7nights_no_0
{
    internal class DBmethods
    {
        
         SQLiteConnection conn;

        public DBmethods()
        {

            conn = new SQLiteConnection("Data Source=db_file\\DD.db;Version=3;");

        }

        public void Read_from_DB() {
            string sql = "select hp, speed, damage, firerate, reloadtime, level, xp, skillpoint, map from player";

                try
                {
                    conn.Open();

                    using (SQLiteCommand command = new SQLiteCommand(sql, conn))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Player.PlayerHealth = reader.GetInt32(reader.GetOrdinal("hp"));
                                Player.PlayerSpeed = reader.GetInt32(reader.GetOrdinal("speed"));
                                Player.Damage = reader.GetInt32(reader.GetOrdinal("damage"));
                                Player.Firerate = reader.GetInt32(reader.GetOrdinal("firerate"));
                                Player.Reload_Time = reader.GetInt32(reader.GetOrdinal("reloadtime"));
                                Player.Level = reader.GetInt32(reader.GetOrdinal("level"));
                                Player.Xp = reader.GetInt32(reader.GetOrdinal("xp"));
                                Player.SkillPoints = reader.GetInt32(reader.GetOrdinal("skillpoint"));
                                Player.Map = reader.GetInt32(reader.GetOrdinal("map"));
                            }
                        }
                    }
                }
                catch (Exception ex)
                    {
                        MessageBox.Show($"Hiba történt az adatbázis olvasása közben: {ex.Message}");
                    }
                finally
                    {
                        conn.Close();
                    }
        }
    }

}

    

