using System;

namespace third_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Third task!");

            Calculator<int, int> calculatorInt = new Calculator<int, int>(10,10);
            Calculator<double, double> calculatorDouble = new Calculator<double, double>(10.2, 20.3);


            Console.WriteLine(calculatorInt.Add());
            Console.WriteLine(calculatorDouble.Add());
        }
    }
}
