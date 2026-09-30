namespace projetoVendas
{
    partial class FrmVenda
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
            txt_codigo_venda = new TextBox();
            lbl_codigo_venda = new Label();
            txt_data_venda = new MaskedTextBox();
            cbox_cliente = new ComboBox();
            lbl_cliente = new Label();
            cbox_produto = new ComboBox();
            lbl_produto = new Label();
            txt_quantidade = new TextBox();
            lbl_quantidade = new Label();
            lbl_preco_unitario = new Label();
            lbl_subtotal = new Label();
            txt_preco_unitario = new TextBox();
            txt_subtotal = new TextBox();
            txt_total = new TextBox();
            lbl_total_venda = new Label();
            btn_fechar = new Button();
            btn_excluir = new Button();
            btn_alterar = new Button();
            btn_consultar = new Button();
            btn_salvar = new Button();
            btn_novo = new Button();
            lbl_data_venda = new Label();
            SuspendLayout();
            // 
            // txt_codigo_venda
            // 
            txt_codigo_venda.Location = new Point(374, 84);
            txt_codigo_venda.Name = "txt_codigo_venda";
            txt_codigo_venda.Size = new Size(151, 27);
            txt_codigo_venda.TabIndex = 17;
            // 
            // lbl_codigo_venda
            // 
            lbl_codigo_venda.AutoSize = true;
            lbl_codigo_venda.Location = new Point(231, 91);
            lbl_codigo_venda.Name = "lbl_codigo_venda";
            lbl_codigo_venda.Size = new Size(124, 20);
            lbl_codigo_venda.TabIndex = 16;
            lbl_codigo_venda.Text = "Código da Venda";
            // 
            // txt_data_venda
            // 
            txt_data_venda.Location = new Point(374, 117);
            txt_data_venda.Mask = "00/00/0000";
            txt_data_venda.Name = "txt_data_venda";
            txt_data_venda.Size = new Size(151, 27);
            txt_data_venda.TabIndex = 23;
            txt_data_venda.ValidatingType = typeof(DateTime);
            // 
            // cbox_cliente
            // 
            cbox_cliente.FormattingEnabled = true;
            cbox_cliente.Location = new Point(374, 150);
            cbox_cliente.Name = "cbox_cliente";
            cbox_cliente.Size = new Size(151, 28);
            cbox_cliente.TabIndex = 25;
            // 
            // lbl_cliente
            // 
            lbl_cliente.AutoSize = true;
            lbl_cliente.Location = new Point(231, 153);
            lbl_cliente.Name = "lbl_cliente";
            lbl_cliente.Size = new Size(55, 20);
            lbl_cliente.TabIndex = 24;
            lbl_cliente.Text = "Cliente";
            // 
            // cbox_produto
            // 
            cbox_produto.FormattingEnabled = true;
            cbox_produto.Location = new Point(374, 184);
            cbox_produto.Name = "cbox_produto";
            cbox_produto.Size = new Size(151, 28);
            cbox_produto.TabIndex = 27;
            // 
            // lbl_produto
            // 
            lbl_produto.AutoSize = true;
            lbl_produto.Location = new Point(231, 187);
            lbl_produto.Name = "lbl_produto";
            lbl_produto.Size = new Size(62, 20);
            lbl_produto.TabIndex = 26;
            lbl_produto.Text = "Produto";
            // 
            // txt_quantidade
            // 
            txt_quantidade.Location = new Point(374, 218);
            txt_quantidade.Name = "txt_quantidade";
            txt_quantidade.Size = new Size(151, 27);
            txt_quantidade.TabIndex = 29;
            // 
            // lbl_quantidade
            // 
            lbl_quantidade.AutoSize = true;
            lbl_quantidade.Location = new Point(231, 225);
            lbl_quantidade.Name = "lbl_quantidade";
            lbl_quantidade.Size = new Size(87, 20);
            lbl_quantidade.TabIndex = 28;
            lbl_quantidade.Text = "Quantidade";
            // 
            // lbl_preco_unitario
            // 
            lbl_preco_unitario.AutoSize = true;
            lbl_preco_unitario.Location = new Point(231, 258);
            lbl_preco_unitario.Name = "lbl_preco_unitario";
            lbl_preco_unitario.Size = new Size(103, 20);
            lbl_preco_unitario.TabIndex = 30;
            lbl_preco_unitario.Text = "Preço Unitário";
            // 
            // lbl_subtotal
            // 
            lbl_subtotal.AutoSize = true;
            lbl_subtotal.Location = new Point(231, 291);
            lbl_subtotal.Name = "lbl_subtotal";
            lbl_subtotal.Size = new Size(65, 20);
            lbl_subtotal.TabIndex = 32;
            lbl_subtotal.Text = "Subtotal";
            // 
            // txt_preco_unitario
            // 
            txt_preco_unitario.Location = new Point(374, 255);
            txt_preco_unitario.Name = "txt_preco_unitario";
            txt_preco_unitario.Size = new Size(151, 27);
            txt_preco_unitario.TabIndex = 33;
            // 
            // txt_subtotal
            // 
            txt_subtotal.Location = new Point(374, 288);
            txt_subtotal.Name = "txt_subtotal";
            txt_subtotal.Size = new Size(151, 27);
            txt_subtotal.TabIndex = 34;
            // 
            // txt_total
            // 
            txt_total.Location = new Point(374, 321);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(151, 27);
            txt_total.TabIndex = 36;
            // 
            // lbl_total_venda
            // 
            lbl_total_venda.AutoSize = true;
            lbl_total_venda.Location = new Point(231, 324);
            lbl_total_venda.Name = "lbl_total_venda";
            lbl_total_venda.Size = new Size(108, 20);
            lbl_total_venda.TabIndex = 35;
            lbl_total_venda.Text = "Total da Venda";
            // 
            // btn_fechar
            // 
            btn_fechar.Location = new Point(604, 392);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(94, 29);
            btn_fechar.TabIndex = 42;
            btn_fechar.Text = "Fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(504, 392);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(94, 29);
            btn_excluir.TabIndex = 41;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_alterar
            // 
            btn_alterar.Location = new Point(404, 392);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(94, 29);
            btn_alterar.TabIndex = 40;
            btn_alterar.Text = "Alterar";
            btn_alterar.UseVisualStyleBackColor = true;
            // 
            // btn_consultar
            // 
            btn_consultar.Location = new Point(304, 392);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(94, 29);
            btn_consultar.TabIndex = 39;
            btn_consultar.Text = "Consultar";
            btn_consultar.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(204, 392);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(94, 29);
            btn_salvar.TabIndex = 38;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            // 
            // btn_novo
            // 
            btn_novo.Location = new Point(104, 392);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(94, 29);
            btn_novo.TabIndex = 37;
            btn_novo.Text = "Novo";
            btn_novo.UseVisualStyleBackColor = true;
            // 
            // lbl_data_venda
            // 
            lbl_data_venda.AutoSize = true;
            lbl_data_venda.Location = new Point(231, 120);
            lbl_data_venda.Name = "lbl_data_venda";
            lbl_data_venda.Size = new Size(107, 20);
            lbl_data_venda.TabIndex = 43;
            lbl_data_venda.Text = "Data da Venda";
            // 
            // FrmVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_data_venda);
            Controls.Add(btn_fechar);
            Controls.Add(btn_excluir);
            Controls.Add(btn_alterar);
            Controls.Add(btn_consultar);
            Controls.Add(btn_salvar);
            Controls.Add(btn_novo);
            Controls.Add(txt_total);
            Controls.Add(lbl_total_venda);
            Controls.Add(txt_subtotal);
            Controls.Add(txt_preco_unitario);
            Controls.Add(lbl_subtotal);
            Controls.Add(lbl_preco_unitario);
            Controls.Add(txt_quantidade);
            Controls.Add(lbl_quantidade);
            Controls.Add(cbox_produto);
            Controls.Add(lbl_produto);
            Controls.Add(cbox_cliente);
            Controls.Add(lbl_cliente);
            Controls.Add(txt_data_venda);
            Controls.Add(txt_codigo_venda);
            Controls.Add(lbl_codigo_venda);
            Name = "FrmVenda";
            Text = "FrmVenda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbox_categoria;
        private Label lbl_categoria;
        private TextBox txt_preco;
        private Label lbl_preco;
        private TextBox txt_nome_produto;
        private Label lbl_nome_produto;
        private TextBox txt_codigo_venda;
        private Label lbl_codigo_venda;
        private MaskedTextBox txt_data_venda;
        private ComboBox cbox_cliente;
        private Label lbl_cliente;
        private ComboBox cbox_produto;
        private Label lbl_produto;
        private TextBox txt_quantidade;
        private Label lbl_quantidade;
        private TextBox txt_total;
        private Label lbl_preco_unitario;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label lbl_subtotal;
        private TextBox txt_preco_unitario;
        private TextBox txt_subtotal;
        private Label lbl_total_venda;
        private Button btn_fechar;
        private Button btn_excluir;
        private Button btn_alterar;
        private Button btn_consultar;
        private Button btn_salvar;
        private Button btn_novo;
        private Label lbl_data_venda;
    }
}