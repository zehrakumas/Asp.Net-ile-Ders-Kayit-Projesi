using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class EntityOgretmen
    {
        private int ogretmenid;
        private string ogretmenadsoyad;
        private string ogretmenbrans;

        public int Ogretmenid
        {
            get { return ogretmenid; }
            set { ogretmenid = value; }
        }

        public string Ogretmenadsoyad
        {
            get { return ogretmenadsoyad; }
            set { ogretmenadsoyad = value; }
        }
        public string Ogretmenbrans
        {
            get { return ogretmenbrans; }
            set { ogretmenbrans = value; }
        }
    }
}
