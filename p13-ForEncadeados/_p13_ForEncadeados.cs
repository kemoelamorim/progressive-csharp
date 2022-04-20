using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _p13_ForEncadeados
{
    internal class _p13_ForEncadeados
    {
        static void Main(string[] args)
        {
            string asterisco = "*";
            Console.WriteLine("Executadno o projeto 13 - For Encadeados");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(asterisco);

                    if (j >= i)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
