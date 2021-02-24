using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer2;
namespace BusinessLayer2
{
    public class OgrenciBusiness
    {
        public static int OgrenciEkleBusiness(EntityOgrenci parametre)
        {//eğer boş değilse dataogrencşye git ve değerleri ekle-kontrol
            if (parametre.Ograd != null && parametre.Ogrsoyad != null && parametre.Ogrnumara != null && parametre.Ogrsifre != null && parametre.Ogrfotograf != null)
            {
                return DataOgrenci.OgrenciEkle(parametre);
            }
            return -1;
        }
        //ogrenci listeleme
        public static List<EntityOgrenci> BusinessListele()
        {
            return DataOgrenci.OgrenciListesi();
        }
        //ogrenci silme
        public static bool BusinessOgrenciSil(int p)
        {
            if (p>=0)
            {
                return DataOgrenci.DataOgrenciSil(p);
            }
            return false;

        }
        //ogrenci güncelleme listesi
        public static List<EntityOgrenci> BusinessOgrenciDetay(int p)
        {
            return DataOgrenci.OgrenciDetay(p);
        }
        //ogrenci güncelleme işlemi
        public static bool BusinessOgrenciGuncelle(EntityOgrenci p)
        {
            if (p.Ograd != null && p.Ograd != "" && p.Ogrsoyad != null && p.Ogrsoyad != "" && p.Ogrnumara != null && p.Ogrnumara != "" && p.Ogrsifre != null && p.Ogrsifre != "" && p.Ogrfotograf != null && p.Ogrfotograf != "")
            {
                return DataOgrenci.OgrenciGuncelle(p);
            }
            return false;

        }
    }
}
