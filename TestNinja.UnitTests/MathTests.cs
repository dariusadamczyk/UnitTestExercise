﻿using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }
        
        
        [Test]
        public void Max_WhenFirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            var result = _math.Max(2, 1);
            Assert.That(result, Is.EqualTo(2));
        }
        
        [Test]
        public void Max_WhenSecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            var result = _math.Max(1, 2);
            Assert.That(result, Is.EqualTo(2));
        }
        
        [Test]
        [Ignore("Below test is more generic")]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {
            var result = _math.Max(1, 1);
            Assert.That(result, Is.EqualTo(1));
        }
        
        [Test]
        [TestCase(2,1,2)]
        [TestCase(1,2,2)]
        [TestCase(1,1,1)]
        public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThenZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);
            
            //Assert.That(result, Is.Not.Empty);
            
            //Assert.That(result.Count(), Is.EqualTo(3));
            
            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));
            
            Assert.That(result, Is.EquivalentTo(new [] {1,3,5}));
            
            Assert.That(result, Is.Ordered); //Make sure result is ordered
            Assert.That(result, Is.Unique); //Make sure result is unique

            
        }
    }
}