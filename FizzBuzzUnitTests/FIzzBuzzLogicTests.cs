using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzApp;
namespace FizzBuzzUnitTests
{
    [TestClass]
    public class FIzzBuzzLogicTests
    {
        //Arrange
        FizzBuzzLogic logicObj = new FizzBuzzLogic();
        [TestMethod]
        public void DivideByZero()
        {
            Assert.AreEqual( string.Empty,logicObj.DoFizzBuzz(0));

        }
        [TestMethod]
        public void MultipleofThreeAndFive()
        {
            Assert.AreEqual("FizzBuzz", logicObj.DoFizzBuzz(45));

        }
        [TestMethod]
        public void MultipleofThreeOnly()
        {
            Assert.AreEqual("Fizz", logicObj.DoFizzBuzz(12));

        }
        [TestMethod]
        public void MultipleofFiveOnly()
        {
            Assert.AreEqual("Buzz", logicObj.DoFizzBuzz(35));

        }
        [TestMethod]
        public void MultipleofNone()
        {
            Assert.AreEqual("1", logicObj.DoFizzBuzz(34));

        }
    }
}
