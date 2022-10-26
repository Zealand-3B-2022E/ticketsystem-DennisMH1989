using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Model.Tests
{
    [TestClass()]
    public class StoreBaeltCarTests
    {
        [TestMethod()]
        public void CarPriceTest()
        {
            //arrange
            StoreBaeltCar car = new StoreBaeltCar();

            //act
            double ticketprice = car.Price();

            //assert
            Assert.AreEqual(240, ticketprice);
        }
        [TestMethod()]
        public void CarPriceTestBrobizzTrue()
        {
            //arrange
            DateTime date = new DateTime(2022, 10, 6);
            StoreBaeltCar car = new StoreBaeltCar("1234567", date, true);

            //act
            double ticketprice = car.Price();

            //assert
            Assert.AreEqual(228, ticketprice, 0.01);
        }


        [TestMethod()]
        public void CarPriceTestBrobizzFalse()
        {
            //arrange
            DateTime date = new DateTime(2022, 10, 6);
            StoreBaeltCar car = new StoreBaeltCar("1234567", date, false);

            //act
            double ticketprice = car.Price();

            //assert
            Assert.AreEqual(240, ticketprice, 0.01);
        }


        [TestMethod()]
        public void CarPriceTestBrobizzWeekendTrue()
        {
            //arrange
            DateTime date = new DateTime(2022, 10, 8);
            StoreBaeltCar car = new StoreBaeltCar("1234567", date, true);

            //act
            double ticketprice = car.Price();

            //assert
            Assert.AreEqual(182.4, ticketprice, 0.01);
        }

        [TestMethod()]
        public void CarPriceTestWeekendTrue()
        {
            //arrange
            DateTime date = new DateTime(2022, 10, 8);
            StoreBaeltCar car = new StoreBaeltCar("1234567", date, false);

            //act
            double ticketprice = car.Price();

            //assert
            Assert.AreEqual(192, ticketprice, 0.01);
        }
    }
}