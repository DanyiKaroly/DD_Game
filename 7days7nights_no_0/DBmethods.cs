﻿
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
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "7days7nights_no_0\\db_file", "DD.db");
            string connString = $"Data Source={dbPath};Version=3;";
            conn = new SQLiteConnection(connString);

        }

        public void Read_from_DB() {
            string sql = "select hp, speed, damage, firerate, reloadtime, level, xp, skillpoint, map from player;";

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

        public void save()
        {
            string updatesql = $"UPDATE player SET hp={Player.PlayerHealth}, speed={Player.PlayerSpeed}, damage={Player.Damage}, firerate={Player.Firerate}, reloadtime={Player.Reload_Time}, level={Player.Level}, xp={Player.Xp}, skillpoint={Player.SkillPoints}, map={Player.Map};";

            try
            {
                conn.Open();
                SQLiteCommand updatecommand = new SQLiteCommand(updatesql, conn);

                MessageBox.Show("Executing '" + updatesql + "' statement...");
                int resultNumber = updatecommand.ExecuteNonQuery();
                MessageBox.Show(resultNumber + " rows updated successfully"+   +Player.PlayerHealth);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hibás módosítás: {e.Message}+     + {Player.PlayerHealth}");
            }
            finally
            {
                conn.Close();
            }



        }


    }

}

    

