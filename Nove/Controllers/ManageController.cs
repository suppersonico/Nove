using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nove.Services;

namespace Nove.Controllers
{
    public class ManageController : Controller
    {
        private readonly IBookServices _bookServices;

        public ManageController(IBookServices bookServices)
        {
            _bookServices = bookServices;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _bookServices.GetAllManageBooks());
        }

        public IActionResult Del(int id)
        {
            _bookServices.BookDel(id);
            return RedirectToAction("Index");
        }

        public IActionResult Pass(int id)
        {
            _bookServices.BookPass(id);
            return RedirectToAction("Index");
        }
    }
}