<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EmpresaUI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Clientes: 
            <asp:DropDownList ID="cmbClientes" runat="server"></asp:DropDownList>

            Productos:
            <asp:DropDownList ID="cmbProductos" runat="server" AutoPostBack="true" OnSelectedIndexChanged="cmbProductos_SelectedIndexChanged"></asp:DropDownList>
        </div>

        <div>
            Cantidad: 
            <asp:TextBox ID="txtCantidad" runat="server" TextMode="Number"></asp:TextBox>

        </div>
        <div>
            
            <asp:RadioButtonList ID="rdbiva" runat="server">
                <asp:ListItem Selected="True">Sí</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:RadioButtonList>
        </div>

        <div>
            Precio
            <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="btnAceptar" runat="server" Text="ACEPTAR" OnClick="btnAceptar_Click" />
            <asp:Button ID="btnCancelar" runat="server" Text="CANCELAR" OnClick="btnCancelar_Click" />
        </div>
    </form>
</body>
</html>
