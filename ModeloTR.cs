using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRelatorioNansen
{
    abstract class ModeloTR : Banco
    {
        protected string txtTr;
        protected string descricaoDespesa;
        protected double valorDespesa;
        protected string dataGravacao;
        protected string nomeEmpresa;
        protected string observacao;
        protected string grupo;

        protected static bool buscaTR(string tr)
        {
            try
            {
                if (Banco.ResultadoBancoString(Comandos.selectTR(tr)))
                {
                    return true;
                }
                return false;

            }
            catch (NullReferenceException e)
            {
                throw new Exception("erro de TR", e);
            }
        }
        public static string buscaCliente(string tr)
        {
            if (!buscaTR(tr))
            {
                return false.ToString();
            }
            else
            {
                try
                {
                    Banco.conexaoRelatorio.Open();
                    SqlCommand comando = new SqlCommand(Comandos.selectCliente(tr), Banco.conexaoRelatorio);
                    SqlDataReader reader;
                    using (reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetString(reader.GetOrdinal("DadosAWB"));
                        }
                        return false.ToString();
                    }
                }
                catch (SqlException e)
                {
                    return false.ToString();
                    throw new Exception("erro de cliente", e);
                }
            }
        }

    }
}
