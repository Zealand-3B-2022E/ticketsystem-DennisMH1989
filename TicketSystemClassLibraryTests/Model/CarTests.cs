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
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            //arrange
            Car cars = new Car();

            //act
            double TicketPrice = cars.Price();

            //assert
            Assert.AreEqual(240, TicketPrice);
        }

        [TestMethod()]
        public void PriceTest1()
        {
            //arrange
            Car cars = new Car();

            //act
            double TicketPrice = cars.Price();

            //assert
            Assert.AreEqual(240, TicketPrice);
        }


        [TestMethod()]
        public void VehicleTypeTest()
        {
            //arrange
            Car cars = new Car();

            //act
            string vehicleType = cars.VehicleType();

            //assert
            Assert.AreEqual("Car", vehicleType);
        }
    }
}