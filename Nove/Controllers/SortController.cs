using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nove.Services;

namespace Nove.Controllers
{
    public class SortController : Controller
    {
        private readonly ISortServices _sortServices;

        public SortController(ISortServices sortServices)
        {
            _sortServices = sortServices;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _sortServices.GetSorts());
        }
    }
}