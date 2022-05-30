<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioCliente.aspx.cs" Inherits="ProyectoNegocio.FormularioCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            height: 32px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="DNI CLIENTE"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDniCliente" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="NOMBRE DEL CLIENTE"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNombreCliente" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="DIRECCION DEL CLIENTE"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDirCliente" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="TELEFONO DEL CLIENTE"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTelCliente" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblResultado" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Button CssClass="btn btn-outline-primary"  ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style3">
                        <asp:Button CssClass="btn btn-outline-primary"  ID="btnconsultar" runat="server" OnClick="btnconsultar_Click" Text="Consultar" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button CssClass =" btn btn-outline-danger" ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button CssClass="btn btn-outline-primary" ID="btnModificar" runat="server" Text="Modificar" Width="145px" OnClick="btnModificar_Click" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
