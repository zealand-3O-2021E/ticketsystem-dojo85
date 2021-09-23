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
        public void Price_Test()
        {
            MC mc = new();
            double expected = 125;

            double actual = mc.Price();

            Assert.AreEqual(expected, actual);
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
