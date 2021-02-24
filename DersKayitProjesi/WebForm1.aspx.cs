using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataLayer2;
using BusinessLayer2;

namespace DersKayitProjesi
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //deneme buton
        protected void Button1_Click(object sender, EventArgs e)
        {
            //değer girdik
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ograd = TxtAd.Text;
            ent.Ogrsoyad = TxtSoyad.Text;
            ent.Ogrnumara = TxtNumara.Text;
            ent.Ogrsifre = TxtSifre.Text;
            ent.Ogrfotograf = TxtFotoğraf.Text;
            //business ogrenci ekle metodu
            OgrenciBusiness.OgrenciEkleBusiness(ent);

        }
    }
}