using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prj37600_prova
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Cardapio> list = new List<Cardapio>();
            GerenciarCardapio gCarda = new GerenciarCardapio();
            list = gCarda.Listar();
            foreach (Cardapio cardapio in list)
            {
                litCardapio.Text += $@"<div class=""itemCardapio"">

                        {cardapio.Data.ToShortDateString()} - {cardapio.Prato.Proteina.Nome} - {cardapio.Prato.Detalhe} - {cardapio.Prato.Acompanhamento.Nome} - {cardapio.Prato.Salada.Nome}
                       </div> ";
            }

        }
    }
}