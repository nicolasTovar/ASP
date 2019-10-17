<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mostrar.aspx.cs" Inherits="EstadoVariableWeb.mostrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtMostrar" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="btnIncrementar" runat="server" Text="Incrementar" OnClick="btnIncrementar_Click" />
        </p>
    </form>
</body>
</html>
