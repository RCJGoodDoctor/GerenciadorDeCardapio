using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;


    public class Cardapio
    {
    public DateTime Data { get; set; }

    public Prato2 Prato { get; set; }

    public bool NovoItem(DateTime data ,int codigoPrato)
    {
       
        string comando = $@"insert into cardapio values('{data.Year}-{data.Month}-{data.Day}',{codigoPrato} )";
        string comandoVerifica = $@"select * from cardapio where dt_cardapio = '{data.Year}-{data.Month}-{data.Day}' and cd_prato = {codigoPrato} ";
        Banco bd = new Banco();
        MySqlDataReader dados = bd.Consultar(comandoVerifica);
        if (dados.Read())
            return false;
        
        bd.Desconectar();
        if(dados != null)
            if(!dados.IsClosed)
                dados.Close();
        bd.Executar(comando);
        return true;
    }
}
