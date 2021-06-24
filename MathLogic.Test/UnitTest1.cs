using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestUnit;

namespace MathLogic.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            CMathlogic m = new CMathlogic();

            double resultat = m.Add(12, 18);

            Assert.AreEqual(resultat, 30);
        }

        [TestMethod]
        public void Test_SubstractMethod()
        {
            //Arrange
            CMathlogic m = new CMathlogic();
            //Art
            double resultat = m.Substract(35, 5);
            //Assert
            Assert.AreEqual(resultat, 30);
        }

        [TestMethod]
        public void Test_DivideMethod()
        {
            
            CMathlogic m = new CMathlogic();
            
            double resultat = m.divide(20, 5);
            
            Assert.AreEqual(resultat, 4);
        }

        [TestMethod]
        public void Test_MultiplyMethod()
        {
            
            CMathlogic m = new CMathlogic();
            
            double resultat = m.Multiply(5, 5);
            
            Assert.AreEqual(resultat, 25);
        }
    }
}
