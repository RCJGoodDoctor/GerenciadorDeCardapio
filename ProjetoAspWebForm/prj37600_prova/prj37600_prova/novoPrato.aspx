<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="novoPrato.aspx.cs" Inherits="prj37600_prova.novoPrato" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <meta charset="utf-8"/>
	<meta name="viewport" content="width=device-width, initial-scale=1"/>
	<title>Reserva de Almoço</title>
	<link rel="stylesheet" type="text/css" href="css/estilo.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="principal">
		<main>
			<nav>
				<ul>
					<li><a href="index.aspx">Cardápio</a></li>
					<li><a href="pratos.aspx">Pratos</a></li>
					<li class="ativo"><a href="novoPrato.html">Novo Prato</a></li>
					<li><a href="novoItem.aspx">Novo Item Cardápio</a></li>
				</ul>
			</nav>

			<section>
				<h1>Novo Prato</h1>
				<section class="areaCardapio">

					<p>
						<label for="proteina">Proteína:</label>
						<asp:DropDownList ID="ddlProteina" runat="server"></asp:DropDownList>
					</p>

					<p>
						<label for="detalhe">Detalhe:</label>
						<asp:TextBox ID="txtDetalhe" runat="server" ></asp:TextBox>
					</p>

					<p>
						<label for="proteina">Acompanhamento:</label>
						<asp:DropDownList ID="ddlAcompanhamento" runat="server"></asp:DropDownList>
					</p>

					<p>
						<label for="proteina">Salada:</label>
						<asp:DropDownList ID="ddlSalada" runat="server"></asp:DropDownList>
						
					</p>


					<p class="centro">
						><asp:Button ID="BtnSalvar" runat="server" Text="Salvar" OnClick="BtnSalvar_Click"/>
					</p>
					<asp:Literal ID="litMsg" runat="server"></asp:Literal>
					
					
				</section>
			</section>
		</main>
	</div>
		<div id="toastContainer">
			 <div class="tost">Produto Adicionado</div>
		</div>
	<script type="text/javascript">
        var data = document.getElementById('data-cardapio');
        var hoje = new Date().toISOString().split('T')[0];
        data.value = hoje;
    </script>

		<asp:Literal ID="litScriptTost" runat="server"></asp:Literal>
    </form>
</body>
</html>
