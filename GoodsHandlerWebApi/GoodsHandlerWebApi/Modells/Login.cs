using Microsoft.EntityFrameworkCore;

namespace GoodsHandlerWebApi.Modells
{
    public class Login
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string Password { get; set; }
    }
}
