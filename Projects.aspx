<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Projects.aspx.cs" MasterPageFile="~/Site.Master" Inherits="WebApplication1.Projects" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <br />
    <br />
    <br />
    <br />
    <asp:DropDownList ID="DropDownList2" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="get the graduation projects" />
    <br />
    &nbsp;<asp:GridView ID="GridView2" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="500px">
    <AlternatingRowStyle BackColor="#CCCCCC" />
    <FooterStyle BackColor="#CCCCCC" />
    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#F1F1F1" />
    <SortedAscendingHeaderStyle BackColor="#808080" />
    <SortedDescendingCellStyle BackColor="#CAC9C9" />
    <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" BackColor="#6699FF" BorderColor="#000099" BorderStyle="Groove" Height="26px" Text="Choose the lecturer you want to work with." ValidateRequestMode="Enabled" Width="373px"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
    </asp:CheckBoxList>
    <br />
    <br />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Choose a lecturer" />
    <br />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>


