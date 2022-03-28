<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Courses.aspx.cs" Inherits="WebApplication1.Courses" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    Course Code<asp:TextBox ID="TextBox2" runat="server" Height="27px" style="margin-left: 0px" Width="179px"></asp:TextBox>
    <br />
    <br />
    Course Name <asp:TextBox ID="TextBox1" runat="server" Height="24px" OnTextChanged="TextBox1_TextChanged" style="margin-bottom: 3px" Width="177px"></asp:TextBox>
    <br />
    <br />
    Credits&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox3" runat="server" Height="28px" Width="176px"></asp:TextBox>
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add the Course" Height="39px" Width="194px" />
    <br />
    <br />
    ,<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete the Course" Height="36px" Width="188px" />
    <br />
    <br />
    <asp:Button ID="Button4" runat="server" Height="38px" OnClick="Button4_Click" Text="Update" Width="92px" />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Height="39px" OnClick="Button1_Click" Text="GET COURSES" Width="116px" />
    <br />
    <br />
    <br />
&nbsp;<asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="250px" Width="497px">
     <AlternatingRowStyle BackColor="#DCDCDC" />
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
    </asp:GridView>
</asp:Content>

