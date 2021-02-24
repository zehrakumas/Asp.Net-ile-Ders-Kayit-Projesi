using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using DataLayer2;
using BusinessLayer2;

namespace DersKayitProjesi
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["Ogrid"].ToString());
            TxtId.Text = x.ToString();
            TxtId.Enabled = false;//id'ye müdahele etmemek için

            if (Page.IsPostBack == false)
            {
                List<EntityOgrenci> OgrList = OgrenciBusiness.BusinessOgrenciDetay(x);
                TxtAd.Text = OgrList[0].Ograd.ToString();
                TxtSoyad.Text = OgrList[0].Ogrsoyad.ToString();
                TxtNumara.Text = OgrList[0].Ogrnumara.ToString();
                TxtSifre.Text = OgrList[0].Ogrsifre.ToString();
                TxtFotoğraf.Text = OgrList[0].Ogrfotograf.ToString();
            }
            
           
        }

        //ogrenci güncelleme butonu
        protected void Button2_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ograd = TxtAd.Text;
            ent.Ogrsoyad = TxtSoyad.Text;
            ent.Ogrnumara = TxtNumara.Text;
            ent.Ogrsifre = TxtSifre.Text;
            ent.Ogrfotograf = TxtFotoğraf.Text;
            ent.Ogrid = Convert.ToInt32(TxtId.Text);
            OgrenciBusiness.BusinessOgrenciGuncelle(ent);
            Response.Redirect("OgrenciListele.aspx");


        }
    }
}