using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Negocios;
using Transferencia;
using Correios.Net;

namespace Formularios
{
    public partial class frm_Cliente : Form
    {
        AcaoNaTela acaoNaTela = new AcaoNaTela();

        public frm_Cliente()
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

            txtNome.Text = cliente.Nome;
            txtEndereco.Text = cliente.Logradouro;
            txtBairro.Text = cliente.Bairro;
            txtCidade.Text = cliente.Cidade;
            cbxUf.Text = cliente.Uf;

            if(cliente.Cep != "0")
            {
                mtbCep.Text = Convert.ToString(cliente.Cep);
            }
            else
            {
                mtbCep.Text = "";
            }
            
            if(cliente.Contato != "0")
            {
                mtbContato.Text = Convert.ToString(cliente.Contato);
            }
            else
            {
                mtbContato.Text = "";
            }
        }
        private void atualizarGrid()
        {
            ClienteNegocios clienteNegocios = new ClienteNegocios();
            ColCliente clienteColecao = clienteNegocios.ConsultarPorNome(txtClientePesquisar.Text);

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clienteColecao;

            dgvClientes.Update();
            dgvClientes.Refresh();

            dataGridVazio();
        }
        private void limparCampos()
        {
            txtNome.Text = "";
            dtpCadastro.Value = DateTime.Today;
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            cbxUf.Text = "SP";
            mtbCep.Text = "";
            mtbContato.Text = "";
        }
        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cbxUf.Enabled = true;
            mtbContato.Enabled = true;
            mtbCep.Enabled = true;

            btnConfirma.Enabled = true;
            btnCancela.Enabled = true;
            btnPesquisaCliente.Enabled = true;

            btnPesquisaCliente.Enabled = false;
            txtClientePesquisar.Enabled = false;
            dgvClientes.Enabled = false;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

            txtNome.Focus();
        }
        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            cbxUf.Enabled = false;
            mtbCep.Enabled = false;
            mtbContato.Enabled = false;

            btnConfirma.Enabled = false;
            btnCancela.Enabled = false;
            btnPesquisaCliente.Enabled = false;

            btnPesquisaCliente.Enabled = true;
            txtClientePesquisar.Enabled = true;
            dgvClientes.Enabled = true;
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }
        private void dataGridVazio()
        {
            if(dgvClientes.Rows.Count == 0)
            {
                btnExcluir.Enabled = false;
                btnEditar.Enabled = false;
                limparCampos();
            }
            else
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }
        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            carregaGrid();
        }
        private void localizarCep()
        {
            if (!string.IsNullOrWhiteSpace(mtbCep.Text))
            {
                Address endereco = SearchZip.GetAddress(mtbCep.Text);

                if(endereco.Zip != null)
                {
                    txtEndereco.Text = endereco.Street;
                    txtBairro.Text = endereco.District;
                    txtCidade.Text = endereco.City;
                    cbxUf.Text = endereco.State;
                }
                else
                {
                    MessageBox.Show("Cep não localizado...");
                }

            }
            else
            {
                MessageBox.Show("Informe um Cep Válido...");
            }
        }

        private void frm_Cliente_Load(object sender, EventArgs e)
        {
            dataGridVazio();
        }
        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            localizarCep();
        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            atualizarGrid();
            if(dgvClientes.Rows.Count == 0)
            {
                limparCampos();
            }
            dataGridVazio();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            limparCampos();

            acaoNaTela = AcaoNaTela.Inserir;
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            acaoNaTela = AcaoNaTela.Alterar;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Cliente foi selecionado!");
                return;
            }
            if(MessageBox.Show("Deseja Excluir o Cliente selecionado da lista?", "Exclusão",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Pessoa clienteSelecionado = (dgvClientes.SelectedRows[0].DataBoundItem as Pessoa);
                ClienteNegocios clienteNegocios = new ClienteNegocios();
                string retorno = clienteNegocios.Excluir(clienteSelecionado);

                try
                {
                    int codcli = Convert.ToInt32(retorno);
                    MessageBox.Show("Cliente Deletado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizarGrid();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível excluir. Detalhes: " + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if(acaoNaTela == AcaoNaTela.Inserir)
            {
                try
                {
                    string Cep;
                    Cep = mtbCep.Text.Replace("-", "");

                    Pessoa cliente = new Pessoa();
                    cliente.Nome = txtNome.Text;
                    cliente.Logradouro = txtEndereco.Text;
                    cliente.Numero = txtNumero.Text;
                    cliente.Bairro = txtBairro.Text;
                    cliente.Cidade = txtCidade.Text;
                    cliente.Uf = cbxUf.Text;
                    cliente.Cep = Convert.ToString(mtbCep.Text.Replace("-", ""));
                    cliente.Contato = Convert.ToString(mtbContato.Text.Replace("(", "").Replace(") ", "").Replace("-", ""));

                    ClienteNegocios clienteNegocios = new ClienteNegocios();
                    string retorno = clienteNegocios.Inserir(cliente);

                    try
                    {
                        int idCliente = Convert.ToInt32(retorno);
                        MessageBox.Show("Cliente inserido com Sucesso. \nCódigo do cliente: " + idCliente, "Código do Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        desabilitarCampos();
                        atualizarGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível adicionar o Cliente.\nTente novamente.\nAviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível adiconar um novo Cliente.\nPreencha todos os campos Corretamente.\nErro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(acaoNaTela == AcaoNaTela.Alterar)
            {
                try
                {
                    Pessoa cliente = new Pessoa();
                    cliente.Codigo = Convert.ToInt32(txtCod.Text);
                    cliente.Nome = txtNome.Text;
                    cliente.Logradouro = txtEndereco.Text;
                    cliente.Numero = txtNumero.Text;
                    cliente.Bairro = txtBairro.Text;
                    cliente.Cidade = txtCidade.Text;
                    cliente.Uf = cbxUf.Text;
                    cliente.Cep = Convert.ToString(mtbCep.Text.Replace("-", ""));
                    cliente.Contato = Convert.ToString(mtbContato.Text.Replace("(", "").Replace(") ", "").Replace("-", ""));

                    ClienteNegocios clienteNegocios = new ClienteNegocios();
                    string retorno = clienteNegocios.Alterar(cliente);

                    try
                    {
                        int idCliente = Convert.ToInt32(retorno);
                        MessageBox.Show("Cliente Alterado com Sucesso.\nCódigo do Cliente: " + idCliente, "Código do Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        desabilitarCampos();
                        atualizarGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possíve Alterar o Cliente.\nTente novamente.\nAviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível Alterar o Cliente.\nErro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            desabilitarCampos();
            carregaGrid();
            dataGridVazio();
        }
    }
}