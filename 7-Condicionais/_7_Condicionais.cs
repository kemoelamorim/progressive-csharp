﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class _7_Condicionais
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if(idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade. Pode entrar");
            }
            else
            {
                if(quantidadePessoas >= 2)
                {
                    Console.WriteLine("João está acompanhado, pode entrar!");
                }
                else
                {
                    Console.WriteLine("João não possui mais de 18 anos, não pode entrar");
                }
            }
        }
    }
}