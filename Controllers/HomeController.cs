using Microsoft.AspNetCore.Mvc;
using MyShop.Models;

namespace MyShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IIndexRepository _indexRepository;

        public HomeController(IIndexRepository indexRepository)
        {
            _indexRepository = indexRepository;
        }
        public IActionResult Index()
        {
            var model = _indexRepository.GetIndexData();
            return View(model);
        }
    }
}
