namespace GoodsHandlerWebApi.Interface
{
    public interface ILoginRepository
    {
        public bool Login(string username, string password);
    }
}
