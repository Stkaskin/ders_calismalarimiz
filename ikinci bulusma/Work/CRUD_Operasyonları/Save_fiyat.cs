using shoe_project.Work.Interfaceler;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace shoe_project.Classlar
{
    public partial class fiyat : ICRUD
    {
        SqlCommand command = new SqlCommand();


        public void Ekle()
        {//script ile 
            command = new SqlCommand();
            command.CommandText = "  INSERT INTO [dbo].[fiyat_T] ([ayakkabiID] ,[Adet_Fiyat]) VALUES (@p1, @p2 )";
            command.Parameters.AddWithValue("@p1", this.Adet_Fiyat);
            command.Parameters.AddWithValue("@p2", this.ayakkabiID);
            new Work.Sql_Operasyonları.Komut().Calistir_Komut(command);
        }

        public void Guncelle()
        {
            command = new SqlCommand();
            command.CommandText = "update fiyat_T set Adet_Fiyat=@p1 where ID=@p2";
            command.Parameters.AddWithValue("@p1", this.Adet_Fiyat);
            command.Parameters.AddWithValue("@p2", this.ID);
            new Work.Sql_Operasyonları.Komut().Calistir_Komut(command);
            /*
             INSERT INTO [dbo].[fiyat_T] ([ayakkabiID] ,[Adet_Fiyat]) VALUES (<ayakkabiID, int,> ,<Adet_Fiyat, int,>)
             
             */
        }

        public void Sil()
        {
            command = new SqlCommand();
            command.CommandText = "delete fiyat_T where ID=@p1";
            command.Parameters.AddWithValue("@p1", this.ID);
            new Work.Sql_Operasyonları.Komut().Calistir_Komut(command);


        }
    }
}
