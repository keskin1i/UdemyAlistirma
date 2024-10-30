using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using EntityLayer;




namespace DataAccessLayer
{
    public class DALPersonel
    { 
        public static List<EntityPersonel> PersonelList()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand cmd = new SqlCommand("Select * from TBLBİLGİ", Baglanti._sql);
            ConnectionControl(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                EntityPersonel entity = new EntityPersonel();
                entity.Id = int.Parse(reader["ID"].ToString());
                entity.Ad = reader["AD"].ToString();
                entity.Soyad = reader["SOYAD"].ToString();
                entity.Sehir = reader["SEHIR"].ToString();
                entity.Gorev = reader["GOREV"].ToString();
                entity.Maas = short.Parse(reader["MAAS"].ToString());
                degerler.Add(entity);
            }
            reader.Close();
            return degerler;
        }

        private static void ConnectionControl(SqlCommand cmd)
        {
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
        }

        public static int PersonelEkle(EntityPersonel entity)
        {
            SqlCommand cmd = new SqlCommand("insert into TBLBİLGİ (AD,SOYAD,GOREV,SEHIR,MAAS) values (@p1,@p2,@p3,@p4,@p5)",Baglanti._sql);
           ConnectionControl(cmd);
            cmd.Parameters.AddWithValue("@p1",entity.Ad);
            cmd.Parameters.AddWithValue("@p2", entity.Soyad);
            cmd.Parameters.AddWithValue("@p3", entity.Gorev);
            cmd.Parameters.AddWithValue("@p4", entity.Sehir);
            cmd.Parameters.AddWithValue("@p5",entity.Maas);
                        

            return cmd.ExecuteNonQuery(); ;
        }

        public static bool PersonelSil(int p)
        {
            SqlCommand cmd = new SqlCommand("Delete from TBLBİLGİ WHERE ID=@P1",Baglanti._sql);
           ConnectionControl (cmd);
            cmd.Parameters.AddWithValue("@P1", p);

            return cmd.ExecuteNonQuery()>0; // geri dönüş tipi boolen olduğu için bu şartı entegre ettik. boolen şartlarda kullanıyoruz.
        }

        public static bool PersonelGuncelle(EntityPersonel ent)
        {
            SqlCommand cmd = new SqlCommand("Update TBLBİLGİ SET AD=@P1,SOYAD=@P2,MAAS=@P3,SEHIR=@P4,GOREV=@P5 WHERE ID=@P6",Baglanti._sql);
            ConnectionControl (cmd);
            cmd.Parameters.AddWithValue("@P1", ent.Ad);
            cmd.Parameters.AddWithValue("@P2",ent.Soyad);
            cmd.Parameters.AddWithValue("@P3", ent.Maas);
            cmd.Parameters.AddWithValue("@P5", ent.Gorev);
            cmd.Parameters.AddWithValue("@P4", ent.Sehir);
            cmd.Parameters.AddWithValue("@P6",ent.Id);
            return cmd.ExecuteNonQuery()>0; ;
        }
    }

}
