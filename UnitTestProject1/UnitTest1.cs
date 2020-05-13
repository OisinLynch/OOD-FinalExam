using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OisinLynch_S00189006;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIncreasePrice()
        {
            //Arrange 
            Phone p1 = new Phone();
            decimal finalPrice = 500m;

            //Act 
            p1.IncreasePrice(500m);


            //Assert
            Assert.AreEqual(finalPrice, p1.Price);
        }
    }
}
