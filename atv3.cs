//Programa para ler um número. se for posítivo, imprimir a raiz quadrada, senão imprimir o quadrado.

using System;
// Questão 3 - Maria Carolinne
class atv2 
{

static void Main(string[] args) 

{
    
    Console.WriteLine("Digite um número");
    double numero = double.Parse(Console.ReadLine());

    double resultado;

    if(numero > 0.0)
    
    {
        resultado = Math.Sqrt(numero);
        Console.WriteLine(resultado);
    }
    else 
    {
        resultado = Math.Pow(numero, 2);
       Console.WriteLine(resultado);
    }
}
  
 

}
