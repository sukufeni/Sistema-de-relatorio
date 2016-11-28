using System;
using System.Data.SqlClient;


namespace SistemaRelatorioNansen
{
    class ClasseNovaTR : ModeloTR
    {
        public ClasseNovaTR(string tr, string nomeEmpresa, string observacao, string grupo)
        {
            this.txtTr = tr;
            this.dataGravacao = DateTime.Now.ToShortDateString();
            this.nomeEmpresa = nomeEmpresa.Replace("False", "-");
            this.observacao = observacao;
            this.grupo = grupo;
        }
        public bool cadastraTR()
        {
            return ResultadoBancoString(Comandos.insertTR(txtTr, descricaoDespesa, dataGravacao, nomeEmpresa, observacao,grupo));
        }
    }
}
