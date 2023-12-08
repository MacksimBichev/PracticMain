using System;
using System.Collections.Generic;
public class Programm
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите числа: ");
        List<int> allnumbers = new List<int>();
        int h = 0;
        while (true)
        {
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                break;
            }
            else
            {
                allnumbers.Add(number); 
                h++;
            }
        }
        int sum = 0;
        int work = 1;
        for (int i = 0; i < allnumbers.Count; i++)
        {
            sum += allnumbers[i];
            work *= allnumbers[i];
        }
        Console.WriteLine($"Сумма всех элементов списка: {sum}");
        Console.WriteLine($"Произведение всех элементов списка: {work}");
        sum /= h;
        Console.WriteLine($"Среднее всех элементов списка: {sum}");
    } 
}