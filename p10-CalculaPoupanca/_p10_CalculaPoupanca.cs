using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _p10_CalculaPoupanca
{
    class _p10_CalculaPoupanca
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - calcula poupança");
            double valorInvestido = 10000;

            int contadorMes = 1;
            while (contadorMes <= 12)
            {

                // 0.36% = 0.0036
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " mês, você terá R$ " + valorInvestido);
                contadorMes++;
            }


        }
    }
}
