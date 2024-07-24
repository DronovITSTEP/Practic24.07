using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic24._07.Part2
{
    /*
     Создайте приложение, которое отображает количество
     чётных, нечётных, уникальных элементов массива.
    */
    internal class Program
    {
        const int SIZE_ARRAY = 10;
        static int[] numbers;
        static void Main(string[] args)
        {
            InitArrayNumbers();
            PrintArrayNumbers();

            Console.WriteLine();

            /*Console.WriteLine($"кол-во четных чисел: {GetCountEvenNumbers()}");
            Console.WriteLine($"кол-во нечетных чисел: {GetCountOddNumbers()}");
            Console.WriteLine($"кол-во уникальных чисел: {GetCountUniqueNumbers()}");*/
            //Console.WriteLine($"кол-во четных чисел: {numbers.Count(n=> n%2 ==0 )}");
            //Console.WriteLine($"кол-во нечетных чисел: {numbers.Count(n => n % 2 != 0)}");
            //Console.WriteLine($"кол-во уникальных чисел: {numbers.Distinct().Count()}");
        }

        static void InitArrayNumbers()
        {
            numbers = new int[SIZE_ARRAY];
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 10);
            }
        }
        static void PrintArrayNumbers()
        {
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static int GetCountEvenNumbers()
        {
            int evenCount = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0) evenCount++;
            }
            return evenCount;
        }
        static int GetCountOddNumbers()
        {
            int oddCount = 0;
            foreach (int i in numbers)
            {
                if (i % 2 != 0) oddCount++;
            }
            return oddCount;
        }
        static int GetCountUniqueNumbers()
        {
            int uniqueCount = 0;
            bool isUnique;
            for (int i = 0; i < numbers.Length; i++)
            {
                isUnique = true;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j] && i != j)
                    {
                        isUnique = false;
                    }
                }
                if (isUnique)
                    uniqueCount++;
            }
            return uniqueCount;
        }
    }

    /*
     Создайте приложение, отображающее количество
    значений в массиве меньше заданного параметра пользователем. 
    Например, количество значений меньших, чем 7
    (7 введено пользователем с клавиатуры).
    */
    /*internal class Program
    {
        const int SIZE_ARRAY = 10;
        static int[] numbers;
        static void Main(string[] args)
        {
            InitArrayNumbers();
            PrintArrayNumbers();

            int lessNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GetCountLessInNumbers(lessNumber));
        }
        static void PrintArrayNumbers()
        {
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void InitArrayNumbers()
        {
            numbers = new int[SIZE_ARRAY];
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 10);
            }
        }   
        static int GetCountLessInNumbers(int lessNumber)
        {
            int count = 0;
            foreach (int i in numbers) {
                if (i < lessNumber) count++;
            }
            return count;
        }
    }*/
}
