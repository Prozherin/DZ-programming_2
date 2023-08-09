// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

using System;

class Program
{
    static void Main(string[] args)
    {
      // Также можно применить функцию Random
      //   Random random = new Random();
      //   int number = random.Next(100, 1000);
      Console.WriteLine("Ведите трехзначное число: ");
      int number = Convert.ToInt32(Console.ReadLine());

        char[] digits = number.ToString().ToCharArray();

      Console.WriteLine(digits[1]);
    }
}
