//Programa para calcular um salário.

using System;
// Questão 8 - Maria Carolinne
class atv8
{

    static void Main(string[] args) 

{
    
 double horasTrab, salarioMin, valorHoraTrab, salarioBruto, imposto, salarioLiq;


        escreve("Digite o número de horas trabalhadas");
        horasTrab = double.Parse(Console.ReadLine());

        escreve("Digite o valor do salario mínimo");
        salarioMin = double.Parse(Console.ReadLine());

    valorHoraTrab = salarioMin / 2;
    salarioBruto = horasTrab * valorHoraTrab;
    imposto = salarioBruto * 0.03;
    salarioLiq = salarioBruto - imposto;

        escreve("O salário a receber é de " + salarioLiq + " reais.");
}



    static string escreve(string texto) 
{

    Console.WriteLine(texto);
    return texto;

}

}
