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
            var abc = "test";
            var abc1 = "test";
            var abc2 = "test";
            var abc3 = "test";
            var rng4 = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55)
            })
            .ToArray();
        }
        
        private bool test()
        {
            bool test = true;
            return true;
        }
    }
}
