using shoe_project.Work.Interfaceler;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoe_project.Classlar
{
    public partial class marka :  ICRUD
    {
        SqlCommand command = new SqlCommand();


        public void Ekle()
        {
            command = new SqlCommand();
            command.CommandText = "INSERT INTO marka_T (ad) VALUES (@p1);";
            command.Parameters.AddWithValue("@p1", this.ad);
            new Work.Sql_Operasyonları.Komut().Calistir_Komut(command);
        }

        public void Guncelle()
        {
            command = new SqlCommand();
            command.CommandText = "Update marka_T ad=@p1 where ID=@p2;";
            command.Parameters.AddWithValue("@p1", this.ad);
            command.Parameters.AddWithValue("@p2", this.ID);
            new Work.Sql_Operasyonları.Komut().Calistir_Komut(command);
        }

        public void Sil()
        {
            command = new SqlCommand();
            command.CommandText = "delete marka_T where ID=@p1";
            command.Parameters.AddWithValue("@p1", this.ID);
            new Work.Sql_Operasyonları.Komut().Calistir_Komut(command);
        }
    }
}
