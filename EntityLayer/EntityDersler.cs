using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDersler
    {
        private int dersid;
        private string dersadi;
        private int dersmaxkontenjan;
        private int dersminkontenjan;

        public int Dersid
        {
            get { return dersid; }
            set { dersid = value; }
        }
        public string Dersadi
        {
            get { return dersadi; }
            set { dersadi = value; }
        }

        public int Dersmaxkontenjan
        {
            get { return dersmaxkontenjan; }
            set { dersmaxkontenjan = value; }
        }
        public int Dersminkontenjan
        {
            get { return dersminkontenjan; }
            set { dersminkontenjan = value; }
        }
    }
}
