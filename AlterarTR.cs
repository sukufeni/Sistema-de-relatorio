using System;
using System.Data.SqlClient;

namespace SistemaRelatorioNansen
{
    class AlterarTR : ModeloTR
    {
        private int codDespesa;
        private int codGrupo;

        public AlterarTR(string tr, string descricaoDespesa, double valorDespesa, string nomeEmpresa, string observacao, string grupo)
        {
            this.txtTr = tr;
            this.descricaoDespesa = descricaoDespesa;
            this.dataGravacao = DateTime.Now.ToShortDateString();
            this.nomeEmpresa = nomeEmpresa.Replace("False", "-");
            this.observacao = observacao;
            this.valorDespesa = valorDespesa;
            this.grupo = grupo;
            selectCodDespesa();
            selectCodGrupo();
        }

        private void selectCodDespesa()
        {
            try
            {
                Banco.conexaoRelatorio.Close();
                SqlCommand comando = new SqlCommand(Comandos.selectCodDespesa(descricaoDespesa), Banco.conexaoRelatorio);
                Banco.conexaoRelatorio.Open();
                this.codDespesa = int.Parse(comando.ExecuteScalar().ToString());
            }
            catch (SqlException erro)
            {
                throw new Exception("erro ao encontrar codigo de TR", erro);
            }
            finally
            {
                Banco.conexaoRelatorio.Close();
            }
        }
        private void selectCodGrupo()
        {
            try
            {
                Banco.conexaoRelatorio.Close();
                SqlCommand comando = new SqlCommand(Comandos.selectCodigoGrupo(grupo), Banco.conexaoRelatorio);
                Banco.conexaoRelatorio.Open();
                this.codGrupo = int.Parse(comando.ExecuteScalar().ToString());
            }
            catch (SqlException erro)
            {
                throw new Exception("erro ao encontrar codigo de TR", erro);
            }
            finally
            {
                Banco.conexaoRelatorio.Close();
            }
        }
        public bool incluiItem()
        {
            return ResultadoBancoString(Comandos.insereItem(this.txtTr, this.codDespesa, this.valorDespesa, this.codGrupo));
        }
        public static bool excluiItem(string tr,string despesa)
        {
            return ResultadoBancoString(Comandos.excluiItem(tr,despesa));
        }
    }
}
