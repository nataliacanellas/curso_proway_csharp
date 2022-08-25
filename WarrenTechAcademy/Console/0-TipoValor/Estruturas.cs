using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor
{
    internal class Estruturas
    {
        public static void Executa()
        {
            PessoaClasse p1 = new PessoaClasse();
            p1.Name = "Joelma";
            PessoaStruct p2 = new PessoaStruct();
            p2.Name = "Chimbinha";
            System.Console.WriteLine(p1.Name);
            System.Console.WriteLine(p2.Name);

            PessoaClasse p3 = new PessoaClasse();
            p3 = p1;
            PessoaStruct p4 = new PessoaStruct();
            p4 = p2;
            System.Console.WriteLine(p3.Name);
            System.Console.WriteLine(p4.Name);
            p1.Name = "Joelma melhor dançarina > Shakira";
            p2.Name = "Chimbinha Guitarrista";
            System.Console.WriteLine("Valores Alterados!");
            System.Console.WriteLine(p1.Name);
            System.Console.WriteLine(p2.Name);
            System.Console.WriteLine(p3.Name);
            System.Console.WriteLine(p4.Name);

        }
    }
    struct PessoaStruct
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
    }
    class PessoaClasse
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
    }
}
