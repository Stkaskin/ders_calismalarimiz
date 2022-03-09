using shoe_project.Work.Interfaceler;
using System;
using shoe_project.Classlar;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace shoe_project.Classlar

{
    //https://www.hikmetokumus.com/makale/23/csharp-partial-class-nedir-
    public partial class ayakkabi:ICRUD
    {
        SqlCommand command = new SqlCommand();
        

        public void Ekle()
        {
            command = new SqlCommand();
            command.CommandText = "INSERT INTO ayakkabi_T(adiID,markaID,renkID,numaraID) VALUES (@adiID,@markaID,@renkID,@numaraID);";
            command.Parameters.AddWithValue("adiID", this.adiID);
            command.Parameters.AddWithValue("markaID", this.markaID);
            command.Parameters.AddWithValue("renkID", this.renkID);
            command.Parameters.AddWithValue("numaraID", this.numaraID);
            new Work.Sql_Operasyonları.Komut().Calistir_Komut(command);
        }

        public void Guncelle()
        {
            command = new SqlCommand();
            command.CommandText = "Update ayakkabi_T set adiID=@p1,markaID==@p2,renkID==@p3,numaraID=@p4) where ID=@p5";
            command.Parameters.AddWithValue("@p1", this.adiID);
            command.Parameters.AddWithValue("@p2", this.markaID);
            command.Parameters.AddWithValue("@p3", this.renkID);
            command.Parameters.AddWithValue("@p4", this.numaraID);
            command.Parameters.AddWithValue("@p5", this.ID);
            new Work.Sql_Operasyonları.Komut().Calistir_Komut(command);
        }

        public void Sil()
        {
            command = new SqlCommand();
            command.CommandText = "delete marka_T ID=@p1";
            command.Parameters.AddWithValue("@p1", this.ID);
            new Work.Sql_Operasyonları.Komut().Calistir_Komut(command);
        }
    }
}
