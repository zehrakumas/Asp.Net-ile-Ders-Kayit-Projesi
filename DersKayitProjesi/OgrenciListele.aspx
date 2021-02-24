<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciListele.aspx.cs" Inherits="DersKayitProjesi.OgrenciListele" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>Öğrenci Id</th>
            <th>Öğrenci Ad</th>
            <th>Öğrenci Soyad</th>
            <th>Öğrenci Numara</th>
            <th>Öğrenci Şifre</th>
            <th>Öğrenci Fotoğraf</th>
            <th>Öğrenci Bakiye</th>
            <th>İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                <tr>
                    <td><%#Eval("Ogrid") %></td>
                    <td><%#Eval("Ograd") %></td>
                    <td><%#Eval("Ogrsoyad") %></td>
                    <td><%#Eval("Ogrnumara") %></td>
                    <td><%#Eval("Ogrsifre") %></td>
                    <td><%#Eval("Ogrfotograf") %></td>
                    <td><%#Eval("Ogrbakiye") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"~/OgrenciSil.aspx?Ogrid="+Eval("Ogrid") %>' runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                        <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"~/OgrenciGuncelle.aspx?Ogrid="+Eval("Ogrid") %>' runat="server" CssClass="btn btn-success">Güncelle</asp:HyperLink>
                    </td>
                </tr>
                    
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
