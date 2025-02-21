using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prj37600_prova
{
    public partial class novoItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GerenciarPrato gPrato = new GerenciarPrato();
                List<Prato2> lista = new List<Prato2>();
                lista = gPrato.ListarPrato();
                foreach (Prato2 prato in lista)
                {
                    string texto = $@"{prato.Proteina.Nome}-{prato.Detalhe}-{prato.Acompanhamento.Nome}-{prato.Salada.Nome}";
                    ddlPrato.Items.Add(new ListItem(texto, prato.Codigo.ToString()));
                }
            }
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            string dataSelecionada = dateInput.Value;
            Cardapio cardapio = new Cardapio();
           
            bool Valido = cardapio.NovoItem(DateTime.Parse(dataSelecionada),int.Parse(ddlPrato.SelectedValue));
            if (Valido)
            {
                litTextTost.Text = "Item Adicionado";
            }
            else
            {
                litTextTost.Text = "Item Existente";
            }
            litScriptTost.Text = $@"<script type=""text/javascript"">
                                        (function () {{
                                            var toastContainer = document.getElementById(""toastContainer"");

			                                toastContainer.style.display = ""block"";

                                            setTimeout(function () {{
                                                toastContainer.style.animation = ""sair 0.5s ease-in-out"";

                
                                                setTimeout(function () {{
                                                    toastContainer.style.display = ""none"";
                                                }}, 450); 
                                            }}, 3000);

                                        }})();

                                    </script>";
        }
    }
}