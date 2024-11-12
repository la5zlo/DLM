using GoodsHandlerWebApi.Modells;

namespace GoodsHandlerWebApi.Interface
{
    public interface IGoodsRepository
    {
        ICollection<Goods> GetGoods();
        bool GoodExists(int goodId);
        Goods GetGoodsById(int goodId);
        bool CreateGood(Goods good);
        bool UpdateGood(Goods good);
        bool DeleteGood(Goods good);
        bool Save();
    }
}
