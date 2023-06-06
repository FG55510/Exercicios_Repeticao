using System; //Biblioteca que permite a utilização do fucoes matematicas entre outras;
using System.Globalization;  //Biblioteca que permite a convercao de um tipo de dado em outro, por exemplo de double para string;
string continua;
do
{//codigo que sera executado e repetido
    float num1, num2, resultado;
    string op;

    Console.WriteLine("Informe a operacao +, -, *, /: "); //interface para o usuario
    op = Console.ReadLine(); //amazena a string informada pelo usuario
    Console.WriteLine("Informe a operacao dois numeros :"); //interface para o usuario

    num1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //amazena o numero informado pelo usuario
    num2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//amazena o numero informado pelo usuario


    switch (op)
    { //Executa e mostra operacao para o usuario seguindo o caso de qual operador foi dado

        case "+":
            resultado = num1 + num2; //calcula o resultado da operacao;
            Console.WriteLine(num1 + " + " + num2 + " = " + resultado);//mostra o resultado para o usuario;
        break;

        case "-":
            resultado = num1 - num2;
            Console.WriteLine(num1 + " - " + num2 + " = " + resultado);
            break ;

        case "*":
            resultado = num1 * num2;
            Console.WriteLine(num1 + " * " + num2 + " = " + resultado);
        break;

        case "/":
            resultado = num1 / num2;
            Console.WriteLine(num1 + " / " + num2 + " = " + resultado);
        break;
        
        default:
            Console.WriteLine("Erro! insira outro operador!"); //mensagem de erro caso o operador seja invalido;
            break ;
    }

    Console.WriteLine(" \nVoce deseja continuar? s/n: "); //interface para o usuario informar se quer continuar;
    continua = Console.ReadLine(); //amazena a string informada pelo usuario

}
while (continua == "s" || continua == "S"); //verificacao da condicao de repeticao