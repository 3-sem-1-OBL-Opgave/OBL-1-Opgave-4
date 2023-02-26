using CarLibaryProject;
using System.Security.Cryptography.X509Certificates;

namespace RESTCarLibaryProjectAPI.Repository
{
    public class CarRepository
    {
        private int _nextID;
        private List<Car> _cars;

        public CarRepository()
        {
            _nextID = 1;
            _cars = new List<Car>()
            {
                new Car(){Id = _nextID++, Model="M2 Coupe", Price=750000, LicensePlate="AA11100"},
                new Car(){Id = _nextID++, Model="A 200", Price=440000, LicensePlate="BB22200"},
                new Car(){Id=_nextID++, Model="718 Boxter", Price=1100000,LicensePlate="CC33300"}
            };
        }

        public List<Car> GetAll()
        {
            return new List<Car>(_cars);
        }

        public Car GetById(int id)
        {
            Car? carGetByID = _cars.Find(findCar => findCar.Id == id);
            if (carGetByID == null)
            {
                return null;
            }
            return carGetByID;
        }

        public Car Add(Car newCar)
        {
            newCar.Id = _nextID++;
            _cars.Add(newCar);
            return newCar;
        }

        public Car Update(int id, Car newCarUpdates)
        {
            Car carToUpdate = GetById(id);
            if (carToUpdate == null)
            {
                return null;
            }
            carToUpdate.Model = newCarUpdates.Model;
            carToUpdate.LicensePlate = newCarUpdates.LicensePlate;
            carToUpdate.Price = newCarUpdates.Price;
            return carToUpdate;
        }

        public Car Delete(int deleteCarById)
        {
            Car carToDelete = GetById(deleteCarById);
            if (carToDelete == null)
            {
                return null;
            }
            _cars.Remove(carToDelete);
            return carToDelete;
        }
    }
}
