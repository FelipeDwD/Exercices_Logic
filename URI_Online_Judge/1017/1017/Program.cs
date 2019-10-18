﻿using System;
using System.Globalization;

namespace _1017
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             Nível 1 
             
              Joaozinho quer calcular e mostrar a quantidade de litros de combustível gastos em uma viagem, ao utilizar 
              um automóvel que faz 12 KM/L. Para isso, ele gostaria que você o auxiliasse através de um simples programa. 
              Para efetuar o cálculo, deve-se fornecer o tempo gasto na viagem (em horas) e a velocidade média durante a mesma (em km/h). 
              Assim, pode-se obter distância percorrida e, em seguida, calcular quantos litros seriam necessários. 
              Mostre o valor com 3 casas decimais após o ponto.

                Entrada
                O arquivo de entrada contém dois inteiros. O primeiro é o tempo gasto na viagem (em horas) e o segundo é a velocidade média durante a mesma (em km/h).

                Saída
                Imprima a quantidade de litros necessária para realizar a viagem, com três dígitos após o ponto decimal
             **/


            double media_litro = 0.0;

            Console.Write("Digite o tempo médio (horas) que irá ser gasto na viagem: ");
            double horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a média de quantos km/h você irá fazer: ");
            double km_h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Seu carro faz quantos km em média por litro? ");
            int km_l = int.Parse(Console.ReadLine());

            media_litro = (horas * km_h) / km_l;

            Console.WriteLine($"{media_litro.ToString("F3", CultureInfo.InvariantCulture)}");


        }
    }
}
