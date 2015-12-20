<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sendmsg.aspx.cs" Inherits="WebSMS.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Enviar Mensaje Manual</title>
    <link rel="stylesheet" href="estilos/estilos.css">
    <script>
	function cuenta(){
	    document.forms[0].caracteres.value = document.forms[0].Txb_mensaje.value.length	    
	}
	</script>
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
	<img src="img/logo.png">
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
	
    <div id="txt_enviar"> Envio Manual de SMS </div>
    
    <div id="id_num">
		
	    Ingrese número de linea a enviar
		
	    <br />
		
	    <asp:TextBox ID="txb_numLinea" runat="server" OnTextChanged="txb_numLinea_TextChanged" ></asp:TextBox>
		
	</div>

	<div id="mensaje">
		
	    Ingrese el mensaje que desee enviar<br />
        <asp:TextBox runat="server" id="Txb_mensaje" onkeydown="cuenta()" TextMode="MultiLine" onkeyup="cuenta()"></asp:TextBox><br />
        Maximo 160 Caracteres. Tienes :
        <input id="txb_char" name="caracteres" type="text" size="4" /><br />
        </div>

	<div id="btn_send">
		
	    <asp:Button ID="btn_sendmsg" runat="server" Text="Enviar Mensaje" OnClick="btn_sendmsg_Click" />
		
	    <br />
		
	</div>
	<div id="result">
		
	    <asp:Label ID="lbl_result_msg" runat="server" Text="Resultado del envio:"></asp:Label>
		
	</div>
	
</div>

</section>
    </form>
</body>
</html>
