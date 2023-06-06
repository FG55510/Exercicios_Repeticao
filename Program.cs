using System; //Biblioteca que permite a utilização do fucoes matematicas entre outras;
using System.Globalization;  //Biblioteca que permite a convercao de um tipo de dado em outro, por exemplo de double para string;

int num;

do
{//codigo que sera executado e repetido
    Console.WriteLine("Digite um numero de 1 a 10: "); //interface para o usuario
    num = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //amazena o numero informado pelo usuario
}
while (num < 1 || num > 10); //verificacao da condicao de repeticao

Console.WriteLine("Voce digitou o numero " + num); //mostra o valor de i na tela fazendo contagem até o numero que o usuario inseriu