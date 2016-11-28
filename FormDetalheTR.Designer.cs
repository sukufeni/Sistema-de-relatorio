namespace SistemaRelatorioNansen
{
    partial class FormDetalheTR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbDescricaoDespesas = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.mskTxtValorDesp = new System.Windows.Forms.MaskedTextBox();
            this.txtTR = new System.Windows.Forms.TextBox();
            this.btnAlterarItem = new System.Windows.Forms.Button();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnIncluirItem = new System.Windows.Forms.Button();
            this.txtDataTR = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.btnGrupo = new System.Windows.Forms.Button();
            this.dtGridDespesas = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDespesas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDescricaoDespesas
            // 
            this.cbDescricaoDespesas.DisplayMember = "descricao";
            this.cbDescricaoDespesas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDescricaoDespesas.FormattingEnabled = true;
            this.cbDescricaoDespesas.Location = new System.Drawing.Point(270, 283);
            this.cbDescricaoDespesas.Name = "cbDescricaoDespesas";
            this.cbDescricaoDespesas.Size = new System.Drawing.Size(198, 21);
            this.cbDescricaoDespesas.TabIndex = 0;
            this.cbDescricaoDespesas.ValueMember = "descricao";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 296);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(761, 309);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // mskTxtValorDesp
            // 
            this.mskTxtValorDesp.Location = new System.Drawing.Point(474, 283);
            this.mskTxtValorDesp.Name = "mskTxtValorDesp";
            this.mskTxtValorDesp.Size = new System.Drawing.Size(100, 20);
            this.mskTxtValorDesp.TabIndex = 3;
            // 
            // txtTR
            // 
            this.txtTR.Location = new System.Drawing.Point(12, 68);
            this.txtTR.Name = "txtTR";
            this.txtTR.Size = new System.Drawing.Size(100, 20);
            this.txtTR.TabIndex = 4;
            this.txtTR.TextChanged += new System.EventHandler(this.txtTR_TextChanged);
            // 
            // btnAlterarItem
            // 
            this.btnAlterarItem.Location = new System.Drawing.Point(12, 267);
            this.btnAlterarItem.Name = "btnAlterarItem";
            this.btnAlterarItem.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarItem.TabIndex = 5;
            this.btnAlterarItem.Text = "Alterar item";
            this.btnAlterarItem.UseVisualStyleBackColor = true;
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Location = new System.Drawing.Point(177, 267);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirItem.TabIndex = 6;
            this.btnExcluirItem.Text = "Excluir Item";
            this.btnExcluirItem.UseVisualStyleBackColor = true;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // btnIncluirItem
            // 
            this.btnIncluirItem.Location = new System.Drawing.Point(93, 267);
            this.btnIncluirItem.Name = "btnIncluirItem";
            this.btnIncluirItem.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirItem.TabIndex = 7;
            this.btnIncluirItem.Text = "Incluir Item";
            this.btnIncluirItem.UseVisualStyleBackColor = true;
            this.btnIncluirItem.Click += new System.EventHandler(this.btnIncluirItem_Click);
            // 
            // txtDataTR
            // 
            this.txtDataTR.Location = new System.Drawing.Point(118, 68);
            this.txtDataTR.Name = "txtDataTR";
            this.txtDataTR.Size = new System.Drawing.Size(121, 20);
            this.txtDataTR.TabIndex = 8;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(15, 94);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(224, 167);
            this.txtObs.TabIndex = 9;
            this.txtObs.Text = "Observações";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código TR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data gravação TR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "valor despesa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Descrição despesa";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Location = new System.Drawing.Point(15, 29);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(537, 20);
            this.txtNomeEmpresa.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nome empresa";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Grupo";
            // 
            // cbGrupo
            // 
            this.cbGrupo.DisplayMember = "descricao";
            this.cbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(580, 282);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(227, 21);
            this.cbGrupo.TabIndex = 16;
            this.cbGrupo.ValueMember = "descricao";
            // 
            // btnGrupo
            // 
            this.btnGrupo.Location = new System.Drawing.Point(93, 296);
            this.btnGrupo.Name = "btnGrupo";
            this.btnGrupo.Size = new System.Drawing.Size(75, 23);
            this.btnGrupo.TabIndex = 20;
            this.btnGrupo.Text = "Incluir Grupo";
            this.btnGrupo.UseVisualStyleBackColor = true;
            this.btnGrupo.Click += new System.EventHandler(this.btnGrupo_Click);
            // 
            // dtGridDespesas
            // 
            this.dtGridDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDespesas.Location = new System.Drawing.Point(245, 68);
            this.dtGridDespesas.Name = "dtGridDespesas";
            this.dtGridDespesas.Size = new System.Drawing.Size(601, 193);
            this.dtGridDespesas.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Detalhe Despesas";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormDetalheTR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 344);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtGridDespesas);
            this.Controls.Add(this.btnGrupo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbGrupo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtDataTR);
            this.Controls.Add(this.btnIncluirItem);
            this.Controls.Add(this.btnExcluirItem);
            this.Controls.Add(this.btnAlterarItem);
            this.Controls.Add(this.txtTR);
            this.Controls.Add(this.mskTxtValorDesp);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbDescricaoDespesas);
            this.Name = "FormDetalheTR";
            this.Text = "FormDetalheTR";
            this.Load += new System.EventHandler(this.FormDetalheTR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDespesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDescricaoDespesas;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.MaskedTextBox mskTxtValorDesp;
        private System.Windows.Forms.TextBox txtTR;
        private System.Windows.Forms.Button btnAlterarItem;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnIncluirItem;
        private System.Windows.Forms.TextBox txtDataTR;
        private System.Windows.Forms.RichTextBox txtObs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.Button btnGrupo;
        private System.Windows.Forms.DataGridView dtGridDespesas;
        private System.Windows.Forms.Label label7;
    }
}