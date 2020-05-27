using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace PricingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2", Environment.MachineName };
        }
    }
}
