using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRelatorioNansen
{
    class Comandos : Banco
    {
       public static string selectTRTelaPrincipal()
        {
            return "select * from DB_SisRelatorio.dbo.TB_PROCESSO";
        }
        public static string selectCodDespesa(string descricao)
        {
            return "select cod_desc from DB_SisRelatorio.dbo.TB_desc_desp where descricao = '" + descricao + "'";
        }
        public static string selectDescricaoDespesa()
        {
            return "select descricao from DB_SisRelatorio.dbo.TB_DESC_DESP";
        }
        public static string selectCodigoGrupo(string grupo)
        {
            return "select cod from DB_SisRelatorio.dbo.TB_grupo where grupo = '"+grupo+"'";
        }
        public static string selectGrupoDespesa()
        {
            return "select grupo from DB_SisRelatorio.dbo.TB_grupo";
        }
        
        public static string selectTR(string tr)
        {
            return "select count(tr.NF1_PROC) from DbComex.dbo.nf1 tr inner join DB_SisRelatorio.dbo.TB_PROCESSO processo on processo.TR = tr.NF1_PROC where processo.TR = '"+tr+"'";
        }
        public static string selectCliente(string tr)
        {
            return "select distinct(cli.DadosAWB) from DbComex.dbo.nf1 tr inner join DbComex.dbo.Cliente cli on cli.IdCliente = tr.cliente inner join DB_SisRelatorio.dbo.TB_PROCESSO processo on processo.TR = tr.NF1_PROC where DadosAWB is not null and DadosAWB != '' and processo.TR = '" + tr + "'";
        }
        public static string insertTR(string tr,string descricaoDespesa,string dataGravacao,string nomeEmpresa,string observacao,string grupo)
        {
            return "USE[DB_SisRelatorio] INSERT INTO[dbo].[TB_PROCESSO] ([TR],[descricao_despesa],[data_geracao],[nome_empresa],[observacao],[grupo]) VALUES('"+tr+"','"+descricaoDespesa+ "','"+dataGravacao+ "','"+nomeEmpresa+ "','"+observacao+ "','" + grupo + "')";
        }
        public static string insereItem(string tr,int codDesp,double valorDesp,int cod_grupo)
        {
            return "USE [DB_SisRelatorio] INSERT INTO[dbo].[TB_DESPESAS]([tr],[cod_desp],[valor_desp],[cod_grupo]) VALUES('" + tr + "',"+codDesp+","+valorDesp+",'"+cod_grupo+"')";
        }
        public static string insertGrupoDespesa(string grupo)
        {
            return "insert into DB_SisRelatorio.dbo.TB_GRUPO (grupo)VALUES('"+grupo+"')";
        }
        public static string deletaTR(string tr)
        {
            return "delete from DB_SisRelatorio.dbo.TB_PROCESSO where TB_PROCESSO.tr = '"+tr+ "'; delete from DB_SisRelatorio.dbo.TB_DESPESAS where TB_DESPESAS.tr = '" + tr + "'";
        }
        public static string excluiItem(string tr, string descricao)
        {
            return "use DB_SisRelatorio delete from DB_SisRelatorio.dbo.TB_DESPESAS from DB_SisRelatorio.dbo.tb_despesas as despesas inner join dbo.TB_PROCESSO on TB_PROCESSO.TR = despesas.tr inner join dbo.TB_DESC_DESP on TB_DESC_DESP.cod_desc = despesas.cod_desp where despesas.tr = '"+tr+"' and TB_DESC_DESP.descricao = '"+descricao+"'";
        }
        public static string carregaDtGridDespesa(string TR)
        {
            return "select despesas.valor_desp,descricao.descricao from DB_SisRelatorio.dbo.TB_DESPESAS despesas inner join TB_PROCESSO processo on processo.TR = despesas.tr inner join DB_SisRelatorio.dbo.TB_DESC_DESP descricao on descricao.cod_desc = despesas.cod_desp where processo.TR = '"+TR+"'";
        }

    }
}
