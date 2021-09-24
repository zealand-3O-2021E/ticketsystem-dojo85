using System;
using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBronTicketLibrary;

namespace OresundBronTests
{
    [TestClass]
    public class OresundCarTests
    {
        [TestMethod]
        public void VehicleType_Test()
        {
            OresundBronTicketLibrary.OresundCar oresundCar = new OresundBronTicketLibrary.OresundCar();
            string actual = oresundCar.VehicleType();

            Assert.AreEqual("Oresund Car", actual);
        }

        [DataTestMethod]
        [DataRow(null, 410)]
        [DataRow(true, 161)]
        public void Price_Test(bool brobizz, double expectedPrice)
        {
            OresundCar oresundCar = new OresundCar("12345", DateTime.Now, brobizz);
            double actualPrice = oresundCar.Price();

            Assert.AreEqual(expectedPrice, actualPrice);
        }
    }
}
