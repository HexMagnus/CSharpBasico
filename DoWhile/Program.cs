using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
  
        static void Main(string[] args){

            double C, F;
            char repetir = 's';

            while (repetir == 's')
            {
                Console.Write("Digite a temperatura em celsius: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                F = 9.0 * C / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Deseja repetir (s/n?");
                repetir = char.Parse(Console.ReadLine());

                Console.ReadLine();
                     }
                }
            }
        }
    

