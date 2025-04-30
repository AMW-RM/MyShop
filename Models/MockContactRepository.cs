using MyShop.ViewModels;

namespace MyShop.Models
{
    public class MockContactRepository : IContactRepository
    {
        public ContactViewModel GetContactInfo()
        {
            return new ContactViewModel
            {
                Name = "Jan Kowalski",
                Email = "jan.kowalski@przyklad.pl",
                Message = "Chciałbym się dowiedzieć więcej o usługach.",
                Address = "ul. Przykładowa 12, 00-001 Warszawa",
                Phone = "+48 123 456 789",
                EmailContact = "kontakt@naszafirma.pl"
            };
        }
    }
}
