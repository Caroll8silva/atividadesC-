//Programa para calcular a idade de uma pessoa e a idade que ela terá em 2022.

using System;
// Questão 5 - Maria Carolinne
class atv5
{

static void Main(string[] args) 

{
   int anoNascimento, anoAtual;
   
   Console.WriteLine("Digite o ano do seu nascimento");
   anoNascimento = int.Parse(Console.ReadLine());

   Console.WriteLine("Digite o ano atual");
   anoAtual = int.Parse(Console.ReadLine());

   Console.WriteLine("Sua idade é: " + (anoAtual - anoNascimento) + " anos");
  
   Console.WriteLine("Em 2022 você terá: " + (2022 - anoNascimento) + " anos");

}
  
 

}
