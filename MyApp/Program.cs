using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new MyApp().Greet("User"));
        }
    }

    public class MyApp
    {
        public string Greet(string name) 
        {
            return $"Hello, {name}!";
        }
    }
}
