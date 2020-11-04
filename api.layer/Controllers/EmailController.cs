using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace api.layer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : Controller
    {
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            sum();
            Add();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55)
            })
            .ToArray();
        }

        private bool sum()
        {
            int unused = 456;
            int number1 = 1234;
            int number2 = 1234;
            int number3 = number1 + number2;
            return number3;
        }

        private bool Add()
        {
            int unused = 456;
            int number1 = 1234;
            int number2 = 1234;
            int number3 = number1 + number2;
            return number3;
        }
    }
}
