using System;
using System.Collections.Generic;

public class Programm
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите строки: ");
        List<string> input = new List<string>();
        
        while (true)
        {
            string word = Console.ReadLine();
            if (word == "")
            {
                break; 
            }
            else
            {
                input.Add(word);
            }
        }
        
        if (input.Count > 0)
        {
            string small = input[0];
            string big = input[0];
            foreach (var word in input)
            {
                if (word.Length < small.Length)
                {
                    small = word;
                }
                if (word.Length > big.Length)
                {
                    big = word;
                }
            }
            
            Console.WriteLine($"Самый короткий элемент: {small}");
            Console.WriteLine($"Самый длинный элемент: {big}");
        }

        else
        {
            Console.WriteLine("Список пустой");
        }
    }  
}