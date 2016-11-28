using System;
using System.Data.SqlClient;

namespace SistemaRelatorioNansen
{
    abstract class Banco
    {
        internal static SqlConnection conexaoRelatorio = new SqlConnection("Data Source=SRVTSI06\\MSSQLSRV2008ENT,1436;Initial Catalog=DB_SisRelatorio;Persist Security Info=True;User ID=dba-wke;Password=Wke2009");
        internal static SqlConnection conexaoexaodbComex = new SqlConnection("Data Source=SRVTSI06\\MSSQLSRV2008ENT,1436;Initial Catalog=DbComex;Persist Security Info=True;User ID=dba-wke;Password=Wke2009");
        protected static string salvo = "";
        protected static string ResultadoBancoSql(SqlCommand sql)
        {
            try
            {
                conexaoRelatorio.Open();
                sql.ExecuteNonQuery();
                salvo = "Sucesso!";
            }
            catch (SqlException e)
            {
                salvo = e.ToString() + " (Banco.cs)";
            }
            finally
            {
                conexaoRelatorio.Close();

            }
            return salvo;
        }

        public static void truncateDadosBanco()
        {
            try
            {
                SqlCommand sql = new SqlCommand("use ControleRamal truncate table tb_pabx", conexaoRelatorio);
                conexaoRelatorio.Open();
                sql.ExecuteNonQuery();
            }

            catch (SqlException ) 
            {
                conexaoRelatorio.Close();
            }
            
        }
        internal static bool ResultadoBancoString(string comando)
        {
            try
            {
                conexaoRelatorio.Close();
                SqlCommand sql = new SqlCommand(comando, conexaoRelatorio);
                conexaoRelatorio.Open();
                sql.ExecuteNonQuery();
                return true;
            }
            catch (SqlException e)
            {
                return false;
                throw new Exception("erro ao executar comando!", e);
            }
            finally
            {
                conexaoRelatorio.Close();
            }
        }
 
    }
}

