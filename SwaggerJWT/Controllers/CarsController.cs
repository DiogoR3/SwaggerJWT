using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SwaggerJWT.Models;
using SwaggerJWT.Services;
using System.Collections.Generic;

namespace SwaggerJWT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly CarService _carService;

        public CarsController(CarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public ActionResult<List<Car>> Get() => _carService.Get();

        [HttpGet("{key:length(24)}", Name = "GetCar")]
        public ActionResult<Car> Get(string key)
        {
            Car car = _carService.Get(key);

            if (car == null)
                return NotFound();

            return car;
        }

        [HttpPost]
        [Authorize]
        public ActionResult<Car> Create(Car car)
        {
            _carService.Create(car);

            return CreatedAtAction("Create", car);
        }

        [HttpPut("{key:length(24)}")]
        [Authorize]
        public IActionResult Update(string key, Car carIn)
        {
            Car car = _carService.Get(key);

            if (car == null)
                return NotFound();

            _carService.Update(key, carIn);

            return NoContent();
        }

        [HttpDelete("{key:length(24)}")]
        [Authorize]
        public IActionResult Delete(string key)
        {
            Car car = _carService.Get(key);

            if (car == null)
                return NotFound();

            _carService.Remove(car.Key);

            return NoContent();
        }
    }
}
