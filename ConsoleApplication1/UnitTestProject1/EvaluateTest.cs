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
            Evaluate my_Evaluation = new Evaluate();
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
            int actual = my_Evaluation.subtractEntries(6, 2);
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

        [TestMethod]
        public void evaluateShouldReturnResult()
        {
            Evaluate testEval = new Evaluate();
            object[] whatEver = new object[] { 1, '*', 3 };
            var actual = testEval.EvaluateResult(whatEver);
            int expected = 3;

            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void evalAdd()
        {
            Evaluate addEval = new Evaluate();
            object[] numsNop = new object[] { 1, '+', 3 };
            var actual = addEval.EvaluateResult(numsNop);
            int expected = 4;

            Assert.AreEqual(actual, expected); 
        }

        [TestMethod]
        public void evalSubtract()
        {
            Evaluate subEval = new Evaluate();
            object[] numsNop = new object[] { 7, '-', 3 };
            var actual = subEval.EvaluateResult(numsNop);
            int expected = 4;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void evalDivide()
        {
            Evaluate divEval = new Evaluate();
            object[] numsNop = new object[] { 12, '/', 3 };
            var actual = divEval.EvaluateResult(numsNop);
            int expected = 4;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void evalModulus()
        {
            Evaluate modEval = new Evaluate();
            object[] numsNop = new object[] { 10, '%', 3 };
            var actual = modEval.EvaluateResult(numsNop);
            int expected = 1;

            Assert.AreEqual(actual, expected);

        }
    }
}
