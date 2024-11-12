using GoodsHandlerWebApi.Data;
using GoodsHandlerWebApi.Interface;
using GoodsHandlerWebApi.Modells;

namespace GoodsHandlerWebApi.Repository
{
    public class GoodsRepository : IGoodsRepository
    {

        private readonly DataContext _context;

        public GoodsRepository(DataContext context)
        {
            _context = context;
        }


        public ICollection<Goods> GetGoods()
        {
            return _context.Goods.ToList();
        }
        public Goods GetGoodsById(int goodId)
        {
            return _context.Goods.Where(g => g.Id == goodId).FirstOrDefault();
        }
        public bool GoodExists(int goodId)
        {
            return _context.Goods.Any(g => g.Id == goodId);
        }

        public bool CreateGood(Goods good)
        {
            _context.Add(good);
            return Save();
        }

        public bool DeleteGood(Goods good)
        {
            _context.Remove(good);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateGood(Goods good)
        {
            _context.Update(good);
            return Save();
        }
    }
}
