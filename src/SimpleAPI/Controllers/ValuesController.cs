using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }

        public ValuesController()
        {
            
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
           return new string[] {"value1", "value2"};
        }

        [HttpGet("{id}")]        
        public ActionResult<string> Get(int id)
        {
           return "Les Jacksonxxxx";
        }
    }
}
