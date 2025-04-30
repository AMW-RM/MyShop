using Microsoft.AspNetCore.Mvc;
using MyShop.Models;

namespace MyShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IIndexRepository _indexRepository;
        private readonly IContactRepository _contactRepository;
        private readonly IAboutRepository _aboutRepository;

        public HomeController(IIndexRepository indexRepository,
            IContactRepository contactRepository,
            IAboutRepository aboutRepository)
        {
            _indexRepository = indexRepository;
            _contactRepository = contactRepository;
            _aboutRepository = aboutRepository;
        }
        public IActionResult Index()
        {
            var model = _indexRepository.GetIndexData();
            return View(model);
        }
        public IActionResult Contact()
        {
            var model = _contactRepository.GetContactInfo();
            return View(model);
        }

        public IActionResult About()
        {
            //alternatywa powyższych
            return View(_aboutRepository.GetCompanyInfo());
        }
    }
}
