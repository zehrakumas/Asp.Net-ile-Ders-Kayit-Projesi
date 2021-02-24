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
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                List<EntityDersler> entders = DersBusiness.BusinessDersListele();
                DropDownList1.DataSource = DersBusiness.BusinessDersListele();
                DropDownList1.DataTextField = "Dersadi";
                DropDownList1.DataValueField = "Dersid";
                DropDownList1.DataBind();
            }
            

        }

        //buton
        protected void Button1_Click(object sender, EventArgs e)
        {
            //TextBox1.Text = DropDownList1.SelectedValue.ToString();
            EntityBasvuru ent = new EntityBasvuru();
            ent.Basvuruid = Convert.ToInt32(TextBox1.Text);
            ent.Dersid = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
            DersBusiness.BusinessTalepEkle(ent);
        }
    }
}