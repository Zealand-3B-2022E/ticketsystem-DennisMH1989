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
    public class VehicleTests
    {
        [TestMethod()]
        public void CarPriceTest()
        {
            //arrange
            Car car = new Car();

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
            Car car = new Car("1234567", date, true);

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
            Car car = new Car("1234567", date, false);

            //act
            double ticketprice = car.Price();

            //assert
            Assert.AreEqual(240, ticketprice, 0.01);
        }


        [TestMethod()]
        public void MCPriceTest()
        {
            //arrange
            MC mc = new MC();

            //act
            double ticketprice = mc.Price();

            //assert
            Assert.AreEqual(125, ticketprice);
        }

        [TestMethod()]
        public void MCPriceTestBrobizzTrue()
        {
            //arrange
            DateTime date = new DateTime(2022, 10, 6);
            MC mc = new MC("1234567", date, true);

            //act
            double ticketprice = mc.Price();

            //assert
            Assert.AreEqual(118.75, ticketprice, 0.01);
        }


        [TestMethod()]
        public void MCPriceTestBrobizzFalse()
        {
            //arrange
            DateTime date = new DateTime(2022, 10, 6);
            MC mc = new MC("1234567", date, false);

            //act
            double ticketprice = mc.Price();

            //assert
            Assert.AreEqual(125, ticketprice, 0.01);
        }

        [TestMethod()]
        public void VehicleTypeCarTest()
        {
            //arrange
            Car cars = new Car();

            //act
            string vehicleType = cars.VehicleType();

            //assert
            Assert.AreEqual("Car", vehicleType);
        }

        [TestMethod()]
        public void VehicleTypeMCTest()
        {
            //arrange
            MC mc = new MC();

            //act
            string vehicleType = mc.VehicleType();

            //assert
            Assert.AreEqual("MC", vehicleType);
        }

        [TestMethod()]
        [DataRow("")]
        [DataRow("&00 0q0")]
        [DataRow("0000000")]
        public void VehicleLincensenPlateTest(string _licensePlate)
        {
            //arrange
            DateTime date = new DateTime(2022, 10, 6);
            bool brobizz = false;
            Car carPlate = new Car(_licensePlate, date, brobizz);
            List<Car> cars = new List<Car>();

            //act
            cars.Add(carPlate);
            //assert
            Assert.AreEqual(cars.Count, 1);
        }

        [TestMethod()]
        [DataRow("00000000")]
        [ExpectedException(typeof(ArgumentException))]
        public void VehicleLicensenPlateTestFail(string _licensePlate)
        {
            //arrange
            DateTime date = new DateTime(2022, 10, 6);
            bool brobizz=false;
            Car carPlate = new Car(_licensePlate, date, brobizz);
            List<Car> cars = new List<Car>();

            //act
            cars.Add(carPlate);
            //assert
            Assert.Fail();
        }

        [TestMethod()]
        [DataRow("")]
        [DataRow("&00 0q0")]
        [DataRow("0000000")]
        public void VehicleLincensenPlateTestMC(string licensePlate)
        {
            //arrange
            DateTime date = new DateTime(2022, 10, 6);
            bool brobizz = false;
            MC MCPlate = new MC(licensePlate, date, brobizz);
            List<MC> MCs = new List<MC>();

            //act
            MCs.Add(MCPlate);
            //assert
            Assert.AreEqual(MCs.Count, 1);
        }

        [TestMethod()]
        [DataRow("00000000")]
        [ExpectedException(typeof(ArgumentException))]
        public void VehicleLicensenPlateTestFailMc(string _licensePlate)
        {
            //arrange
            DateTime date = new DateTime(2022, 10, 6);
            bool brobizz = false;
            MC mcPlate = new MC(_licensePlate, date, brobizz);
            List<MC> mcs = new List<MC>();

            //act
            mcs.Add(mcPlate);
            //assert
            Assert.Fail();
        }

    }
}