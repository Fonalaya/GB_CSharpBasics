using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, как тебя зовут");
            string name = Console.ReadLine();
            string date = DateTime.UtcNow.ToString("d");
            Console.WriteLine("Привет, " + name + ", сегодня " + date + ".");
            Console.ReadLine();
        }
    }
}
