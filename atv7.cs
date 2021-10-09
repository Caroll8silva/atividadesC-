using System;
// Questão 7 - Maria Carolinne
class atv7
{

    static void Main(string[] args) 

{
    
 double alturaDegrau, alturaUsuario;

    escreve("Digite a altura que você quer alcançar");
    alturaUsuario = double.Parse(Console.ReadLine());

    escreve("Digite a altura do degrau da escada");
    alturaDegrau = double.Parse(Console.ReadLine());

    escreve("Você deverá subir " + (alturaUsuario / alturaDegrau) + " degraus para alcançar a altura desejada");


}

    static string escreve(string texto) 
{

    Console.WriteLine(texto);
    return texto;

}

}