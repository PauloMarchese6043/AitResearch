<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffSearch.aspx.cs" Inherits="AitResearch.StaffSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff's Search</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Search by:" Font-Size="XX-Large"></asp:Label>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Name: " Font-Bold="True" Font-Size="Large"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Font-Size="Large"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Gender: " Font-Bold="True" Font-Size="Large"></asp:Label>
            <asp:CheckBoxList ID="CheckBoxList2" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="State: " Font-Bold="True" Font-Size="Large"></asp:Label>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem>Victoria</asp:ListItem>
                <asp:ListItem>New South Wales</asp:ListItem>
                <asp:ListItem>Queensland</asp:ListItem>
                <asp:ListItem>South Australia</asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Search" Font-Size="Large" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
