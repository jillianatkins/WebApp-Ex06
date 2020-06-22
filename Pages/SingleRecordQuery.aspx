<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SingleRecordQuery.aspx.cs" Inherits="WebApplication2.Pages.SingleRecordQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<%--    <h1>Hey Man</h1>--%>
    <h1>Simple Query by Primary Key (Ex06)</h1>
    <div class="row">
        <div class="col-md-6">
            <asp:Label runat="server" Text="Enter a Team ID:"></asp:Label>&nbsp;&nbsp;
            <asp:TextBox id="IDArg" runat="server"></asp:TextBox>&nbsp;&nbsp;
            <asp:Button id="Fetch" runat="server" Text="Fetch" OnClick="Fetch_Click" />
        </div>
    </div>

    <div class="row">
        <div class="col-md-6">
            <asp:Label id="MessageLabel" runat="server"></asp:Label>
        </div>
    </div>

    <div class="row">
        <div class="col-md-6">
            <asp:Label runat="server" Text="Team ID:"></asp:Label>&nbsp;&nbsp;
            <asp:Label id="ID" runat="server" ></asp:Label>
            <br />
            <asp:Label runat="server" Text="Team Name:"></asp:Label>&nbsp;&nbsp;
            <asp:Label id="Name" runat="server" ></asp:Label>
        </div>
    </div>

</asp:Content>
