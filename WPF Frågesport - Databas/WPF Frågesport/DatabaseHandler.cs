using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Data.Sqlite;



namespace WPF_Frågesport
{
    class DatabaseHandler
    {
        // name of database file
        private string dbName = "fragesport.db";
        private string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public string GetPathAndDbName()
        {
            return Path.Combine(docPath, dbName); ;
        }


       

        public List<MainCard> GetQuestion()
        {
            List<MainCard> frågesporten = new List<MainCard>();

            using (SqliteConnection db =
               new SqliteConnection($"Filename={GetPathAndDbName()}"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand("SELECT * from fragesport", db);

                SqliteDataReader query = selectCommand.ExecuteReader();


                while (query.Read())
                {
                   
                    
                    MainCard frågesport = new QuestionCard(query.GetString(1), query.GetString(2));

                    frågesporten.Add(frågesport);
                       
                }

                db.Close();
            }

            return frågesporten;
        }


        private int NumberOfTowers()
        {
            int count = 0;
            using (SqliteConnection db =
              new SqliteConnection($"Filename={GetPathAndDbName()}"))
            {
                db.Open();

                SqliteCommand sqlCommand = new SqliteCommand();
                sqlCommand.Connection = db;

                sqlCommand.CommandText = "SELECT COUNT (id) FROM tower";
                SqliteDataReader query = sqlCommand.ExecuteReader();
                if (query.Read())
                {
                    count = int.Parse(query.GetString(0));
                }

                db.Close();
            }

            return count;
        }
    }

}
