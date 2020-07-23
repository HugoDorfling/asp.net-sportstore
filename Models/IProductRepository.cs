using System.Linq;

namespace sportstore.Models {
    public interface IProductRepository {
        IQueryable<Product> Products { get; }
    }
}