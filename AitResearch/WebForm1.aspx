<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AitResearch.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AIT - Research</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="QuestionLabel" runat="server" Text="Label" Font-Bold="True" Font-Size="X-Large"></asp:Label>
            <br />
            <br />
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            <br />
            <br />
            <br />
            <asp:Button ID="NextBtn" runat="server" Text="Next" OnClick="NextBtn_Click" BackColor="#339966" Font-Bold="True" Font-Size="Large" ForeColor="White" Font-Overline="False" />
        </div>
    </form>
</body>
</html>
