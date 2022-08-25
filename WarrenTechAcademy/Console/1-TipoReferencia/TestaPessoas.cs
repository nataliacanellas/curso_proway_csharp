using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class TestaPessoas
    {
        public static void ExecutaPessoa()
        {
            Pessoa p = new Pessoa("Natalia", "Canellas");
            Pessoa p1 = new PessoaFisica("Lorena", "Canellas", "958473628478");
            Pessoa p2 = new PessoaJuridica("Warren", "Tech", "029498239/04988");

            PessoaFisica pf1 = (PessoaFisica)p1;
            PessoaJuridica pj2 = (PessoaJuridica)p2;

            BaseRepository repository = new BaseRepository();
            repository.Create(p);
            repository.Create(pf1);
            repository.Create(pj2);
            foreach (var pessoa in repository.Read())
            {
                System.Console.WriteLine(pessoa.Saudacao());
            }
        }
        public static void ExecutaPessoaFisica()
        {
            PessoaFisica pessoaFisica = new PessoaFisica("Natalia", "Canellas", "08968574876");
            PessoaFisica pessoaFisica2 = new PessoaFisica("Lorena", "Canellas", "12468465859"); 
            BaseRepository repository = new BaseRepository();
            System.Console.WriteLine(repository.Create(pessoaFisica));
            repository.Create(pessoaFisica2);
            List<Pessoa> pessoasF = repository.Read();
            foreach (PessoaFisica p in pessoasF)
            {
                System.Console.WriteLine(p.Saudacao());
            }
        }
        public static void ExecutaPessoaJuridica()
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica("Cooper", "Supermercado", "392748324203982");
            PessoaJuridica pessoaJuridica2 = new PessoaJuridica("Angeloni", "Supermercaro", "39283479244203982");
            BaseRepository repository = new BaseRepository();
            System.Console.WriteLine(repository.Create(pessoaJuridica));
            repository.Create(pessoaJuridica2);
            List<Pessoa> pessoasJ = repository.Read();
            foreach (PessoaJuridica p in pessoasJ)
            {
                System.Console.WriteLine(p.Saudacao());
            }
        }
    }
}
