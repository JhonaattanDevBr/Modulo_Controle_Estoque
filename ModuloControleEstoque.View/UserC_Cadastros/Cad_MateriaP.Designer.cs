namespace ModuloControleEstoque.View.UserC_Cadastros
{
    partial class Cad_MateriaP
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCadastrarFornecedor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CkbCadastrarMP = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbFornecedorMP = new System.Windows.Forms.ComboBox();
            this.TxtQuantidadeMP = new System.Windows.Forms.TextBox();
            this.TxtPrecoUnitarioMP = new System.Windows.Forms.TextBox();
            this.TxtNovaCategoriaMP = new System.Windows.Forms.TextBox();
            this.CmbCategoriaMP = new System.Windows.Forms.ComboBox();
            this.LblFornecedorMP = new System.Windows.Forms.Label();
            this.TxtNomeMP = new System.Windows.Forms.TextBox();
            this.LblQuantidadeMP = new System.Windows.Forms.Label();
            this.LblPrecoUnitarioMP = new System.Windows.Forms.Label();
            this.LblNovaCategoriaMP = new System.Windows.Forms.Label();
            this.LblCategoriaMP = new System.Windows.Forms.Label();
            this.LblNomeMP = new System.Windows.Forms.Label();
            this.LblExemplo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCadastrarFornecedor
            // 
            this.BtnCadastrarFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCadastrarFornecedor.BackColor = System.Drawing.Color.White;
            this.BtnCadastrarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCadastrarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnCadastrarFornecedor.Location = new System.Drawing.Point(585, 440);
            this.BtnCadastrarFornecedor.Name = "BtnCadastrarFornecedor";
            this.BtnCadastrarFornecedor.Size = new System.Drawing.Size(96, 45);
            this.BtnCadastrarFornecedor.TabIndex = 15;
            this.BtnCadastrarFornecedor.Text = "Finalizar Cadastro";
            this.BtnCadastrarFornecedor.UseVisualStyleBackColor = false;
            this.BtnCadastrarFornecedor.Click += new System.EventHandler(this.BtnCadastrarFornecedor_Click);
            this.BtnCadastrarFornecedor.MouseEnter += new System.EventHandler(this.BtnCadastrarFornecedor_MouseEnter);
            this.BtnCadastrarFornecedor.MouseLeave += new System.EventHandler(this.BtnCadastrarFornecedor_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.LblExemplo);
            this.groupBox1.Controls.Add(this.CkbCadastrarMP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CmbFornecedorMP);
            this.groupBox1.Controls.Add(this.TxtQuantidadeMP);
            this.groupBox1.Controls.Add(this.TxtPrecoUnitarioMP);
            this.groupBox1.Controls.Add(this.TxtNovaCategoriaMP);
            this.groupBox1.Controls.Add(this.CmbCategoriaMP);
            this.groupBox1.Controls.Add(this.LblFornecedorMP);
            this.groupBox1.Controls.Add(this.TxtNomeMP);
            this.groupBox1.Controls.Add(this.LblQuantidadeMP);
            this.groupBox1.Controls.Add(this.LblPrecoUnitarioMP);
            this.groupBox1.Controls.Add(this.LblNovaCategoriaMP);
            this.groupBox1.Controls.Add(this.LblCategoriaMP);
            this.groupBox1.Controls.Add(this.LblNomeMP);
            this.groupBox1.Controls.Add(this.BtnCadastrarFornecedor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 491);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Matérias Primas";
            // 
            // CkbCadastrarMP
            // 
            this.CkbCadastrarMP.AutoSize = true;
            this.CkbCadastrarMP.Location = new System.Drawing.Point(224, 116);
            this.CkbCadastrarMP.Name = "CkbCadastrarMP";
            this.CkbCadastrarMP.Size = new System.Drawing.Size(98, 21);
            this.CkbCadastrarMP.TabIndex = 29;
            this.CkbCadastrarMP.Text = "Cadastrar";
            this.CkbCadastrarMP.UseVisualStyleBackColor = true;
            this.CkbCadastrarMP.CheckedChanged += new System.EventHandler(this.CkbCadastrarMP_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(221, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Caso a matéria prima não tenha uma categoria click em CADASTRAR.";
            // 
            // CmbFornecedorMP
            // 
            this.CmbFornecedorMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFornecedorMP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmbFornecedorMP.FormattingEnabled = true;
            this.CmbFornecedorMP.Location = new System.Drawing.Point(6, 345);
            this.CmbFornecedorMP.Name = "CmbFornecedorMP";
            this.CmbFornecedorMP.Size = new System.Drawing.Size(121, 24);
            this.CmbFornecedorMP.TabIndex = 27;
            this.CmbFornecedorMP.Enter += new System.EventHandler(this.CmbFornecedorMP_Enter);
            this.CmbFornecedorMP.Leave += new System.EventHandler(this.CmbFornecedorMP_Leave);
            // 
            // TxtQuantidadeMP
            // 
            this.TxtQuantidadeMP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtQuantidadeMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtQuantidadeMP.Location = new System.Drawing.Point(6, 287);
            this.TxtQuantidadeMP.Name = "TxtQuantidadeMP";
            this.TxtQuantidadeMP.Size = new System.Drawing.Size(260, 23);
            this.TxtQuantidadeMP.TabIndex = 26;
            this.TxtQuantidadeMP.TextChanged += new System.EventHandler(this.TxtQuantidadeMP_TextChanged);
            this.TxtQuantidadeMP.Enter += new System.EventHandler(this.TxtQuantidadeMP_Enter);
            this.TxtQuantidadeMP.Leave += new System.EventHandler(this.TxtQuantidadeMP_Leave);
            // 
            // TxtPrecoUnitarioMP
            // 
            this.TxtPrecoUnitarioMP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPrecoUnitarioMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtPrecoUnitarioMP.Location = new System.Drawing.Point(6, 227);
            this.TxtPrecoUnitarioMP.Name = "TxtPrecoUnitarioMP";
            this.TxtPrecoUnitarioMP.Size = new System.Drawing.Size(260, 23);
            this.TxtPrecoUnitarioMP.TabIndex = 25;
            this.TxtPrecoUnitarioMP.TextChanged += new System.EventHandler(this.TxtPrecoUnitarioMP_TextChanged);
            this.TxtPrecoUnitarioMP.Enter += new System.EventHandler(this.TxtPrecoUnitarioMP_Enter);
            this.TxtPrecoUnitarioMP.Leave += new System.EventHandler(this.TxtPrecoUnitarioMP_Leave);
            // 
            // TxtNovaCategoriaMP
            // 
            this.TxtNovaCategoriaMP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNovaCategoriaMP.Enabled = false;
            this.TxtNovaCategoriaMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtNovaCategoriaMP.Location = new System.Drawing.Point(6, 167);
            this.TxtNovaCategoriaMP.Name = "TxtNovaCategoriaMP";
            this.TxtNovaCategoriaMP.Size = new System.Drawing.Size(260, 23);
            this.TxtNovaCategoriaMP.TabIndex = 24;
            this.TxtNovaCategoriaMP.TextChanged += new System.EventHandler(this.TxtNovaCategoriaMP_TextChanged);
            this.TxtNovaCategoriaMP.Enter += new System.EventHandler(this.TxtNovaCategoriaMP_Enter);
            this.TxtNovaCategoriaMP.Leave += new System.EventHandler(this.TxtNovaCategoriaMP_Leave);
            // 
            // CmbCategoriaMP
            // 
            this.CmbCategoriaMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategoriaMP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmbCategoriaMP.FormattingEnabled = true;
            this.CmbCategoriaMP.Location = new System.Drawing.Point(6, 110);
            this.CmbCategoriaMP.Name = "CmbCategoriaMP";
            this.CmbCategoriaMP.Size = new System.Drawing.Size(121, 24);
            this.CmbCategoriaMP.TabIndex = 23;
            this.CmbCategoriaMP.Enter += new System.EventHandler(this.CmbCategoriaMP_Enter);
            this.CmbCategoriaMP.Leave += new System.EventHandler(this.CmbCategoriaMP_Leave);
            // 
            // LblFornecedorMP
            // 
            this.LblFornecedorMP.AutoSize = true;
            this.LblFornecedorMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblFornecedorMP.Location = new System.Drawing.Point(6, 325);
            this.LblFornecedorMP.Name = "LblFornecedorMP";
            this.LblFornecedorMP.Size = new System.Drawing.Size(81, 17);
            this.LblFornecedorMP.TabIndex = 22;
            this.LblFornecedorMP.Text = "Fornecedor";
            // 
            // TxtNomeMP
            // 
            this.TxtNomeMP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNomeMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtNomeMP.Location = new System.Drawing.Point(6, 54);
            this.TxtNomeMP.Name = "TxtNomeMP";
            this.TxtNomeMP.Size = new System.Drawing.Size(260, 23);
            this.TxtNomeMP.TabIndex = 21;
            this.TxtNomeMP.TextChanged += new System.EventHandler(this.TxtNomeMP_TextChanged);
            this.TxtNomeMP.Enter += new System.EventHandler(this.TxtNomeMP_Enter);
            this.TxtNomeMP.Leave += new System.EventHandler(this.TxtNomeMP_Leave);
            // 
            // LblQuantidadeMP
            // 
            this.LblQuantidadeMP.AutoSize = true;
            this.LblQuantidadeMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblQuantidadeMP.Location = new System.Drawing.Point(6, 267);
            this.LblQuantidadeMP.Name = "LblQuantidadeMP";
            this.LblQuantidadeMP.Size = new System.Drawing.Size(82, 17);
            this.LblQuantidadeMP.TabIndex = 20;
            this.LblQuantidadeMP.Text = "Quantidade";
            // 
            // LblPrecoUnitarioMP
            // 
            this.LblPrecoUnitarioMP.AutoSize = true;
            this.LblPrecoUnitarioMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblPrecoUnitarioMP.Location = new System.Drawing.Point(6, 207);
            this.LblPrecoUnitarioMP.Name = "LblPrecoUnitarioMP";
            this.LblPrecoUnitarioMP.Size = new System.Drawing.Size(98, 17);
            this.LblPrecoUnitarioMP.TabIndex = 19;
            this.LblPrecoUnitarioMP.Text = "Preço Unitário";
            // 
            // LblNovaCategoriaMP
            // 
            this.LblNovaCategoriaMP.AutoSize = true;
            this.LblNovaCategoriaMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblNovaCategoriaMP.Location = new System.Drawing.Point(6, 147);
            this.LblNovaCategoriaMP.Name = "LblNovaCategoriaMP";
            this.LblNovaCategoriaMP.Size = new System.Drawing.Size(106, 17);
            this.LblNovaCategoriaMP.TabIndex = 18;
            this.LblNovaCategoriaMP.Text = "Nova Categoria";
            // 
            // LblCategoriaMP
            // 
            this.LblCategoriaMP.AutoSize = true;
            this.LblCategoriaMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblCategoriaMP.Location = new System.Drawing.Point(6, 90);
            this.LblCategoriaMP.Name = "LblCategoriaMP";
            this.LblCategoriaMP.Size = new System.Drawing.Size(160, 17);
            this.LblCategoriaMP.TabIndex = 17;
            this.LblCategoriaMP.Text = "Categoria Matéria Prima";
            // 
            // LblNomeMP
            // 
            this.LblNomeMP.AutoSize = true;
            this.LblNomeMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblNomeMP.Location = new System.Drawing.Point(6, 34);
            this.LblNomeMP.Name = "LblNomeMP";
            this.LblNomeMP.Size = new System.Drawing.Size(136, 17);
            this.LblNomeMP.TabIndex = 16;
            this.LblNomeMP.Text = "Nome Matéria Prima";
            // 
            // LblExemplo
            // 
            this.LblExemplo.AutoSize = true;
            this.LblExemplo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblExemplo.ForeColor = System.Drawing.Color.DarkRed;
            this.LblExemplo.Location = new System.Drawing.Point(103, 253);
            this.LblExemplo.Name = "LblExemplo";
            this.LblExemplo.Size = new System.Drawing.Size(206, 15);
            this.LblExemplo.TabIndex = 30;
            this.LblExemplo.Text = "Dica: 3,50 / 15,99 / 345,55 / 1.450,99";
            // 
            // Cad_MateriaP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Cad_MateriaP";
            this.Size = new System.Drawing.Size(693, 497);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCadastrarFornecedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbFornecedorMP;
        private System.Windows.Forms.TextBox TxtQuantidadeMP;
        private System.Windows.Forms.TextBox TxtPrecoUnitarioMP;
        private System.Windows.Forms.TextBox TxtNovaCategoriaMP;
        private System.Windows.Forms.ComboBox CmbCategoriaMP;
        private System.Windows.Forms.Label LblFornecedorMP;
        private System.Windows.Forms.TextBox TxtNomeMP;
        private System.Windows.Forms.Label LblQuantidadeMP;
        private System.Windows.Forms.Label LblPrecoUnitarioMP;
        private System.Windows.Forms.Label LblNovaCategoriaMP;
        private System.Windows.Forms.Label LblCategoriaMP;
        private System.Windows.Forms.Label LblNomeMP;
        private System.Windows.Forms.CheckBox CkbCadastrarMP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblExemplo;
    }
}
