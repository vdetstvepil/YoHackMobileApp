using System;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Xamarin.Forms;
namespace YoHackMobileApp
{
    public static class SendToDB
    {
        public static void sendToDB(string cmd)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "yohackserver.database.windows.net";
                builder.UserID = "vdetstvepil";
                builder.Password = "8ezffgdK";
                builder.InitialCatalog = "db";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    //Console.WriteLine("\nQuery data example:");
                    //.WriteLine("=========================================\n");
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    //sb.Append("INSERT INTO \"investor\" (name_investor, surname_investor, " +
                    //    "login_investor, money_investor) " +
                    //    $"VALUES ('Anton', 'Kislyakov', '{log}', 100.5);");

                    //String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(cmd, connection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
