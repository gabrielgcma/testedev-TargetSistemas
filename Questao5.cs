/*
* 
* Autor: Gabriel Carneiro Marques Amado
* Questão 5)
* 
* Linguagem: C# 10.0 (.NET 6.0)
* Sobre os acentos: alguns compiladores e debuggers online podem não suportar os acentos.
* Alguns compiladores e debuggers online também não aceitam Console.ReadKey(). Rodar este código
* em implementação local de um Console app.
*/ 

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Digite uma frase e pressione ENTER:");
            Console.Write("> ");

            string str = Console.ReadLine();

            string str_reverse = "";

            for (int i = str.Length - 1; i >= 0; i--)
                str_reverse += str[i];

            Console.WriteLine("\n\nA string revertida:");
            Console.WriteLine(str_reverse);

            Console.WriteLine("\n\n\nPressione qualquer tecla para repetir");
            Console.ReadKey(true);
        }
    }
}