using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataLayer2
{
    public class DataDers
    {
        //ders listeleme işlemi
        public static List<EntityDersler> DersListesi()
        {
            List<EntityDersler> degerler = new List<EntityDersler>();
            SqlCommand komut1 = new SqlCommand("select * from Tbldersler", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();//eğer bağlantı kapalıysa bağlantıyı aç
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityDersler ent = new EntityDersler();
                ent.Dersadi = dr["dersadi"].ToString();
                ent.Dersid = Convert.ToInt32(dr["dersid"].ToString());
                ent.Dersmaxkontenjan = Convert.ToInt32 (dr["dersmaxkontenjan"].ToString());
                ent.Dersminkontenjan = Convert.ToInt32(dr["dersminkontenjan"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int talepekle(EntityBasvuru parametre)
        {
            SqlCommand komut = new SqlCommand("insert into Tblbasvuruform (ogrenciid,dersid) values (@p1,@p2) ", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", parametre.Ogrenciid);
            komut.Parameters.AddWithValue("@p2", parametre.Dersid);
       
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();//eğer bağlantı kapalıysa bağlantıyı aç
            }
            return komut.ExecuteNonQuery();
        }
    }
}
