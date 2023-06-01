using System.Data.SQLite;

namespace AutoCopySelectionText
{
    public class DBConnect
    {
        public static SQLiteConnection GetDBConnection()
        {
            var sql = "Data Source = KeyPress.db";
            SQLiteConnection con = new SQLiteConnection(sql);
            return con;
        }
        SQLiteConnection con = GetDBConnection();
        public void CreateDB()
        {
            var sql = "Data Source = KeyPress.db";
            SQLiteConnection.CreateFile(sql);
        }

        public void CreateTable(SQLiteConnection con)
        {
            string create = "CREATE TABLE Keys(idEvent NCHAR(10) PRIMARY KEY, keys NCHAR(10))";
            var cmd = new SQLiteCommand(create, con);
            cmd.ExecuteNonQuery();
        }

        public void Insert(SQLiteConnection con, string idEvent, string keys)
        {
            string insert = "INSERT INTO Keys(idEvent, keys) VALUES(@idEvent, @keys)";
            var cmd = new SQLiteCommand(insert, con);
            cmd.Parameters.AddWithValue("@idEvent", idEvent);
            cmd.Parameters.AddWithValue("@keys", keys);
            cmd.ExecuteNonQuery();
        }

        public void Update(string idEvent, string keys)
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            string update = "UPDATE Keys SET keys = @keys WHERE idEvent = @idEvent";
            SQLiteCommand cmd = new SQLiteCommand(update, con);
            cmd.Parameters.AddWithValue("@keys", keys);
            cmd.Parameters.AddWithValue("@idEvent", idEvent);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void CreateTableVoices(SQLiteConnection con)
        {
            string create = "CREATE TABLE Voices(idVoice int PRIMARY KEY, nameVoice NVARCHAR(50))";
            var cmd = new SQLiteCommand(create, con);
            cmd.ExecuteNonQuery();
        }

        public void InsertVoices(SQLiteConnection con, int idVoice, string nameVoice)
        {
            string insert = "INSERT INTO Voices(idVoice, nameVoice) VALUES(@idVoice, @nameVoice)";
            var cmd = new SQLiteCommand(insert, con);
            cmd.Parameters.AddWithValue("@idVoice", idVoice);
            cmd.Parameters.AddWithValue("@nameVoice", nameVoice);
            cmd.ExecuteNonQuery();
        }

        public void CreateTableChooseVoice(SQLiteConnection con)
        {
            string create = "CREATE TABLE ChooseVoice(nameVoice NVARCHAR(50))";
            var cmd = new SQLiteCommand(create, con);
            cmd.ExecuteNonQuery();
        }

        public void InsertChooseVoice(SQLiteConnection con, string nameVoice)
        {
            string insert = "INSERT INTO ChooseVoice(nameVoice) VALUES(@nameVoice)";
            var cmd = new SQLiteCommand(insert, con);
            cmd.Parameters.AddWithValue("@nameVoice", nameVoice);
            cmd.ExecuteNonQuery();
        }

        public void UpdateChooseVoice(string nameVoice)
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            string update = "UPDATE ChooseVoice SET nameVoice = @nameVoice";
            SQLiteCommand cmd = new SQLiteCommand(update, con);
            cmd.Parameters.AddWithValue("@nameVoice", nameVoice);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void InsertZaloApiKey(SQLiteConnection con, string key)
        {
            string sql = "insert into apiKey (key) values (@key)";
            var com = new SQLiteCommand(sql, con);
            com.Parameters.AddWithValue("@key", key);
            com.ExecuteNonQuery();
        }

        public void UpdateZaloApiKey(string key)
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            string update = "UPDATE apiKey SET key = @key";
            SQLiteCommand cmd = new SQLiteCommand(update, con);
            cmd.Parameters.AddWithValue("@key", key);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
