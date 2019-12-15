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
    public class ProdutoNegocios
    {
        AcessoSqlServer acessoDadosSql = new AcessoSqlServer();

        //Inserir, Alterar, Excluir, Consultar um(s) produto(s) usando StoreProcedure
        public string Inserir(Produto produto)
        {
            try
            {
                acessoDadosSql.LimparParametros();
                acessoDadosSql.AdicionarParametros("@pro_Nome", produto.Nome);
                acessoDadosSql.AdicionarParametros("@pro_Logradouro", produto.Descricao);
                acessoDadosSql.AdicionarParametros("@pro_Numero", produto.Preco);
                return acessoDadosSql.ExecutarManipulacao(CommandType.StoredProcedure, "usp_produtoInserir").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Alterar(Produto produto)
        {
            try
            {
                acessoDadosSql.LimparParametros();
                acessoDadosSql.AdicionarParametros("@cli_Codigo", produto.Codigo);
                acessoDadosSql.AdicionarParametros("@pro_Nome", produto.Nome);
                acessoDadosSql.AdicionarParametros("@pro_Logradouro", produto.Descricao);
                acessoDadosSql.AdicionarParametros("@pro_Numero", produto.Preco);
                return acessoDadosSql.ExecutarManipulacao(CommandType.StoredProcedure, "usp_produtoAlterar").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Excluir(Produto produto)
        {
            try
            {
                acessoDadosSql.LimparParametros();
                acessoDadosSql.AdicionarParametros("@cli_Codigo", produto.Codigo);
                return acessoDadosSql.ExecutarManipulacao(CommandType.StoredProcedure, "usp_produtoExcluir").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public ColProduto ConsultarPorNome(string nome)
        {
            try
            {
                //Criação de uma coleão nova de produtos (aqui está vazio)
                ColProduto produtoColecao = new ColProduto();

                acessoDadosSql.LimparParametros();
                acessoDadosSql.AdicionarParametros("@pro_Nome", nome);

                DataTable dataTableProduto = acessoDadosSql.ExecutarConsulta(CommandType.StoredProcedure, "usp_ProdutoConsultarPorNome");

                foreach (DataRow linha in dataTableProduto.Rows)
                {
                    Produto produto = new Produto();

                    produto.Codigo = Convert.ToInt32(linha["pro_Cod"]);
                    produto.Nome = Convert.ToString(linha["pro_Nome"]);
                    produto.Descricao = Convert.ToString(linha["pro_Descricao"]);
                    produto.Preco = Convert.ToDouble(linha["pro_Preco"]);

                    produtoColecao.Add(produto);
                }

                return produtoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o Produto pelo Nome.\nDetalhes: " + ex.Message);
            }
        }
        public ColProduto ConsultarPorCodigo(int codigo)
        {
            try
            {
                //Criação de uma coleão nova de produtos (aqui está vazio)
                ColProduto produtoColecao = new ColProduto();

                acessoDadosSql.LimparParametros();
                acessoDadosSql.AdicionarParametros("@codProduto", codigo);

                DataTable dataTableProduto = acessoDadosSql.ExecutarConsulta(CommandType.StoredProcedure, "usp_ProdutoConsultarPorId");

                //Faz um conjunto de coleção
                foreach (DataRow linha in dataTableProduto.Rows)
                {
                    //Criar um produto vazio
                    Produto produto = new Produto();

                    //Colocar os dados da linha nele
                    produto.Codigo = Convert.ToInt32(linha["pro_Cod"]);
                    produto.Nome = Convert.ToString(linha["pro_Nome"]);
                    produto.Descricao = Convert.ToString(linha["pro_Descricao"]);
                    produto.Preco = Convert.ToDouble(linha["pro_Preco"]);

                    //Adicionar ele na coleção
                    produtoColecao.Add(produto);
                }
                return produtoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o Produto por Código.\nDetalhes: " + ex.Message);
            }
        }
    }
}
