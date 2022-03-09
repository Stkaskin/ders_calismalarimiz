using shoe_project.Work.Interfaceler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace shoe_project.Classlar
{
    public partial class numara : ICRUD
    {
        SqlCommand command = new SqlCommand();


        public void Ekle()
        {
            command = new SqlCommand();
            command.CommandText = "insert into numara_T (numarasi,uluslararasıStandartKodu) values (@p1,@p2)";
            command.Parameters.AddWithValue("@p1", this.numarasi);
            command.Parameters.AddWithValue("@p2", this.uluslararasıStandartKodu);
            new Work.Sql_Operasyonları.Komut().Calistir_Komut(command);
        }

        public void Guncelle()
        {
            command = new SqlCommand();
            command.CommandText = "Update numara_T Set numarasi=@p1,uluslararasıStandartKodu=@p2 where ID=@p3";
            command.Parameters.AddWithValue("@p1", this.numarasi);
            command.Parameters.AddWithValue("@p2", this.uluslararasıStandartKodu);
            command.Parameters.AddWithValue("@p3", this.ID);
            new Work.Sql_Operasyonları.Komut().Calistir_Komut(command);
        }

        public void Sil()
        {
            command = new SqlCommand();
            command.CommandText = "delete numara_T where ID=@p1";
            command.Parameters.AddWithValue("@p1", this.ID);
            new Work.Sql_Operasyonları.Komut().Calistir_Komut(command);
        }
    }
}
