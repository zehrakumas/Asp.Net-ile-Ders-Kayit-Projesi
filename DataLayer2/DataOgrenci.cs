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

    public class DataOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into Tblogrenci (ograd,ogrsoyad,ogrnumara,ogrfotograf,ogrsifre) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();//eğer bağlantı kapalıysa bağlantıyı aç
            }
            komut1.Parameters.AddWithValue("@p1", parametre.Ograd);
            komut1.Parameters.AddWithValue("@p2", parametre.Ogrsoyad);
            komut1.Parameters.AddWithValue("@p3", parametre.Ogrnumara);
            komut1.Parameters.AddWithValue("@p4", parametre.Ogrfotograf);
            komut1.Parameters.AddWithValue("@p5", parametre.Ogrsifre);
            return komut1.ExecuteNonQuery();
        }
        //ogrenci listeleme işlemi
        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("select * from Tblogrenci", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();//eğer bağlantı kapalıysa bağlantıyı aç
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Ogrid = Convert.ToInt32(dr["ogrid"].ToString());
                ent.Ograd = dr["ograd"].ToString();
                ent.Ogrsoyad = dr["ogrsoyad"].ToString();
                ent.Ogrnumara = dr["ogrnumara"].ToString();
                ent.Ogrsifre = dr["ogrsifre"].ToString();
                ent.Ogrfotograf = dr["ogrfotograf"].ToString();
                ent.Ogrbakiye = Convert.ToDouble(dr["ogrbakiye"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        //silme kısmı
        public static bool DataOgrenciSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("delete from Tblogrenci where ogrid=@p1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();//eğer bağlantı kapalıysa bağlantıyı aç
            }
            komut3.Parameters.AddWithValue("@p1", parametre);
            return komut3.ExecuteNonQuery() > 0; //true ise döndürücek

        }
        //ogrenci güncelleme sayfasında listemele ve textboxların doldurulma işlemi
        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut4 = new SqlCommand("select * from Tblogrenci where Ogrid=@p1", Baglanti.bgl);
            komut4.Parameters.AddWithValue("@p1", id);

            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();//eğer bağlantı kapalıysa bağlantıyı aç
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Ograd = dr["ograd"].ToString();
                ent.Ogrsoyad = dr["ogrsoyad"].ToString();
                ent.Ogrnumara = dr["ogrnumara"].ToString();
                ent.Ogrsifre = dr["ogrsifre"].ToString();
                ent.Ogrfotograf = dr["ogrfotograf"].ToString();
                ent.Ogrbakiye = Convert.ToDouble(dr["ogrbakiye"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        //ogrenci detay güncelleme işlemi
        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komut5 = new SqlCommand("update tblogrenci set ograd=@p1,ogrsoyad=@p2,ogrnumara=@p3,ogrfotograf=@p4,ogrsifre=@p5 where ogrid=@p6", Baglanti.bgl);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();//eğer bağlantı kapalıysa bağlantıyı aç
            }
            komut5.Parameters.AddWithValue("@p1", deger.Ograd);
            komut5.Parameters.AddWithValue("@p2", deger.Ogrsoyad);
            komut5.Parameters.AddWithValue("@p3", deger.Ogrnumara);
            komut5.Parameters.AddWithValue("@p4", deger.Ogrfotograf);
            komut5.Parameters.AddWithValue("@p5", deger.Ogrsifre);
            komut5.Parameters.AddWithValue("@p6", deger.Ogrid);
            return komut5.ExecuteNonQuery()>0;
        }

    }
}
