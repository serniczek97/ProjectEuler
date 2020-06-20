using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public static class Problems
    {
        /// <summary>
        /// Finds the sum of multipliers in given space of two given numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Find(int a, int b, int x)
        {
            int sum = 0;
            for (int i = 0; i < x; i++)
            {
                if (i % a == 0 || i % b == 0) sum += i;
            }
            return sum;
        }
        /// <summary>
        /// Returns sum of all even numbers in the Fibonacci sequence, where the biggest number is given
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int Fibonacci(int number)
        {
            int sum = 2;
            int i = 2;
            List<int> fibonacci = new List<int>();
            fibonacci.Add(1);
            fibonacci.Add(2);
            fibonacci.Add(3);
            while (fibonacci[i] < number)
            {
                fibonacci.Add(fibonacci[i] + fibonacci[i - 1]);
                i++;
                if (fibonacci[i] % 2 == 0) sum += fibonacci[i];

            }
            return sum;
        }
        /// <summary>
        ///   Returns the biggest prime factor of given number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static long PrimeFactors(long number)
        {
            long count = 0;
            List<long> maxFactor = new List<long>();
            for (int i = 2; i < number + 1; i++)
            {
                count = 0;
                for (int j = 2; j < i + 1; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    if (number % i == 0)
                    {
                        number /= i;
                        maxFactor.Add(i);
                    }
                }
            }
            maxFactor.Sort();
            return maxFactor[maxFactor.Count() - 1];
        }
        /// <summary>
        /// Finding the biggest palindrome in given section
        /// </summary>
        /// <param name="minNumber"></param>
        /// <param name="maxNumber"></param>
        /// <returns></returns>
        public static int FindPalindrome(int minNumber, int maxNumber)
        {
            List<int> numbers = new List<int>();
            int count, number;
            string num;
            char[] digits;
            for (int x = maxNumber; x >= minNumber; x--)
            {
                for (int i = maxNumber; i >= minNumber; i--)
                {
                    count = 0;
                    number = x * i;
                    num = number.ToString();
                    digits = num.ToCharArray();
                    if (digits.Count() % 2 == 0)
                    {
                        for (int j = 0; j < (digits.Count()) / 2; j++)
                        {
                            if (digits[j] == digits[digits.Count() - 1 - j]) count++;
                            else break;
                        }
                    }
                    else
                    {
                        for (int j = 0; j < (digits.Count() - 1) / 2; j++)
                        {
                            if (digits[j] == digits[digits.Count() - 1 - j]) count++;
                            else break;
                        }
                    }
                    if (count == digits.Count() / 2)
                    {
                        string charsToArray = new string(digits);
                        int.TryParse(charsToArray, out number);
                        numbers.Add(number);
                    }
                }
            }
            numbers.Sort();
            return numbers[numbers.Count() - 1];
        }
        /// <summary>
        /// Finding the smalles number that is divisible by all of the numbers in given section
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int FindTheSmallest(int a, int b)
        {
            int number = 0, score = 0;
            while (score == 0)
            {
                int count = 0;
                number++;
                for (int i = a; i < b + 1; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                    else break;
                }
                Console.WriteLine(number);
                if (count == b) score = number;
            }
            return score;
        }
    }
}
