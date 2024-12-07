using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;


namespace Calculatir.Test
{
    [TestClass]
    public class OutTest
    {
        [TestMethod]
        public void Sum_20plus10_return30()
        {
            // Arrange 
            int a = 10; int b = 20;
            int expected = 30;
            //act
            Calc calc = new Calc();
            int actual = calc.Sum(a,b);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}
