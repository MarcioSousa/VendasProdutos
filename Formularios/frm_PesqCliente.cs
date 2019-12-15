using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transferencia;
using Negocios;

namespace Formularios
{
    public partial class frm_PesqCliente : Form
    {
        public frm_PesqCliente()
        {
            InitializeComponent();
            dgvClientes.AutoGenerateColumns = false;
        }

        private void carregaGrid()
        {
            if(dgvClientes.SelectedRows.Count == 0)
            {
                return;
            }

            Pessoa cliente = (dgvClientes.SelectedRows[0].DataBoundItem as Pessoa);

        }
        private void atualizaGrid()
        {
            ClienteNegocios clienteNegocios = new ClienteNegocios();

            if(Convert.ToString(txtClientePesquisar.Text.Trim()) != "")
            {
                if (char.IsDigit(txtClientePesquisar.Text[0]))
                {
                    ColCliente clienteColecao = clienteNegocios.ConsultarPorCodigo(Convert.ToInt32(txtClientePesquisar.Text));
                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = clienteColecao;
                }
                else
                {
                    ColCliente clienteColecao = clienteNegocios.ConsultarPorNome(txtClientePesquisar.Text.Trim());
                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = clienteColecao;
                }
            }
            else
            {
                ColCliente clienteColecao = clienteNegocios.ConsultarPorNome(txtClientePesquisar.Text.Trim());
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = clienteColecao;
            }

            dgvClientes.Update();
            dgvClientes.Refresh();
        }

        private void frm_PesqCliente_Load(object sender, EventArgs e)
        {
            carregaGrid();
            atualizaGrid();
        }
        private void txtClientePesquisar_TextChanged(object sender, EventArgs e)
        {
            atualizaGrid();
        }
        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            //frm_Venda venda = new frm_Venda();
            //MessageBox.Show(Convert.ToString(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value));
            //MessageBox.Show(Convert.ToString(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[1].Value));
            //venda.txtCod.Text = Convert.ToString(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value);
            this.Close();
        }
    }
}