using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nove.Services;

namespace Nove.Controllers
{
    public class UserCenterController : Controller
    {
        private readonly IBookServices _bookServices;

        public UserCenterController(IBookServices bookServices)
        {
            _bookServices = bookServices;
        }

        public async Task<IActionResult> Index()
        {
            var userName = this.User.FindFirstValue(ClaimTypes.Name);
            return View(await _bookServices.GetMyBooks(userName));
        }
    }
}