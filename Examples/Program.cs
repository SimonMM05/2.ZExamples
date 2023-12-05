using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("John er en skattesvindler");

        Console.WriteLine("Indtast dit svar");
        string userInput = Console.ReadLine();

        if (userInput.ToLower() == "true")
        {
            Console.WriteLine("-1000000 i statskassen");
        }
        else
        {
            Console.WriteLine("Forkert svar");
        }
    }
}