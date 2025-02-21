using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

    public class GerenciarCardapio
    {
        public List<Cardapio> Listar()
        {
          List<Cardapio> list = new List<Cardapio>();
             string comando = $@"select pr.cd_prato , p.cd_proteina ,p.nm_proteina , s.nm_salada , s.cd_salada , a.nm_acompanhamento , a.cd_acompanhamento , pr.nm_detalhe , c.dt_cardapio from prato pr 
                                right join proteina p on(pr.cd_proteina = p.cd_proteina)
                                right join salada s on(s.cd_salada = pr.cd_salada)
                                right join acompanhamento a on(a.cd_acompanhamento = pr.cd_acompanhamento)
								right join cardapio c on(pr.cd_prato = c.cd_prato)
                                order by c.dt_cardapio desc";
            Banco bd = new Banco();
            MySqlDataReader dados = bd.Consultar(comando);

        while (dados.Read())
        {
            Cardapio cardapio = new Cardapio();
            Prato2 prato = new Prato2();
            prato.Codigo = dados.GetInt32(0);
            Proteina prot = new Proteina();
            prot.Codigo = dados.GetInt32(1);
            prot.Nome = dados.GetString(2);
            prato.Proteina = prot;

            Salada sala = new Salada();
            sala.Codigo = dados.GetInt32(4);
            sala.Nome = dados.GetString(3);
            prato.Salada = sala;

            Acompanhamento acom = new Acompanhamento();
            acom.Codigo = dados.GetInt32(6);
            acom.Nome = dados.GetString(5);
            prato.Acompanhamento = acom;

            prato.Detalhe = dados.GetString(7);
            cardapio.Prato = prato;
            cardapio.Data = dados.GetDateTime(8);
            list.Add(cardapio);
        }
        bd.Desconectar();
        if (dados != null)
            if (!dados.IsClosed)
                dados.Close();
        return list;
    }
    }
