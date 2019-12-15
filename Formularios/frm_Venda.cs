using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Transferencia;

namespace Formularios
{
    public partial class frm_Venda : Form
    {
        public frm_Venda()
        {
            InitializeComponent();
        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            frm_PesqCliente pesqCliente = new frm_PesqCliente();
            pesqCliente.ShowDialog();
            txtCod.Text =Convert.ToString(pesqCliente.dgvClientes.Rows[pesqCliente.dgvClientes.CurrentRow.Index].Cells[0].Value);
            txtNome.Text = Convert.ToString(pesqCliente.dgvClientes.Rows[pesqCliente.dgvClientes.CurrentRow.Index].Cells[1].Value);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtCod.Text != "" && txtNome.Text != "")
            {
                MessageBox.Show("abre campos");
            }
            else
            {
                MessageBox.Show("Preencha o campo Codigo do Cliente e o Nome do Cliente para dar continuidade.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void frm_Venda_Load(object sender, EventArgs e)
        {
            atualizarGrid();
            if (dgvProduto.Rows.Count == 0)
            {
                //limparCampos();
            }
        }
        private void atualizarGrid()
        {
            ProdutoNegocios produtoNegocios = new ProdutoNegocios();
            ColProduto produtoColecao = produtoNegocios.ConsultarPorNome("");

            dgvProduto.DataSource = null;
            dgvProduto.DataSource = produtoColecao;

            dgvProduto.Update();
            dgvProduto.Refresh();
        }

    }
}
