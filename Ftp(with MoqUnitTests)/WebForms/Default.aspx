<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label">login</asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Registration" OnClick="Button1_Click" />
            <p>
            <asp:Label ID="Label2" runat="server" Text="Label">password</asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
             <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            </p>



        </div>
    </form>
</body>
</html>
