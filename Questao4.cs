/*
* 
* Autor: Gabriel Carneiro Marques Amado
* Questão 4)
* 
* Linguagem: C# 10.0 (.NET 6.0)
* Sobre os acentos: alguns compiladores e debuggers online podem não suportar os acentos.
*/ 

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        double SP = 67836.43;
        double RJ = 36678.66;
        double MG = 29229.88;
        double ES = 27165.48;
        double outros = 19849.53;

        double total = SP + RJ + MG + ES + outros;

        double percentSP = (SP / total) * 100;
        double percentRJ = (RJ / total) * 100;
        double percentMG = (MG / total) * 100;
        double percentES = (ES / total) * 100;
        double percentOutros = (outros / total) * 100;

        Console.WriteLine("O percentual de representação que SP teve dentro do total foi de aproximadamente " + percentSP.ToString("N2") + "%");
        Console.WriteLine("O percentual de representação que RJ teve dentro do total foi de aproximadamente " + percentRJ.ToString("N2") + "%");
        Console.WriteLine("O percentual de representação que MG teve dentro do total foi de aproximadamente " + percentMG.ToString("N2") + "%");
        Console.WriteLine("O percentual de representação que ES teve dentro do total foi de aproximadamente " + percentES.ToString("N2") + "%");
        Console.WriteLine("O percentual de representação que OUTROS tiveram dentro do total foi de aproximadamente " + percentOutros.ToString("N2") + "%");
    }
}