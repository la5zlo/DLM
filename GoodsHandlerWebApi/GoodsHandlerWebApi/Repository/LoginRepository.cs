using GoodsHandlerWebApi.Data;
using GoodsHandlerWebApi.Interface;

namespace GoodsHandlerWebApi.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly DataContext _context;

        public LoginRepository(DataContext context)
        {
            _context = context;
        }
        public bool Login(string username, string password)
        {
            return _context.Logins.Any(l => l.AccountName == username && l.Password == password);
        }
    }
}
