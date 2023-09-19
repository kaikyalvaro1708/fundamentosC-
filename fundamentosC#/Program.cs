using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            //variáveis
            string name = "Kaiky";
            int idade = 19;

            Console.WriteLine($"Olá meu nome é {name} e tenho {idade} anos de idade");

            // ------------------------------------------------------------------------

            //outra forma de declarar variavel
            //Os dynamic são determinados apenas em tempo de execução
            dynamic cor_favorita = "Vermelho";

            Console.WriteLine(cor_favorita);

            cor_favorita = 2323133131 ; //mudou a variavel para int

            Console.WriteLine(cor_favorita);//saída: 2323133131

            cor_favorita = 212244.1881f; //mudou a var para float

            Console.WriteLine(cor_favorita); //212244.1881f

            // -----------------------------------------------------------------------
            //Entradas
            string nome = "";

            Console.WriteLine("Escreva seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: ");
            Console.WriteLine(nome);

            //Condicionais 
            // -----------------------------------------------------------------------
            Console.WriteLine("Digite sua nota: ");
            int nota = int.Parse(Console.ReadLine());

            if (nota > 8 && nota <= 10)
            {
                Console.WriteLine("Você passou, parabéns pelo esforço!");
            }
            else if (nota >= 6 && nota <= 8)
            {
                Console.WriteLine("Você passou, parabéns!");
            }
            else
            {
                Console.WriteLine("Você está reprovado!");
            }
            // -----------------------------------------------------------------------------
            //Funções

            static void ExibirMsg()
            {
                Console.WriteLine("Esse sistema é show!");
                Console.WriteLine("Estou usando funções!");
            }

            static void GerarPreco(string nome, int preco)
            {
                Console.WriteLine("Nome do produto: " + nome);
                int valorFinal = preco + (2 * preco);
                Console.WriteLine("Valor final: " + valorFinal);
            }

            ExibirMsg();
            GerarPreco("Curso de Inglês", 50);

            Console.ReadLine();
        }
    }
}