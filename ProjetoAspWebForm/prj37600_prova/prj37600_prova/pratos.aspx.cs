using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prj37600_prova
{
    public partial class Prato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GerenciarPrato gPrato = new GerenciarPrato();
            List<Prato2> lista = new List<Prato2>();
            lista = gPrato.ListarPrato();
            foreach (Prato2 prato2 in lista)
            {
                litCardapio.Text += $@"<div class=""itemCardapio"">
                        {prato2.Codigo} - {prato2.Proteina.Nome} - {prato2.Detalhe} - {prato2.Acompanhamento.Nome} - {prato2.Salada.Nome}
                        </div>";
            }
        }
    }
}