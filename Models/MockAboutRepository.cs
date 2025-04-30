using MyShop.ViewModels;
using System.Globalization;

namespace MyShop.Models;

public class MockAboutRepository : IAboutRepository
{
    public AboutViewModel GetCompanyInfo()
    {
        // Dane o firmie
        return new AboutViewModel
        {
            CompanyName = "Nasza Firma IT",
            Description = "Od ponad dekady tworzymy nowoczesne rozwiązania IT, które usprawniają codzienną pracę firm z różnych branż. Nasze systemy są wykorzystywane w sektorze zdrowia, przemysłu oraz e-commerce.",
            KeyPoints = new List<string>
           {
               "✅ <strong>11+</strong> lat doświadczenia",
               "✅ 500+ zadowolonych klientów",
               "✅ 50+ ekspertów w zespole"
           },
            ImagePath = "/images/Standup meeting-amico.png"
        };
    }
}
