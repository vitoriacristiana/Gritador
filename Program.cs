﻿using System;

namespace gritador
{
    class Program
    
    
{
        static void Main(string[] args)
        { 
            string fraseDigitada;
            Console.Write("Digite uma frase: ");
            fraseDigitada = Console.ReadLine();

            Console.WriteLine(fraseDigitada.ToUpper());

        }
    }
}
