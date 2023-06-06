using System; //Biblioteca que permite a utilização do fucoes matematicas entre outras;
using System.Globalization;  //Biblioteca que permite a convercao de um tipo de dado em outro, por exemplo de double para string;

int num;



Console.WriteLine("Digite um numero intero"); //interface para o usuario
num = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//amazena o numero informado pelo usuario

Console.WriteLine("Os primeiros " + num + " numeros pares sao:\n");//interface para o usuario informando o que ira acontecer

for (int i= 2; i <= num * 2; i+=2) //para cada vez que o codigo for executado, i que eh o parametro da repeticao sera adicionado de mais 2
{
    Console.WriteLine(i + "\n"); //mostra o valor de i na tela fazendo contagem até o numero que o usuario inseriu
}