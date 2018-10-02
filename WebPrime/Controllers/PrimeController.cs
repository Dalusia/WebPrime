using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimeLogic;

namespace WebPrime.Controllers
{
    public class PrimeController : Controller
    {
        public IActionResult Index(int? howManyPrimes)
        {
            var gen = new PrimeGenerator();
            return View(gen.FindPrimes(howManyPrimes ?? 7));
        }

        public IActionResult Choose(int myPrime)
        {
            return View(myPrime);
        }
    }
}