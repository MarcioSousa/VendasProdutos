using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frm_Cliente cliente = new frm_Cliente();
            cliente.ShowDialog();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frm_Produto produto = new frm_Produto();
            produto.ShowDialog();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            frm_Venda venda = new frm_Venda();
            venda.ShowDialog();
        }
    }
}
