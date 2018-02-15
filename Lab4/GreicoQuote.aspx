<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GreicoQuote.aspx.cs" Inherits="Lab4.GreicoQuote" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            width: 976px;
        }
        .auto-style7 {
            width: 823px;
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
        }
        .auto-style9 {
            width: 823px;
        }
        .auto-style10 {
            width: 823px;
            height: 22px;
        }
        .auto-style11 {
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style3">
                <tr>
                    <td class="auto-style9" style="text-align:right">
                        <asp:Label runat="server" Text="First Name:" AssociatedControlID="txtFName"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="text-align:right">
                        <asp:Label ID="Label2" runat="server" Text="Last Name:" AssociatedControlID="txtLName"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7" style="text-align:right">
                        <asp:Label ID="Label3" runat="server" Text="Zip Code:" AssociatedControlID="txtZip"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="text-align:right">
                        <asp:Label ID="Label6" runat="server" Text="Car Year:" AssociatedControlID="ddlYear"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlYear_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="text-align:right">
                        <asp:Label ID="lblMake" runat="server" Text="Car Make:" AssociatedControlID="ddlMake"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlMake" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMake_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10" style="text-align:right">
                        <asp:Label ID="lblModel" runat="server" Text="Car Model:" AssociatedControlID="ddlModel"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:DropDownList ID="ddlModel" runat="server" >
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="text-align:right">
                        <asp:Label ID="Label7" runat="server" Text="Primary Driver Age:" AssociatedControlID="ddlAge"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlAge" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="text-align:right">
                        <asp:Label ID="Label8" runat="server" Text="Have a traffic violation in the last 3 years?" AssociatedControlID="ckbViolation"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBox ID="ckbViolation" runat="server"/>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="text-align:right">
                        <asp:Label ID="Label9" runat="server" Text="Insurance Type" AssociatedControlID="rblType"></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButtonList ID="rblType" runat="server">
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnCalculate" runat="server" Text="Calculate Quote" OnClick="btnCalculate_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnPurchase" runat="server" Text="Purchase" PostBackUrl="~/Quotes.aspx" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtQuote" runat="server" Width="735px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
