using System;

namespace VisualBasicAssignment
{
    static class Module1
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static string editid;
        public static string detailid;

        public static bool openconnect()
        {
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodShop.mdf;Integrated Security=True";
            try
            {
                con.ConnectionString = connString;
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static void closeconnect()
        {
            con.Close();
        }
    }
}