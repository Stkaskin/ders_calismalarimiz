using shoe_project.Work.Interfaceler;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoe_project.Classlar
{
    public partial class ayakkabi_bilgi :ICRUD
    {
        SqlCommand command;

        public void Ekle()
        {
            command = new SqlCommand();
            command.CommandText = "INSERT INTO ayakkabi_bilgi_T(adi) VALUES (@p1);";
            command.Parameters.AddWithValue("@p1", this.adi);
            new Work.Sql_Operasyonları.Komut().Calistir_Komut(command);
        }

        public void Guncelle()
        {
            command = new SqlCommand();
            command.CommandText = "Update ayakkabi_bilgi_T set adi=@p1 where ID=@p2";
            command.Parameters.AddWithValue("@p1", this.adi);
            command.Parameters.AddWithValue("@p2", this.ID);
            new Work.Sql_Operasyonları.Komut().Calistir_Komut(command);
        }

        public void Sil()
        {
            command = new SqlCommand();
            command.CommandText = "delete ayakkabi_bilgi_T where ID=@p1";
            command.Parameters.AddWithValue("@p1", this.ID);
            new Work.Sql_Operasyonları.Komut().Calistir_Komut(command);

        }
    }
}
