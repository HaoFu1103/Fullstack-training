﻿
namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("MyConnectString");
            SqlCommand cmd = new SqlCommand("sp_Myproc", conn);
            conn.Open();
            cmd.ExecuteNonQuery();

            /*And
              SqlConnection conn = new SqlConnection(Myconnectstring);
              SqlCommand cmd = new SqlCommand("sp_Myproc", conn);
            */

            using (conn)
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
