using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBronTicketLibrary;

namespace OresundBronTests
{
    [TestClass]
    public class OresundMCTests
    {
        [TestMethod]
        public void VehicleType_Test()
        {
            OresundMC oresundMc = new OresundMC();
            string actualType = oresundMc.VehicleType();
            Assert.AreEqual("Oresund MC", actualType);
        }

        [DataTestMethod]
        [DataRow(null, 210)]
        [DataRow(true, 73)]
        public void Price_Test(bool brobizz, double expectedPrice)
        {
            OresundMC oresundMc = new OresundMC("12345", DateTime.Now, brobizz);
            double actualPrice = oresundMc.Price();
            Assert.AreEqual(expectedPrice, actualPrice);
        }
    }
}
