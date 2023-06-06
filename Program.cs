using System; //Biblioteca que permite a utilização do fucoes matematicas entre outras;
using System.Globalization;  //Biblioteca que permite a convercao de um tipo de dado em outro, por exemplo de double para string;

int num, i = 1;

Console.WriteLine("Digite um numero intero"); //interface para o usuario
num = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//amazena o numero informado pelo usuario

while (num >= i)//verificacao da condicao de repeticao
{
    Console.WriteLine(i + "\n"); //mostra o valor de i na tela fazendo contagem até o numero que o usuario inseriu
    i++; //adiciona mais 1 ao valor de i
}