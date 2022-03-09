using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoe_project.Work.Sql_Operasyonları
{
  public  class Komut 
    {
        SqlConnection connection = new SqlConnection("data source=.;initial catalog=Ayakkabi_Db;integrated security=True;MultipleActiveResultSets=True;");
        SqlCommand command;

        public object Calistir_Komut(SqlCommand command)
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            command.Connection = connection;
            var value_=command.ExecuteReader();
            connection.Close();
            return value_;

        }
        public object Sorgu_Calistir(string sorgu) 
        {
            command= new SqlCommand();
            command.CommandText = sorgu;
            return (SqlDataReader)Calistir_Komut(command);
        }
       
    }
}
