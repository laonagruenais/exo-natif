using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Veuillez entrer du texte : ");
        string userInput = Console.ReadLine();

        string uppercasedText = ConvertToUpper(userInput);
        Console.WriteLine("Texte en majuscules : " + uppercasedText);
    }

    public static string ConvertToUpper(string text)
    {
        return text.ToUpper();
    }
}
