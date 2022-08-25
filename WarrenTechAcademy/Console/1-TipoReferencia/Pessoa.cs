using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class Pessoa
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public Pessoa(string name, string lastName)
        {
            this.Name = name;
            this.LastName = lastName;
        }
        virtual
        public string Saudacao()
        {
            return ("Olá, "+ this.Name + " " + this.LastName);
        }
    }
}
