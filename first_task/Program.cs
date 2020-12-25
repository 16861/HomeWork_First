using System;

namespace first_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First task!");

            Book<int> bookInt = new Book<int>() {
                Name = "The art of computer programming",
                Price = 10
            };
            Book<Double> bookDouble = new Book<Double>() {
                Name = "Design Patterns: Elements of Reusable Object-Oriented Software",
                Price = 10.2
            };
        
            bookInt.Show();
            bookDouble.Show();
        }
    }
}
