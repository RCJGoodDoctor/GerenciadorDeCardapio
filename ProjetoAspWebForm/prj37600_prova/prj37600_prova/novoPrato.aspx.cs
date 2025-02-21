using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prj37600_prova
{
    public partial class novoPrato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GerenciarProteina gProteina = new GerenciarProteina();
                List<Proteina> proteinaList = gProteina.ListarProteina();
                foreach (Proteina proteina in proteinaList)
                {
                    ddlProteina.Items.Add(new ListItem(proteina.Nome, proteina.Codigo.ToString()));
                }

                GerenciarSalada gSalada = new GerenciarSalada();
                List<Salada> SaladaList = gSalada.ListarSalada();
                foreach (Salada Salada in SaladaList)
                {
                    ddlSalada.Items.Add(new ListItem(Salada.Nome, Salada.Codigo.ToString()));
                }

                GerenciarAcompanhamento gAcompanhamento = new GerenciarAcompanhamento();
                List<Acompanhamento> acompanhamentoList = gAcompanhamento.ListarAcompanhamento();
                foreach (Acompanhamento acompanhamento in acompanhamentoList)
                {
                    ddlAcompanhamento.Items.Add(new ListItem(acompanhamento.Nome, acompanhamento.Codigo.ToString()));
                }
            }
           
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            Prato2 prato = new Prato2();
            int codigo = prato.BuscarProximoCodigo();
            prato.NovoPrato(codigo, txtDetalhe.Text,int.Parse(ddlProteina.SelectedValue),int.Parse( ddlAcompanhamento.SelectedValue), int.Parse(ddlSalada.SelectedValue));
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