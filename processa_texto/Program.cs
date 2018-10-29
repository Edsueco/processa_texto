using System;

namespace processa_texto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int opc;
            Console.WriteLine("Informe o nome completo: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe o nome completo: ");
            Console.WriteLine("1.Imprima o nome: ");
            Console.WriteLine("2.Imprima o 1o caractere: ");
            Console.WriteLine("3.Imprima a Quantidade de caractere: ");
            Console.WriteLine("4.Imprima o ultimo caractere: ");
            Console.WriteLine("5.Imprima até o 3 caractere: ");
            Console.WriteLine("6.Imprima o 4 caractere: ");
            Console.WriteLine("7.Imprima todos os caractere menos o primerio: ");
            Console.WriteLine("8.Imprima os dois ultimos caractere: ");
            opc = Int32.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine("Nome:" + nome);
                    break;
                case 2:
                    Console.WriteLine("1o Caractere: "+ nome.Substring(0, 1));
                    break;
                case 3:
                    Console.WriteLine("Quantidade de caractere: " + nome.Length);
                    break;
                case 4:
                    Console.WriteLine("Ultimo caractere: " + nome.Substring(nome.Length - 1, 1));
                    break;
                case 5:
                    Console.WriteLine("Até o 3 caractere: " + nome.Substring(0, 3));
                    break;
                case 6:
                    Console.WriteLine("O 4 caractere: " + nome.Substring(3, 1));
                    break;
                case 7:
                    Console.WriteLine("Todos os caractere menos o primerio: " + nome.Substring(1));
                    break;
                case 8:
                    Console.WriteLine("Os dois ultimos caractere: " + nome.Substring(nome.Length - 2));
                    break;
            }        
        }
    }
}
