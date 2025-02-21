using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
 public class GerenciarPrato
 {
    public List<Prato2> ListarPrato()
    {
        Banco bd = new Banco();
        List<Prato2> lista = new List<Prato2>();

        string comando = $@"select pr.cd_prato , p.cd_proteina ,p.nm_proteina , s.nm_salada , s.cd_salada , a.nm_acompanhamento , a.cd_acompanhamento , pr.nm_detalhe from prato pr 
                                left join proteina p on(pr.cd_proteina = p.cd_proteina)
                                left join salada s on(s.cd_salada = pr.cd_salada)
                                left join acompanhamento a on(a.cd_acompanhamento = pr.cd_acompanhamento)
                                order by pr.cd_prato";
        MySqlDataReader dados = bd.Consultar(comando);

        while (dados.Read())
        {
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
            lista.Add(prato);
        }
        bd.Desconectar();
        if (dados != null)
            if (!dados.IsClosed)
                dados.Close();
        return lista;
    }

    

 }
