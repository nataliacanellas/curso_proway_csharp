using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._99_Exercicios
{
    internal class _000Cadastro
    {
        // Crie um sistema de cadastro de pessoas
        // 1 - O sistema deve exibir uma mensagem de boas vindas
        // 2 - Deve solicitar as seguintes informações ao usuário:
        //      Nome, Sobrenome e Idade
        // 3 - Ao fim da execução, deve exibir o nome completo e idade,
        // juntamente com mensagem de despedida.

        public static void Cadastro()
        {
            System.Console.WriteLine("Olá, seja bem vindo!");
            System.Console.Write("Digite o seu nome: ");
            string name = System.Console.ReadLine();
            System.Console.Write("Digite o seu sobrenome: ");
            string lastName = System.Console.ReadLine();
            System.Console.Write("Digite sua idade: ");
            byte age = Byte.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Seu nome completo é: " + name + " " + lastName);
            System.Console.WriteLine("Sua idade é: " + age + " anos, Até logo!");
            System.Console.ReadLine();

        }
    }
}
