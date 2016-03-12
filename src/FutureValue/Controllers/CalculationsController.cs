﻿using System;
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
            //http://localhost:64389/api/calculations/?principal=5000&rate=0.05&years=10&compounds=12
            return Math.Round(principal*Math.Pow((1+rate/compounds),years*compounds),2);
        }        
    }
}
