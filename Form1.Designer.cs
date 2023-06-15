namespace Prova2Bim
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            lb_codigo = new Label();
            tx_codigo = new TextBox();
            lb_unidade = new Label();
            cb_unidade = new ComboBox();
            lb_descricao = new Label();
            tx_descricao = new TextBox();
            lb_valor = new Label();
            lb_pis = new Label();
            lb_icms = new Label();
            lb_confins = new Label();
            lb_lucro = new Label();
            lb_vlrVenda = new Label();
            bt_cadastrar = new Button();
            tx_valor = new TextBox();
            tx_pis = new TextBox();
            tx_icms = new TextBox();
            tx_confins = new TextBox();
            tx_lucro = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(302, 12);
            label1.Name = "label1";
            label1.Size = new Size(211, 23);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produto";
            // 
            // panel1
            // 
            panel1.Controls.Add(tx_lucro);
            panel1.Controls.Add(tx_confins);
            panel1.Controls.Add(tx_icms);
            panel1.Controls.Add(tx_pis);
            panel1.Controls.Add(tx_valor);
            panel1.Controls.Add(bt_cadastrar);
            panel1.Controls.Add(lb_vlrVenda);
            panel1.Controls.Add(lb_lucro);
            panel1.Controls.Add(lb_confins);
            panel1.Controls.Add(lb_icms);
            panel1.Controls.Add(lb_pis);
            panel1.Controls.Add(lb_valor);
            panel1.Controls.Add(tx_descricao);
            panel1.Controls.Add(lb_descricao);
            panel1.Controls.Add(cb_unidade);
            panel1.Controls.Add(lb_unidade);
            panel1.Controls.Add(tx_codigo);
            panel1.Controls.Add(lb_codigo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(761, 517);
            panel1.TabIndex = 1;
            // 
            // lb_codigo
            // 
            lb_codigo.AutoSize = true;
            lb_codigo.Location = new Point(49, 65);
            lb_codigo.Name = "lb_codigo";
            lb_codigo.Size = new Size(58, 20);
            lb_codigo.TabIndex = 1;
            lb_codigo.Text = "Código";
            // 
            // tx_codigo
            // 
            tx_codigo.BorderStyle = BorderStyle.FixedSingle;
            tx_codigo.Location = new Point(129, 63);
            tx_codigo.Name = "tx_codigo";
            tx_codigo.Size = new Size(179, 27);
            tx_codigo.TabIndex = 2;
            // 
            // lb_unidade
            // 
            lb_unidade.AutoSize = true;
            lb_unidade.Location = new Point(457, 65);
            lb_unidade.Name = "lb_unidade";
            lb_unidade.Size = new Size(65, 20);
            lb_unidade.TabIndex = 3;
            lb_unidade.Text = "Unidade";
            // 
            // cb_unidade
            // 
            cb_unidade.FormattingEnabled = true;
            cb_unidade.Items.AddRange(new object[] { "UN", "LT", "KG" });
            cb_unidade.Location = new Point(542, 60);
            cb_unidade.Name = "cb_unidade";
            cb_unidade.Size = new Size(172, 28);
            cb_unidade.TabIndex = 4;
            // 
            // lb_descricao
            // 
            lb_descricao.AutoSize = true;
            lb_descricao.Location = new Point(49, 137);
            lb_descricao.Name = "lb_descricao";
            lb_descricao.Size = new Size(74, 20);
            lb_descricao.TabIndex = 5;
            lb_descricao.Text = "Descrição";
            // 
            // tx_descricao
            // 
            tx_descricao.BorderStyle = BorderStyle.FixedSingle;
            tx_descricao.Location = new Point(129, 134);
            tx_descricao.Name = "tx_descricao";
            tx_descricao.Size = new Size(585, 27);
            tx_descricao.TabIndex = 6;
            // 
            // lb_valor
            // 
            lb_valor.AutoSize = true;
            lb_valor.Location = new Point(49, 202);
            lb_valor.Name = "lb_valor";
            lb_valor.Size = new Size(43, 20);
            lb_valor.TabIndex = 7;
            lb_valor.Text = "Valor";
            // 
            // lb_pis
            // 
            lb_pis.AutoSize = true;
            lb_pis.Location = new Point(498, 202);
            lb_pis.Name = "lb_pis";
            lb_pis.Size = new Size(29, 20);
            lb_pis.TabIndex = 8;
            lb_pis.Text = "PIS";
            // 
            // lb_icms
            // 
            lb_icms.AutoSize = true;
            lb_icms.Location = new Point(49, 266);
            lb_icms.Name = "lb_icms";
            lb_icms.Size = new Size(43, 20);
            lb_icms.TabIndex = 9;
            lb_icms.Text = "ICMS";
            // 
            // lb_confins
            // 
            lb_confins.AutoSize = true;
            lb_confins.Location = new Point(457, 266);
            lb_confins.Name = "lb_confins";
            lb_confins.Size = new Size(70, 20);
            lb_confins.TabIndex = 10;
            lb_confins.Text = "CONFINS";
            // 
            // lb_lucro
            // 
            lb_lucro.AutoSize = true;
            lb_lucro.Location = new Point(49, 333);
            lb_lucro.Name = "lb_lucro";
            lb_lucro.Size = new Size(45, 20);
            lb_lucro.TabIndex = 11;
            lb_lucro.Text = "Lucro";
            // 
            // lb_vlrVenda
            // 
            lb_vlrVenda.AutoSize = true;
            lb_vlrVenda.Location = new Point(49, 406);
            lb_vlrVenda.Name = "lb_vlrVenda";
            lb_vlrVenda.Size = new Size(109, 20);
            lb_vlrVenda.TabIndex = 12;
            lb_vlrVenda.Text = "Valor de Venda";
            // 
            // bt_cadastrar
            // 
            bt_cadastrar.Location = new Point(49, 474);
            bt_cadastrar.Name = "bt_cadastrar";
            bt_cadastrar.Size = new Size(665, 29);
            bt_cadastrar.TabIndex = 13;
            bt_cadastrar.Text = "Cadastrar";
            bt_cadastrar.UseVisualStyleBackColor = true;
            bt_cadastrar.Click += button1_Click;
            // 
            // tx_valor
            // 
            tx_valor.BorderStyle = BorderStyle.FixedSingle;
            tx_valor.Location = new Point(129, 200);
            tx_valor.Name = "tx_valor";
            tx_valor.Size = new Size(179, 27);
            tx_valor.TabIndex = 14;
            // 
            // tx_pis
            // 
            tx_pis.BorderStyle = BorderStyle.FixedSingle;
            tx_pis.Location = new Point(542, 200);
            tx_pis.Name = "tx_pis";
            tx_pis.Size = new Size(172, 27);
            tx_pis.TabIndex = 15;
            // 
            // tx_icms
            // 
            tx_icms.BorderStyle = BorderStyle.FixedSingle;
            tx_icms.Location = new Point(129, 263);
            tx_icms.Name = "tx_icms";
            tx_icms.Size = new Size(179, 27);
            tx_icms.TabIndex = 16;
            // 
            // tx_confins
            // 
            tx_confins.BorderStyle = BorderStyle.FixedSingle;
            tx_confins.Location = new Point(542, 263);
            tx_confins.Name = "tx_confins";
            tx_confins.Size = new Size(172, 27);
            tx_confins.TabIndex = 17;
            // 
            // tx_lucro
            // 
            tx_lucro.BorderStyle = BorderStyle.FixedSingle;
            tx_lucro.Location = new Point(129, 330);
            tx_lucro.Name = "tx_lucro";
            tx_lucro.Size = new Size(179, 27);
            tx_lucro.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label lb_unidade;
        private TextBox tx_codigo;
        private Label lb_codigo;
        private ComboBox cb_unidade;
        private TextBox tx_confins;
        private TextBox tx_icms;
        private TextBox tx_pis;
        private TextBox tx_valor;
        private Button bt_cadastrar;
        private Label lb_vlrVenda;
        private Label lb_lucro;
        private Label lb_confins;
        private Label lb_icms;
        private Label lb_pis;
        private Label lb_valor;
        private TextBox tx_descricao;
        private Label lb_descricao;
        private TextBox tx_lucro;
    }
}