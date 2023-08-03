using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num1;
        Console.WriteLine("Введите число");
        num1 = Convert.ToInt32(Console.ReadLine());
        for (int i = 2; i <= num1; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }       
    }
}