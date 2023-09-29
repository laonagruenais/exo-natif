using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    static List<char> alphabet = new List<char>
    {
        'a','b','c','d','e','f','g','h','i','j','k','l','m',
        'n','o','p','q','r','s','t','u','v','w','x','y','z'
    };

    public static void Main()
    {
        AlgoTest(MyNameIs);
        Console.ReadLine();
    }

    public static string MyNameIs(string name)
    {
        StringBuilder result = new StringBuilder();

        foreach (char letter in name.ToLower()) // Convertir la lettre en minuscules pour une correspondance insensible à la casse
        {
            int index = alphabet.IndexOf(letter);
            if (index >= 0)
            {
                result.Append(index);
            }
        }

        return result.ToString();
    }

    public static void AlgoTest(Func<string, string> func)
    {
        if (func("AB") == "01" &&
            func("Ahmed") == "071243" &&
            func("Dorlean") == "31417114013" &&
            func("a") == "0" &&
            func("Sandrine") == "180133178134")
        {
            Console.WriteLine("Success");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}
