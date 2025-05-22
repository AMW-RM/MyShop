using Microsoft.AspNetCore.Mvc;
using MyShop.Models;

namespace MyShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IIndexRepository _indexRepository;
        private readonly IContactRepository _contactRepository;
        private readonly IAboutRepository _aboutRepository;
        private readonly IProductRepository _productRepository;

        public HomeController(IIndexRepository indexRepository,
            IContactRepository contactRepository,
            IAboutRepository aboutRepository,
            IProductRepository productRepository)
        {
            _indexRepository = indexRepository;
            _contactRepository = contactRepository;
            _aboutRepository = aboutRepository;
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var model = _indexRepository.GetIndexData();
            model.ProductsOfTheWeek = _productRepository.ProductsOfTheWeek.ToList();
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
            var model = _aboutRepository.GetCompanyInfo();
            model.ProductsOfTheWeek = _productRepository.ProductsOfTheWeek.Take(1).ToList();
            return View(model);
        }
    }
}
