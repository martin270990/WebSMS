<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="~/sendmsg.aspx.designer.cs" Inherits="WebSMS.Formulario_web1" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <div id="msg-content">	
    <div id="txt_enviar"> Envio Manual de SMS </div>    
    <div id="id_num">		
	    Ingrese número de linea a enviar		
	    <br />		
	    <asp:TextBox ID="txb_numLinea" runat="server" ></asp:TextBox>		
	</div>

	<div id="mensaje">		
	    Ingrese el mensaje que desee enviar<br />
        <asp:TextBox runat="server" id="Txb_mensaje" onkeydown="cuenta()" TextMode="MultiLine" onkeyup="cuenta()" Height="112px" Width="409px"></asp:TextBox><br />
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


</asp:Content>

