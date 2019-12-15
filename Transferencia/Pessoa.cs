using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transferencia
{
    public class Pessoa
    {
        public int Codigo { get; set; }
        private string _nome;
        public string Nome
        {
            get
            {
                return _nome.ToUpper();
            }

            set
            {
                _nome = value;
            }
        }
        public DateTime DataCadastro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string Email { get; set; }
        public string Contato { get; set; }
        public string Observacao { get; set; }
        public bool Ativo { get; set; }
    }
}
