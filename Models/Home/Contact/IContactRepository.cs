using MyShop.ViewModels;

namespace MyShop.Models;

public interface IContactRepository
{
    ContactViewModel GetContactInfo();
}
