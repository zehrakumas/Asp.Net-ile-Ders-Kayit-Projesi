using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//gerekli kütüphaneleri ekliyoruz
using System.Data;
using System.Data.SqlClient;

namespace DataLayer2
{
    public class Baglanti
    {
        //diger sınıflardan da baglantıya ulaşabiliriz
        public static SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-UQ44GJP;Initial Catalog = dbyazokulu;Integrated Security=True");
    }
}
