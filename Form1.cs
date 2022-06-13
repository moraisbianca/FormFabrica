using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        double saldovenda, saldodespesas, saldoempresa = 0;

        private void saldototal()
        {
            saldoempresa = saldovenda - saldodespesas;
            lblsaldototal.Text = saldoempresa.ToString("C");
        }

        private void novo_Click(object sender, EventArgs e)
        {
            codproduto.Clear();
            cliente.Clear();
            valor_pedido.Clear();
            despesa.Clear();
            valor_despesa.Clear();
        }

        private void inserir_Click(object sender, EventArgs e)
        {
            //Lista de Pedidos
            ListViewItem item = new ListViewItem(codproduto.Text);
            item.SubItems.Add(cliente.Text);
            item.SubItems.Add(valor_pedido.Text);
            listpedidos.Items.Add(item);

            //Calculo
            double valor_pedidos = double.Parse(valor_pedido.Text);

            saldovenda += valor_pedidos;

            total_pedidos.Text = saldovenda.ToString("C");

            saldototal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Lista de Despesas
            ListViewItem item = new ListViewItem(despesa.Text);
            item.SubItems.Add(valor_despesa.Text);
            listdespesas.Items.Add(item);

            double valor_despesas = double.Parse(valor_despesa.Text);

            saldodespesas += valor_despesas;

            total_despesas.Text = saldodespesas.ToString("C");

            saldototal();
        }
    }
}
