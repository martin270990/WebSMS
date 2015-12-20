<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="contacts.aspx.cs" Inherits="WebSMS.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link rel="stylesheet" href="estilos/estilos.css"/>
    <div id="msg-content">
	
    <div id="txt_contactos">Contactos</div>
    <div id="menu_nav_top">
        <li><input id="btn_group" type="button" value="Crear Nuevo Grupo" onclick="mostrar('crt-group')" /></li>
        <li><input id="btn_view_delete_group" type="button" value="Ver o eliminar Grupos" onclick="mostrar('view-edit-group')" /></li>
        <li><input id="btn_search_contact" type="button" value="Buscar Contactos" onclick="mostrar('')" /></li>
        
    </div>
    <div id="menu_nav_bottom">
        <li><input id="btn_import" type="button" value="Importar contactos desde excel" onclick="mostrar('')" /></li>
    </div>
        </div>

    <div id="content-group">
             
        <div id="crt-group" style="display:none">
        Ingrese nombre del grupo:
        <br />
        <asp:TextBox ID="name_group" runat="server" Width="288px" ></asp:TextBox>           
        <br />
        <br />
        <asp:Button ID="btn_crt_group" runat="server" Text="Crear Grupo" OnClick="btn_crt_group_Click"/>
        <br />
        </div>

        <div id="view-edit-group" style="display:normal">
                
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
                
            <br />
                
       </div>
    </div>


    <div id="result"> <asp:Label ID="lbl_result_group" runat="server" Text=""></asp:Label></div>
</asp:Content>
