using NUnit.Framework;
using second_task;

namespace unit_tests
{
    [TestFixture(typeof(bool))]
    [TestFixture(typeof(int))]
    [TestFixture(typeof(double))]
    public class TestsSecondTask<T> where T : struct
    {
        MyValueType<T> _myValue;
        [SetUp]
        public void Setup()
        {
            _myValue = new MyValueType<T>();
        }

        [Test]
        public void Test1()
        {
            Assert.IsInstanceOf(typeof(T), _myValue.FactoryMethod());
        }
    }
}