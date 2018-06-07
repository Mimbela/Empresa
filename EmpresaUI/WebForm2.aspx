<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="EmpresaUI.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            CLIENTE: <asp:TextBox ID="txtCliente" runat="server" Enabled="false"></asp:TextBox>
            FECHA: <asp:TextBox ID="txtFecha" runat="server" Enabled="false"></asp:TextBox>
            <br />
            <table>
                <tr>
                    <th>PRODUCTO</th>
                    <th>CANTIDAD</th>
                    <th>PRECIO</th>
                </tr>
                <TD>
                    <asp:TextBox ID="txtProducto" runat="server" Enabled="false"></asp:TextBox>
                </TD>
                  <TD>
                    <asp:TextBox ID="txtCantidad" runat="server" Enabled="false"></asp:TextBox>
                </TD>
                  <TD>
                    <asp:TextBox ID="txtPrecio" runat="server" Enabled="false"></asp:TextBox>
                </TD>
            </table>

            <br />
            TOTAL FACTURA:
            <asp:TextBox ID="txtTotal" runat="server" Enabled="false"></asp:TextBox>

            

        </div>
    </form>
</body>
</html>
