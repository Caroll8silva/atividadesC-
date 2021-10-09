using System;
// Questão 6 - Maria Carolinne
class atv6
{

    static void Main(string[] args) 

{
    
    double custoCarro, precoFabrica, percentDistribuidor, percentImposto, lucroDistribuidor, imposto;
    
    escreve("Qual é o preço de fábrica do veículo?");
    precoFabrica = double.Parse(Console.ReadLine());
    escreve("Qual é o percentual de lucro do distribuidor?");
    percentDistribuidor = double.Parse(Console.ReadLine());
    escreve("Qual é o percentual de impostos?");
    percentImposto = double.Parse(Console.ReadLine());

    
    lucroDistribuidor = (precoFabrica * percentDistribuidor) / 100;
    imposto = (precoFabrica * percentImposto) / 100;
    custoCarro = precoFabrica + lucroDistribuidor + imposto;


    escreve("O lucro do distribuidor é " + lucroDistribuidor);
    escreve("O valor dos impostos é " + imposto);
    escreve( "O valor total do carro novo é " + custoCarro);

}
  
    static string escreve(string texto) 
{

    Console.WriteLine(texto);
    return texto;

}
 

}