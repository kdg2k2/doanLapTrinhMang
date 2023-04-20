using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AutoCopySelectionText
{
    public class DBConnect
    {
        public static SqlConnection GetDBConnection()
        {
            string connString = @"Data Source=DG;Initial Catalog=KdgTranslate_HotKeys;Integrated Security=True";
            SqlConnection con = new SqlConnection(connString);
            return con;
        }

        SqlConnection con = GetDBConnection();
        public void Update(string idEvent, string keys)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string update = "UPDATE Keys SET keys = @keys WHERE idEvent = @idEvent";
            SqlCommand cmd = new SqlCommand(update, con);
            cmd.Parameters.AddWithValue("@keys", keys);
            cmd.Parameters.AddWithValue("@idEvent", idEvent);
            cmd.ExecuteNonQuery();
            con.Close();
        }


    }
}
