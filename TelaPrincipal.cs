using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRelatorioNansen
{
    public partial class TelaPrincipal : Form
    {
        private string tr;
        public TelaPrincipal()
        {
            InitializeComponent();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregaDataGrid();
        }

        private void carregaDataGrid()
        {
            GetData(Comandos.selectTRTelaPrincipal());
        }

        private void GetData(string comando)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(comando, Banco.conexaoRelatorio);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(ds);
                dtGridTr.ReadOnly = false;
                dtGridTr.DataSource = ds.Tables[0];
            }
            catch (SqlException e)
            {
                MessageBox.Show(" erro ao conectar ao banco!",e.ToString());
            }
            finally
            {
                Banco.conexaoRelatorio.Close();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
           FormDetalheTR n = new FormDetalheTR();
           n.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carregaDataGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tr == ""||tr==null) MessageBox.Show("escolha uma TR!");
            else
            {
                FormDetalheTR n = new FormDetalheTR(tr);
                n.Show();
            }
        }

        private void dtGridTr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tr = dtGridTr.Rows[dtGridTr.CurrentCell.RowIndex].Cells[dtGridTr.CurrentCell.ColumnIndex].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Banco.ResultadoBancoString(Comandos.deletaTR(tr))) MessageBox.Show("TR excluida com sucesso!");
            else MessageBox.Show("erro ao excluir a TR");
        }
    }
}
