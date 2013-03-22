<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="index.aspx.cs" Inherits="Clothes671.index" %>

<asp:Content ID="TitleContent" runat="server" ContentPlaceHolderID="TitleContent">--index</asp:Content>

<asp:Content ID="MainContent" runat="server" ContentPlaceHolderID="MainContent">
    <table>
        <tr>
            <td>Categories</td>
            <td>:</td>
            <td>
                <asp:DropDownList ID="lstCategories" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="lstCategories_SelectedIndexChanged" AppendDataBoundItems="true">
                    <asp:ListItem Text="--Select a Category--" Selected="True" Value="-1"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Products</td>
            <td>:</td>
            <td>
                <asp:DropDownList ID="lstProducts" runat="server"></asp:DropDownList>
            </td>
        </tr>
    </table>
</asp:Content>

