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
            this.components = new System.ComponentModel.Container();
            this.BtnCadastrarMP = new System.Windows.Forms.Button();
            this.GpbCadastroMP = new System.Windows.Forms.GroupBox();
            this.TxtValorUnitarioMP = new System.Windows.Forms.TextBox();
            this.TxtPesoMP = new System.Windows.Forms.TextBox();
            this.TxtMaterialMP = new System.Windows.Forms.TextBox();
            this.TxtNomeMP = new System.Windows.Forms.TextBox();
            this.LblValorUnitarioMP = new System.Windows.Forms.Label();
            this.LblNomeMP = new System.Windows.Forms.Label();
            this.LblMaterialMP = new System.Windows.Forms.Label();
            this.LblFornecedorMP = new System.Windows.Forms.Label();
            this.LblPesoMP = new System.Windows.Forms.Label();
            this.CmbFornecedorMP = new System.Windows.Forms.ComboBox();
            this.TtpDica = new System.Windows.Forms.ToolTip(this.components);
            this.GpbCadastroMP.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCadastrarMP
            // 
            this.BtnCadastrarMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCadastrarMP.BackColor = System.Drawing.Color.White;
            this.BtnCadastrarMP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCadastrarMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnCadastrarMP.Location = new System.Drawing.Point(585, 440);
            this.BtnCadastrarMP.Name = "BtnCadastrarMP";
            this.BtnCadastrarMP.Size = new System.Drawing.Size(96, 45);
            this.BtnCadastrarMP.TabIndex = 15;
            this.BtnCadastrarMP.Text = "Finalizar Cadastro";
            this.BtnCadastrarMP.UseVisualStyleBackColor = false;
            this.BtnCadastrarMP.Click += new System.EventHandler(this.BtnCadastrarMP_Click);
            this.BtnCadastrarMP.MouseEnter += new System.EventHandler(this.BtnCadastrarMP_MouseEnter);
            this.BtnCadastrarMP.MouseLeave += new System.EventHandler(this.BtnCadastrarMP_MouseLeave);
            // 
            // GpbCadastroMP
            // 
            this.GpbCadastroMP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpbCadastroMP.Controls.Add(this.CmbFornecedorMP);
            this.GpbCadastroMP.Controls.Add(this.TxtValorUnitarioMP);
            this.GpbCadastroMP.Controls.Add(this.TxtPesoMP);
            this.GpbCadastroMP.Controls.Add(this.TxtMaterialMP);
            this.GpbCadastroMP.Controls.Add(this.TxtNomeMP);
            this.GpbCadastroMP.Controls.Add(this.LblValorUnitarioMP);
            this.GpbCadastroMP.Controls.Add(this.LblNomeMP);
            this.GpbCadastroMP.Controls.Add(this.LblMaterialMP);
            this.GpbCadastroMP.Controls.Add(this.LblFornecedorMP);
            this.GpbCadastroMP.Controls.Add(this.LblPesoMP);
            this.GpbCadastroMP.Controls.Add(this.BtnCadastrarMP);
            this.GpbCadastroMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GpbCadastroMP.Location = new System.Drawing.Point(3, 3);
            this.GpbCadastroMP.Name = "GpbCadastroMP";
            this.GpbCadastroMP.Size = new System.Drawing.Size(687, 491);
            this.GpbCadastroMP.TabIndex = 16;
            this.GpbCadastroMP.TabStop = false;
            this.GpbCadastroMP.Text = "Cadastro de Matérias Primas";
            // 
            // TxtValorUnitarioMP
            // 
            this.TxtValorUnitarioMP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtValorUnitarioMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtValorUnitarioMP.Location = new System.Drawing.Point(6, 216);
            this.TxtValorUnitarioMP.MaxLength = 14;
            this.TxtValorUnitarioMP.Name = "TxtValorUnitarioMP";
            this.TxtValorUnitarioMP.Size = new System.Drawing.Size(260, 23);
            this.TxtValorUnitarioMP.TabIndex = 36;
            this.TxtValorUnitarioMP.Enter += new System.EventHandler(this.TxtValorUnitarioMP_Enter);
            this.TxtValorUnitarioMP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorUnitarioMP_KeyPress);
            this.TxtValorUnitarioMP.Leave += new System.EventHandler(this.TxtValorUnitarioMP_Leave);
            // 
            // TxtPesoMP
            // 
            this.TxtPesoMP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPesoMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtPesoMP.Location = new System.Drawing.Point(6, 156);
            this.TxtPesoMP.MaxLength = 100;
            this.TxtPesoMP.Name = "TxtPesoMP";
            this.TxtPesoMP.Size = new System.Drawing.Size(260, 23);
            this.TxtPesoMP.TabIndex = 35;
            this.TxtPesoMP.Enter += new System.EventHandler(this.TxtPesoMP_Enter);
            this.TxtPesoMP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPesoMP_KeyPress);
            this.TxtPesoMP.Leave += new System.EventHandler(this.TxtPesoMP_Leave);
            // 
            // TxtMaterialMP
            // 
            this.TxtMaterialMP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtMaterialMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtMaterialMP.Location = new System.Drawing.Point(6, 99);
            this.TxtMaterialMP.MaxLength = 18;
            this.TxtMaterialMP.Name = "TxtMaterialMP";
            this.TxtMaterialMP.Size = new System.Drawing.Size(260, 23);
            this.TxtMaterialMP.TabIndex = 34;
            this.TxtMaterialMP.Enter += new System.EventHandler(this.TxtMaterialMP_Enter);
            this.TxtMaterialMP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMaterialMP_KeyPress);
            this.TxtMaterialMP.Leave += new System.EventHandler(this.TxtMaterialMP_Leave);
            // 
            // TxtNomeMP
            // 
            this.TxtNomeMP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNomeMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtNomeMP.Location = new System.Drawing.Point(6, 43);
            this.TxtNomeMP.MaxLength = 50;
            this.TxtNomeMP.Name = "TxtNomeMP";
            this.TxtNomeMP.Size = new System.Drawing.Size(260, 23);
            this.TxtNomeMP.TabIndex = 33;
            this.TxtNomeMP.Enter += new System.EventHandler(this.TxtNomeMP_Enter);
            this.TxtNomeMP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNomeMP_KeyPress);
            this.TxtNomeMP.Leave += new System.EventHandler(this.TxtNomeMP_Leave);
            // 
            // LblValorUnitarioMP
            // 
            this.LblValorUnitarioMP.AutoSize = true;
            this.LblValorUnitarioMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblValorUnitarioMP.Location = new System.Drawing.Point(6, 196);
            this.LblValorUnitarioMP.Name = "LblValorUnitarioMP";
            this.LblValorUnitarioMP.Size = new System.Drawing.Size(94, 17);
            this.LblValorUnitarioMP.TabIndex = 28;
            this.LblValorUnitarioMP.Text = "Valor Unitário";
            // 
            // LblNomeMP
            // 
            this.LblNomeMP.AutoSize = true;
            this.LblNomeMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblNomeMP.Location = new System.Drawing.Point(6, 23);
            this.LblNomeMP.Name = "LblNomeMP";
            this.LblNomeMP.Size = new System.Drawing.Size(156, 17);
            this.LblNomeMP.TabIndex = 25;
            this.LblNomeMP.Text = "Nome da Matéria Prima";
            // 
            // LblMaterialMP
            // 
            this.LblMaterialMP.AutoSize = true;
            this.LblMaterialMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblMaterialMP.Location = new System.Drawing.Point(6, 79);
            this.LblMaterialMP.Name = "LblMaterialMP";
            this.LblMaterialMP.Size = new System.Drawing.Size(169, 17);
            this.LblMaterialMP.TabIndex = 26;
            this.LblMaterialMP.Text = "Material da Matéria Prima";
            // 
            // LblFornecedorMP
            // 
            this.LblFornecedorMP.AutoSize = true;
            this.LblFornecedorMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblFornecedorMP.Location = new System.Drawing.Point(6, 256);
            this.LblFornecedorMP.Name = "LblFornecedorMP";
            this.LblFornecedorMP.Size = new System.Drawing.Size(81, 17);
            this.LblFornecedorMP.TabIndex = 29;
            this.LblFornecedorMP.Text = "Fornecedor";
            // 
            // LblPesoMP
            // 
            this.LblPesoMP.AutoSize = true;
            this.LblPesoMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblPesoMP.Location = new System.Drawing.Point(6, 136);
            this.LblPesoMP.Name = "LblPesoMP";
            this.LblPesoMP.Size = new System.Drawing.Size(40, 17);
            this.LblPesoMP.TabIndex = 27;
            this.LblPesoMP.Text = "Peso";
            // 
            // CmbFornecedorMP
            // 
            this.CmbFornecedorMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFornecedorMP.FormattingEnabled = true;
            this.CmbFornecedorMP.Location = new System.Drawing.Point(6, 276);
            this.CmbFornecedorMP.Name = "CmbFornecedorMP";
            this.CmbFornecedorMP.Size = new System.Drawing.Size(260, 24);
            this.CmbFornecedorMP.TabIndex = 37;
            this.CmbFornecedorMP.Enter += new System.EventHandler(this.CmbFornecedorMP_Enter);
            this.CmbFornecedorMP.Leave += new System.EventHandler(this.CmbFornecedorMP_Leave);
            // 
            // TtpDica
            // 
            this.TtpDica.AutomaticDelay = 5000;
            this.TtpDica.AutoPopDelay = 4000;
            this.TtpDica.InitialDelay = 100;
            this.TtpDica.ReshowDelay = 1000;
            // 
            // Cad_MateriaP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GpbCadastroMP);
            this.Name = "Cad_MateriaP";
            this.Size = new System.Drawing.Size(693, 497);
            this.GpbCadastroMP.ResumeLayout(false);
            this.GpbCadastroMP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCadastrarMP;
        private System.Windows.Forms.GroupBox GpbCadastroMP;
        private System.Windows.Forms.TextBox TxtValorUnitarioMP;
        private System.Windows.Forms.TextBox TxtPesoMP;
        private System.Windows.Forms.TextBox TxtMaterialMP;
        private System.Windows.Forms.TextBox TxtNomeMP;
        private System.Windows.Forms.Label LblValorUnitarioMP;
        private System.Windows.Forms.Label LblNomeMP;
        private System.Windows.Forms.Label LblMaterialMP;
        private System.Windows.Forms.Label LblFornecedorMP;
        private System.Windows.Forms.Label LblPesoMP;
        private System.Windows.Forms.ComboBox CmbFornecedorMP;
        private System.Windows.Forms.ToolTip TtpDica;
    }
}
