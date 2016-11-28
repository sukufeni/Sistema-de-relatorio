using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaRelatorioNansen
{
    public partial class FormDetalheTR : Form
    {        
        public FormDetalheTR(string tr)
        {
            InitializeComponent();
            txtTR.Text = tr;
            carregaDataGrid();
            ClasseNovaTR.buscaCliente(txtTR.Text);
            btnSalvar.Enabled = false;
        }
        public FormDetalheTR()
        {
            InitializeComponent();
            btnAlterarItem.Enabled = false;
            btnExcluirItem.Enabled = false;
            btnGrupo.Enabled = false;
            btnIncluirItem.Enabled = false;
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaPrincipal m = new TelaPrincipal();
            m.Close();
            m.Refresh();
            m.Focus();
        }
        private void FormDetalheTR_Load(object sender, EventArgs e)
        {
            carregaCb();
            preenchetxtData();
        }

        private void carregaCb()
        {
            carregaCbDescricao();
            carregaCbGrupo();
        }

        private void preenchetxtData()
        {
            this.txtDataTR.Text = System.DateTime.Now.Date.Day.ToString()+"/"+System.DateTime.Now.Date.Month.ToString()+"/"+ System.DateTime.Now.Date.Year.ToString();
        }
        private void txtTR_TextChanged(object sender, EventArgs e)
        {
            txtNomeEmpresa.Text = ClasseNovaTR.buscaCliente(txtTR.Text);
        }
        private void carregaCbDescricao()
        {
            try
            {
                Banco.conexaoRelatorio.Close();
                Banco.conexaoRelatorio.Open();
                SqlCommand comando = new SqlCommand(Comandos.selectDescricaoDespesa(), Banco.conexaoRelatorio);
                SqlDataReader reader;
                reader = comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                cbDescricaoDespesas.ValueMember = "descricao";
                cbDescricaoDespesas.DisplayMember = "descricao";
                cbDescricaoDespesas.DataSource = dt;
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                Banco.conexaoRelatorio.Close();
            }
        }
        private void carregaCbGrupo()
        {
            try
            {
                Banco.conexaoRelatorio.Close();
                Banco.conexaoRelatorio.Open();
                SqlCommand comando = new SqlCommand(Comandos.selectGrupoDespesa(), Banco.conexaoRelatorio);
                SqlDataReader reader;
                reader = comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                cbGrupo.ValueMember = "grupo";
                cbGrupo.DisplayMember = "grupo";
                cbGrupo.DataSource = dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                Banco.conexaoRelatorio.Close();
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtTR.Text !=""||txtTR != null)
            {
               ClasseNovaTR manipulaTR = new ClasseNovaTR(txtTR.Text, txtNomeEmpresa.Text, txtObs.Text,cbGrupo.SelectedValue.ToString());
                if (manipulaTR.cadastraTR()) MessageBox.Show("TR cadastrada!");
                else MessageBox.Show("erro ao cadastrar a tr!");
            }
            else
            {
                throw new Exception("preencha o campo de TR e o valor da Descrição!");
            }
        }
        private void btnIncluirItem_Click(object sender, EventArgs e)
        {
            if (verificaCampos())
            {
                AlterarTR alterar = criaAlterarItem();
                if (alterar.incluiItem()) MessageBox.Show("item incluido!");
                else MessageBox.Show("erro ao incluir item!");
            }
            else throw new Exception("preencha o campo de TR e o valor da Descrição!");
            carregaDataGrid();
        }
        private void btnGrupo_Click(object sender, EventArgs e)
        {
            if (cbGrupo.DropDownStyle == ComboBoxStyle.DropDownList) cbGrupo.DropDownStyle = ComboBoxStyle.DropDown;
            else
            {
                if (Banco.ResultadoBancoString(Comandos.insertGrupoDespesa(cbGrupo.Text.ToString())))
                {
                    carregaCbGrupo();
                    cbGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                else MessageBox.Show("erro ao inserir grupo!");
            }
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
           if (AlterarTR.excluiItem(txtTR.Text.ToString(),dtGridDespesas.Rows[dtGridDespesas.CurrentCell.RowIndex].Cells[dtGridDespesas.CurrentCell.ColumnIndex].Value.ToString()))
            {
                MessageBox.Show("item excluido!");
                carregaDataGrid();
            }
           else MessageBox.Show("erro ao incluir item!");
        }
        private bool verificaCampos()
        {
            if (txtTR.Text != "" || mskTxtValorDesp.Text != "") return true;
            return false;
        }
        private AlterarTR criaAlterarItem()
        {
            return new AlterarTR(txtTR.Text, cbDescricaoDespesas.SelectedValue.ToString(), double.Parse(mskTxtValorDesp.Text), txtNomeEmpresa.Text, txtObs.Text, cbGrupo.SelectedValue.ToString());
        }
        private void carregaDataGrid()
        {
            GetData(Comandos.carregaDtGridDespesa(txtTR.Text));
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
                dtGridDespesas.ReadOnly = false;
                dtGridDespesas.DataSource = ds.Tables[0];
            }
            catch (SqlException e)
            {
                MessageBox.Show(" erro ao trazer dados!", e.ToString());
            }
            finally
            {
                Banco.conexaoRelatorio.Close();
            }
        }




    }
}
