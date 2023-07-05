using System;
namespace FelixBanco
{
    public class ContaCorrente

    {
        private int Agencia;
        private int Numero;

        public static double TaxaOperacao { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }

        public ContaCorrente(int agencia, int numero)
        {
            agencia = agencia;
            numero = numero;

            try 
            { 

                TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;

                Console.WriteLine("0 resultado é: " + TaxaOperacao);

            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("nao podemos dividir por 0");
                
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(9999,123456);
            ContaCorrente conta2 = new ContaCorrente(8888, 223456);
            ContaCorrente conta3 = new ContaCorrente(1111, 323456);


            Console.ReadLine();
        }
    }
}