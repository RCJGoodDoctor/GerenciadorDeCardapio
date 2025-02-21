using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


public class GerenciarProteina
{
   public List<Proteina> ListarProteina()
   {
      Banco bd = new Banco();
        List<Proteina> lista = new List<Proteina>();    
      string comando = $"select * from proteina order by nm_proteina;";
      MySqlDataReader dados = bd.Consultar(comando);

        while (dados.Read())
        {
            Proteina proteina = new Proteina();
            proteina.Nome = dados.GetString("nm_proteina");
            proteina.Codigo = dados.GetInt32("cd_proteina");
            lista.Add(proteina);
        }
        bd.Desconectar();
        if (dados != null)
            if (!dados.IsClosed)
                dados.Close();
        return lista;
   }
}
