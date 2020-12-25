using System;

namespace second_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Second taks!");

            MyValueType<int> _int = new MyValueType<int>();
            MyValueType<double> _double = new MyValueType<double>();
            MyValueType<bool> _bool = new MyValueType<bool>();
            //MyObject<string> _string = new MyObject<string>();

            Console.WriteLine("Create string: {0}", _int.FactoryMethod().GetType());
            Console.WriteLine("Create double: {0}", _double.FactoryMethod().GetType());
            Console.WriteLine("Create bool: {0}", _bool.FactoryMethod().GetType());
        }
    }
}
