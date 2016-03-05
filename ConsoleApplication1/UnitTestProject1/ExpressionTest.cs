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
        //// Prove you can extract the operation embedded in the expression.

        //// Ensure you have examples of GOOD and BAD input and have your Expression class throw an exception when there's an error.
        //public void MyTestMethod3()
        //{
        //    //Arrange

        //    //Act

        //    //Assert

        //}




    }
}