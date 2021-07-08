using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POCforLifecycle.Models;

namespace POCforLifecycle.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private readonly ISingletonGenerator singletonGenerator;
        private readonly IScopedGenerator scopedGenerator;
        private readonly ITransientGenerator transientGenerator;
        private readonly CustomService customService;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ISingletonGenerator singletonGenerator, IScopedGenerator scopedGenerator, ITransientGenerator transientGenerator, CustomService customService)
        {
            this.singletonGenerator = singletonGenerator;
            this.scopedGenerator = scopedGenerator;
            this.transientGenerator = transientGenerator;
            this.customService = customService;
            _logger = logger;
        }

        [HttpGet]
        public GuidModel Get()
        {
            GuidModel guidModel = new GuidModel()
            {
                ScopedGuid = scopedGenerator.GeneratedGuid,
                SingletonGuid = singletonGenerator.GeneratedGuid,
                TransientGuid = transientGenerator.GeneratedGuid,
                
                // Warning!!! Call by service:
                ScopedServiceGuid = customService.ScopedGuid,
                SingletonServiceGuid = customService.SingletonGuid,
                TransientServiceGuidGuid = customService.TransientGuid
            };


            return guidModel;
        }
    }
}
