namespace Fabrica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pedidos = new System.Windows.Forms.GroupBox();
            this.total_pedidos = new System.Windows.Forms.Label();
            this.inserir = new System.Windows.Forms.Button();
            this.listpedidos = new System.Windows.Forms.ListView();
            this.itemcodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemcliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemvalor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valor_pedido = new System.Windows.Forms.TextBox();
            this.cliente = new System.Windows.Forms.TextBox();
            this.codproduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.despesas = new System.Windows.Forms.GroupBox();
            this.total_despesas = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listdespesas = new System.Windows.Forms.ListView();
            this.itemdespesas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemvalordesp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valor_despesa = new System.Windows.Forms.TextBox();
            this.despesa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saldo = new System.Windows.Forms.GroupBox();
            this.lblsaldototal = new System.Windows.Forms.Label();
            this.novo = new System.Windows.Forms.Button();
            this.fechar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pedidos.SuspendLayout();
            this.despesas.SuspendLayout();
            this.saldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pedidos
            // 
            this.pedidos.Controls.Add(this.total_pedidos);
            this.pedidos.Controls.Add(this.inserir);
            this.pedidos.Controls.Add(this.listpedidos);
            this.pedidos.Controls.Add(this.valor_pedido);
            this.pedidos.Controls.Add(this.cliente);
            this.pedidos.Controls.Add(this.codproduto);
            this.pedidos.Controls.Add(this.label7);
            this.pedidos.Controls.Add(this.label3);
            this.pedidos.Controls.Add(this.label2);
            this.pedidos.Controls.Add(this.label1);
            this.pedidos.Location = new System.Drawing.Point(12, 28);
            this.pedidos.Name = "pedidos";
            this.pedidos.Size = new System.Drawing.Size(423, 374);
            this.pedidos.TabIndex = 0;
            this.pedidos.TabStop = false;
            this.pedidos.Text = "Pedidos";
            // 
            // total_pedidos
            // 
            this.total_pedidos.AutoSize = true;
            this.total_pedidos.Location = new System.Drawing.Point(235, 334);
            this.total_pedidos.Name = "total_pedidos";
            this.total_pedidos.Size = new System.Drawing.Size(0, 13);
            this.total_pedidos.TabIndex = 9;
            // 
            // inserir
            // 
            this.inserir.Location = new System.Drawing.Point(296, 74);
            this.inserir.Name = "inserir";
            this.inserir.Size = new System.Drawing.Size(103, 40);
            this.inserir.TabIndex = 4;
            this.inserir.Text = "Inserir Pedido";
            this.inserir.UseVisualStyleBackColor = true;
            this.inserir.Click += new System.EventHandler(this.inserir_Click);
            // 
            // listpedidos
            // 
            this.listpedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemcodigo,
            this.itemcliente,
            this.itemvalor});
            this.listpedidos.Enabled = false;
            this.listpedidos.HideSelection = false;
            this.listpedidos.Location = new System.Drawing.Point(28, 170);
            this.listpedidos.Name = "listpedidos";
            this.listpedidos.Size = new System.Drawing.Size(365, 131);
            this.listpedidos.TabIndex = 7;
            this.listpedidos.UseCompatibleStateImageBehavior = false;
            this.listpedidos.View = System.Windows.Forms.View.Details;
            // 
            // itemcodigo
            // 
            this.itemcodigo.Text = "Código do Pedido";
            this.itemcodigo.Width = 103;
            // 
            // itemcliente
            // 
            this.itemcliente.Text = "Cliente";
            this.itemcliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemcliente.Width = 171;
            // 
            // itemvalor
            // 
            this.itemvalor.Text = "Valor";
            this.itemvalor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemvalor.Width = 87;
            // 
            // valor_pedido
            // 
            this.valor_pedido.Location = new System.Drawing.Point(89, 120);
            this.valor_pedido.Name = "valor_pedido";
            this.valor_pedido.Size = new System.Drawing.Size(187, 20);
            this.valor_pedido.TabIndex = 3;
            // 
            // cliente
            // 
            this.cliente.Location = new System.Drawing.Point(89, 81);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(187, 20);
            this.cliente.TabIndex = 1;
            // 
            // codproduto
            // 
            this.codproduto.Location = new System.Drawing.Point(89, 40);
            this.codproduto.Name = "codproduto";
            this.codproduto.Size = new System.Drawing.Size(187, 20);
            this.codproduto.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total dos pedidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cód. Pedido:";
            // 
            // despesas
            // 
            this.despesas.Controls.Add(this.total_despesas);
            this.despesas.Controls.Add(this.button2);
            this.despesas.Controls.Add(this.listdespesas);
            this.despesas.Controls.Add(this.valor_despesa);
            this.despesas.Controls.Add(this.despesa);
            this.despesas.Controls.Add(this.label6);
            this.despesas.Controls.Add(this.label5);
            this.despesas.Controls.Add(this.label4);
            this.despesas.Location = new System.Drawing.Point(463, 28);
            this.despesas.Name = "despesas";
            this.despesas.Size = new System.Drawing.Size(425, 374);
            this.despesas.TabIndex = 1;
            this.despesas.TabStop = false;
            this.despesas.Text = "Despesas";
            // 
            // total_despesas
            // 
            this.total_despesas.AutoSize = true;
            this.total_despesas.Location = new System.Drawing.Point(260, 334);
            this.total_despesas.Name = "total_despesas";
            this.total_despesas.Size = new System.Drawing.Size(0, 13);
            this.total_despesas.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Inserir Despesa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listdespesas
            // 
            this.listdespesas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemdespesas,
            this.itemvalordesp});
            this.listdespesas.Enabled = false;
            this.listdespesas.HideSelection = false;
            this.listdespesas.Location = new System.Drawing.Point(29, 170);
            this.listdespesas.Name = "listdespesas";
            this.listdespesas.Size = new System.Drawing.Size(365, 131);
            this.listdespesas.TabIndex = 8;
            this.listdespesas.UseCompatibleStateImageBehavior = false;
            this.listdespesas.View = System.Windows.Forms.View.Details;
            // 
            // itemdespesas
            // 
            this.itemdespesas.Text = "Despesas";
            this.itemdespesas.Width = 159;
            // 
            // itemvalordesp
            // 
            this.itemvalordesp.Text = "Valor";
            this.itemvalordesp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemvalordesp.Width = 90;
            // 
            // valor_despesa
            // 
            this.valor_despesa.Location = new System.Drawing.Point(85, 83);
            this.valor_despesa.Name = "valor_despesa";
            this.valor_despesa.Size = new System.Drawing.Size(180, 20);
            this.valor_despesa.TabIndex = 6;
            // 
            // despesa
            // 
            this.despesa.Location = new System.Drawing.Point(85, 43);
            this.despesa.Name = "despesa";
            this.despesa.Size = new System.Drawing.Size(180, 20);
            this.despesa.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total das despesas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Despesas:";
            // 
            // saldo
            // 
            this.saldo.Controls.Add(this.lblsaldototal);
            this.saldo.Controls.Add(this.novo);
            this.saldo.Controls.Add(this.fechar);
            this.saldo.Controls.Add(this.label8);
            this.saldo.Location = new System.Drawing.Point(20, 441);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(860, 87);
            this.saldo.TabIndex = 2;
            this.saldo.TabStop = false;
            this.saldo.Text = "Saldos da Empresa";
            // 
            // lblsaldototal
            // 
            this.lblsaldototal.AutoSize = true;
            this.lblsaldototal.Location = new System.Drawing.Point(176, 43);
            this.lblsaldototal.Name = "lblsaldototal";
            this.lblsaldototal.Size = new System.Drawing.Size(0, 13);
            this.lblsaldototal.TabIndex = 3;
            // 
            // novo
            // 
            this.novo.Location = new System.Drawing.Point(579, 23);
            this.novo.Name = "novo";
            this.novo.Size = new System.Drawing.Size(125, 47);
            this.novo.TabIndex = 8;
            this.novo.Text = "Novo Lançamento";
            this.novo.UseVisualStyleBackColor = true;
            this.novo.Click += new System.EventHandler(this.novo_Click);
            // 
            // fechar
            // 
            this.fechar.Location = new System.Drawing.Point(717, 23);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(120, 47);
            this.fechar.TabIndex = 9;
            this.fechar.Text = "Fechar";
            this.fechar.UseVisualStyleBackColor = true;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Saldo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.saldo);
            this.Controls.Add(this.despesas);
            this.Controls.Add(this.pedidos);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fábrica de Calçados";
            this.pedidos.ResumeLayout(false);
            this.pedidos.PerformLayout();
            this.despesas.ResumeLayout(false);
            this.despesas.PerformLayout();
            this.saldo.ResumeLayout(false);
            this.saldo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pedidos;
        private System.Windows.Forms.TextBox valor_pedido;
        private System.Windows.Forms.TextBox cliente;
        private System.Windows.Forms.TextBox codproduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox despesas;
        private System.Windows.Forms.TextBox valor_despesa;
        private System.Windows.Forms.TextBox despesa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox saldo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button inserir;
        private System.Windows.Forms.ListView listpedidos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listdespesas;
        private System.Windows.Forms.Button novo;
        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.Label total_pedidos;
        private System.Windows.Forms.Label total_despesas;
        private System.Windows.Forms.Label lblsaldototal;
        private System.Windows.Forms.ColumnHeader itemcodigo;
        private System.Windows.Forms.ColumnHeader itemcliente;
        private System.Windows.Forms.ColumnHeader itemvalor;
        private System.Windows.Forms.ColumnHeader itemdespesas;
        private System.Windows.Forms.ColumnHeader itemvalordesp;
    }
}

