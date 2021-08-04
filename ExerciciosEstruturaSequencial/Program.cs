using System;
using System.Globalization;

namespace ExerciciosEstruturaSequencial
{
    class Program
    {

        static void Main(string[] args)
        {
            //Faça um programa para ler dois valores inteiros,
            //e depois mostrar na tela a soma desses números com uma
            //mensagem explicativa, conforme exemplos.
            int num1, num2, soma;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            soma = num1 + num2;
            Console.WriteLine("SOMA = " + soma);

            //Faça um programa para ler o valor do raio de um círculo,
            //e depois mostrar o valor da área deste círculo com quatro
            //casas decimais conforme exemplos.
            //Fórmula da área: area = π.raio2
            //Considere o valor de π = 3.14159
            float area, raio;
            raio = float.Parse(Console.ReadLine());
            area = (float)3.14159 * (raio * raio);
            Console.Write("Area do círculo = ");
            Console.WriteLine(area.ToString("F4"), CultureInfo.InvariantCulture);

            //Fazer um programa para ler quatro valores inteiros A, B, C e D.
            //A seguir, calcule e mostre a diferença do produto
            //de A e B pelo produto de C e D
            //segundo a fórmula: DIFERENCA = (A * B - C * D).
            int v1, v2, v3, v4, difDoProd;
            v1 = int.Parse(Console.ReadLine());
            v2 = int.Parse(Console.ReadLine());
            v3 = int.Parse(Console.ReadLine());
            v4 = int.Parse(Console.ReadLine());
            difDoProd = (v1 * v2) - (v3 * v4);
            Console.Write("DIFERENÇA = ");
            Console.WriteLine(difDoProd.ToString("F4"), CultureInfo.InvariantCulture);



        }
    }
}
