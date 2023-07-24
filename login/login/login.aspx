<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="login.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Txtusername" runat="server" Text="Username :"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Password :"></asp:Label>
        <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Button ID="BtnLogin" runat="server" Text="Login" onclick="BtnLogin_Click" PostBackUrl="~/home.aspx" />
        <asp:Label ID="Lblerromsg" runat="server" Text=""></asp:Label>
        

         
    </div>
    </form>
</body>
</html>
