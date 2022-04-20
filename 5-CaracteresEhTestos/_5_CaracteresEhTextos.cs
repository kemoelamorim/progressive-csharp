using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresEhTestos
{
    class _5_CaracteresEhTextos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string texto = "Iniciando C# em " + 2022;
            Console.WriteLine(texto);

            string cursosProgramacao = @" 
                - .NET
                - Java
                - JavaScript";
            Console.WriteLine(cursosProgramacao);   
        }
    }
}
