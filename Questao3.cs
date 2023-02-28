/*
* 
* Autor: Gabriel Carneiro Marques Amado
* Questão 3)
* 
* Linguagem: C# 10.0 (.NET 6.0)
* Sobre os acentos: alguns compiladores e debuggers online podem não suportar os acentos.
*/ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public class Program
{
    public class FaturamentoDia
    {
        // Getters estão em minúsculo pois a ferramenta System.Text.Json é case-sensitive 
        // em relação às keys do JSON.
        public int dia { get; set; }
        public double valor { get; set; }
    }

    public static void Main()
    {
        Console.WriteLine("==== Faturamento diário ====");
        Console.WriteLine("\nLendo os dados do arquivo dados.json...");

        string conteudoJson = @"[
        	{
        		""dia"": 1,
        		""valor"": 22174.1664
        	},
        	{
        		""dia"": 2,
        		""valor"": 24537.6698
        	},
        	{
        		""dia"": 3,
        		""valor"": 26139.6134
        	},
        	{
        		""dia"": 4,
        		""valor"": 0.0
        	},
        	{
        		""dia"": 5,
        		""valor"": 0.0
        	},
        	{
        		""dia"": 6,
        		""valor"": 26742.6612
        	},
        	{
        		""dia"": 7,
        		""valor"": 0.0
        	},
        	{
        		""dia"": 8,
        		""valor"": 42889.2258
        	},
        	{
        		""dia"": 9,
        		""valor"": 46251.174
        	},
        	{
        		""dia"": 10,
        		""valor"": 11191.4722
        	},
        	{
        		""dia"": 11,
        		""valor"": 0.0
        	},
        	{
        		""dia"": 12,
        		""valor"": 0.0
        	},
        	{
        		""dia"": 13,
        		""valor"": 3847.4823
        	},
        	{
        		""dia"": 14,
        		""valor"": 373.7838
        	},
        	{
        		""dia"": 15,
        		""valor"": 2659.7563
        	},
        	{
        		""dia"": 16,
        		""valor"": 48924.2448
        	},
        	{
        		""dia"": 17,
        		""valor"": 18419.2614
        	},
        	{
        		""dia"": 18,
        		""valor"": 0.0
        	},
        	{
        		""dia"": 19,
        		""valor"": 0.0
        	},
        	{
        		""dia"": 20,
        		""valor"": 35240.1826
        	},
        	{
        		""dia"": 21,
        		""valor"": 43829.1667
        	},
        	{
        		""dia"": 22,
        		""valor"": 18235.6852
        	},
        	{
        		""dia"": 23,
        		""valor"": 4355.0662
        	},
        	{
        		""dia"": 24,
        		""valor"": 13327.1025
        	},
        	{
        		""dia"": 25,
        		""valor"": 0.0
        	},
        	{
        		""dia"": 26,
        		""valor"": 0.0
        	},
        	{
        		""dia"": 27,
        		""valor"": 25681.8318
        	},
        	{
        		""dia"": 28,
        		""valor"": 1718.1221
        	},
        	{
        		""dia"": 29,
        		""valor"": 13220.495
        	},
        	{
        		""dia"": 30,
        		""valor"": 8414.61
        	}
        ]";

        List<FaturamentoDia> faturamentoMes = JsonSerializer.Deserialize<List<FaturamentoDia>>(conteudoJson);

        FaturamentoDia maiorFat = new();
        FaturamentoDia menorFat = new();

        maiorFat.valor = 0;
        menorFat.valor = 999999999;

        double mediaMensal = 0; 
        int diasDesconsiderados = 0;

        foreach (FaturamentoDia fat in faturamentoMes)
        {
            if (fat.valor != 0 && fat.valor > maiorFat.valor) 
                maiorFat = fat;
            else if (fat.valor != 0 && fat.valor < menorFat.valor) 
                menorFat = fat;

            if (fat.valor == 0)
                diasDesconsiderados++;

            mediaMensal += fat.valor;
        }

        mediaMensal /= 30 - diasDesconsiderados;

        int numDiasFatAcimaMedia = 0;
        foreach(FaturamentoDia fat in faturamentoMes)
        {
            if (fat.valor != 0 && fat.valor > mediaMensal)
                numDiasFatAcimaMedia++;
        }

        Console.WriteLine("\n\nO menor valor de faturamento ocorrido em um dia válido do mês foi de R$ " + menorFat.valor.ToString("N4"));
        Console.WriteLine("O maior valor de faturamento ocorrido em um dia válido do mês foi de R$ " + maiorFat.valor.ToString("N4"));
        Console.WriteLine("A média do mês foi de R$ " + mediaMensal.ToString("N4"));
        Console.WriteLine("O número de dias válidos com faturamento acima da média do mês foi de " + numDiasFatAcimaMedia.ToString());
    }
}