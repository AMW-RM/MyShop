using MyShop.ViewModels;

namespace MyShop.Models
{
    public interface IMockContactRepository
    {
        ContactViewModel GetContactInfo();
    }
}