using System;
using System.Collections.Generic;

namespace Task
{
    internal class Program
    {
        private static List<int> Calculate(int number) // ДЗ с циклами
        {
            List<int> result = new List<int>();
            for (int i = 1; i < 1000; i++)
            {
                if (i % number == 0)
                {
                    result.Add(i);
                }
            }
            return result;
        }
        private static double TaskBank(double startSumm, double duration, double persent)
        {
            for (int i = 0; i < duration; i++)
            {
                double peryear = startSumm * persent / 100;
                startSumm += peryear;

            }
            return startSumm;
        }
        private static int CofeShop(int number)
        {
            int first = 1;
            int second = 1;
            switch (number)
            {
                case 1:
                    return 1;
                case 2: return 1;
                case int n when n <= 0:
                    return 0;
            }
            for (int i = 2; i < number; i++)
            {

                if (i % 2 == 0)
                {
                    second += first;
                }
                else
                {
                    first += second;
                }

            }
            if (number % 2 == 0)
            {
                return first;
            }
            else
            {
                return second;
            }

        }
        // While
        private static void CashMashine(int number)
        {
            int[] denomination = { 1000, 500, 100 };
            int[] count = new int[denomination.Length];
            int i = 0;
            while (i < denomination.Length && number > 0)
            {
                count[i] = number / denomination[i];
                number %= denomination[i];
                i++;
                for (int j = 0; j < count.Length; j++)
                {
                    Console.WriteLine($"{denomination[j]} рублей {count[j]}");
                }
            }

        }
        private static void SeriesAnalysis(int firstNumber, int secondNumber)
        {
            List<int> simplNumber = new List<int>();
            for (int j = firstNumber; j <= secondNumber; j++)
            {
                if (IsPrime(j))
                {
                    simplNumber.Add(j);
                }

            }
            foreach (int number in simplNumber)
            {
                Console.WriteLine(number);
            }
        }
        private static bool IsPrime(int number)
        {
            switch (number)
            {
                case int n when n <= 1:
                    return false;
                case 2: return true;
                case int n when n % 2 == 0:
                    return false;
            }
            var boundary = (int)Math.Sqrt(number);
            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
        private static void Registration()
        {
            string password;
            string confirmPassword;
            do
            {
                Console.WriteLine("Введите пароль ");
                password = Console.ReadLine();

                Console.WriteLine("Повторите пароль ");
                confirmPassword = Console.ReadLine();

                if (password == confirmPassword)
                {
                    Console.WriteLine("Регистрация успешна!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка: пароли не совпадают. Попробуйте еще раз.");
                }
            }
                while (password != confirmPassword) ;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(TaskBank(1000, 1, 10));
            Console.ReadLine();

            foreach (int i in Calculate(10))
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            Console.WriteLine(CofeShop(7));
            Console.ReadLine();

            CashMashine(1500);
            Console.ReadLine();
            SeriesAnalysis(1, 100);
            Console.ReadLine();

            Registration();
        }
    }
}
