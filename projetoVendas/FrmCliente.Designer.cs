namespace projetoVendas
{
    partial class FrmCliente
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
            gbox_situacao = new GroupBox();
            txt_limite_credito = new TextBox();
            lbl_limite_credito = new Label();
            cbox_situacao = new ComboBox();
            lbl_status = new Label();
            gbox_cliente = new GroupBox();
            txt_telefone = new MaskedTextBox();
            lbl_telefone = new Label();
            cbox_uf = new ComboBox();
            lbl_uf = new Label();
            txt_complemento = new TextBox();
            lbl_complemento = new Label();
            txt_bairro = new TextBox();
            lbl_bairro = new Label();
            txt_rg = new MaskedTextBox();
            lbl_rg = new Label();
            txt_numero = new TextBox();
            lbl_numero = new Label();
            maskedTextBox1 = new MaskedTextBox();
            lbl_cep = new Label();
            txt_cpf = new MaskedTextBox();
            lbl_cpf = new Label();
            txt_rua = new TextBox();
            lbl_rua = new Label();
            txt_cidade = new TextBox();
            lbl_cidade = new Label();
            txt_nome_cliente = new TextBox();
            lbl_nome_cliente = new Label();
            txt_codigo_cliente = new TextBox();
            lbl_codigo_cliente = new Label();
            btn_fechar = new Button();
            btn_excluir = new Button();
            btn_alterar = new Button();
            btn_consultar = new Button();
            btn_salvar = new Button();
            btn_novo = new Button();
            gbox_situacao.SuspendLayout();
            gbox_cliente.SuspendLayout();
            SuspendLayout();
            // 
            // gbox_situacao
            // 
            gbox_situacao.Controls.Add(txt_limite_credito);
            gbox_situacao.Controls.Add(lbl_limite_credito);
            gbox_situacao.Controls.Add(cbox_situacao);
            gbox_situacao.Controls.Add(lbl_status);
            gbox_situacao.Location = new Point(73, 348);
            gbox_situacao.Name = "gbox_situacao";
            gbox_situacao.Size = new Size(907, 108);
            gbox_situacao.TabIndex = 31;
            gbox_situacao.TabStop = false;
            gbox_situacao.Text = "Situação";
            // 
            // txt_limite_credito
            // 
            txt_limite_credito.Location = new Point(462, 37);
            txt_limite_credito.Name = "txt_limite_credito";
            txt_limite_credito.Size = new Size(205, 27);
            txt_limite_credito.TabIndex = 27;
            // 
            // lbl_limite_credito
            // 
            lbl_limite_credito.AutoSize = true;
            lbl_limite_credito.Location = new Point(332, 40);
            lbl_limite_credito.Name = "lbl_limite_credito";
            lbl_limite_credito.Size = new Size(124, 20);
            lbl_limite_credito.TabIndex = 26;
            lbl_limite_credito.Text = "Limite de Crédito";
            // 
            // cbox_situacao
            // 
            cbox_situacao.FormattingEnabled = true;
            cbox_situacao.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbox_situacao.Location = new Point(114, 37);
            cbox_situacao.Name = "cbox_situacao";
            cbox_situacao.Size = new Size(151, 28);
            cbox_situacao.TabIndex = 27;
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Location = new Point(40, 40);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(49, 20);
            lbl_status.TabIndex = 26;
            lbl_status.Text = "Status";
            // 
            // gbox_cliente
            // 
            gbox_cliente.Controls.Add(txt_telefone);
            gbox_cliente.Controls.Add(lbl_telefone);
            gbox_cliente.Controls.Add(cbox_uf);
            gbox_cliente.Controls.Add(lbl_uf);
            gbox_cliente.Controls.Add(txt_complemento);
            gbox_cliente.Controls.Add(lbl_complemento);
            gbox_cliente.Controls.Add(txt_bairro);
            gbox_cliente.Controls.Add(lbl_bairro);
            gbox_cliente.Controls.Add(txt_rg);
            gbox_cliente.Controls.Add(lbl_rg);
            gbox_cliente.Controls.Add(txt_numero);
            gbox_cliente.Controls.Add(lbl_numero);
            gbox_cliente.Controls.Add(maskedTextBox1);
            gbox_cliente.Controls.Add(lbl_cep);
            gbox_cliente.Controls.Add(txt_cpf);
            gbox_cliente.Controls.Add(lbl_cpf);
            gbox_cliente.Controls.Add(txt_rua);
            gbox_cliente.Controls.Add(lbl_rua);
            gbox_cliente.Controls.Add(txt_cidade);
            gbox_cliente.Controls.Add(lbl_cidade);
            gbox_cliente.Controls.Add(txt_nome_cliente);
            gbox_cliente.Controls.Add(lbl_nome_cliente);
            gbox_cliente.Controls.Add(txt_codigo_cliente);
            gbox_cliente.Controls.Add(lbl_codigo_cliente);
            gbox_cliente.Location = new Point(73, 90);
            gbox_cliente.Name = "gbox_cliente";
            gbox_cliente.Size = new Size(907, 252);
            gbox_cliente.TabIndex = 30;
            gbox_cliente.TabStop = false;
            gbox_cliente.Text = "Cliente";
            // 
            // txt_telefone
            // 
            txt_telefone.Location = new Point(404, 179);
            txt_telefone.Mask = "(00)00000-0000";
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(125, 27);
            txt_telefone.TabIndex = 25;
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Location = new Point(332, 182);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(66, 20);
            lbl_telefone.TabIndex = 24;
            lbl_telefone.Text = "Telefone";
            // 
            // cbox_uf
            // 
            cbox_uf.FormattingEnabled = true;
            cbox_uf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbox_uf.Location = new Point(114, 179);
            cbox_uf.Name = "cbox_uf";
            cbox_uf.Size = new Size(151, 28);
            cbox_uf.TabIndex = 23;
            // 
            // lbl_uf
            // 
            lbl_uf.AutoSize = true;
            lbl_uf.Location = new Point(40, 182);
            lbl_uf.Name = "lbl_uf";
            lbl_uf.Size = new Size(26, 20);
            lbl_uf.TabIndex = 22;
            lbl_uf.Text = "UF";
            // 
            // txt_complemento
            // 
            txt_complemento.Location = new Point(617, 150);
            txt_complemento.Name = "txt_complemento";
            txt_complemento.Size = new Size(205, 27);
            txt_complemento.TabIndex = 21;
            // 
            // lbl_complemento
            // 
            lbl_complemento.AutoSize = true;
            lbl_complemento.Location = new Point(507, 153);
            lbl_complemento.Name = "lbl_complemento";
            lbl_complemento.Size = new Size(104, 20);
            lbl_complemento.TabIndex = 20;
            lbl_complemento.Text = "Complemento";
            // 
            // txt_bairro
            // 
            txt_bairro.Location = new Point(562, 117);
            txt_bairro.Name = "txt_bairro";
            txt_bairro.Size = new Size(205, 27);
            txt_bairro.TabIndex = 19;
            // 
            // lbl_bairro
            // 
            lbl_bairro.AutoSize = true;
            lbl_bairro.Location = new Point(507, 120);
            lbl_bairro.Name = "lbl_bairro";
            lbl_bairro.Size = new Size(49, 20);
            lbl_bairro.TabIndex = 18;
            lbl_bairro.Text = "Bairro";
            // 
            // txt_rg
            // 
            txt_rg.Location = new Point(546, 84);
            txt_rg.Mask = "00.000.000-A";
            txt_rg.Name = "txt_rg";
            txt_rg.Size = new Size(110, 27);
            txt_rg.TabIndex = 17;
            // 
            // lbl_rg
            // 
            lbl_rg.AutoSize = true;
            lbl_rg.Location = new Point(507, 87);
            lbl_rg.Name = "lbl_rg";
            lbl_rg.Size = new Size(28, 20);
            lbl_rg.TabIndex = 16;
            lbl_rg.Text = "RG";
            // 
            // txt_numero
            // 
            txt_numero.Location = new Point(401, 146);
            txt_numero.Name = "txt_numero";
            txt_numero.Size = new Size(95, 27);
            txt_numero.TabIndex = 15;
            // 
            // lbl_numero
            // 
            lbl_numero.AutoSize = true;
            lbl_numero.Location = new Point(332, 153);
            lbl_numero.Name = "lbl_numero";
            lbl_numero.Size = new Size(63, 20);
            lbl_numero.TabIndex = 14;
            lbl_numero.Text = "Número";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(371, 117);
            maskedTextBox1.Mask = "00000-000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 13;
            // 
            // lbl_cep
            // 
            lbl_cep.AutoSize = true;
            lbl_cep.Location = new Point(332, 120);
            lbl_cep.Name = "lbl_cep";
            lbl_cep.Size = new Size(34, 20);
            lbl_cep.TabIndex = 12;
            lbl_cep.Text = "CEP";
            // 
            // txt_cpf
            // 
            txt_cpf.Location = new Point(371, 84);
            txt_cpf.Mask = "000.000.000-00";
            txt_cpf.Name = "txt_cpf";
            txt_cpf.Size = new Size(125, 27);
            txt_cpf.TabIndex = 11;
            // 
            // lbl_cpf
            // 
            lbl_cpf.AutoSize = true;
            lbl_cpf.Location = new Point(332, 87);
            lbl_cpf.Name = "lbl_cpf";
            lbl_cpf.Size = new Size(33, 20);
            lbl_cpf.TabIndex = 10;
            lbl_cpf.Text = "CPF";
            // 
            // txt_rua
            // 
            txt_rua.Location = new Point(114, 146);
            txt_rua.Name = "txt_rua";
            txt_rua.Size = new Size(205, 27);
            txt_rua.TabIndex = 9;
            // 
            // lbl_rua
            // 
            lbl_rua.AutoSize = true;
            lbl_rua.Location = new Point(40, 153);
            lbl_rua.Name = "lbl_rua";
            lbl_rua.Size = new Size(34, 20);
            lbl_rua.TabIndex = 8;
            lbl_rua.Text = "Rua";
            // 
            // txt_cidade
            // 
            txt_cidade.Location = new Point(114, 113);
            txt_cidade.Name = "txt_cidade";
            txt_cidade.Size = new Size(205, 27);
            txt_cidade.TabIndex = 7;
            // 
            // lbl_cidade
            // 
            lbl_cidade.AutoSize = true;
            lbl_cidade.Location = new Point(40, 120);
            lbl_cidade.Name = "lbl_cidade";
            lbl_cidade.Size = new Size(56, 20);
            lbl_cidade.TabIndex = 6;
            lbl_cidade.Text = "Cidade";
            // 
            // txt_nome_cliente
            // 
            txt_nome_cliente.Location = new Point(114, 80);
            txt_nome_cliente.MaxLength = 50;
            txt_nome_cliente.Name = "txt_nome_cliente";
            txt_nome_cliente.Size = new Size(205, 27);
            txt_nome_cliente.TabIndex = 5;
            // 
            // lbl_nome_cliente
            // 
            lbl_nome_cliente.AutoSize = true;
            lbl_nome_cliente.Location = new Point(40, 87);
            lbl_nome_cliente.Name = "lbl_nome_cliente";
            lbl_nome_cliente.Size = new Size(50, 20);
            lbl_nome_cliente.TabIndex = 4;
            lbl_nome_cliente.Text = "Nome";
            // 
            // txt_codigo_cliente
            // 
            txt_codigo_cliente.Location = new Point(194, 39);
            txt_codigo_cliente.Name = "txt_codigo_cliente";
            txt_codigo_cliente.Size = new Size(125, 27);
            txt_codigo_cliente.TabIndex = 3;
            // 
            // lbl_codigo_cliente
            // 
            lbl_codigo_cliente.AutoSize = true;
            lbl_codigo_cliente.Location = new Point(40, 46);
            lbl_codigo_cliente.Name = "lbl_codigo_cliente";
            lbl_codigo_cliente.Size = new Size(130, 20);
            lbl_codigo_cliente.TabIndex = 2;
            lbl_codigo_cliente.Text = "Código do Cliente";
            // 
            // btn_fechar
            // 
            btn_fechar.Location = new Point(577, 502);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(94, 29);
            btn_fechar.TabIndex = 37;
            btn_fechar.Text = "Fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(477, 502);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(94, 29);
            btn_excluir.TabIndex = 36;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_alterar
            // 
            btn_alterar.Location = new Point(377, 502);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(94, 29);
            btn_alterar.TabIndex = 35;
            btn_alterar.Text = "Alterar";
            btn_alterar.UseVisualStyleBackColor = true;
            // 
            // btn_consultar
            // 
            btn_consultar.Location = new Point(277, 502);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(94, 29);
            btn_consultar.TabIndex = 34;
            btn_consultar.Text = "Consultar";
            btn_consultar.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(177, 502);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(94, 29);
            btn_salvar.TabIndex = 33;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            // 
            // btn_novo
            // 
            btn_novo.Location = new Point(77, 502);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(94, 29);
            btn_novo.TabIndex = 32;
            btn_novo.Text = "Novo";
            btn_novo.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 582);
            Controls.Add(btn_fechar);
            Controls.Add(btn_excluir);
            Controls.Add(btn_alterar);
            Controls.Add(btn_consultar);
            Controls.Add(btn_salvar);
            Controls.Add(btn_novo);
            Controls.Add(gbox_situacao);
            Controls.Add(gbox_cliente);
            Name = "FrmCliente";
            Text = "FrmCliente";
            gbox_situacao.ResumeLayout(false);
            gbox_situacao.PerformLayout();
            gbox_cliente.ResumeLayout(false);
            gbox_cliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbox_situacao;
        private TextBox txt_limite_credito;
        private Label lbl_limite_credito;
        private ComboBox cbox_situacao;
        private Label lbl_status;
        private GroupBox gbox_cliente;
        private MaskedTextBox txt_telefone;
        private Label lbl_telefone;
        private ComboBox cbox_uf;
        private Label lbl_uf;
        private TextBox txt_complemento;
        private Label lbl_complemento;
        private TextBox txt_bairro;
        private Label lbl_bairro;
        private MaskedTextBox txt_rg;
        private Label lbl_rg;
        private TextBox txt_numero;
        private Label lbl_numero;
        private MaskedTextBox maskedTextBox1;
        private Label lbl_cep;
        private MaskedTextBox txt_cpf;
        private Label lbl_cpf;
        private TextBox txt_rua;
        private Label lbl_rua;
        private TextBox txt_cidade;
        private Label lbl_cidade;
        private TextBox txt_nome_cliente;
        private Label lbl_nome_cliente;
        private TextBox txt_codigo_cliente;
        private Label lbl_codigo_cliente;
        private Button btn_fechar;
        private Button btn_excluir;
        private Button btn_alterar;
        private Button btn_consultar;
        private Button btn_salvar;
        private Button btn_novo;
    }
}