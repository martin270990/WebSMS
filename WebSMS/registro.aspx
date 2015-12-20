<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="WebSMS.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registrar Nuevo Usuario - Smart SMS </title>
 <link href="estilos/registro.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="reg_contenido">
    
        <div id="reg_arriba">
             <img src="/img/reg_new_user.png" />
        </div>

        <div id="reg_medio">
           
            <p><asp:TextBox runat="server" input title="Nombre Requerido" id="txb_nombre" type="text" placeholder="Nombre" OnTextChanged="txb_nombre_TextChanged1"></asp:TextBox></p>
            <p><asp:TextBox runat="server" input title="Apellido Requerido" id="txb_apellido" type="text" placeholder="Apellido"></asp:TextBox></p>
            <p><asp:TextBox runat="server" input title="Mail Requerido" id="txb_correo" type="text" placeholder="Mail"></asp:TextBox></p>
            <p><asp:TextBox runat="server" input title="Usuario Requerido" id="txb_usuario" type="text" placeholder="Usuario"></asp:TextBox></p>
            <p><asp:TextBox runat="server" input title="Contraseña Requerida" id="txb_pass" type="text" placeholder="Contraseña"></asp:TextBox></p>
       </div>

        <div id="reg_abajo">
            <asp:Button runat="server" ID="btn_registrar" Text="Registar" OnClick="btn_registrar_Click"></asp:Button>
            <asp:Button runat="server" ID="btn_cancelar" Text="Cancelar" OnClick="btn_cancelar_Click"></asp:Button>

            <br />
        <asp:Label ID="lbl_error" runat="server"></asp:Label>

        </div>


    </div>
    </form>
</body>
</html>