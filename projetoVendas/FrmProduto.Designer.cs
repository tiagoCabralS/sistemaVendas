namespace projetoVendas
{
    partial class FrmProduto
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
            txt_nome_produto = new TextBox();
            lbl_nome_produto = new Label();
            txt_codigo_produto = new TextBox();
            lbl_codigo_produto = new Label();
            txt_preco = new TextBox();
            lbl_preco = new Label();
            lbl_categoria = new Label();
            cbox_categoria = new ComboBox();
            btn_fechar = new Button();
            btn_excluir = new Button();
            btn_alterar = new Button();
            btn_consultar = new Button();
            btn_salvar = new Button();
            btn_novo = new Button();
            SuspendLayout();
            // 
            // txt_nome_produto
            // 
            txt_nome_produto.Location = new Point(369, 135);
            txt_nome_produto.Name = "txt_nome_produto";
            txt_nome_produto.Size = new Size(151, 27);
            txt_nome_produto.TabIndex = 11;
            // 
            // lbl_nome_produto
            // 
            lbl_nome_produto.AutoSize = true;
            lbl_nome_produto.Location = new Point(226, 142);
            lbl_nome_produto.Name = "lbl_nome_produto";
            lbl_nome_produto.Size = new Size(129, 20);
            lbl_nome_produto.TabIndex = 10;
            lbl_nome_produto.Text = "Nome do Produto";
            // 
            // txt_codigo_produto
            // 
            txt_codigo_produto.Location = new Point(369, 102);
            txt_codigo_produto.Name = "txt_codigo_produto";
            txt_codigo_produto.Size = new Size(151, 27);
            txt_codigo_produto.TabIndex = 9;
            // 
            // lbl_codigo_produto
            // 
            lbl_codigo_produto.AutoSize = true;
            lbl_codigo_produto.Location = new Point(226, 109);
            lbl_codigo_produto.Name = "lbl_codigo_produto";
            lbl_codigo_produto.Size = new Size(137, 20);
            lbl_codigo_produto.TabIndex = 8;
            lbl_codigo_produto.Text = "Código do Produto";
            // 
            // txt_preco
            // 
            txt_preco.Location = new Point(369, 168);
            txt_preco.Name = "txt_preco";
            txt_preco.Size = new Size(151, 27);
            txt_preco.TabIndex = 13;
            // 
            // lbl_preco
            // 
            lbl_preco.AutoSize = true;
            lbl_preco.Location = new Point(226, 175);
            lbl_preco.Name = "lbl_preco";
            lbl_preco.Size = new Size(46, 20);
            lbl_preco.TabIndex = 12;
            lbl_preco.Text = "Preço";
            // 
            // lbl_categoria
            // 
            lbl_categoria.AutoSize = true;
            lbl_categoria.Location = new Point(226, 206);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(74, 20);
            lbl_categoria.TabIndex = 14;
            lbl_categoria.Text = "Categoria";
            // 
            // cbox_categoria
            // 
            cbox_categoria.FormattingEnabled = true;
            cbox_categoria.Location = new Point(369, 203);
            cbox_categoria.Name = "cbox_categoria";
            cbox_categoria.Size = new Size(151, 28);
            cbox_categoria.TabIndex = 15;
            // 
            // btn_fechar
            // 
            btn_fechar.Location = new Point(611, 307);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(94, 29);
            btn_fechar.TabIndex = 21;
            btn_fechar.Text = "Fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(511, 307);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(94, 29);
            btn_excluir.TabIndex = 20;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_alterar
            // 
            btn_alterar.Location = new Point(411, 307);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(94, 29);
            btn_alterar.TabIndex = 19;
            btn_alterar.Text = "Alterar";
            btn_alterar.UseVisualStyleBackColor = true;
            // 
            // btn_consultar
            // 
            btn_consultar.Location = new Point(311, 307);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(94, 29);
            btn_consultar.TabIndex = 18;
            btn_consultar.Text = "Consultar";
            btn_consultar.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(211, 307);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(94, 29);
            btn_salvar.TabIndex = 17;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            // 
            // btn_novo
            // 
            btn_novo.Location = new Point(111, 307);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(94, 29);
            btn_novo.TabIndex = 16;
            btn_novo.Text = "Novo";
            btn_novo.UseVisualStyleBackColor = true;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_fechar);
            Controls.Add(btn_excluir);
            Controls.Add(btn_alterar);
            Controls.Add(btn_consultar);
            Controls.Add(btn_salvar);
            Controls.Add(btn_novo);
            Controls.Add(cbox_categoria);
            Controls.Add(lbl_categoria);
            Controls.Add(txt_preco);
            Controls.Add(lbl_preco);
            Controls.Add(txt_nome_produto);
            Controls.Add(lbl_nome_produto);
            Controls.Add(txt_codigo_produto);
            Controls.Add(lbl_codigo_produto);
            Name = "FrmProduto";
            Text = "FrmProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_nome_produto;
        private Label lbl_nome_produto;
        private TextBox txt_codigo_produto;
        private Label lbl_codigo_produto;
        private TextBox txt_preco;
        private Label lbl_preco;
        private Label lbl_categoria;
        private ComboBox cbox_categoria;
        private Button btn_fechar;
        private Button btn_excluir;
        private Button btn_alterar;
        private Button btn_consultar;
        private Button btn_salvar;
        private Button btn_novo;
    }
}