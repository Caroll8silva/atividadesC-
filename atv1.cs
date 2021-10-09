//Programa para transformar uma temperatura em Graus Celsius para Fahrenheit

using System;
// Questão 1- Maria Carolinne 
class atv1 {

static void Main(string[] args) {
        
 

    Console.WriteLine("Digite aqui a temperatura em Celsius");
    double temperaturaC = double.Parse(Console.ReadLine());

    double temperaturaF = temperaturaC * 18 / 10 + 32;

    Console.WriteLine(temperaturaC + " Em Fahrenheit é " + temperaturaF);
    
    }

}
