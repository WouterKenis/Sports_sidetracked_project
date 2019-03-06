using Microsoft.AspNetCore.Mvc;
using Sports.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports.Controllers
{
    public class BasketballController : Controller
    {
        private ISportsData _sportsData;

        public BasketballController(ISportsData sportsData)
        {
            _sportsData = sportsData;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
