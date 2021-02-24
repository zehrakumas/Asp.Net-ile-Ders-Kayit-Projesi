<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DersKayitProjesi.WebForm1" %>
 <asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
     <form id="form1" runat="server">

         <div class="mt-3"></div> <%--üst boşluk tagı--%>
         
         
            <div class="form-group ml-3 mr-3"> <%--ml ve mr ile sağdan ve soldan 3 boşluk bıraktık--%>

                <div>
                    <strong>
                    <asp:Label for="TxtAd" runat="server" Text="Öğrenci Adı:"></asp:Label>
                    </strong>
                    <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
             <br /><%-- bir boşluk için kullandık--%>
               <div>
                   <strong>
                   <asp:Label for="TxtSoyad" runat="server" Text="Öğrenci Soyadı:"></asp:Label>
                    </strong>
                    <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
               </div>
                <br /><%-- bir boşluk için kullandık--%>
               <div>
                   <strong>
                   <asp:Label for="TxtNumara" runat="server" Text="Öğrenci Numara:"></asp:Label>
                    </strong>
                    <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control"></asp:TextBox>
               </div>
             <br /><%-- bir boşluk için kullandık--%>
               <div>
                   <strong>
                   <asp:Label for="TxtSifre" runat="server" Text="Öğrenci Şifre:"></asp:Label>
                    </strong>
                    <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control"></asp:TextBox>
               </div>
            <br /><%-- bir boşluk için kullandık--%>
               <div>
                   <strong>
                   <asp:Label for="TxtFotoğraf" runat="server" Text="Öğrenci Fotoğraf:"></asp:Label>
                    </strong>
                    <asp:TextBox ID="TxtFotoğraf" runat="server" CssClass="form-control"></asp:TextBox>
               </div>


         </div>
             
         <div class="ml-3"> <%--soldan 3 boşluk verilmesini sağladık--%>
             <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" CssClass="btn btn-info"/>
         </div>
         
     </form>
     
</asp:Content>



