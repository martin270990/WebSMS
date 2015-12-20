<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contactos.aspx.cs" Inherits="WebSMS.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Enviar Mensaje Manual</title>
    <link rel="stylesheet" href="estilos/estilos.css"/>
   
    <style type="text/css">
        #Text1 {
            width: 35px;
        }
        #contador_char {
            width: 54px;
        }
        #caracteres {
            width: 43px;
        }
        #TextArea1 {
            height: 78px;
            width: 301px;
        }
        #Txb_mensaje {
            height: 110px;
            width: 377px;
        }
        #txb_char {
            width: 41px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <section id="contenedor">

<header id="encabezado">
	<img src="img/logo.png"/>
	<div id="user-status">
		<div id="user">		
		    <asp:Label ID="lbl_user" runat="server" Text="user_logged"></asp:Label>		
		</div>
		<div id="btn_loginout">			
		    <asp:Button ID="btn_disconnect" runat="server" Text="Desconectarse" />			
		</div>
	</div>
</header>


<div id="menu-nav">
	<div id="menu">
                <li>Inicio</li>
                <li>Enviar Mensaje</li>
                <li>Campañas</li>
                <li>Contactos</li>
                <li>Créditos</li>
                <li>Reportes</li>
                <li>Configuración</li>
    </div>
</div>

<div id="msg-content">
	
    <div id="txt_contactos">Contactos</div>
    <div id="menu_nav_top">
        <li>Crear Grupo</li>
        <li>Editar Grupo</li>
        <li>Eliminar Grupo</li>
        <li>Buscar Contacto o Grupo</li>
    </div>
    <div id="menu_nav_bottom">
        <li>Importar Contactos desde Excel</li>
        <li>Agregar Contacto</li>
        <li>Eliminar Contacto</li>
    </div>

    
    
	
</div>

</section>
    </form>
</body>
</html>
