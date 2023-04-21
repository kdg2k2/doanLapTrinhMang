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
    }
}
