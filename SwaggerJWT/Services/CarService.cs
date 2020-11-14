using MongoDB.Driver;
using SwaggerJWT.Models;
using System.Collections.Generic;

namespace SwaggerJWT.Services
{
    public class CarService
    {
        private readonly IMongoCollection<Car> _cars;

        public CarService(ICarStoreDatabaseSettings settings)
        {
            MongoClient client = new MongoClient(settings.ConnectionString);
            IMongoDatabase database = client.GetDatabase(settings.DatabaseName);

            _cars = database.GetCollection<Car>(settings.CarsCollectionName);
        }

        public List<Car> Get() => _cars.Find(car => true).ToList();

        public Car Get(string key) => _cars.Find<Car>(car => car.Key == key).FirstOrDefault();

        public Car Create(Car car)
        {
            _cars.InsertOne(car);
            return car;
        }

        public void Update(string key, Car carIn) => _cars.ReplaceOne(car => car.Key == key, carIn);

        public void Remove(Car carIn) => _cars.DeleteOne(car => car.Key == carIn.Key);

        public void Remove(string key) => _cars.DeleteOne(car => car.Key == key);
    }
}
