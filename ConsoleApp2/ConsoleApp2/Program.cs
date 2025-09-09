using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESA EL VALOR DE A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("INGRESA EL VALOR DE B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            if (A > B)
            {
                Console.WriteLine("EXECLENYTE ");

            }
            else if (A < B)
            {
                Console.WriteLine(" BRUTO ");






            }
        }
    }
}
