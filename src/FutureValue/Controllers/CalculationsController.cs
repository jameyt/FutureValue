using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace FutureValue.Controllers
{
    [Route("api/[controller]")]
    public class CalculationsController : Controller
    {
        // GET: api/values
        [HttpGet]
        public double CalculateFutureValue(double principal,double rate, double years, double compounds)
        {
            return Math.Pow(principal*(1+rate/years),years*compounds);
        }        
    }
}
