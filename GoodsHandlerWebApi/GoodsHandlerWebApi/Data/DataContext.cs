using GoodsHandlerWebApi.Modells;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace GoodsHandlerWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Goods> Goods { get; set; }
        public DbSet<Login> Logins { get; set; }
    }
}
