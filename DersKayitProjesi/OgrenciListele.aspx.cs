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
    public partial class OgrenciListele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityOgrenci> OgrList = OgrenciBusiness.BusinessListele();
            Repeater1.DataSource = OgrList;
            Repeater1.DataBind();
        }
    }
}