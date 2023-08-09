// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

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

      try
      {
        Console.WriteLine(digits[2]);
      }
      catch (Exception)
      {
        Console.WriteLine("Третьей цифры нет");
      }
    
    }
}