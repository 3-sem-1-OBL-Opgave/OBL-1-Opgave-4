using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarLibaryProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RESTCarLibaryProjectAPI.Repository;


namespace RESTCarLibaryProjectAPI.Repository.Tests
{
    [TestClass()]
    public class CarRepositoryTests
    {
        CarRepository _repo;
        private List<Car> testListOfCars;
        private Car testCar;
        private int testCarId;
        private string testCarModel;
        private int testCarPrice;
        private string testCarLicensePlate;

        public CarRepositoryTests()
        {
            _repo = new();
            testCarId = 2;
            testCarModel = "A 200";
            testCarPrice = 440000;
            testCarLicensePlate = "BB22200";
            testCar = _repo.GetById(testCarId);
            testListOfCars = _repo.GetAll();
        }
            
        [TestMethod()]
        public void GetAllTest()
        {
           /*
            Test for:
                * At listen ikke er null
                * At listen indeholder det rette antal objekter
            */
                
            Assert.IsNotNull(testListOfCars, "List of cars is null");
            Assert.AreEqual(testListOfCars.Count(), 3, "The list does not contain the right number of cars");
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            /*
             Teste for:
                * At det givne objekt findes eller ikke er null
                * At objektet indeholder de rette instanser
             */
            Assert.IsNotNull(testCar, "Car is null");
            Assert.AreEqual(testCarId, testCar.Id, "The id of the car are not equal the given argument");
            Assert.AreEqual(testCarModel,testCar.Model, "The car model are not equal the given argument");
            Assert.AreEqual(testCarLicensePlate,testCar.LicensePlate, "The licenseplate of the car are not equal the given argument");
            Assert.AreEqual(testCarPrice, testCar.Price, "The price of the car are not equal the given argument");
        }

        /*
        [TestMethod()]
        public void AddTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }
        */
    }
}