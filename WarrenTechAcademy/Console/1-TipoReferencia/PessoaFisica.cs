using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
        public PessoaFisica(string name, string lastName, string cpf) : base(name, lastName)
        {
            this.Cpf = cpf;
        }
        
        public override string Saudacao()
        {
            return base.Saudacao()+ " - " + this.Cpf;
        }
    }
}
