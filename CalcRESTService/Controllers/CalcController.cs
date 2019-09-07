using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalcRESTService.Controllers
{
    [RoutePrefix("api")]
    public class CalcController : ApiController
    {
        public CalcController()
        {
            Console.WriteLine();
        }
        [HttpGet]
        [Route("add")]
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public double Divide(int x, int y)
        {
            return x / y;
        }

    }
}
