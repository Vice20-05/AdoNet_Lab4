using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Taks 3 
// Simple SQLite helper class to manage a connection and basic keyword CRUD
namespace AdoNet_Lab4
{
    internal class SQLiteHandler
    {
        private SQLiteConnection connection;
        // Constructor receives the connection string and prepares the connection
        public SQLiteHandler(string connectionString)
        {
            connection = new SQLiteConnection(connectionString);
        }

        //Connect to the database and create the table if it does not exist
        public void ConnectToDB()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            // SQL statement to ensure the Keywords table exists (no-op if already created)
            string sql = "CREATE TABLE IF NOT EXISTS Keywords(" + "Id INTEGER PRIMARY KEY AUTOINCREMENT," +
                "Keyword TEXT)";
            SQLiteCommand cmd=new SQLiteCommand(sql, connection);
            // Execute the table creation command
            cmd.ExecuteNonQuery();
        }
        public void DisconnectFromDB()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

       
        public bool IsConnected()
        {
            // Return true when the underlying connection is open
            return connection.State == System.Data.ConnectionState.Open;
        }

        public SQLiteCommand CreateCommand(string commandText)
        {
            // Create a command object bound to the current connection
            return new SQLiteCommand(commandText, connection);
        }

        public void InsertKeyword(string keyword)
        {
            // Insert a single keyword using a parameter to avoid SQL injection
            string sql = "INSERT INTO Keywords(Keyword) VALUES(@keyword)";
            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            cmd.Parameters.AddWithValue("@keyword", keyword);
            cmd.ExecuteNonQuery();
        }

        public List<string> GetAllKeywords()
        {
            List<string> keywords = new List<string>();
            // Read all keywords from the Keywords table
            string sql = "SELECT Keyword FROM Keywords";
            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                keywords.Add(reader.GetString(0));
            }
            return keywords;
        }
    }
}
