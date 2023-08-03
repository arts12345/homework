using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num1;
        Console.WriteLine("Введите число");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        
        if (num1 % 2 ==0)
        {
            Console.WriteLine($"Число {num1} является чётным");
        }
        else  
        {
            Console.WriteLine($"Число {num1} не является чётным");
        }
        
    }
}