using Microsoft.AspNetCore.Mvc;
using Sports.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports.Controllers
{
    public class FootballController : Controller
    {
        private ISportsData _sportsData;

        public FootballController(ISportsData sportsData)
        {
            _sportsData = sportsData;
        }

        public IActionResult Index()
        {

            var players = _sportsData.GetAllFootballPlayers();

            return View(players);
        }
    }
}
