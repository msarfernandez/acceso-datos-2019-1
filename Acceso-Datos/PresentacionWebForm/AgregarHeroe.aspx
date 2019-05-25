<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarHeroe.aspx.cs" Inherits="PresentacionWebForm.AgregarHeroe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Agregar Heroe</title>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>

</head>
<body>
    <form id="form1" runat="server">

        <div style="width: 50%;">
            <div class="form-group">
                <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox CssClass="form-control" placeholder="Nombre del Heroe" ID="txtNombre" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblDebilidad" runat="server" Text="Debilidad"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtDebilidad" runat="server"></asp:TextBox>
            </div>

            <asp:Button CssClass="btn btn-primary" ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
        </div>

    </form>
</body>
</html>
