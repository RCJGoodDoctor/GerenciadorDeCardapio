using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Prato2
{
    public int Codigo { get; set; }
    public string Detalhe { get; set; }
    public Proteina Proteina { get; set; }
    public Acompanhamento Acompanhamento { get; set; }
    public Salada Salada { get; set; }

    public void NovoPrato(int codigoPrato, string detalhe, int codigoProteina, int codigoAcompanhamento, int codigoSalada)
    {
        Banco bd = new Banco();
        string comando = $"insert into prato values({codigoPrato},{codigoProteina},'{detalhe}',{codigoAcompanhamento},{codigoSalada})";
        bd.Executar(comando);
    }

    public int BuscarProximoCodigo()
    {
        Banco bd = new Banco();
        string comando = "select coalesce(max(cd_prato + 1),1) from prato;";
        MySqlDataReader dados = bd.Consultar(comando);
        dados.Read();
        int codigo = dados.GetInt32(0);
        bd.Desconectar();
        if (dados != null)
            if (!dados.IsClosed)
                dados.Close();
        return codigo;
    }       

}
