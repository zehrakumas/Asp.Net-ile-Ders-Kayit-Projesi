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
    public partial class OgrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["Ogrid"]);
            Response.Write(x);
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ogrid = x;
            OgrenciBusiness.BusinessOgrenciSil(ent.Ogrid);
            Response.Redirect("OgrenciListele.aspx");
        }
    }
}