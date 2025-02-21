<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="prj37600_prova.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Reserva de Almoço</title>
	<link rel="stylesheet" type="text/css" href="css/estilo.css">
</head>
<body>
    <form id="form1" runat="server">
       <div class="principal">
		<main>
			<nav>
				<ul>
					<li class="ativo"><a href="index.aspx">Cardápio</a></li>
					<li><a href="pratos.aspx">Pratos</a></li>
					<li><a href="novoPrato.aspx">Novo Prato</a></li>
					<li><a href="novoItem.aspx">Novo Item Cardápio</a></li>
				</ul>
			</nav>

			<section>
				
				<h1>Cardápio</h1>
				<section class="areaCardapio">
					<asp:Literal ID="litCardapio" runat="server"></asp:Literal>
				
				</section>
			</section>
		</main>
	</div>
    </form>
</body>
</html>
