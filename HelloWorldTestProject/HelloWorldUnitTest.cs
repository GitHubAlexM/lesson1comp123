using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldTestProject
{
    [TestClass]
    public class HelloWorldUnitTest
    {
        [TestMethod]
        public void HelloWorldToConsoleTestMethod()
        {
            // Arrange 
            //string wrongExpectedResult = "Hello World";
            ////Should fail

            string correctExpectedResult = "Hello, World!";
            //Should pass

            // Act
            string result = Lesson1.Program.HelloWorldToConsole();

            // Assert
            //Assert.AreEqual(wrongExpectedResult, result);
            Assert.AreEqual(correctExpectedResult, result);
        }
    }
}
