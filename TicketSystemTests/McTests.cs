using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicketSystemTests
{
    [TestClass]
    public class McTests
    {
        [TestMethod]
        public void Price_WithDefaultConstructor_Test()
        {
            MC mc = new();
            double expected = 125;

            double actual = mc.Price();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(null, 125)]
        [DataRow(false, 125)]
        [DataRow(true, 118.75)]
        public void Price_WithBrobizzConstructor_Test(bool hasBrobizz, double expectedPrice)
        {
            MC mc = new("12345", DateTime.Now, hasBrobizz);

            double actual = mc.Price();

            Assert.AreEqual(expectedPrice, actual, 0.01);
        }

        [TestMethod]
        public void VehicleType_Test()
        {
            MC mc = new();
            string expected = "MC";

            string actual = mc.VehicleType();

            Assert.AreEqual(expected, actual);
        }
    }
}
