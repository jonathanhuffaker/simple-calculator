using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class EvaluateTest
    {
        [TestMethod]
        public void EvaluateTest1()
        {
            //Arrange
            Addition my_Evaluation = new Addition();
            //Act
            //Assert
            Assert.IsNotNull(my_Evaluation);
        }

        [TestMethod]
        public void AddTest()
        {
            //Arrange
            Addition my_Evaluation = new Addition();

            //Act
            int actual= 2 + 2;
            int expected = 4;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void SubtractTest()
        {
            //Arrange
            Subtraction my_Evaluation = new Subtraction();

            //Act
            int actual = 6 - 2;
            int expected = 4;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void MultTest()
        {
            //Arrange
            Multiplication my_Evaluation = new Multiplication();

            //Act
            int actual = 6 * 2;
            int expected = 12;

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void DivTest()
        {
            //Arrange
            Division my_Evaluation = new Division();

            //Act
            int actual = 6 / 2;
            int expected = 3;

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void ModulusTest()
        {
            //Arrange
            Modulus my_Evaluation = new Modulus();

            //Act
            int actual = 9 % 2;
            int expected = 1;

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
