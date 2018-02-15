<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Quotes.aspx.cs" Inherits="Lab4.Quotes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtQuoteList" runat="server" Enabled="False" Height="278px" Width="926px"></asp:TextBox>
        </div>
        <asp:Button ID="btnReturn" runat="server" PostBackUrl="~/GreicoQuote.aspx" Text="Add Another Quote" />
    </form>
</body>
</html>
