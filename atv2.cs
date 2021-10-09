//Programa para calcular o salário líquido de um professor.

using System;
// Questão 2 - Maria Carolinne
class atv2 
{

static void Main(string[] args) 
{

    int numAula; 
    float salarioBruto, valorInss, valorAula, salarioLiquido, descInss;

   Console.WriteLine("Digite o número de aulas dadas");
   numAula = int.Parse(Console.ReadLine());

   Console.WriteLine("Digite o valor de uma aula");
   valorAula = float.Parse(Console.ReadLine());

   Console.WriteLine("Digite o valor a ser descontado pelo INSS em %");
   valorInss = float.Parse(Console.ReadLine());

    salarioBruto = numAula * valorAula;
    descInss = salarioBruto * (valorInss / 100.0f);
    salarioLiquido = salarioBruto - descInss;

    Console.WriteLine("Seu salário líquido é $" + salarioLiquido);

}
  
 

}
