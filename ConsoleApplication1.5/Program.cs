using System;
using System.Collections.Generic;

public class Programm
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите строки: ");
        List<string> input = new List<string>();
        input.Add("Start");
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

        input.Add("End");
        int num = 0;
        if (input.Count > 0)
        {
            foreach (var word in input)
            {
                Console.Write(word + " ");
                num++;
            }
        }
        Console.WriteLine(num);
    }
}