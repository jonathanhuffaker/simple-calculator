using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class ExpressionTest
    {
        [TestMethod]
        public void MyTestMethod1()
        {
            //Arrange
            Expression my_Expression = new Expression();
            //Act
            //Assert
            Assert.IsNotNull(my_Expression);
        }

        [TestMethod]
        // Prove you can extract the terms of the expression.
        public void ExtractExpression()
        {
             // Arrange
            Expression my_expression = new Expression();
            string userEntry = "1 + 1";
            // Act
            object [] expected = { 1 , '+' , 1 };
            object[] actual = my_expression.ParseExpression(userEntry);
            // Assert
            CollectionAssert.AreEqual(expected, actual);

        }
        //[TestMethod]
        ////// Prove you can extract the operation embedded in the expression.
        //public void ExtractOperation()
        //{
        //  Expression my_expression = new Expression();
        //    object[] actual = my_expression.ParseExpression("1 + 1");
        //    object[] expected = { 1, '+', 1 };

        //    CollectionAssert.AreEqual(expected, actual);
        //}




        //// Ensure you have examples of GOOD and BAD input and have your Expression class throw an exception when there's an error.
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void BadInputExample()
        {
            //    //Arrange
            Expression my_expression = new Expression();
            string badExpressionEx = "+2";
            my_expression.ParseExpression(badExpressionEx);

        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void BadVariableInputExample()
        {
            //    //Arrange
            Expression my_expression = new Expression();
            string badExpressionEx = "x+1";
            my_expression.ParseExpression(badExpressionEx);

        }


        //this will be for last & last q


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
            Expression evaluateLastQ = new Expression();

            Assert.IsNull(evaluateLastQ.stackOnStack.lastQ);
            //Act
            evaluateLastQ.ParseExpression("10 + 3");
            string expected = ("10 + 3");
            string actual = evaluateLastQ.stackOnStack.lastQ;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBadInput()
        {
            Expression parser = new Expression();

            try
            {
                parser.ParseExpression("hello");
            }
            catch(IndexOutOfRangeException){ }
            Assert.IsNull(parser.stackOnStack.lastQ);
        }

        [TestMethod]
        public void TestBadInput2()
        {
            Expression parser = new Expression();

            try
            {
                parser.ParseExpression("1 + ");
            }
            catch (FormatException) { }
            Assert.IsNull(parser.stackOnStack.lastQ);
        }
    }
}