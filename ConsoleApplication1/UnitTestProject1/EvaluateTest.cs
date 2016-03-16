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
            //Arrange
            Evaluate testEval = new Evaluate();

            //act
            object[] whatEver = new object[] { 1, '*', 3 };
            var actual = testEval.EvaluateResult(whatEver);
            int expected = 3;
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void evalAdd()
        {
            //Arrange
            Evaluate addEval = new Evaluate();

            //act
            object[] numsNop = new object[] { 1, '+', 3 };
            var actual = addEval.EvaluateResult(numsNop);
            int expected = 4;


            //Assert
            Assert.AreEqual(actual, expected); 
        }

        [TestMethod]
        public void evalSubtract()
        {

            //Arrange
            Evaluate subEval = new Evaluate();

            //act
            object[] numsNop = new object[] { 7, '-', 3 };
            var actual = subEval.EvaluateResult(numsNop);
            int expected = 4;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void evalDivide()
        {

            //Arrange
            Evaluate divEval = new Evaluate();

            //Act
            object[] numsNop = new object[] { 12, '/', 3 };
            var actual = divEval.EvaluateResult(numsNop);
            int expected = 4;
            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void evalModulus()
        {
            //Arrange
            Evaluate modEval = new Evaluate();

            //Act
            object[] numsNop = new object[] { 10, '%', 3 };
            var actual = modEval.EvaluateResult(numsNop);
            int expected = 1;

            //Assert
            Assert.AreEqual(actual, expected);

        }

        //below tests the last answer
        //[TestMethod]
        //public void lastTest()
        //{
        //Arrange
        //Evaluate evaluateLast = new Evaluate();

        //Act
        //    object[] numsNop = new object[] { 10, '+', 3 };
        //int expected = 13;
        //    int evalLast = evaluateLast.EvaluateResult(2)
     
        //}


        //below test the last question/formula

        [TestMethod]
        public void lastQTest()
        {
            //Arrange
            Evaluate evaluateLastQ = new Evaluate();

            //Act
            object[] numsNop = new object[] { 10, '+', 3 };

            string expected = ("10 + 3");
            string actual = evaluateLastQ.stackOnStack.lastQ;
            //assert
            Assert.AreEqual(expected, actual);


        }
    }
}
