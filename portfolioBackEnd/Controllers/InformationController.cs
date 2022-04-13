using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace portfolioBackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class informationController : ControllerBase
    {

        [HttpGet]
        public String Get()
        {
            //Get Information from table
            return "Hello World";
        }
    }
}
