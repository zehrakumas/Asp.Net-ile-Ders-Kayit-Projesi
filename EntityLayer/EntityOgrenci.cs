using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        private int ogrid;
        private string ograd;
        private string ogrsoyad;
        private string ogrnumara;
        private string ogrfotograf;
        private string ogrsifre;
        private double ogrbakiye;

        public int Ogrid
        {
            get { return ogrid; }

            set { ogrid = value; }
        }

        public string Ograd
        {
            get { return ograd; }
            set { ograd = value; }
        }

        public string Ogrsoyad
        {
            get { return ogrsoyad; }
            set { ogrsoyad = value; }
        }

        public string Ogrnumara
        {
            get { return ogrnumara; }
            set { ogrnumara = value; }
        }

        public string Ogrfotograf
        {
            get { return ogrfotograf; }
            set { ogrfotograf = value; }
        }

        public string Ogrsifre
        {
            get { return ogrsifre; }
            set { ogrsifre = value; }
        }

        public double Ogrbakiye
        {
            get { return ogrbakiye; }
            set { ogrbakiye = value; }
        }
    }
}
