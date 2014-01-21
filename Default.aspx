<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="aspnet_Versaler_1.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="css.css" rel="stylesheet" />
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="textArea" runat="server" OnTextChanged="textArea_TextChanged"></asp:TextBox>
        <asp:Button ID="button" runat="server"  Text="Button" OnClick="button_Click" />
        <p id="pTag" runat="server">
        </p>
        <p id="tries" runat="server"></p>
    </div>
    </form>
</body>
</html>
