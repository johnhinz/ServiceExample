using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RESTCalcService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        [HttpGet]
        public ActionResult<int> Add(int x, int y)
        {
            return Ok(x + y);
        }

        public ActionResult<double> Divide(int x, int y)
        {
            if (y == 0)
            {
                return BadRequest();
            }

            return Ok(x / y);


        }



    }
}