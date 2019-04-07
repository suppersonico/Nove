using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nove.Services;

namespace Nove.Controllers
{
    public class RankController : Controller
    {
        private readonly IBookServices _bookServices;

        public RankController(IBookServices bookServices)
        {
            _bookServices = bookServices;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _bookServices.GetBooksRank());
        }
    }
}