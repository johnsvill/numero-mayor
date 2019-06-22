using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Ingrese primer número : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese segundo número:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese tercer número: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            if(num1 > num2 && num1 > num3)
            {
                Console.WriteLine("El número mayor es: {0}", num1);
            }
            else
            {
                if(num2 > num1 && num2 > num3)
                {
                    Console.WriteLine("El número mayor es: {0}", num2);
                }
                else
                {
                    Console.WriteLine("El número mayor es: {0}", num3);
                }
            }
            Console.ReadKey();
        }
    }
}
