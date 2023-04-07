using ShopTest.Web.DataAccess.Data;
using ShopTest.Web.Models;

namespace ShopTest.Web.DataAccess.Repositories
{
    public class CartRepository : Repository<Cart>, ICartRepository
    {
        private ApplicationDbContext _context;

        public CartRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
