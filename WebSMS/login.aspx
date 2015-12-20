<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebSMS.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="estilos/login.css" rel="stylesheet" />
 
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ingreso al Sistema - Smart SMS</title>
</head>
<body style="height: 434px">
    <form id="form1" runat="server">
    <div id="login_content">
        <div id="arriba">
            <img src="/img/back_login_head.png" />
        </div>

        <div id="medio">
             <asp:TextBox runat="server"  id="txb_user" type="text" placeholder="Usuario" Width="270px" required></asp:TextBox>
             <br />
             <asp:TextBox runat="server"  id="txb_pass" type="password" placeholder="Contraseña" Width="270px" required></asp:TextBox>
             <br />
             <br />        
        </div>

        <div id="abajo">
            <asp:Button ID="btn_login" runat="server" Text="Entrar" OnClick="btn_login_Click" />
&nbsp;<br />
        <asp:Label ID="lbl_error" runat="server"></asp:Label>
        </div>
        </div>
    </form>
</body>
</html>
