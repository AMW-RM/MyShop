using MyShop.ViewModels;

namespace MyShop.Models;

public class MockIndexRepository : IIndexRepository
{
    public IndexViewModel GetIndexData()
    {
        return new IndexViewModel
        {
            HeroTitle = "Witamy w Naszej Firmie IT",
            HeroDescription = "Tworzymy nowoczesne oprogramowanie dopasowane do Twoich potrzeb. Skontaktuj się z nami, aby porozmawiać o Twoim projekcie.",
            AboutTitle = "Kim jesteśmy?",
            AboutText = "Od 11 lat budujemy dedykowane aplikacje dla biznesu. Nasz zespół składa się z doświadczonych specjalistów w .NET, frontendzie i UX/UI.",
            Services = new List<ServiceItem>
          {
              new ServiceItem
               {
                   Title = "Aplikacje webowe",
                   Description = "Budujemy nowoczesne aplikacje webowe z wykorzystaniem .NET Core i React lub Vue."
               },
              new ServiceItem
              {
                   Title = "Integracje systemowe",
                   Description = "Łączymy systemy zewnętrzne przez API, EDI i inne rozwiązania dopasowane do klienta."
               },
              new ServiceItem
              {
                   Title = "UX/UI i projektowanie",
                   Description = "Tworzymy estetyczne i funkcjonalne interfejsy użytkownika zgodne z najnowszymi trendami."
               }
           },
            CtaTitle = "Gotowy na współpracę?",
            CtaText = "Skontaktuj się z nami i rozpocznijmy nowy projekt razem!"
        };
    }
}
