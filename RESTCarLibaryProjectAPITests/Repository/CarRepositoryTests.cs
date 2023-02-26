using Microsoft.VisualStudio.TestTools.UnitTesting;
using RESTCarLibaryProjectAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibaryProject;
using RESTCarLibaryProjectAPI.Repository;

namespace RESTCarLibaryProjectAPI.Repository.Tests
{
    [TestClass()]
    public class CarRepositoryTests
    {
        CarRepositoryTests _repo;
        private List<Car> testListOfCars;
        private Car testCar;
        private int testCarId;
        private string testCarModel;
        private int testCarPrice;
        private string testCarLicensePlate;

        public CarRepositoryTests()
        {
            _repo = new();
            testCarId = 1;
            testCarModel = "Urus";
            testCarPrice = 1360000;
            testCarLicensePlate = "TT11777";
            //testCar = _repo.getById(testCarId);
            //testListOfCars = get
        }

        [TestMethod()]
        public void GetAllTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Assert.Fail();
        }

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
    }
}