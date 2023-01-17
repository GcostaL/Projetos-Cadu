using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadu_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero;

            Console.WriteLine("Digite um número:");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 0)
            {

                Console.WriteLine("O número é igual a Zero");

            }

            else
            {
                Console.WriteLine("O numero não é igual a Zero");
            }


        }
    }
}
