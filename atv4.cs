using System;
// Questão 4 - Maria Carolinne
class atv2 
{

static void Main(string[] args) 

{
    const double pi = 3.1415f;

    Console.WriteLine("Digite o Raio do círculo");
    double raio = double.Parse(Console.ReadLine());

    double calcRaio = Math.Pow(raio, 2);
    double area = pi * calcRaio;

    Console.WriteLine("A area do círculo é " + area);
}
  
 

}