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
                    connection.Open();
                    StringBuilder sb = new StringBuilder();


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
      public struct info
        {
            public string login_startup;
            public string stage;
            public string sum_money;
            public string conditions;
        } 
        public static List<info> GtInvestorRounds(string cmd)
        {

            List<info> round = new List<info>();
            
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "yohackserver.database.windows.net";
                builder.UserID = "vdetstvepil";
                builder.Password = "8ezffgdK";
                builder.InitialCatalog = "db";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();


                    using (SqlCommand command = new SqlCommand(cmd, connection))
                    {
                        SqlDataReader reader; //объявляем переменную чтения возвращаемого потока данных (ридер)
                        reader = command.ExecuteReader(); //выполняем запрос и заливаем весь возвращаемый поток данных в ридер
                        while (reader.Read()) //вытягиваем данные из ридера до тех пор, пока ридер не останется пустым
                        {   info r = new info();
                            //в квадратных скобках пишем названия полей таблицы таким же образом, как они указаны в запросе
                            r.login_startup = reader["stage"].ToString();
                            r.stage=reader["stage"].ToString();
                            r.sum_money= reader["sum_money"].ToString();
                            r.conditions= reader["conditions"].ToString();
                            round.Add(r);
                        }
                        reader.Close(); //закрываем ридер

                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            return round;
        }

        public static List<string> GetInvestors(string cmd)
        {

            List<string> investor = new List<string>();

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "yohackserver.database.windows.net";
                builder.UserID = "vdetstvepil";
                builder.Password = "8ezffgdK";
                builder.InitialCatalog = "db";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    

                    using (SqlCommand command = new SqlCommand(cmd, connection))
                    {
                        SqlDataReader reader; //объявляем переменную чтения возвращаемого потока данных (ридер)
                        reader = command.ExecuteReader(); //выполняем запрос и заливаем весь возвращаемый поток данных в ридер
                        while (reader.Read()) //вытягиваем данные из ридера до тех пор, пока ридер не останется пустым
                        {
                            
                            //в квадратных скобках пишем названия полей таблицы таким же образом, как они указаны в запросе
      
                              investor.Add( reader["name_investor"].ToString());
            
                        }
                        reader.Close(); //закрываем ридер

                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            return investor;
        }
    }
}
