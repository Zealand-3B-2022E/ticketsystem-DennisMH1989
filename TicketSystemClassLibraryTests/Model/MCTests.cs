using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketSystemClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.Model.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            //arrange
            MC mc = new MC();

            //act
            double ticketprice = mc.Price();

            //assert
            Assert.AreEqual(125, ticketprice);

        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //arrange
            MC mc = new MC();

            //act
            string vehicleType = mc.VehicleType();

            //assert
            Assert.AreEqual("MC", vehicleType);
        }
    }
}