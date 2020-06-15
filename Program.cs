using System;

namespace sinais
{
    class Program
    {
        static void Main(string[] args)
        {
              int numero;
          Console.WriteLine("digite um numero:");
          numero = Convert.ToInt16(Console.ReadLine());

            if(numero > 0)
            {
                Console.WriteLine("positivo");
            }
            if(numero < 0)
            {
                Console.WriteLine("negativo");
            }
            else if (numero == 0)
            {
                Console.WriteLine("zero");
            }

        }
    }
}
