<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Userlogin.aspx.cs" Inherits="WebApplication1.Userlogin" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <br />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Medium" ForeColor="#006600" Text="User Login"></asp:Label>
    <br />
    <br />
    User Name :
    <asp:TextBox ID="TextBox1" runat="server" Width="168px"></asp:TextBox>
    <br />
    <br />
    Password :
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    <br />
    <asp:Label ID="Label2" runat="server" ForeColor="#FF3300" Text="Label"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

