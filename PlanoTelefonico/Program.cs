using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoraTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {

            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());

            conta = 50.0;
            if (minutos > 100)
            {
                conta = conta + (minutos - 100) * 2.0;
            }

            Console.WriteLine("Valor a pagar: R$ " + conta);

        }
    }
}
