using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nove.Services;

namespace NovelWeb.Controllers
{
    public class HomeController : Controller
    {

        private readonly IBookServices _bookServices;


        public HomeController(IBookServices bookServices)
        {
            _bookServices = bookServices;

        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "首页1";

            return View(await _bookServices.GetAllBooks());
        }
    }
}