using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

 public class GerenciarSalada
 {
    public List<Salada> ListarSalada()
    {
        Banco bd = new Banco();
        List<Salada> lista = new List<Salada>();
        string comando = $"select * from Salada order by nm_Salada";
        MySqlDataReader dados = bd.Consultar(comando);

        while (dados.Read())
        {
            Salada Salada = new Salada();
            Salada.Nome = dados.GetString("nm_Salada");
            Salada.Codigo = dados.GetInt32("cd_Salada");
            lista.Add(Salada);
        }
        bd.Desconectar();
        if(dados != null)
            if(!dados.IsClosed)
                dados.Close();
        return lista;
    }
}
