using Microsoft.AspNetCore.Mvc;
using MyShop.Models;

namespace MyShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IIndexRepository _indexRepository;
        private readonly IMockContactRepository _mockContactRepository;

        public HomeController(IIndexRepository indexRepository,
            IMockContactRepository mockContactRepository)
        {
            _indexRepository = indexRepository;
            _mockContactRepository = mockContactRepository;
        }
        public IActionResult Index()
        {
            var model = _indexRepository.GetIndexData();
            return View(model);
        }
        public IActionResult Contact()
        {
            var model = _mockContactRepository.GetContactInfo();
            return View(model);
        }

        public IActionResult About()
        {

            return View();
        }
    }
}
