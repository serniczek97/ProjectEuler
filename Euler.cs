using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NothingAndAll
{
    class Euler
    {
        /// <summary>
        /// Returns the sum of squared numbers in the given space
        /// </summary>
        /// <param name="minNumber"></param>
        /// <param name="MaxNumber"></param>
        /// <returns></returns>
        public static int SumOfSquares(int minNumber, int MaxNumber)
        {
            int score = 0;
            for (int i = minNumber; i < MaxNumber + 1; i++)
            {
                score += i*i;
            }
            return score;
        }
        /// <summary>
        /// Returns the squared sum of numbers in given space
        /// </summary>
        /// <param name="minNumber"></param>
        /// <param name="maxNumber"></param>
        /// <returns></returns>
        public static int SumOfSquared(int minNumber, int maxNumber)
        {
            int score = 0;
            for (int i = minNumber; i < maxNumber + 1; i++)
            {
                score += i;
            }
            score *= score;
            return score;
        }
        /// <summary>
        /// Find number of prime numbers
        /// </summary>
        /// <param name="minNumber"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public static int PrimeNumbers(int minNumber, int quantity)
        {
            List<int> primeNumbers = new List<int>();
            int countFactors, countNumbers = 0;
            while(countNumbers < quantity)
            {
                countFactors = 0;
                for (int i = minNumber; i > 0; i--)
                {
                    if (minNumber % i == 0) countFactors++;
                    //Console.WriteLine(i);
                }
                if(countFactors == 2)
                {
                    primeNumbers.Add(minNumber);
                    countNumbers++;
                }
                minNumber++;
            }
            return primeNumbers[quantity - 1];
        }
        /// <summary>
        /// Find adjacent digits that have the greatest product
        /// </summary>
        /// <param name="FilePath"></param>
        /// <param name="Max"></param>
        /// <returns></returns>
        public static string FindBiggest(string FilePath, string maxNumbers)
        {
            long topScore = 0;
            long number;
            int maxNumber = Convert.ToInt16(maxNumbers);
            string endScore;
            string file = System.IO.File.ReadAllText(FilePath);
            char[] numbers = file.ToCharArray();
            for (int i = 0; i < numbers.Count() - maxNumber; i++)
            {
                number = 1;
                for (int j = i; j < i + maxNumber; j++)
                {
                    number *= (long)Char.GetNumericValue(numbers[j]);
                }
                if (number > topScore)
                {
                    topScore = number;
                }
            }
            endScore = Convert.ToString(topScore);
            return endScore;
        }
        /// <summary>
        /// Retuns multiplication of 3 numbers that create triangle and its sum is of specific length
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int Pytagoras(int number)
        {
            int c = 0, x = 0, y = 0;
            for (int a = 1; a < number/2; a++)
            {
                for (int b = 1; b < number/2; b++)
                {
                    if (a + b + Math.Sqrt(a * a + b * b) == number)
                    {
                        x = a;
                        y = b;
                        c = (int)Math.Sqrt(a * a + b * b);
                        break;
                    }
                }
            }
            if (x == 0) Console.WriteLine("There are no such numbers");
            Console.WriteLine("Your numbers are: " + c + ", " + x + ", " + y);
            return c * x * y;
        }
        /// <summary>
        /// Return the sum of all prime numbers from a given space
        /// </summary>
        /// <param name="minNumber"></param>
        /// <param name="maxNumber"></param>
        /// <returns></returns>
        public static long SummationOfPrimes(int minNumber, int maxNumber)
        {
            List<int> primeNumbers = new List<int>();
            long score = 0;
            int count;
            primeNumbers.Add(2);
            primeNumbers.Add(3);
            if (minNumber % 2 == 0) minNumber++;
            for (int i = minNumber; i < maxNumber; i+=2)
            {
                count = 0;
                for (int j = 0; j < primeNumbers.Count() - 1; j++)
                {
                    if (i % primeNumbers[j] == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    primeNumbers.Add(i);
                    Console.WriteLine(i);
                }
            }
            foreach (int x in primeNumbers)
            {
                score += x;
            }
            return score;
        }
    }
}
