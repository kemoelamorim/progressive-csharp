using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversaoDeTiposNumericos
{
    class _4_ConversaoDeTiposNumericos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convertendo tipos Numéricos Cast");
            // O long é uma variável de 64 bits
            long numero = 12000000010;
            long covertInt = numero;

            Console.WriteLine(covertInt);
            // O short é um tipo que de variável de 16 bits
            short qtdProdutos;
            qtdProdutos = 19999;
            Console.WriteLine(qtdProdutos);

            float altura = 1.81f;
            Console.WriteLine(altura);

            double x = 0.01;
            double y = 0.02;
            double total = x + y;
            Console.WriteLine(total);

            Console.ReadLine();

            int idade = 10 * 20;

        }
    }
}
