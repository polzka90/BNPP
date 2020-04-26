namespace BNPP.UI
{
    partial class ManualMovementsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_cosif = new System.Windows.Forms.ComboBox();
            this.cbx_produto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_movimentos = new System.Windows.Forms.DataGridView();
            this.mtxt_mes = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_ano = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_movimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.mtxt_ano);
            this.groupBox1.Controls.Add(this.mtxt_mes);
            this.groupBox1.Controls.Add(this.btn_limpar);
            this.groupBox1.Controls.Add(this.btn_novo);
            this.groupBox1.Controls.Add(this.btn_incluir);
            this.groupBox1.Controls.Add(this.txt_descricao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_valor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbx_cosif);
            this.groupBox1.Controls.Add(this.cbx_produto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movimentos";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(151, 251);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 14;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(232, 251);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 23);
            this.btn_novo.TabIndex = 13;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_incluir
            // 
            this.btn_incluir.Location = new System.Drawing.Point(316, 251);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(75, 23);
            this.btn_incluir.TabIndex = 12;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.UseVisualStyleBackColor = true;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(72, 161);
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(319, 74);
            this.txt_descricao.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Descrição:";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(72, 116);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor:";
            // 
            // cbx_cosif
            // 
            this.cbx_cosif.FormattingEnabled = true;
            this.cbx_cosif.Location = new System.Drawing.Point(268, 73);
            this.cbx_cosif.Name = "cbx_cosif";
            this.cbx_cosif.Size = new System.Drawing.Size(121, 21);
            this.cbx_cosif.TabIndex = 6;
            // 
            // cbx_produto
            // 
            this.cbx_produto.FormattingEnabled = true;
            this.cbx_produto.Location = new System.Drawing.Point(72, 73);
            this.cbx_produto.Name = "cbx_produto";
            this.cbx_produto.Size = new System.Drawing.Size(121, 21);
            this.cbx_produto.TabIndex = 5;
            this.cbx_produto.SelectedIndexChanged += new System.EventHandler(this.cbx_produto_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cosif:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ano:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mês:";
            // 
            // grid_movimentos
            // 
            this.grid_movimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_movimentos.Location = new System.Drawing.Point(12, 314);
            this.grid_movimentos.Name = "grid_movimentos";
            this.grid_movimentos.Size = new System.Drawing.Size(776, 217);
            this.grid_movimentos.TabIndex = 1;
            // 
            // mtxt_mes
            // 
            this.mtxt_mes.Location = new System.Drawing.Point(72, 32);
            this.mtxt_mes.Mask = "00";
            this.mtxt_mes.Name = "mtxt_mes";
            this.mtxt_mes.Size = new System.Drawing.Size(121, 20);
            this.mtxt_mes.TabIndex = 15;
            this.mtxt_mes.ValidatingType = typeof(int);
            // 
            // mtxt_ano
            // 
            this.mtxt_ano.Location = new System.Drawing.Point(270, 32);
            this.mtxt_ano.Mask = "0000";
            this.mtxt_ano.Name = "mtxt_ano";
            this.mtxt_ano.Size = new System.Drawing.Size(121, 20);
            this.mtxt_ano.TabIndex = 16;
            this.mtxt_ano.ValidatingType = typeof(int);
            // 
            // ManualMovementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.grid_movimentos);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManualMovementsForm";
            this.Text = "ManualMovements";
            this.Load += new System.EventHandler(this.ManualMovements_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_movimentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_cosif;
        private System.Windows.Forms.ComboBox cbx_produto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_movimentos;
        private System.Windows.Forms.MaskedTextBox mtxt_ano;
        private System.Windows.Forms.MaskedTextBox mtxt_mes;
    }
}

