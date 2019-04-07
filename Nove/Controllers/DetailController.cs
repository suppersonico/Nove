using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Nove.Services;

namespace Nove.Controllers
{
    public class DetailController : Controller
    {
        private readonly IBookServices _bookServices;

        public DetailController(IBookServices bookServices)
        {
            _bookServices = bookServices;
        }
        public IActionResult Index(int id)
        {
            var url = ".\\wwwroot\\" + _bookServices.BookDetail(id).Url;

            ViewBag.Content = System.IO.File.ReadAllLines(url);

            
            return View(_bookServices.BookDetail(id));
        }
    }
}