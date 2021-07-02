using NUnit.Framework;
using NunitDemo;
using System;

namespace NunitTestProject
{
    //[TestFixture]
    public class UnitTestCalulator
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Additon_WithValid_Integer()
        {
            var calc = new Calculator();
            var result = calc.Addition(5, 3);
            Assert.AreEqual(8, result);
           
        }
        [Test]
        public void Test_Subtraction_ArgumentException()
        {
            var calc = new Calculator();
            Assert.Catch<ArgumentException>(() => calc.Subtraction(4, 5));
            Assert.Catch<SystemException>(() => calc.Subtraction(4, 5));

        }

        [TestCase(1,2,3)]
        [TestCase(5, 2, 7)]
        [TestCase(6, 2, 8)]
        public void Test_Additon_Multiple(int First, int Second, int ExpectedResult)
        {
            var calc = new Calculator();
            var result = calc.Addition(First, Second);
            Assert.AreEqual(ExpectedResult, result);

        }
    }
}