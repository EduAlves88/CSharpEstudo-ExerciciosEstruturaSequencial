using System;


//Faça um programa para ler dois valores inteiros,
//e depois mostrar na tela a soma desses números com uma
//mensagem explicativa, conforme exemplos.
namespace ExerciciosEstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, soma;

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}
