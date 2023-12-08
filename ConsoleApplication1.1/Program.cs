using System;
public class Programm
{
    public static void Main(string[] args)
    {
        int n = 10;
        int[] numbers = new int[n];

        Random rnd1 = new Random();
        Console.WriteLine("Массив из 10 чисел: ");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = rnd1.Next(-1000, 1000);
            Console.Write("{0, 5}", numbers[i]);
            
            if ((i + 1) % 10 == 0)
            {
                Console.WriteLine();
            }
        }
        
        Console.Write("Номер минимального элемента массива: ");
        int temp = 0;
        int stap = numbers[0];
        for (int i = 0; i < n; i++)
        {
            if (numbers[i] < stap)
            {
                temp = i;
                stap = numbers[i];
            }
        }
        Console.Write(temp);
    } 
}