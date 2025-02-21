<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="novoItem.aspx.cs" Inherits="prj37600_prova.novoItem" %>

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
					<li><a href="novoPrato.aspx">Novo Prato</a></li>
					<li class="ativo"><a href="novoItem.aspx">Novo Item Cardápio</a></li>
				</ul>
			</nav>

			<section>
				<h1>Novo Item Cardápio</h1>
				<section class="areaCardapio">

					<p>
						<label for="data-cardapio">Data:</label>
						 <input type="date" id="dateInput" runat="server"/>
						
						
					</p>

					<p>
						<label for="prato">Prato:</label>
						<asp:DropDownList ID="ddlPrato" runat="server"></asp:DropDownList>
					</p>

					<p class="centro">
						<asp:Button ID="BtnSalvar" runat="server" Text="Salvar" OnClick="BtnSalvar_Click"/>
					</p>

					
				</section>
			</section>
		</main>
	</div>
		<div id="toastContainer">
			 <div class="tost"><asp:Literal ID="litTextTost" runat="server"></asp:Literal></div>
		</div>
	<script type="text/javascript">
        var data = document.getElementById('dateInput');
        var hoje = new Date().toISOString().split('T')[0];
        data.value = hoje;
    </script>
		<asp:Literal ID="litScriptTost" runat="server"></asp:Literal>
    </form>
</body>
</html>
