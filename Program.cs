using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NothingAndAll
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(Euler.SumOfSquares(1, 10));
            //Console.WriteLine(Euler.SumOfSquared(1, 100) - Euler.SumOfSquares(1, 100));
            //Console.WriteLine(Euler.PrimeNumbers(1, 10001));
            //Console.WriteLine(Euler.FindBiggest("D:/Programowanie/NothingAndAll/tdigits.txt", "13"));
            //Console.WriteLine(Euler.Pytagoras(1000));
            Console.WriteLine(Euler.SummationOfPrimes(4, 2000000));
            Console.ReadLine();
        }
    }
}
