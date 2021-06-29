using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using WebAppServiceReference;

namespace WCF2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpGet]
        public ActionResult<int> Get()
        {
            //WebService1SoapClient webService1SoapClient = new WebService1SoapClient("null");
            var obj = new WebService1SoapClient(WebService1SoapClient.EndpointConfiguration.WebService1Soap);


            // var kaunts = countriesRequestBody;
            //CountriesRequest countriesRequest = new CountriesRequest();
            // Reference.WebService1 proxy = 
           // Task<CountriesResponse> x = obj.CountriesAsync();
            Task<int> x = obj.addAsync(3,4);
            //Task<CountriesResponse> x = obj.CountriesAsync();
            return Ok(x);
           // return Ok(x);
        }
    }
}
