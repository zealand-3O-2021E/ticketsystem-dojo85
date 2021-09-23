using System;
using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBronTicketLibrary;
using Car = OresundBronTicketLibrary.Car;

namespace OresundBronTests
{
    [TestClass]
    public class OresundCarTests
    {
        [TestMethod]
        public void VehicleType_Test()
        {
            OresundBronTicketLibrary.Car car = new OresundBronTicketLibrary.Car();
            string actual = car.VehicleType();

            Assert.AreEqual("Oresund Car", actual);
        }

        [DataTestMethod]
        [DataRow(null, 410)]
        [DataRow(true, 161)]
        public void Price_Test(bool brobizz, double expectedPrice)
        {
            Car car = new Car("12345", DateTime.Now, brobizz);
            double actualPrice = car.Price();

            Assert.AreEqual(expectedPrice, actualPrice);
        }
    }
}
