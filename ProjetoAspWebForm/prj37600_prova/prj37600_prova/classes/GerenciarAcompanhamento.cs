using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


public class GerenciarAcompanhamento
{
    public List<Acompanhamento> ListarAcompanhamento()
    {
        Banco bd = new Banco();
        List<Acompanhamento> lista = new List<Acompanhamento>();
        string comando = $"select * from acompanhamento order by nm_acompanhamento";
        MySqlDataReader dados = bd.Consultar(comando);

        while (dados.Read())
        {
            Acompanhamento acompanhamento = new Acompanhamento();
            acompanhamento.Nome = dados.GetString("nm_acompanhamento");
            acompanhamento.Codigo = dados.GetInt32("cd_acompanhamento");
            lista.Add(acompanhamento);
        }
        bd.Desconectar();
        if (dados != null)
            if (!dados.IsClosed)
                dados.Close();
        return lista;
    }
}