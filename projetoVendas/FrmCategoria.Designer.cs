namespace projetoVendas
{
    partial class FrmCategoria
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
            txt_codigo_categoria = new TextBox();
            lbl_codigo_categoria = new Label();
            txt_nome_categoria = new TextBox();
            lbl_nome_categoria = new Label();
            btn_novo = new Button();
            btn_salvar = new Button();
            btn_alterar = new Button();
            btn_consultar = new Button();
            btn_fechar = new Button();
            btn_excluir = new Button();
            SuspendLayout();
            // 
            // txt_codigo_categoria
            // 
            txt_codigo_categoria.Location = new Point(381, 108);
            txt_codigo_categoria.Name = "txt_codigo_categoria";
            txt_codigo_categoria.Size = new Size(125, 27);
            txt_codigo_categoria.TabIndex = 5;
            // 
            // lbl_codigo_categoria
            // 
            lbl_codigo_categoria.AutoSize = true;
            lbl_codigo_categoria.Location = new Point(227, 115);
            lbl_codigo_categoria.Name = "lbl_codigo_categoria";
            lbl_codigo_categoria.Size = new Size(148, 20);
            lbl_codigo_categoria.TabIndex = 4;
            lbl_codigo_categoria.Text = "Código da Categoria";
            // 
            // txt_nome_categoria
            // 
            txt_nome_categoria.Location = new Point(381, 141);
            txt_nome_categoria.Name = "txt_nome_categoria";
            txt_nome_categoria.Size = new Size(125, 27);
            txt_nome_categoria.TabIndex = 7;
            // 
            // lbl_nome_categoria
            // 
            lbl_nome_categoria.AutoSize = true;
            lbl_nome_categoria.Location = new Point(227, 148);
            lbl_nome_categoria.Name = "lbl_nome_categoria";
            lbl_nome_categoria.Size = new Size(140, 20);
            lbl_nome_categoria.TabIndex = 6;
            lbl_nome_categoria.Text = "Nome da Categoria";
            // 
            // btn_novo
            // 
            btn_novo.Location = new Point(128, 270);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(94, 29);
            btn_novo.TabIndex = 8;
            btn_novo.Text = "Novo";
            btn_novo.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(228, 270);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(94, 29);
            btn_salvar.TabIndex = 9;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            // 
            // btn_alterar
            // 
            btn_alterar.Location = new Point(428, 270);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(94, 29);
            btn_alterar.TabIndex = 11;
            btn_alterar.Text = "Alterar";
            btn_alterar.UseVisualStyleBackColor = true;
            // 
            // btn_consultar
            // 
            btn_consultar.Location = new Point(328, 270);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(94, 29);
            btn_consultar.TabIndex = 10;
            btn_consultar.Text = "Consultar";
            btn_consultar.UseVisualStyleBackColor = true;
            // 
            // btn_fechar
            // 
            btn_fechar.Location = new Point(628, 270);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(94, 29);
            btn_fechar.TabIndex = 13;
            btn_fechar.Text = "Fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(528, 270);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(94, 29);
            btn_excluir.TabIndex = 12;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            // 
            // FrmCategoria
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
            Controls.Add(txt_nome_categoria);
            Controls.Add(lbl_nome_categoria);
            Controls.Add(txt_codigo_categoria);
            Controls.Add(lbl_codigo_categoria);
            Name = "FrmCategoria";
            Text = "FrmCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_codigo_categoria;
        private Label lbl_codigo_categoria;
        private TextBox txt_nome_categoria;
        private Label lbl_nome_categoria;
        private Button btn_novo;
        private Button btn_salvar;
        private Button btn_alterar;
        private Button btn_consultar;
        private Button btn_fechar;
        private Button btn_excluir;
    }
}