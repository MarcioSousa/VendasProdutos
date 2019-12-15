using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcessoBD;
using Transferencia;

namespace Negocios
{
    public class ClienteNegocios
    {
        AcessoSqlServer acessoDadosSql = new AcessoSqlServer();

        //Inserir, Alterar, Excluir, Consultar um(s) cliente(s) usando StoreProcedure
        public string Inserir(Pessoa cliente)
        {
            try
            {
                acessoDadosSql.LimparParametros();
                acessoDadosSql.AdicionarParametros("@cli_Nome", cliente.Nome);
                acessoDadosSql.AdicionarParametros("@cli_Logradouro", cliente.Logradouro);
                acessoDadosSql.AdicionarParametros("@cli_Numero", cliente.Numero);
                acessoDadosSql.AdicionarParametros("@cli_Bairro", cliente.Bairro);
                acessoDadosSql.AdicionarParametros("@cli_Cidade", cliente.Cidade);
                acessoDadosSql.AdicionarParametros("@cli_Uf", cliente.Uf);
                acessoDadosSql.AdicionarParametros("@cli_Cep", cliente.Cep);
                return acessoDadosSql.ExecutarManipulacao(CommandType.StoredProcedure, "usp_clienteInserir").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Alterar(Pessoa cliente)
        {
            try
            {
                acessoDadosSql.LimparParametros();
                acessoDadosSql.AdicionarParametros("@cli_Codigo", cliente.Codigo);
                acessoDadosSql.AdicionarParametros("@cli_Nome", cliente.Nome);
                acessoDadosSql.AdicionarParametros("@cli_Logradouro", cliente.Logradouro);
                acessoDadosSql.AdicionarParametros("@cli_Numero", cliente.Numero);
                acessoDadosSql.AdicionarParametros("@cli_Bairro", cliente.Bairro);
                acessoDadosSql.AdicionarParametros("@cli_Cidade", cliente.Cidade);
                acessoDadosSql.AdicionarParametros("@cli_Uf", cliente.Uf);
                acessoDadosSql.AdicionarParametros("@cli_Cep", cliente.Cep);
                return acessoDadosSql.ExecutarManipulacao(CommandType.StoredProcedure, "usp_clienteAlterar").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Excluir(Pessoa cliente)
        {
            try
            {
                acessoDadosSql.LimparParametros();
                acessoDadosSql.AdicionarParametros("@cli_Codigo", cliente.Codigo);
                return acessoDadosSql.ExecutarManipulacao(CommandType.StoredProcedure, "usp_clienteExcluir").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public ColCliente ConsultarPorNome(string nome)
        {
            try
            {
                //Criação de uma coleão nova de clientes (aqui está vazio)
                ColCliente clienteColecao = new ColCliente();

                acessoDadosSql.LimparParametros();
                acessoDadosSql.AdicionarParametros("@cli_Nome", nome);

                DataTable dataTablecliente = acessoDadosSql.ExecutarConsulta(CommandType.StoredProcedure, "usp_ClienteConsultarPorNome");

                //Faz um conjunto de coleção
                foreach (DataRow linha in dataTablecliente.Rows)
                {
                    //Criar um cliente vazio
                    Pessoa cliente = new Pessoa();

                    //Colocar os dados da linha nele
                    cliente.Codigo = Convert.ToInt32(linha["cli_Cod"]);
                    cliente.Nome = Convert.ToString(linha["cli_Nome"]);
                    cliente.DataCadastro = Convert.ToDateTime(linha["cli_DataCadastro"]);
                    cliente.Logradouro = Convert.ToString(linha["cli_Rua"]);
                    cliente.Numero = Convert.ToString(linha["cli_Numero"]);
                    cliente.Bairro = Convert.ToString(linha["cli_Bairro"]);
                    cliente.Cidade = Convert.ToString(linha["cli_Cidade"]);
                    cliente.Uf = Convert.ToString(linha["cli_Uf"]);
                    cliente.Cep = Convert.ToString(linha["cli_Cep"]);
                    cliente.Email = Convert.ToString(linha["cli_Email"]);
                    cliente.Contato = Convert.ToString(linha["cli_Contato"]);
                    cliente.Observacao = Convert.ToString(linha["cli_Observacao"]);
                    cliente.Ativo = Convert.ToBoolean(linha["cli_Ativo"]);
                    //Adicionar ele na coleção
                    clienteColecao.Add(cliente);
                }

                return clienteColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o cliente por Nome.\nDetalhes: " + ex.Message);
            }
        }
        public ColCliente ConsultarPorCodigo(int codigo)
        {
            try
            {
                //Criação de uma coleão nova de clientes (aqui está vazio)
                ColCliente clienteColecao = new ColCliente();

                acessoDadosSql.LimparParametros();
                acessoDadosSql.AdicionarParametros("@codCliente", codigo);

                DataTable dataTablecliente = acessoDadosSql.ExecutarConsulta(CommandType.StoredProcedure, "usp_ClienteConsultarPorId");

                //Faz um conjunto de coleção
                foreach (DataRow linha in dataTablecliente.Rows)
                {
                    //Criar um cliente vazio
                    Pessoa cliente = new Pessoa();

                    //Colocar os dados da linha nele
                    cliente.Codigo = Convert.ToInt32(linha["cli_Cod"]);
                    cliente.Nome = Convert.ToString(linha["cli_Nome"]);
                    cliente.DataCadastro = Convert.ToDateTime(linha["cli_DataCadastro"]);
                    cliente.Logradouro = Convert.ToString(linha["cli_Rua"]);
                    cliente.Numero = Convert.ToString(linha["cli_Numero"]);
                    cliente.Bairro = Convert.ToString(linha["cli_Bairro"]);
                    cliente.Cidade = Convert.ToString(linha["cli_Cidade"]);
                    cliente.Uf = Convert.ToString(linha["cli_Uf"]);
                    cliente.Cep = Convert.ToString(linha["cli_Cep"]);
                    cliente.Email = Convert.ToString(linha["cli_Email"]);
                    cliente.Contato = Convert.ToString(linha["cli_Contato"]);
                    cliente.Observacao = Convert.ToString(linha["cli_Observacao"]);
                    cliente.Ativo = Convert.ToBoolean(linha["cli_Ativo"]);

                    //Adicionar ele na coleção
                    clienteColecao.Add(cliente);
                }
                return clienteColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o cliente por Código.\nDetalhes: " + ex.Message);
            }
        }

    }
}