<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PresentacionWebForm.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Heroes</title>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>

    <script src="Scripts/miLibreriaJS.js"></script>

    <link href="https://fonts.googleapis.com/css?family=Mandali&display=swap" rel="stylesheet">
</head>
<body>
    <style>
        .body-content {
            padding-left: 15px;
            padding-right: 15px;
        }
    </style>
    <h1 style="font-family: 'Mandali', sans-serif;">Heroes</h1>


    <form id="form1" runat="server">
        <div>
            <h3>Listado de heroes</h3>
        </div>
        <%--        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <asp:Button ID="btnPresioname" runat="server" Text="Presioname" OnClick="btnPresioname_Click" />
        <asp:Label ID="lblSaludo" runat="server" Text="Label"></asp:Label>--%>

        <asp:GridView ID="dgvHeroes" runat="server" CssClass="table">
            <%--            <Columns>
                <asp:BoundField AccessibleHeaderText="Nombre" DataField="Nombre" />
            </Columns>--%>
        </asp:GridView>

        <div class="form-group">
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-primary btn-lg" OnClick="btnAgregar_Click" />
        </div>



    </form>




    <%--    <button id="btnSaludar" onclick="saludar()">hola</button>
    <input type="text" name="name" value="" />
    <label>label html</label>--%>
</body>
</html>
