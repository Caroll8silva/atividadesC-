using System;
// Questão 9 - Maria Carolinne
class atv9
{

    static void Main(string[] args) 

{
     
    int numero = 4;

    switch (numero)
    {
        case 1: 
        escreve("Seu será presente uma bola");
        break;

        case 2: 
        escreve("Seu presente será um baralho");
        break;

        case 3:
        escreve("Seu presente será um notebook");
        break;

        case 4:
        escreve("Seu presente será um Playstation 4");
        break;

        
    }
}



    static string escreve(string texto) 
{

    Console.WriteLine(texto);
    return texto;

}

}