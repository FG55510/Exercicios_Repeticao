using System; //Biblioteca que permite a utilização do fucoes matematicas entre outras;
using System.Globalization; //Biblioteca que permite a convercao de um tipo de dado em outro, por exemplo de double para string;

namespace Course //Local do programa;
{
    public class program //Classe onde ficara o programa
    {
        public static void Main(string[] args) //Funcao principal do programa onde mostrara os resultados para o usuario;
        {
            Console.WriteLine(Soma(2,5));
            Console.WriteLine(Subtracao(2, 5));
            Console.WriteLine(Multiplicacao(2, 5));
            Console.WriteLine(Divisao(2, 5));
        }


        public static int Soma(int a, int b) //funcao que retorna numeros inteiros e recebe dois numeros inteiros as parametros;
        {
            return a + b; //funcao retorna o resultado da operacao;
        }

        public static int Subtracao(int a, int b) //funcao que retorna numeros inteiros e recebe dois numeros inteiros as parametros;
        {
            return a - b; //funcao retorna o resultado da operacao;
        }

        public static int Multiplicacao(int a, int b) //funcao que retorna numeros inteiros e recebe dois numeros inteiros as parametros;
        {
            return a * b; //funcao retorna o resultado da operacao;
        }

        public static int Divisao(int a, int b) //funcao que retorna numeros inteiros e recebe dois numeros inteiros as parametros;
        { 
            return a / b; //funcao retorna o resultado da operacao;
        }

    }
}