/*
* 
* Autor: Gabriel Carneiro Marques Amado
* Questão 2)
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
    public static int LerNumUser()
    {
        int num;
        // Lê e checa caso o número lido não seja um inteiro válido por meio do TryParse. Enquanto não for, continua lendo.
        while (!int.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("Digite apenas números válidos. Tente novamente.\n");
        }
        return num;
    }

	public static void Main()
	{
        // Gerar a sequência a ser populada durante a execução:
        List<int> fib = new();

        // Será usada a abordagem iterativa da implementação da seq. de Fibonacci, 
        // por ser conveniente usar uma condicional para ir verificando a existência do número 
        // de análise na sequência.
        bool EstaNaSeqFib(int n)
        {
            fib.Add(0);
            fib.Add(1);

            // Casos triviais:
            if (n == 0 || n == 1) return true;

            // Só precisamos ir incrementando a sequência enquanto o número mais recente
            // for menor que o analisado.
            while (fib.Last() < n)
            {
                fib.Add(fib[fib.Count - 2] + fib.Last());
            }

            if (fib.Last() == n) return true;
            else return false;
        }

        while (true)
        {
            Console.Clear();
            fib.Clear();
            Console.WriteLine("==== Está na sequência Fibonacci? ====\n");
            Console.WriteLine("Insira um número inteiro e aperte ENTER. " +
                              "\nO programa verificará se ele pertence à sequência Fibonacci");
            Console.WriteLine("\n======================================\n\n");

            Console.Write("> ");
            int num = LerNumUser();

            if (EstaNaSeqFib(num))
                Console.WriteLine("\nO número " + num + " ESTÁ presente na sequência!");
            else
                Console.WriteLine("\nO número " + num + " NÃO está presente na sequência!");

            Console.WriteLine("A sequência gerada foi: ");
            foreach (int n in fib) Console.Write(n + " ");

            Console.WriteLine("\n\n\nPressione qualquer tecla para rodar novamente");
            Console.ReadKey(true);
        }
	}
}