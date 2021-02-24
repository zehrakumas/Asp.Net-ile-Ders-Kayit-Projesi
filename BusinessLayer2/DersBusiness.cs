using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer2;

namespace BusinessLayer2
{
    public class DersBusiness
    {
        public static List<EntityDersler> BusinessDersListele()
        {
            return DataDers.DersListesi();
        }
        public static int BusinessTalepEkle(EntityBasvuru p)
        {
            if(p.Ogrenciid != null && p.Dersid != null)
            {
                return DataDers.talepekle(p);
            }
            return -1;
        }
    }
}
