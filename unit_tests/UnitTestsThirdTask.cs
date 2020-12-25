using NUnit.Framework;
using third_task;
using System.Collections.Generic;
using System;

namespace unit_tests
{
    public class TestsThirdTask
    {
        public static IEnumerable<TestCaseData> TestCasesInt() {
            yield return new TestCaseData(10.0, 10.0, new Calculator<int, int>(10, 10));
            yield return new TestCaseData(20.0, 3.0, new Calculator<int, int>(20, 3));
        }

        public static IEnumerable<TestCaseData> TestCasesDouble() {
            yield return new TestCaseData(10.0, 10.0, new Calculator<double, double>(10, 10));
            yield return new TestCaseData(20.0, 3.0, new Calculator<double, double>(20, 3));
        }

        [Test]
        [TestCaseSource("TestCasesInt")]
        public void Test1(double v1, double v2, Calculator<int, int> calculator)
        {
            //Calculator<int, int> calculator = new Calculator<int, int>(10, 10);


            Assert.AreEqual(v1+v2, calculator.Add());
            Assert.AreEqual(v1-v2, calculator.Substract());
            Assert.AreEqual(Math.Round(v1/v2), Math.Round(calculator.Divide()));
            Assert.AreEqual(v1*v2, calculator.Multiply());
        }

        [Test]
        [TestCaseSource("TestCasesDouble")]
        public void Test2(double v1, double v2, Calculator<double, double> calculator)
        {
            //Calculator<int, int> calculator = new Calculator<int, int>(10, 10);


            Assert.AreEqual(v1+v2, calculator.Add());
            Assert.AreEqual(v1-v2, calculator.Substract());
            Assert.AreEqual(Math.Round(v1/v2), Math.Round(calculator.Divide()));
            Assert.AreEqual(v1*v2, calculator.Multiply());
        }
    }
}