using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBasvuru
    {
        private int basvuruid;
        private int dersid;
        private int ogrenciid;

        public int Basvuruid
        {
            get { return basvuruid; }
            set { basvuruid = value; }
        }

        public int Dersid
        {
            get { return dersid; }
            set { dersid = value; }
        }
        public int Ogrenciid
        {
            get { return ogrenciid; }
            set { ogrenciid = value; }
        }
    }
}
