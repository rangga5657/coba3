using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "aplikasi calculator";

            Console.Write("inputkan niali a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("inputkan niali b = ");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("hasil penambahan" + a + "+" + b + " = " + penambahan(a, b));
            Console.WriteLine("hasil pengurangan {0} - {1} = {2}",a,b,pengurangan(a,b));
            Console.WriteLine("hasil perkalian {0} * {1} = {2}",a,b,perkalian(a, b));
            Console.WriteLine("hasil pembagian {0} / {1} = {2}",a,b,pembagian(a, b));

            Console.WriteLine("\ntekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}