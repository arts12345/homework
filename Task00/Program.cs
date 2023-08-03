using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num1, num2;
        Console.WriteLine("Введите первое число");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        num2 = Convert.ToInt32(Console.ReadLine());
        if (num1 > num2)
        {
            Console.WriteLine($"Число {num1} больше {num2}");
        }
        else
        {
            Console.WriteLine($"Число {num2} больше {num1}");
        }

    }
}