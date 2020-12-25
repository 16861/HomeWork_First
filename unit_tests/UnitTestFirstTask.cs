using NUnit.Framework;
using first_task;
using System;
using System.IO;

namespace unit_tests
{
    public class TestsFirstTask
    {
        [Test]
        public void TestFirstTask() {
            Book<int> book = new Book<int>();
            book.Name = "The art of computer programming";
            book.Price = 100;

            using(var consoleOut = new StringWriter()) {
                Console.SetOut(consoleOut);
                book.Show();
                Assert.AreEqual(
                    "Name: The art of computer programming, price: 100\n", 
                    consoleOut.ToString());
            }
        }
    }
}