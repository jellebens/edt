using Sharpsolutions.Edt.Domain.Account;

namespace Sharpsolutions.Edt.Data.Azure
{
    public interface IUserRepository
    {
        void Add(User user);
        User Get(string id);
    }
}