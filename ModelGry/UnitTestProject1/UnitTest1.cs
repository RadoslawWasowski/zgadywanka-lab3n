using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelGry;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Losuj_Zakres_OK()
        {
            //AAA
            //Arrange
            int x = 1;
            int y = 10;

            //Act
            int los = Gra.Losuj(x, y);

            //Assert
            Assert.IsTrue(los >= x && los <= y);
        }
    }
}
